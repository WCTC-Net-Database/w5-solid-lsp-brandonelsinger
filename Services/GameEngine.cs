using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _archer;
        private readonly IEntity _mage;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity archer, IEntity mage)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _archer = archer;
            _mage = mage;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _archer.Name = "Archer";
            _mage.Name = "Mage";

            _character.Move();
            _goblin.Move();
            _character.Attack(_goblin);
            _goblin.Attack(_character);
            Console.WriteLine();

            _ghost.Move();
            _archer.Move();
            _archer.Attack(_ghost);
            _ghost.Attack(_archer);

            if (_ghost is IFlyable flyableEntity)
            {
                flyableEntity.Fly();
            }       

            if (_archer is IShootable shootableEntity)
            {
                shootableEntity.Shoot();
            }
            Console.WriteLine();

            _mage.Move();
            _character.Move();
            _character.Attack(_mage);

            if (_mage is ICastable castableEntity)
            {
                castableEntity.CastSpell("Lightning Bolt");
            }
        }
    }
}