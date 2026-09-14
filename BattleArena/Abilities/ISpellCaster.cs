using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BattleArena.Abilities
{
    internal interface ISpellCaster
    {
        void CastSpell(Warrior target);
    }
}