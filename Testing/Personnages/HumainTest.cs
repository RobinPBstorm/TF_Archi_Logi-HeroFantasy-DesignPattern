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
    public class HumainTest
    {
        #region constructor
        [Fact]
        public void Humain_ConstructorWithJustName()
        {
            // Arrange
            string nom = "théo";

            // Act
            Humain monHumainDeTest = new Humain("théo");

            //Assert
            Assert.Equal("théo", monHumainDeTest.Nom);
            Assert.Null(monHumainDeTest.ArmeEquipee);
            Assert.Null(monHumainDeTest.ArmureEquipee);
        }

        [Fact]
        public void Humain_ConstructorWithoutName_Exception()
        {
            // Arrange
            string nom = null;

            // Act
            Action creation = () => new Humain(nom);

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
            Humain monHumainDeTest = new Humain("théo");

            // Act
            bool estEquipe = monHumainDeTest.Equiper(baton);

            // Arrange
            Assert.True(estEquipe);
            Assert.Equal(baton, monHumainDeTest.ArmeEquipee);
        }

        [Fact]
        public void Equiper_ArmeDistance()
        {
            // Arrange
            ArcCourt arc = new ArcCourt();
            Humain monHumainDeTest = new Humain("théo");

            // Act
            bool estEquipe = monHumainDeTest.Equiper(arc);

            // Arrange
            Assert.True(estEquipe);
            Assert.Equal(arc, monHumainDeTest.ArmeEquipee);
        }
        [Fact]
        public void Equiper_ArmureLegere()
        {
            // Arrange
            ArmureDeCuir armureDeCuir = new ArmureDeCuir();
            Humain monHumainDeTest = new Humain("théo");

            // Act
            bool estEquipe = monHumainDeTest.Equiper(armureDeCuir);

            // Arrange
            Assert.True(estEquipe);
            Assert.Equal(armureDeCuir, monHumainDeTest.ArmureEquipee);
        }
        [Fact]
        public void Equiper_ArmureIntermediaire()
        {
            // Arrange
            Cuirasse cuirasse = new Cuirasse();
            Humain monHumainDeTest = new Humain("théo");

            // Act
            bool estEquipe = monHumainDeTest.Equiper(cuirasse);

            // Arrange
            Assert.True(estEquipe);
            Assert.Equal(cuirasse, monHumainDeTest.ArmureEquipee);
        }
        [Fact]
        public void Equiper_ArmureLourde()
        {
            // Arrange
            CotteDeMailles cotteDeMailles = new CotteDeMailles();
            Humain monHumainDeTest = new Humain("théo");

            // Act
            bool estEquipe = monHumainDeTest.Equiper(cotteDeMailles);

            // Arrange
            Assert.True(estEquipe);
            Assert.Equal(cotteDeMailles, monHumainDeTest.ArmureEquipee);
        }


        #endregion

        #region EquiperArme ()
        [Fact]
        public void EquiperArme_ArmeContact()
        {
            // Arrange
            Baton baton = new Baton();
            Humain monHumainDeTest = new Humain("théo");

            // Act
            bool estEquipe = monHumainDeTest.EquiperArme(baton);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(baton, monHumainDeTest.ArmeEquipee);

        }
        [Fact]
        public void EquiperArme_ArmeDistance()
        {
            // Arrange
            ArcCourt arc = new ArcCourt();
            Elfe monHumainDeTest = new Elfe("théo");

            // Act
            bool estEquipe = monHumainDeTest.EquiperArme(arc);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(arc, monHumainDeTest.ArmeEquipee);
        }
        #endregion

        #region EquiperArmure()
        [Fact]
        public void EquiperArmure_ArmureLegere()
        {
            // Arrange
            ArmureDeCuir armureDeCuir = new ArmureDeCuir();
            Humain monHumainDeTest = new Humain("théo");

            // Act
            bool estEquipe = monHumainDeTest.EquiperArmure(armureDeCuir);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(armureDeCuir, monHumainDeTest.ArmureEquipee);
        }
        [Fact]
        public void EquiperArmure_ArmureIntermediaire()
        {
            // Arrange
            Cuirasse cuirasse = new Cuirasse();
            Humain monHumainDeTest = new Humain("théo");

            // Act
            bool estEquipe = monHumainDeTest.Equiper(cuirasse);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(cuirasse, monHumainDeTest.ArmureEquipee);
        }
        [Fact]
        public void EquiperArmure_ArmureLourde()
        {
            // Arrange
            CotteDeMailles cotteDeMailles = new CotteDeMailles();
            Humain monHumainDeTest = new Humain("théo");

            // Act
            bool estEquipe = monHumainDeTest.Equiper(cotteDeMailles);

            // Assert
            Assert.True(estEquipe);
            Assert.Equal(cotteDeMailles, monHumainDeTest.ArmureEquipee);
        }
        #endregion
    }


}
