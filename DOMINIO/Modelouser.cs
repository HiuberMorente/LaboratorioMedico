using System;
using ACCESOADATOS;


namespace NEGOCIO
{
    public class Modelouser
    {
        
        Userdao userdao = new Userdao(); 
        public bool Iniciouser(string user, string pass)
        {
            return userdao.Login(user,pass);
        }
        
       
    }
}
