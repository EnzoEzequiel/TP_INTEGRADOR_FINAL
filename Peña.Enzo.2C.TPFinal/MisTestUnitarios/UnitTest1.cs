

using LibreriaClases.DataBase;
using LibreriaClases.Excepciones;

namespace MisTestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EjecutarQuery_DeberiaEjecutarConsultaSinError()
        {
            // Arrange
            var gestorSQL = new GestorSQL();
            var query = "INSERT INTO TuTabla (Campo1, Campo2) VALUES ('Valor1', 'Valor2')";

            // Act
            try
            {
                gestorSQL.EjecutarQuery(query);

                // Assert
                // Agrega aserciones según tus necesidades
                // Por ejemplo, podrías verificar que los datos se hayan insertado correctamente.
            }
            catch (BaseDeDatosException ex)
            {
                // Assert.Fail("No debería lanzar una excepción en este caso", ex);
                Assert.Fail($"No debería lanzar una excepción en este caso: {ex.Message}");
            }
        }
    }
}