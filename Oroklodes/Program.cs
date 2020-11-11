using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public interface IPeldaInterface2 { }

    public interface IPeldaInterface1: IPeldaInterface2
    {
        void Peldametodus(string parameter1, string parameter2);
    }
    abstract class Emlos: IPeldaInterface1, IPeldaInterface2
    {
        public int Kor { get; set; }
        public void Oregszik(int evekszam)
        {
            Kor++;
            HangotAd();
        }

        public abstract void HangotAd();

        public void Peldametodus(string parameter1, string parameter2)
        {
            throw new NotImplementedException();
        }
    }

    class Macska : Emlos
    {
        public override void HangotAd()
        { Console.WriteLine("Miau"); }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Macska Micike = new Macska();
            Micike.Oregszik(1);
            Console.WriteLine(Micike.Kor);
            Console.ReadLine();
        }
    }



}
