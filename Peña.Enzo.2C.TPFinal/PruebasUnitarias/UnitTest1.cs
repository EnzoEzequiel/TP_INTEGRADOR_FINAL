using LibreriaClases.DataBase;
using LibreriaClases.Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class GestorSQLTests
    {
        private readonly GestorSQL gestorSQL = new GestorSQL();

        [TestMethod]
        public void ObtenerDue�oByIdPersona_ShouldReturnOwnerId()
        {
            // Arrange
            int idUsuario = 3; //uso el 3 porque apartir de ahi si tenia agregado un due�o

            // Act
            int idDue�o = gestorSQL.ObtenerDue�oByIdPersona(idUsuario);

            // Assert
            Assert.IsNotNull(idDue�o);
            Assert.IsTrue(idDue�o > 0);
        }
    }
}
