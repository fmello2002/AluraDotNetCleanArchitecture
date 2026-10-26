using ScheduleAPI.Domain.ValueObjects;

namespace ScheduleAPI.Test
{
    public class EmailCtor
    {
        [Fact]
        public void Deve_Lancar_ArgumentException_Quando_Valor_Invalido()
        {
            // arrange
            string emailInvalido = "felipeteste.com";

            // act && assert
            Assert.Throws<ArgumentException>(() => new Email(emailInvalido));
        }

        [Fact]
        public void Deve_Criar_Email_Valido_Quando_Valor_Sao_Validos()
        {
            // arrange
            string emailValido = "felipe@teste.com";

            // act
            Email email = new Email(emailValido);

            // Assert
            Assert.Equal(emailValido, email.Value);
        }
    }
}