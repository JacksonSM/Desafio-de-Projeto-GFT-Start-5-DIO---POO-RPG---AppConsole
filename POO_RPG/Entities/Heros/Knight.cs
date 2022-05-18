using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities
{
    public class Knight : Hero
    {
        public KnightWeapon Weapon { get; set; }

        public override string Attack()
        {
            return $"{this.Name} causou dano de {(int)Weapon} com sua {Weapon}";
        }
    }
}
