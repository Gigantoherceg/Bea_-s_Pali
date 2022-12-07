using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.FighterEx
{
    public class FightClubMain
    {
        static void Main(string[] args)
        {
            Fighter fighterFiú = new Fighter("Kis Pál", 20);
            Fighter fighterCsaj = new Fighter("Nagy Bea", 20);
            
            FightClub fightclub = new FightClub();

            string kezdő = fightclub.declareWinner(fighterFiú, fighterCsaj);

            bool üt=false;

            if (kezdő==fighterFiú.Name)
            {
                üt = true;
            }

            while (( fighterCsaj.Health > 0) && (fighterFiú.Health > 0))
            {                
                if (üt)
                {
                    fighterCsaj.Health -= fighterFiú.Attack();
                }
                else
                {
                    fighterFiú.Health -= fighterCsaj.Attack();
                }
                üt = !üt;
            } 

            string győztes;

            if (fighterCsaj.Health <= 0)
            {
                győztes = fighterFiú.Name;
            }
            else
            {
                győztes= fighterCsaj.Name;
            }
            Console.WriteLine(kezdő);
            Console.WriteLine("A győztesünk: "+győztes.ToUpper());

        }
    }
}
