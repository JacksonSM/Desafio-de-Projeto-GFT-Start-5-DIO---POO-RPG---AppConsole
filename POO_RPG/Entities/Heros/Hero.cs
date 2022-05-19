using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities.Heros
{
    public class Hero 
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public  HeroType HeroType { get; set; }

       

        public virtual string Attack()
        {
            return "Ataque";
        }

        public override string ToString()
        {
            return @$"{this.Name} - {this.HeroType}
   Level {this.Level}
   HP {this.HP}
   MP {this.MP}";
        }
    }
}
