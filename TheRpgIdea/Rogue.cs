using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRpgIdea
{
    internal class Rogue:Adventurer
    {
        public Rogue(string sName, string sClass, string sRace, int sStr, int sDex, int sCon, int sWis, int sInt, int sChar) : base(sName, sClass, sRace, sStr, sDex, sCon, sWis, sInt, sChar)
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
