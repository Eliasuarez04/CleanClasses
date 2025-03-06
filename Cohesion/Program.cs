//Código Sucio

class Report
{
    public void GenerateReport() { Console.WriteLine("Generating report..."); }
    public void SaveToDatabase() { Console.WriteLine("Saving to DB..."); }
    public void SendEmail() { Console.WriteLine("Sending email..."); }
}


//Código Limpio
class ReportGenerator
{
    public void Generate() { Console.WriteLine("Generating report..."); }
}

class ReportSaver
{
    public void Save() { Console.WriteLine("Saving to DB..."); }
}

class EmailSender
{
    public void Send() { Console.WriteLine("Sending email..."); }
}

