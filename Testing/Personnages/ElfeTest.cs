using Héroique_Fantasy_en_Desgin_pattern.Models.Exceptions;
using Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armes;
using Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Armures;
using Héroique_Fantasy_en_Desgin_pattern.Models.Specialized.Personnages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Personnages
{
    public class ElfeTest
    {
        #region Constructeur
        [Fact]
        public void Elfe_ConstructorWithJustName()
        {
            // Arrange
            string nom = "théo";

            // Act
            Elfe monElfeDeTest = new Elfe("théo");

            //Assert
            Assert.Equal("théo", monElfeDeTest.Nom);
            Assert.Null(monElfeDeTest.ArmeEquipee);
            Assert.Null(monElfeDeTest.ArmureEquipee);
        }

        [Fact]
        public void Elfe_ConstructorWithoutName_Exception()
        {
            // Arrange
            string nom = null;

            // Act
            Action creation = () => new Elfe(nom);

            // Assert
            Assert.Throws<NoNameGivenException>(creation);
        }
        #endregion

        #region Equiper()
        [Fact]
        public void Equiper_ArmeContact()
        {
            // Arrange
            Baton baton = new Baton();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            bool estEquipe = monElfeDeTest.Equiper(baton);

            // Arrange
            Assert.True(estEquipe);
            Assert.Equal(baton, monElfeDeTest.ArmeEquipee);
        }

        [Fact]
        public void Equiper_ArmeDistance()
        {
            // Arrange
            ArcCourt arc = new ArcCourt();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            bool estEquipe = monElfeDeTest.Equiper(arc);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(arc, monElfeDeTest.ArmeEquipee);
        }
        [Fact]
        public void Equiper_ArmureLegere()
        {
            // Arrange
            ArmureDeCuir armureDeCuir = new ArmureDeCuir();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            bool estEquipe = monElfeDeTest.Equiper(armureDeCuir);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(armureDeCuir, monElfeDeTest.ArmureEquipee);
        }
        [Fact]
        public void Equiper_ArmureIntermediaire_Exception()
        {
            // Arrange
            Cuirasse cuirasse = new Cuirasse();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            Action equiper = () => monElfeDeTest.Equiper(cuirasse);

            // Assert
            Assert.Throws<NotAdaptedEquipementException>(equiper);
        }
        [Fact]
        public void Equiper_ArmureLourde_Exception()
        {
            // Arrange
            CotteDeMailles cotteDeMailles = new CotteDeMailles();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            Action equiper = () => monElfeDeTest.Equiper(cotteDeMailles);

            // Assert
            Assert.Throws<NotAdaptedEquipementException>(equiper);
        }


        #endregion

        #region EquiperArme ()
        [Fact]
        public void EquiperArme_ArmeContact()
        {
            // Arrange
            Baton baton = new Baton();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            bool estEquipe = monElfeDeTest.EquiperArme(baton);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(baton, monElfeDeTest.ArmeEquipee);

        }
        [Fact]
        public void EquiperArme_ArmeDistance()
        {
            // Arrange
            ArcCourt arc = new ArcCourt();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            bool estEquipe = monElfeDeTest.EquiperArme(arc);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(arc, monElfeDeTest.ArmeEquipee);
        }
        #endregion

        #region EquiperArmure()
        [Fact]
        public void EquiperArmure_ArmureLegere()
        {
            // Arrange
            ArmureDeCuir armureDeCuir = new ArmureDeCuir();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            bool estEquipe = monElfeDeTest.EquiperArmure(armureDeCuir);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(armureDeCuir, monElfeDeTest.ArmureEquipee);
        }
        [Fact]
        public void EquiperArmure_ArmureIntermediaire_Exception()
        {
            // Arrange
            Cuirasse cuirasse = new Cuirasse();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            Action equiper = () => monElfeDeTest.EquiperArmure(cuirasse);

            // Assert
            Assert.Throws<NotAdaptedEquipementException>(equiper);
        }
        [Fact]
        public void EquiperArmure_ArmureLourde_Exception()
        {
            // Arrange
            CotteDeMailles cotteDeMailles = new CotteDeMailles();
            Elfe monElfeDeTest = new Elfe("théo");

            // Act
            Action equiper = () => monElfeDeTest.EquiperArmure(cotteDeMailles);

            // Assert
            Assert.Throws<NotAdaptedEquipementException>(equiper);
        }
        #endregion
    }
}
