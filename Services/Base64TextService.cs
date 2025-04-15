using System.Text;

namespace console_base64.Services;

public static class Base64TextService
{
    public static string EncodeTextToBase64(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("Entrada inválida!");

        byte[] bytes = Encoding.UTF8.GetBytes(input);
        return Convert.ToBase64String(bytes);
    }

    public static string DecodeBase64ToText(string base64)
    {
        if (string.IsNullOrWhiteSpace(base64))
            throw new ArgumentException("Entrada inválida!");

        byte[] bytes = Convert.FromBase64String(base64);
        return Encoding.UTF8.GetString(bytes);
    }
}
