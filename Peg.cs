using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class Peg
    {
        public bool[] _pegArray;
        public string _pegName;

        public Peg(int n, string pegName)
        {
            _pegArray = new bool[n];
            _pegName = pegName;
        }

        public override string ToString()
        {
            return _pegName;
        }
    }
}
