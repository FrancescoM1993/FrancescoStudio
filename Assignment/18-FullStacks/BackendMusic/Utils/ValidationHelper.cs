namespace BackendMusic.Utils
{
    public static class ValidationHelper
    {
        // Questo metodo verifica se una stringa è vuota o null
        public static bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        // Verifica che la stringa sia un indirizzo email valido
        public static bool IsValidEmail(string email)
        {
            if (IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Verifica che un prezzio sia positivo
        public static bool IsPositivePrice(decimal price)
        {
            return price > 0;
        }

        // Verifica che un CAP sia valido (5 cifre)
        public static bool IsValidCAP(string cap)
        {
            return !IsNullOrWhiteSpace(cap) && cap.Length == 5 && int.TryParse(cap, out _);
        }

        // Verifica che un indirizzo sia valido cioè composto da città, via e CAP non nullo o vuoti
        public static bool IsValidAddress(string city, string street, string cap)
        {
            return !IsNullOrWhiteSpace(city) && !IsNullOrWhiteSpace(street) && IsValidCAP(cap);
        }

    }
}