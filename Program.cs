using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            HanoiInstructions x = new HanoiInstructions(3, "Dog", "Cat", "Cow");
            foreach (var instruction in x.InstructionList)
            {
                Console.WriteLine($"{instruction.Disk} is transferred from {instruction.StartPeg} to {instruction.EndPeg}");
            }

            Console.Read();
        }
    }
}
