using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Communication
{
    public class EcrireFichier
    {
        public static void Ecrire(string contenu, string nomFichier)
        {
            try
            {
                File.WriteAllText(nomFichier, contenu);
                Console.WriteLine("Ecriture terminee dans le fichier " + nomFichier);
            }
            catch(IOException e)
            {
                Console.WriteLine("Impossible d'ecrire dans le fichier " + nomFichier);
            }
        }
    }
}
