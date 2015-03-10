using SNCF.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test execution");
            Console.WriteLine("Test execution");

            Utilisateur unUser = new Utilisateur(1,"","","test@mail.fr","root","");
            Bdd bdd = new Bdd();

            bdd.addUser(unUser);

            Console.ReadLine();
        }
    }
}
