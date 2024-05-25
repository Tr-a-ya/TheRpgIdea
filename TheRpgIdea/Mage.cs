using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheRpgIdea
{
    internal class Mage:Adventurer
    {

        public override void useAbility()
        {
            Console.WriteLine("Arcane energy flows around you.");
        }
        public Mage(string sName, string sClass, string sRace, int sStr, int sDex, int sCon, int sWis, int sInt, int sChar) : base (sName, sClass, sRace, sStr, sDex, sCon, sWis, sInt, sChar)
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
