using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities.Heros
{
    public class WhiteWizard : Hero
    {
        public WizardMagic Magic { get; set; }

        public WhiteWizard(string name, int level, int hP, int mP)
        {
            Name = name;
            Level = level;
            HP = hP;
            MP = mP;
            HeroType = HeroType.WhiteWizard;

        }

        public override string Attack()
        {
            return $"{this.Name} causou um dano de {((int)this.Magic)} com sua {this.Magic}";
        }
    }
}
