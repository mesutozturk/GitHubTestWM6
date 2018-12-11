using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    public class Alper
    {
        public Alper(string isim)
        {
            banaKendiniTanit(isim);
        }
        public string banaKendiniTanit(string isim)
        {
            return $"Merhaba {isim}, ben Alper, nasıl gidiyor?";
        }
    }
}
