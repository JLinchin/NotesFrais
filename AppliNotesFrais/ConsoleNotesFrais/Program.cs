using LibNotesFrais;
using LibOutils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNotesFrais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lienFile = "sce.bin";

            SceCommercial unSce = (SceCommercial)Serialisation.Charger(lienFile);

            //SceCommercial unSce = new SceCommercial();
            
            /*Visiteur unVisiteur = new Visiteur("DUPONT", "Louis", 'B', 7);
            Visiteur visit2 = new Visiteur("DUPUY", "Pascaline", 'A', 5);

            unSce.AjouterVisiteur(unVisiteur);
            unSce.AjouterNote(new DateTime(2023, 11, 08), unVisiteur, 100);
            unSce.AjouterNote(new DateTime(2023, 11, 09), unVisiteur, 15.5);
            unSce.AjouterNote(new DateTime(2023, 11, 10), unVisiteur, 105, 2);

            unSce.AjouterVisiteur(visit2);
            unSce.AjouterNote(new DateTime(2023, 11, 08), visit2, 250);
            unSce.AjouterNote(new DateTime(2023, 11, 09), visit2, 45.0);*/

            Console.WriteLine(unSce.CumulNoteFraisParAnneePourTousVisiteur(2023));


            Console.ReadLine();

            Serialisation.Enregistrer(lienFile, unSce);
        }
    }
}
