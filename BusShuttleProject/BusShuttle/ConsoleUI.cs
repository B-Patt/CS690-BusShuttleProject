namespace BusShuttle;
public class ConsoleUI
{
	FileSaver fileSaver;

	public ConsoleUI() 
	{
		fileSaver = new FileSaver("passenger-data.txt");
	}

	public void Show() 
	{
		string mode = AskforInput("Please select mode (driver OR manager): ");

		if(mode == "driver") 
		{

			string command;

			do 
			{

				string stopName = AskforInput("Enter stop name: ");

				int boarded = int.Parse(AskforInput("Enter number of boarded passengers: "));

				fileSaver.AppendLine(stopName + ":" + boarded);

				command = AskforInput("Enter command (end OR continue): ");

			} while(command != "end");
		}
	}

	public static string AskforInput(string message)
	{
		Console.Write(message);
		return Console.ReadLine();
	}
}