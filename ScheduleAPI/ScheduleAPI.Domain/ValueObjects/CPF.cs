namespace ScheduleAPI.Domain.ValueObjects
{
    public record CPF
    {
        public string Value { get; }

        public CPF(string valor)
        {
            if (!ValidarCpf(valor))
                throw new ArgumentException("O CPF informado é inválido.", nameof(valor));

            Value = ApenasNumeros(valor);
        }

        private static bool ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            string posicaoNumerica = ApenasNumeros(cpf);

            if (posicaoNumerica.Length != 11)
                return false;

            if (posicaoNumerica.Distinct().Count() == 1)
                return false;

            int[] multiplicador1 = [10, 9, 8, 7, 6, 5, 4, 3, 2];
            int[] multiplicador2 = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];

            string tempCpf = posicaoNumerica[..9];
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (tempCpf[i] - '0') * multiplicador1[i];

            int resto = soma % 11;
            int primeiroDigito = resto < 2 ? 0 : 11 - resto;

            tempCpf += primeiroDigito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (tempCpf[i] - '0') * multiplicador2[i];

            resto = soma % 11;
            int segundoDigito = resto < 2 ? 0 : 11 - resto;

            return posicaoNumerica.EndsWith($"{primeiroDigito}{segundoDigito}");
        }

        private static string ApenasNumeros(string texto) =>
            new([.. texto.Where(char.IsDigit)]);
    }
}