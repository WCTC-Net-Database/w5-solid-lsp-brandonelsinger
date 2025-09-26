using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Mage: IEntity, ICastable
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} strikes {target.Name} with an uppercut punch!");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} glides forward!");
        }

        public void CastSpell(string spellName)
        {
            Console.WriteLine($"{Name} uses the {spellName} spell!");
        }
    }
}