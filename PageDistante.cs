using System;
using System.Net;

namespace Communication
{
    public class PageDistante
    {
        public static void Main(string[] args)
        {
            string url = DonneeUtiisateur.DemanderUneUrl();
            //Console.WriteLine("Url saisie :" + );
            if (DonneeUtiisateur.URLValide(url))
            {
                string contenu = RecupererContenu(url);

                try
                {
                    EcrireFichier.Ecrire(contenu, "output.txt");
                }
                catch(IOException e)
                {
                    Console.WriteLine("Impossible d'ecrire dans le fichier - " + e.ToString());
                }
            }
        }

        public static string RecupererContenu(string url)
        {
            string contenu = "";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    contenu = webClient.DownloadString(url);
                }
            }
            catch(WebException e)
            {
                Console.WriteLine("Impossible d'etablir une connexion - " + e.ToString());
            }
            
            return contenu;
        }
    }
}
