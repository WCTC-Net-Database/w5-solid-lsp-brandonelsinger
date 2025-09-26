using W5_assignment_template.Models;
using W5_assignment_template.Services;

namespace W5_assignment_template
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            var goblin = new Goblin();
            var ghost = new Ghost();
            var archer = new Archer();
            var mage = new Mage();  

            var gameEngine = new GameEngine(character, goblin, ghost, archer, mage);
            gameEngine?.Run();
        }

    }
}