using CompetencePlus.PackageAnneeFormations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///Classe de test pour AnneeFormationDAOTest, destinée à contenir tous
    ///les tests unitaires AnneeFormationDAOTest
    ///</summary>
    [TestClass()]
    public class AnneeFormationDAOTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            AnneeFormationDAO target = new AnneeFormationDAO(); // TODO: initialisez à une valeur appropriée
            AnneeFormation A =new AnneeFormation () ; // TODO: initialisez à une valeur appropriée
           // A.Id = 0;
            A.Title = "2014-2015";
          
            target.Add(A);
            //Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
            
        }
    }
}
