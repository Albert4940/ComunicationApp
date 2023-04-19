using System;
namespace Communication;

public class DonneeUtiisateur
{
    public static string DemanderUneUrl()
    {
        Console.WriteLine("Veuillez saisir une URL valide");

        string strChaineUrl = "";
            strChaineUrl = Console.ReadLine();

        return strChaineUrl;
    }

    public static bool URLValide(string chaineUrl)
    {
        if(Uri.IsWellFormedUriString(chaineUrl, UriKind.Absolute))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}