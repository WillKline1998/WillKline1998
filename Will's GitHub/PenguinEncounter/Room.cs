using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinEncounter
{
    internal class Room
    {
        public Room(string name, string prevRoom, string nextRoom)
        {
            Name = name;
            PrevRoom = prevRoom;
            NextRoom = nextRoom;
        }
        public Room(string name, string prevRoom)
        {
            Name = name;
            PrevRoom = prevRoom;
            NextRoom = "none";
        }
        public string Name { get;}
        public string PrevRoom { get; }
        public string NextRoom { get; }
        public void Enter()
        {
            Console.WriteLine($"Passing through the fancy door you enter the {Name} and leave behind the {PrevRoom}.");
            Console.WriteLine($"The {Name} is full of ornate decorations, but you smell blood and sweat.");
            if(NextRoom == "none")
            {
                Console.WriteLine($"Before you stands an opulent inner chamber, and in the center, a mighty Penguin wearing a crown.");
            }
            else
            {
                Console.WriteLine($"You can see the golden door of the {NextRoom}...");
                Console.WriteLine($"But in its way stand an enemy.");
            }
            Console.ReadLine();
        }
        public void Leave()
        {

        }

    }
}
