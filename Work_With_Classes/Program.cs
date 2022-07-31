namespace Work_With_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character[] characters = { new Character("Андрей", 300, 100, 1000, 1000, 200, 65), 
                new Character("Олег", 300, 100, 1000, 1000, 200, 65), new Character("Даша", 300, 100, 1000, 1000, 200, 65) };

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].ShowCharacteristics();
            }
        }
    }

    class Character
    {
        private string _name;
        private int _damage;
        private int _defence;
        private int _maxHealth;
        private int _currentHealth;
        private int _speed;
        private int _jumpHeight;

        public Character(string name, int damage, int defence, int maxHealth, int currentHealth, int speed, int jumpHeight)
        {
            _name = name;
            _damage = damage;
            _defence = defence;
            _maxHealth = maxHealth;
            _currentHealth = currentHealth;
            _speed = speed;
            _jumpHeight = jumpHeight;
        }

        public void ShowCharacteristics()
        {
            Console.WriteLine($"Имя персонажа: {_name}\nУрон: {_damage}\nБроня: {_defence}\nЗдоровье: {_currentHealth} / {_maxHealth}" +
                $"\nСкорость: {_speed}\nВысота прыжка: {_jumpHeight}\n");
        }
    }
}