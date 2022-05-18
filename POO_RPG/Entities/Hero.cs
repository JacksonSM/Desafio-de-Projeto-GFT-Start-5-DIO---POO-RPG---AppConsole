using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities
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
    }
}
