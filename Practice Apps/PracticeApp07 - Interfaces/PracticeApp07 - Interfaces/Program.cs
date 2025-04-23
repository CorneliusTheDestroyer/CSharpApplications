namespace PracticeApp07___Interfaces
{
    public interface IEnemy
    {
        void Attack();
        void Defend();
    }

    public class Goblin : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Goblin attacks!");
        }
        public void Defend()
        {
            Console.WriteLine("Goblin defends!");
        }
    }

    public class Troll : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Troll attacks!");
        }
        public void Defend()
        {
            Console.WriteLine("Troll defends!");
        }
    }

    public class Dragon : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Dragon attacks!");
        }
        public void Defend()
        {
            Console.WriteLine("Dragon defends!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnemy goblin = new Goblin();
            IEnemy troll = new Troll();
            IEnemy dragon = new Dragon();

            //goblin.Attack();
            //goblin.Defend();
            //troll.Attack();
            //troll.Defend();
            //dragon.Attack();
            //dragon.Defend();

            List<IEnemy> enemies = new List<IEnemy>();

            enemies.Add(goblin);
            enemies.Add(troll);
            enemies.Add(dragon);
            
            foreach (IEnemy enemy in enemies)
            {
                enemy.Attack();
                enemy.Defend();
            }
        }
    }
}
