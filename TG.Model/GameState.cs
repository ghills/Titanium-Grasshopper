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
        private const String _defGameText = "You are in a room.... or something.";
        
        public int HitPoints { get; set; }
        public int Damage { get; set; }
        public String CharacterName { get; set; }
        public String GameText { get; set; }

        public GameState() : this( _defName, _defHP, _defDamage, _defGameText )
        { }

        public GameState(String CharacterName, int HitPoints, int Damage, String GameText)
        {
            this.CharacterName = CharacterName;
            this.HitPoints = HitPoints;
            this.Damage = Damage;
            this.GameText = GameText;
        }
        //TODO: add inventory
    }
}
