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
    public class OrqueTest
    {
        #region constructeur
        [Fact]
        public void Orque_ConstructorWithJustName()
        {
            // Arrange
            string nom = "théo";

            // Act
            Orque monOrqueDeTest = new Orque("théo");

            //Assert
            Assert.Equal("théo", monOrqueDeTest.Nom);
            Assert.Null(monOrqueDeTest.ArmeEquipee);
            Assert.Null(monOrqueDeTest.ArmureEquipee);
        }

        [Fact]
        public void Orque_ConstructorWithoutName_Exception()
        {
            // Arrange
            string nom = null;

            // Act
            Action creation = () => new Orque(nom);

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
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            bool estEquipe = monOrqueDeTest.Equiper(baton);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(baton, monOrqueDeTest.ArmeEquipee);
        }

        [Fact]
        public void Equiper_ArmeDistance_Exception()
        {
            // Arrange
            ArcCourt arc = new ArcCourt();
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            Action equiper = () => monOrqueDeTest.Equiper(arc);

            // Assert
            Assert.Throws<NotAdaptedEquipementException>(equiper);
        }
        [Fact]
        public void Equiper_ArmureLegere()
        {
            // Arrange
            ArmureDeCuir armureDeCuir = new ArmureDeCuir();
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            Action equiper = () => monOrqueDeTest.Equiper(armureDeCuir);

            // Assert
            Assert.Throws<NotAdaptedEquipementException>(equiper);
        }
        [Fact]
        public void Equiper_ArmureIntermediaire()
        {
            // Arrange
            Cuirasse cuirasse = new Cuirasse();
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            bool estEquipe = monOrqueDeTest.Equiper(cuirasse);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(cuirasse, monOrqueDeTest.ArmureEquipee);
        }
        [Fact]
        public void Equiper_ArmureLourde()
        {
            // Arrange
            CotteDeMailles cotteDeMailles = new CotteDeMailles();
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            bool estEquipe = monOrqueDeTest.Equiper(cotteDeMailles);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(cotteDeMailles, monOrqueDeTest.ArmureEquipee);
        }


        #endregion

        #region EquiperArme ()
        [Fact]
        public void EquiperArme_ArmeContact()
        {
            // Arrange
            Baton baton = new Baton();
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            bool estEquipe = monOrqueDeTest.EquiperArme(baton);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(baton, monOrqueDeTest.ArmeEquipee);

        }
        [Fact]
        public void EquiperArme_ArmeDistance()
        {
            // Arrange
            ArcCourt arc = new ArcCourt();
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            Action equiper = () => monOrqueDeTest.EquiperArme(arc);

            // Assert
            Assert.Throws<NotAdaptedEquipementException>(equiper);

        }
        #endregion

        #region EquiperArmure()
        [Fact]
        public void EquiperArmure_ArmureLegere_Exception()
        {
            // Arrange
            ArmureDeCuir armureDeCuir = new ArmureDeCuir();
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            Action equiper = () => monOrqueDeTest.EquiperArmure(armureDeCuir);

            // Assert
            Assert.Throws<NotAdaptedEquipementException>(equiper);
        }
        [Fact]
        public void EquiperArmure_ArmureIntermediaire()
        {
            // Arrange
            Cuirasse cuirasse = new Cuirasse();
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            bool estEquipe = monOrqueDeTest.Equiper(cuirasse);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(cuirasse, monOrqueDeTest.ArmureEquipee);
        }
        [Fact]
        public void EquiperArmure_ArmureLourde()
        {
            // Arrange
            CotteDeMailles cotteDeMailles = new CotteDeMailles();
            Orque monOrqueDeTest = new Orque("théo");

            // Act
            bool estEquipe = monOrqueDeTest.Equiper(cotteDeMailles);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(cotteDeMailles, monOrqueDeTest.ArmureEquipee);
        }
        #endregion
    }
}
