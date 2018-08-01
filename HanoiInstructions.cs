using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class HanoiInstructions
    {
        public Peg _leftPeg;
        public Peg _centerPeg;
        public Peg _rightPeg;
        public List<Instruction> InstructionList = new List<Instruction>();

        public HanoiInstructions(int n, string leftPegName, string centerPegName, string rightPegName)
        {
            _leftPeg = new Peg(n, leftPegName);
            _centerPeg = new Peg(n, centerPegName);
            _rightPeg = new Peg(n, rightPegName);

            GetInstructions(n, _leftPeg, _centerPeg, _rightPeg);
        }



        public void GetInstructions(int disk, Peg startPeg, Peg auxPeg, Peg endPeg)
        {
            if (disk == 1)
            {
                InstructionList.Add(new Instruction(disk, startPeg, endPeg));
            }
            else
            {
                GetInstructions(disk - 1, startPeg, endPeg, auxPeg);

                InstructionList.Add(new Instruction(disk, startPeg, endPeg));

                GetInstructions(disk - 1, auxPeg, startPeg, endPeg);
            }

        }
    }
}
