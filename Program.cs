Console.Clear();

Console.WriteLine("--- Groot Chatbot ---\n");

string pergunta = "";

do
{
    Console.Write("Pergunta: ");
    pergunta = Convert.ToString(Console.ReadLine()).ToUpper();

    if (pergunta == "TCHAU")
    {
        break;
    }

    Console.WriteLine("Resposta: Eu sou Groot.");
}
while (true);


Console.WriteLine("Resposta: Eu sou Groot!");
Environment.Exit(0);
