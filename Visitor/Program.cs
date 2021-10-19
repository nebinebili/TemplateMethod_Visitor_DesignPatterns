using System;


namespace Visitor
{
   public interface IVisitor
   {
        void Visit(IPrinter printer);
   }

    public class FaxVisitor : IVisitor
    {
        public void Visit(IPrinter printer)
        {
            Console.WriteLine($"{printer.Name} of Fax Sending..");
        }
    }

    public interface IPrinter
    {
        public string Name { get; set; }
        void Print();
        void Accept(IVisitor visit);
    }

    public class HPPrinter : IPrinter
    {
        public string Name { get; set; }
        public void Print()
        {
        
            Console.WriteLine($"{Name} print...");
        }

        public void Accept(IVisitor visit) => visit.Visit(this);
    }

    public class LexmarkPrinter : IPrinter
    {
        public string Name { get; set; }
        public void Print()
        {
          
            Console.WriteLine($"{Name} print...");
        }

        public void Accept(IVisitor visit) => visit.Visit(this);
    }

    class Program
    {
        static void Main(string[] args)
        {
            HPPrinter hPPrinter = new HPPrinter { Name = "HppPrinter" };
            LexmarkPrinter lexmarkPrinter = new LexmarkPrinter { Name = "LexmarkPrinter" };

            hPPrinter.Print();
            lexmarkPrinter.Print();

            IVisitor visitor = new FaxVisitor();
            hPPrinter.Accept(visitor);
            lexmarkPrinter.Accept(visitor);
        }
    }
}
