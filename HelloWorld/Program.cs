using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("Quel est votre nom ?");
            String nomUtilisateur = Console.ReadLine();

            Console.WriteLine("Quel est votre âge ?");
            String ageUtilisateur = Console.ReadLine();

            int ageUtilisateurNum = 0;
            if (int.TryParse(ageUtilisateur, out ageUtilisateurNum) == true)
            {
                ageUtilisateurNum++;
                Console.WriteLine("Vous vous appelez " + nomUtilisateur + ", vous avez " + ageUtilisateur + " ans." + " L'an prochain vous aurez " + ageUtilisateurNum + " ans.");
            }
            else
            {
                Console.WriteLine("ATTENTION : Votre âge doit être un nombre !");
            }

        }
    }
}
