# NiscoGPT
Pequeno projeto integrando com o ChatGPT

Aqui está uma versão mais simples e direta do README para o seu projeto de integração do ChatGPT com C# no console:

---

# ChatGPT-C# Console Integration

Este é um projeto simples que integra o ChatGPT com C#, permitindo que você faça perguntas e receba respostas diretamente no console.

## Funcionalidades

- Faça uma pergunta no console e receba uma resposta do ChatGPT.
- Integração simples usando chamadas de API para o modelo GPT-4 da OpenAI.

## Requisitos

- .NET 7 ou posterior
- Chave de API da OpenAI (disponível em [OpenAI](https://platform.openai.com/signup))

## Como Usar

1. Clone o repositório:
   ```bash
   git clone https://github.com/Nich27Oli/NiscoGPT.git
   ```

2. Instale a dependência necessária:
   Adicione o pacote `OpenAI` SDK (ou use `RestSharp` para chamadas HTTP simples):
   ```bash
   dotnet add package OpenAI --version <versão>
   ```

3. Configure sua chave de API:
   No código, adicione sua chave de API para a OpenAI:
   ```csharp
   string openAIKey = "sua-chave-api-aqui";
   ```

4. Execute o projeto:
   ```bash
   dotnet run
   ```

5. Exemplo de Uso:
   O programa solicitará uma pergunta no console. Basta digitar sua pergunta e pressionar Enter para receber uma resposta do ChatGPT.

## Exemplo

```bash
Digite sua pergunta: O que é inteligência artificial?
Resposta: Inteligência artificial (IA) refere-se à simulação de inteligência humana em máquinas que são programadas para pensar como humanos e imitar suas ações...
```

