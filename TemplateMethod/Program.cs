using System;

namespace TemplateMethod
{
    public abstract class BaseFile
    {
        public abstract void FormatFile(); 

        public void LoadFile()
        {
            Console.WriteLine("Loading file");
        }

        public void SaveFile()
        {
            Console.WriteLine("Saving file");
        }

        public void DoWork()
        {
            Console.WriteLine("Working on file");
        }

        public void Run()
        {
            LoadFile();
            FormatFile();
            DoWork();
            SaveFile();
        }
    }

    public class JsonFile : BaseFile
    {
        public override void FormatFile()
        {
            Console.WriteLine("Formatting Json File");
        }
    }

    public class XMLFile : BaseFile
    {
        public override void FormatFile()
        {
            Console.WriteLine("Formatting XML File");
        }
    }

    public class TxtFile : BaseFile
    {
        public override void FormatFile()
        {
            Console.WriteLine("Formatting Txt File");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseFile jsonFile = new JsonFile();
            jsonFile.Run();
            Console.WriteLine("");

            BaseFile xmlFile = new XMLFile();
            xmlFile.Run();
            Console.WriteLine("");

            BaseFile txtFile = new TxtFile();
            txtFile.Run();
            Console.WriteLine("");
        }
    }
}
