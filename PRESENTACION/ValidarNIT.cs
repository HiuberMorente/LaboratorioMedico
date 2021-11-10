using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpresionesRegulares
{
    public class ValidarNIT
    {

        private static Regex expression = new Regex("^([0-9]{8}(-?[0-9kK])?)$", RegexOptions.CultureInvariant | RegexOptions.Singleline);

        public bool HasValidFormat(string nit)
        {             
            if (nit == null)
                throw new ArgumentNullException("nit");

            return expression.IsMatch(nit);
        }

        public bool nitIsValid(string nit)
        {
            if(nit == null)            
                MessageBox.Show("Ingrese nuevo numero de nit");
            

            nit = nit.Replace("-", "");
            int lastChar = nit.Length - 1;
            int indexChar = nit.IndexOf(nit);
            string number = nit.Substring(0, lastChar);
            string expectedCheker = nit.Substring(7, 1);

            int factor = number.Length + 1;

            int total = 0;

            for(int i = 0; i < number.Length; i++)
            {

                string character = number.Substring(i, number.Length - i );
                int digit = Convert.ToInt32(character, 10);

                total += (digit * factor);
                factor = factor - 1;

            }

            int modulus = (11 - (total % 11)) % 11;

            var computedChecker = modulus == 10 ? "k" : modulus.ToString();

            return expectedCheker == computedChecker;

        }

        
    }
}
