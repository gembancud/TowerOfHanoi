using System;

namespace TowerOfHanoi
{
    public class Instruction
    {


        public int Disk { get; set; }
        public Peg StartPeg { get; set; }
        public Peg EndPeg { get; set; }

        public Instruction(int disk, Peg A, Peg B)
        {
            Disk = disk;
            StartPeg = A;
            EndPeg = B;

            StartPeg._pegArray[Disk-1] = false;
            EndPeg._pegArray[Disk-1] = true;
        }

        public override string ToString()
        {
            return $"Disk {Disk} transferred from {StartPeg} to {EndPeg}";
        }
    }
}