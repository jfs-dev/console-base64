namespace console_base64.Services;

public static class Base64ImageService
{
    public static string EncodeImageToBase64(string imagePath)
    {
        if (!File.Exists(imagePath))
            throw new FileNotFoundException("Imagem não encontrada!", imagePath);

        byte[] imageBytes = File.ReadAllBytes(imagePath);
        return Convert.ToBase64String(imageBytes);
    }

    public static void DecodeBase64ToImage(string base64, string outputPath)
    {
        if (string.IsNullOrWhiteSpace(base64))
            throw new ArgumentException("Entrada inválida!");

        if (File.Exists(outputPath))
            File.Delete(outputPath);
            
        byte[] imageBytes = Convert.FromBase64String(base64);
        File.WriteAllBytes(outputPath, imageBytes);
    }
}
