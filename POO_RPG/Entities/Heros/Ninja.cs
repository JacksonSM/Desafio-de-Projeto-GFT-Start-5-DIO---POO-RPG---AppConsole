using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities.Heros
{
    public class Ninja : Hero
    {
        public NinjaWeapon Weapon { get; set; }

        public Ninja(string name, int level)
        {
            Name = name;
            Level = level;
            HP = level * 8;
            MP = level * 3;
            HeroType = HeroType.Ninja;
            
        }
        public override string Attack()
        {
            return $"{this.Name} causou um dano de {((int)this.Weapon)} com sua {this.Weapon}";
        }

    }
}
