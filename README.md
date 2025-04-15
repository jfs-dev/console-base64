# console-base64
Implementação de codificação e decodificação Base64 em C# utilizando a classe Convert

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como implementar a codificação e decodificação Base64 em C# utilizando a classe Convert.

Base64 é um método de codificação que converte dados binários em texto ASCII, permitindo que informações sejam transmitidas ou armazenadas em sistemas que aceitam apenas texto. Ele é amplamente utilizado em situações onde dados binários, como imagens, documentos ou strings com caracteres especiais, precisam ser representados de forma legível e transportável. A codificação Base64 transforma esses dados em uma sequência de caracteres simples (letras, números e símbolos seguros como <code>+</code>, <code>/</code> e <code>=</code>), garantindo compatibilidade em protocolos como e-mails, URLs e bancos de dados baseados em texto.

No entanto, o uso tem suas limitações. Ele aumenta o tamanho dos dados, o que pode ser uma desvantagem em ambientes onde o espaço ou a largura de banda são restritos. Além disso, ele não oferece nenhuma camada de segurança ou criptografia, ele apenas transforma os dados em um formato diferente, mas facilmente reversível. Ainda assim, sua aplicação é essencial em cenários onde a compatibilidade de formato é crucial, como a integração de sistemas ou envio de dados através de APIs.

Em resumo, Base64 é uma solução prática e eficiente para codificação de dados binários, desde que suas limitações sejam consideradas.

<div align="center">
    <img src="https://github.com/user-attachments/assets/356ab893-bfa3-4801-8355-e38f8974d0e7"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=net-10.0

## Licença
GPL-3.0 license
