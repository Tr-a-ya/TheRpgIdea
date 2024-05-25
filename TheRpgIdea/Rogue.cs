using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheRpgIdea
{
    internal class Rogue:Adventurer
    {
        public override void useAbility()
        {
            Console.WriteLine ("You meld with the shadows.");  
        }
        public Rogue(string rogueName, string sClass, string sRace, int sStr, int sDex, int sCon, int sWis, int sInt, int sChar) : base(rogueName, sClass, sRace, sStr, sDex, sCon, sWis, sInt, sChar)
        {
            aName = rogueName;
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
