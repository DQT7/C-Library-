using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;

namespace _0._03_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate
            Donut mattsDonut = new Donut();
            //Donut DQDonut = new Donut();
            mattsDonut.Type = "glazed";
            mattsDonut.HasCream = false;
            mattsDonut.Price = 10.99M;
            //DQDonut.Type = "cream";
            //mattsDonut.PrintDonutType();
            SpeechSynthesizer speak = new SpeechSynthesizer();
            //speak.Speak(mattsDonut.Type);
            Donut dqDonut = new Donut();
            dqDonut.Type = "Bald Ha Ha!";
            speak.Speak("Ian is" + dqDonut.Type);
            Console.WriteLine(mattsDonut.Type);

        }
    }
}
