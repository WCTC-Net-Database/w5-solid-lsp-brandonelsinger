using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Archer : IEntity, IShootable
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} hits {target.Name} with a roundhouse kick!");
        }
        public void Move()
        {
            Console.WriteLine($"{Name} performs a cartwheel!");
        }
        public void Shoot()
        {
            Console.WriteLine($"{Name} launches an arrow!");
        }
    }
}