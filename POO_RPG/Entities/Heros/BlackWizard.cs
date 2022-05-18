using POO_RPG.Entities.Enums;

namespace POO_RPG.Entities.Heros
{
    public class BlackWizard : Hero
    {
        public WizardMagic Magic { get; set; }

        public BlackWizard(string name, int level)
        {
            Name = name;
            Level = level;
            HP = level * 8;
            MP = level * 19;
            HeroType = HeroType.BlackWizard;

        }

        public override string Attack()
        {
            return $"{this.Name} lançou {this.Magic} que causou {((int)this.Magic)} de dano. ";
        }
    }
}
