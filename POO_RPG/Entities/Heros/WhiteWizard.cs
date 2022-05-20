using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities.Heros
{
    public class WhiteWizard : Hero
    {
        public WizardMagic Magic { get; set; }

        public WhiteWizard(string name, int level, WizardMagic magic)
        {
            Name = name;
            Level = level;
            HP = level * 7;
            MP = level * 18;
            HeroType = HeroType.WhiteWizard;
            Magic = magic;
        }

        public override string Attack()
        {
            return $"{this.Name} lançou {this.Magic} que causou {((int)this.Magic)} de dano. ";
        }
    }
}
