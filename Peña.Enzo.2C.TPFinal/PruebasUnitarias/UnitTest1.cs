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
        public void ObtenerDueñoByIdPersona_ShouldReturnOwnerId()
        {
            // Arrange
            int idUsuario = 3; //uso el 3 porque apartir de ahi si tenia agregado un dueño

            // Act
            int idDueño = gestorSQL.ObtenerDueñoByIdPersona(idUsuario);

            // Assert
            Assert.IsNotNull(idDueño);
            Assert.IsTrue(idDueño > 0);
        }
    }
}
