using OpenAI_API;

class Program
{
	static async Task Main(String[] args)
	{
		while (true)
		{
			string openAIKey = "";

			var authentication = new APIAuthentication(openAIKey);

			var api = new OpenAIAPI(authentication);

			var chat = api.Chat.CreateConversation();

			Console.WriteLine("Mensagem: ");
			string? question = Console.ReadLine();

			Console.WriteLine("*****************************************\n");
			
			chat.AppendUserInput(question);

			Console.ForegroundColor = ConsoleColor.Green;
			string answer = await chat.GetResponseFromChatbotAsync();
			Console.WriteLine(answer + "\n");

			Console.WriteLine("*****************************************\n");
			Console.ResetColor();

		}
	}
}