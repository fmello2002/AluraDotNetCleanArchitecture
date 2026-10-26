using System.Text.RegularExpressions;

namespace ScheduleAPI.Domain.ValueObjects
{
    public record Email
    {
        public string Value { get; }

        private static readonly Regex EmailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || !EmailRegex.IsMatch(value))
            {
                throw new ArgumentException("E-mail inválido.", nameof(value));
            }

            Value = value;
        }
    }
}