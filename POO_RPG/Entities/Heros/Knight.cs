using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities.Heros
{
    public class Knight : Hero
    {
        public KnightWeapon Weapon { get; set; }

        public Knight(string name, int level)
        {
            Name = name;
            Level = level;
            HP = level * 12;
            MP = level * 3;
            HeroType = HeroType.Knight;

        }
        public override string Attack()
        {
            return $"{this.Name} causou dano de {(int)this.Weapon} com sua {this.Weapon}";
        }
    }
}
