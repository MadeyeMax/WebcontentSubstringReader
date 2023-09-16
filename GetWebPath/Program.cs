

using System.Net;
using System.Reflection.Metadata;
using static System.Net.Http.HttpClient;
using static System.Net.WebRequestMethods;

public class Programm
{

    public static string webPath(string Code, string Start, string End){

        string result = "";
        if (Code.Contains(Start) && Code.Contains(End))
        {
            int StartIndex = Code.IndexOf(Start) + Start.Length;
            int EndIndex = Code.IndexOf(End, StartIndex);
            result = Code.Substring(StartIndex, EndIndex - StartIndex);
            return result;
        }
           return result;
    }

    public static string getUrlData(string url)
    {
        

        HttpClient client = new HttpClient();
        string urlData = client.GetStringAsync(url).Result;
        return urlData;
    }


    public static void Main(){

        string url = ""; //insert URL
        


       
        string start = ""; //insert start of text
        string end = ""; //insert end of text
        string code = getUrlData(url); 

        string textBetween = webPath(code, start, end); //returns content between start and end text


        Console.WriteLine(textBetween);

    }


    


}



