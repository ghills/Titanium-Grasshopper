using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TG.Model
{
    public class GameState
    {
        private const String _defName = "Uber Noob";
        private const int _defHP = 0;
        private const int _defDamage = 0;
        
        public int HitPoints { get; set; }
        public int Damage { get; set; }
        public String CharacterName { get; set; }

        public GameState() : this( _defName, _defHP, _defDamage )
        { }

        public GameState(String CharacterName, int HitPoints, int Damage)
        {
            this.CharacterName = CharacterName;
            this.HitPoints = HitPoints;
            this.Damage = Damage;
        }
        //TODO: add inventory
    }
}
