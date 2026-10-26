using ScheduleAPI.Domain.ValueObjects;

namespace ScheduleAPI.Test
{
    public class CpfCtor
    {
        [Fact]
        public void Deve_Lancar_ArgumentException_Quando_Valor_Invalido()
        {
            // arrange
            string emailInvalido = "12345678902";

            // act && assert
            Assert.Throws<ArgumentException>(() => new Email(emailInvalido));
        }

        [Fact]
        public void Deve_Criar_Email_Valido_Quando_Valor_Sao_Validos()
        {
            // arrange
            string cpfValido = "62041337052";

            // act
            CPF cpf = new CPF(cpfValido);

            // Assert
            Assert.Equal(cpfValido, cpf.Value);
        }
    }
}