using FluentAssertions;
using LibNotesFrais;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestNoteFrais
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestAjouterNoteFrais()
        {
            Visiteur unVisiteur = new Visiteur("DUPONT", "Louis", 'A', 5);
            NoteFrais note1 = new NoteFrais(new DateTime(2023, 11, 08), unVisiteur);
            NoteFrais note2 = new NoteFrais(new DateTime(2023, 11, 08), unVisiteur);

            Assert.AreEqual(2, unVisiteur.MesNotesFrais.Count);
        }

        [TestMethod]
        public void TestNbNotesFraisNonRemboursees()
        {
            SceCommercial leSce = new SceCommercial();
            Visiteur visit1 = new Visiteur("DUPONT", "Louis", 'B', 7);
            Visiteur visit2 = new Visiteur("DUPUY", "Pascaline", 'A', 5);

            leSce.AjouterVisiteur(visit1);
            leSce.AjouterVisiteur(visit2);

            NoteFrais note1 = new NoteFrais(new DateTime(2023, 11, 08), visit1);
            NoteFrais note2 = new NoteFrais(new DateTime(2023, 11, 09), visit1);
            note2.SetEstRembourse();
            NoteFrais note3 = new NoteFrais(new DateTime(2023, 11, 10), visit2);
            NoteFrais note4 = new NoteFrais(new DateTime(2023, 11, 11), visit2);
            note4.SetEstRembourse();
            NoteFrais note5 = new NoteFrais(new DateTime(2023, 11, 12), visit2);
            note5.SetEstRembourse();

            Assert.AreEqual(2, leSce.NbNotesFraisNonRemboursees());
        }

        [TestMethod]
        public void TestCalculMttARembourser()
        {
            Visiteur unVisiteur = new Visiteur("DUPONT", "Louis", 'A', 7);
            Visiteur visit2 = new Visiteur("DUPUY", "Pascaline", 'B', 5);


            NoteFrais fraisTransp = new FraisTransport(new DateTime(2023, 11, 08), unVisiteur, 100);
            20.0.Should().Be(fraisTransp.MttARembourser, "Résultat attendu 20");


            NoteFrais fraisRep1 = new FraisRepasMidi(new DateTime(2023, 11, 08), unVisiteur, 35);
            25.0.Should().Be(fraisRep1.MttARembourser, "Résultat attendu 25");

            NoteFrais fraisRep2 = new FraisRepasMidi(new DateTime(2023, 11, 09), visit2, 15.5);
            15.5.Should().Be(fraisRep2.MttARembourser, "Résualtat attendu 15.5");


            NoteFrais fraisNuit1 = new FraisNuitee(new DateTime(2023, 11, 10), unVisiteur, 46, 2);
            46.0.Should().Be(fraisNuit1.MttARembourser, "Résultat attendu 46");

            NoteFrais fraisNuit2 = new FraisNuitee(new DateTime(2023, 11, 11), visit2, 75, 3);
            63.25.Should().Be(fraisNuit2.MttARembourser, "Résultat attendu 63.25");
        }

        [TestMethod]
        public void TestSceAjoutNoteFrais()
        {
            SceCommercial unSce = new SceCommercial();
            Visiteur unVisiteur = new Visiteur("DUPONT", "Louis", 'A', 7);

            unSce.AjouterVisiteur(unVisiteur);
            unSce.AjouterNote(new DateTime(2023, 11, 08), unVisiteur, 100);
            unSce.AjouterNote(new DateTime(2023, 11, 09), unVisiteur, 15.5);
            unSce.AjouterNote(new DateTime(2023, 11, 10), unVisiteur, 105, 2);

            3.Should().Be(unVisiteur.MesNotesFrais.Count, "Nombre de Notes Frais 3");
        }
    }
}
