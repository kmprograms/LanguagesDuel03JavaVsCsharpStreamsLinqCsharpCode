using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagesDuel03JavaVsCsharpStreamsLinqCsharpCode
{
    public readonly record struct Person(string Name, int Age)
    {
        public bool HasAgeBetween(int ageFrom, int ageTo) 
            => ageFrom <= Age && Age <= ageTo;
    }
}
