using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StoryTutorium
{
    internal class Player
    {
        public Orientierung orientierung = Orientierung.Norden;
        public bool Taschenuhr;
        public bool Tagebuch;
        public bool Kalenderseite;

        public enum Orientierung
        {
            Norden,
            Osten,
            Süden,
            Westen
        }

        public void Drehen()
        {
            Console.WriteLine($"Der Spieler schaut Richtung {orientierung.ToString()}");
            Console.WriteLine("In welche Richtung möchtest du dich drehen?");
            Console.WriteLine("Gültige Eingaben: \"l\" (Für Links) & \"r\" (Für Rechts)");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "l")
            {
                if (orientierung == Orientierung.Norden)
                {
                    orientierung = Orientierung.Westen;
                }
                else if (orientierung == Orientierung.Westen)
                {
                    orientierung = Orientierung.Süden;
                }
                else if (orientierung == Orientierung.Süden)
                {
                    orientierung = Orientierung.Osten;
                }
                else if (orientierung == Orientierung.Osten)
                {
                    orientierung = Orientierung.Norden;
                }
            }
            else if (userInput == "r")
            {
                if (orientierung == Orientierung.Norden)
                {
                    orientierung = Orientierung.Osten;
                }
                else if (orientierung == Orientierung.Osten)
                {
                    orientierung = Orientierung.Süden;
                }
                else if (orientierung == Orientierung.Süden)
                {
                    orientierung = Orientierung.Westen;
                }
                else if (orientierung == Orientierung.Westen)
                {
                    orientierung = Orientierung.Norden;
                }
            }
            Console.WriteLine($"Der Spieler schaut Richtung {orientierung.ToString()}");

        }

        public void Inventar()
        {
            int items = 0;
            if (Taschenuhr)
            {
            Console.WriteLine("Spieler besitzt die Taschenuhr.");
                items++;
            }
            if (Tagebuch)
            {
                Console.WriteLine("Spieler besitzt das Tagebuch.");
                items++;
            }
            if (Kalenderseite)
            {
                Console.WriteLine("Spieler besitzt die Kalenderseite.");
                items++;
            }
            Console.WriteLine($"Du besitzt {items} von 3 Gegenständen.");
        }
    }
}
