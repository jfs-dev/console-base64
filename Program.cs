﻿using console_base64.Services;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Texto");
Console.WriteLine("-----");

var textContent = "Olá Mundo!";

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Entrada: ");

Console.ResetColor();
Console.WriteLine($"{textContent}\n");

var contentEncodeTextToBase64 = Base64TextService.EncodeTextToBase64(textContent);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Codificação Base64: ");

Console.ResetColor();
Console.WriteLine($"{contentEncodeTextToBase64}");

var contentDecodeBase64ToText = Base64TextService.DecodeBase64ToText(contentEncodeTextToBase64);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Decodificação Base64: ");

Console.ResetColor();
Console.WriteLine($"{contentDecodeBase64ToText}\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Imagem");
Console.WriteLine("------");

var repositoriesInputPath = @".\Repositories\Input\";
var repositoriesOutputPath = @".\Repositories\Output\";

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Entrada: ");

Console.ResetColor();
Console.WriteLine($"{repositoriesInputPath}Image.jpeg\n");

var EncodeImageToBase64 = Base64ImageService.EncodeImageToBase64($"{repositoriesInputPath}Image.jpeg");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Codificação Base64: ");

Console.ResetColor();
Console.WriteLine($"{EncodeImageToBase64}");

Base64ImageService.DecodeBase64ToImage(EncodeImageToBase64, $"{repositoriesOutputPath}Image.jpeg");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Decodificação Base64: ");

Console.ResetColor();
Console.WriteLine($"{repositoriesOutputPath}Image.jpeg");
