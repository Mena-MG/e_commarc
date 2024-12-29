using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class emplyeprofil
    {
        [key]
        public int id { get; set; }

        public string bio { get; set; }

        []
        public project project { get; set; }

    }


    class project
    {
        public int id { get; set; }
        public string name { get; set; }

        emplyeprofil emplyeprofil { get; set; }

    }

}
