using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities
{
    public class Ninja : Hero
    {
        public NinjaWeapon Weapon { get; set; }

        public Ninja(string name, int level, int hP, int mP)
        {
            Name = name;
            Level = level;
            HP = hP;
            MP = mP;
            HeroType = HeroType.Ninja;
            
        }
        public override string Attack()
        {
            return $"{this.Name} causou um dano de {((int)this.Weapon)} com sua {this.Weapon}";
        }

    }
}
