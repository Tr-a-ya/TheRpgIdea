using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheRpgIdea
{
    internal class Adventurer
    {
        public string aName;
        public string aClass;
        public string aRace;
        public int aStr;
        public int aDex;
        public int aCon;
        public int aWis;
        public int aInt;
        public int aChar;
        public virtual void useAbility()
        {
            Console.WriteLine("Adventurer uses their ability");
        }

        public Adventurer(string sName, string sClass, string sRace, int sStr, int sDex, int sCon, int sWis, int sInt, int sChar)
        {
            aName = sName;
            aClass = sClass;
            aRace = sRace;
            aStr = sStr;
            aDex = sDex;
            aCon = sCon;
            aWis = sWis;
            aInt = sInt;
            aChar = sChar;

            
        }

    }
}
