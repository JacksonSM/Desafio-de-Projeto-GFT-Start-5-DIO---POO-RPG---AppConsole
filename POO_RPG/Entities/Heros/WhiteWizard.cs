using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities.Heros
{
    public class WhiteWizard : Hero
    {
        public WizardMagic Magic { get; set; }

        public WhiteWizard(string name, int level)
        {
            Name = name;
            Level = level;
            HP = level * 7;
            MP = level * 18;
            HeroType = HeroType.WhiteWizard;

        }

        public override string Attack()
        {
            return $"{this.Name} lançou {this.Magic} que causou {((int)this.Magic)} de dano. ";
        }
    }
}
