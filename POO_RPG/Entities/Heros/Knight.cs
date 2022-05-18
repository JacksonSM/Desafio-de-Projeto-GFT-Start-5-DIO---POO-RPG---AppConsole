using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities
{
    public class Knight : Hero
    {
        public KnightWeapon Weapon { get; set; }

        public Knight(string name, int level, int hP, int mP)
        {
            Name = name;
            Level = level;
            HP = hP;
            MP = mP;
            HeroType = HeroType.Knight;

        }
        public override string Attack()
        {
            return $"{this.Name} causou dano de {(int)this.Weapon} com sua {this.Weapon}";
        }
    }
}
