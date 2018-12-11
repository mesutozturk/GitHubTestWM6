using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    class Samet
    {
        private int _say;

        public Samet(int say)
        {
            Say = say;
        }

        public int Say { get => _say; set => _say = value; }
    }
}
