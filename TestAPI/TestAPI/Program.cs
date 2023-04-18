using System;
using System.IO;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://its-api-laravel.herokuapp.com/api/v1/stringa-casuale"; // URL dell'API
        string outputFile = "output_almeida.txt"; // Nome del file di output

        try
        {
            // Creazione della richiesta HTTP
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            // Ottenere la risposta dall'API
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string result = reader.ReadToEnd();

            // Salvare il risultato in un file di testo
            File.WriteAllText(outputFile, result);

            Console.WriteLine("Dati salvati in " + outputFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Errore durante l'interrogazione dell'API: " + ex.Message);
        }
    }
}
