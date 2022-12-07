using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Copyright © Progmasters (QTC Kft.), 2016-2022.
 * All rights reserved. No part or the whole of this Teaching Material (TM) may be reproduced, copied, distributed, 
 * publicly performed, disseminated to the public, adapted or transmitted in any form or by any means, including 
 * photocopying, recording, or other electronic or mechanical methods, without the prior written permission of QTC Kft. 
 * This TM may only be used for the purposes of teaching exclusively by QTC Kft. and studying exclusively by QTC Kft.’s 
 * students and for no other purposes by any parties other than QTC Kft.
 * This TM shall be kept confidential and shall not be made public or made available or disclosed to any unauthorized person.
 * Any dispute or claim arising out of the breach of these provisions shall be governed by and construed in accordance with the laws of Hungary.
 */
namespace Inheritance.FighterEx
{
    /**
     * Create a function that returns the name of the winner in a fight between two fighters.
     * Each fighter takes turns attacking the other and whoever kills the other first is the victorious.
     * Death is defined as having health <= 0.
     * Both health and damagePerAttack will be integers larger than 0. You can mutate the Fighter objects.
     */
    public class FightClub
    {
        private int fighterOne;
        private int fighterTwo;
        public string declareWinner(Fighter fighter1, Fighter fighter2)
        {
            string firstAttacker;
            Random random= new Random();
            fighterOne = random.Next(1,16);
            Random random1 = new Random();
            fighterTwo = random1.Next(1,16);
            if (fighterOne >= fighterTwo)
            {
                firstAttacker = fighter1.Name;
            }
            else
            {
                firstAttacker= fighter2.Name;
            }

            return firstAttacker;
        }
    }
}
