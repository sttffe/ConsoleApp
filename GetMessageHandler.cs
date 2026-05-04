namespace ConsoleApp1 ;



public class GetMessageHandler
{


    public async void Handle(GetMessage getMessage )
    {



        Console.WriteLine("GetMessageHandler: " + getMessage.Message);

    }



}