using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Dal
{
    public static class Autenticacao
    {
        static string login;
        static string senha;
        static int privilegio;

        public static void Login(string login1, string senha1)
        {
            login = login1;
            senha = senha1;
        }
        public static void logout()
        {
            login = null;
            senha = null;
            privilegio = 0;
        }

        public static String getlogin()
        {
            return "login: " + login + "\nSenha:" + senha + "\nprivilegio: " + privilegio;
        }
    }
}
