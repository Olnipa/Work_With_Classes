namespace Work_With_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("Андрей", 300, 100, 1000, 1000, 200, 65);
            Character character2 = new Character("Олег", 300, 100, 1000, 1000, 200, 65);
            Character character3 = new Character("Даша", 300, 100, 1000, 1000, 200, 65);

            character1.ShowCharacteristics();
            character2.ShowCharacteristics();
            character3.ShowCharacteristics();
        }
    }

    class Character
    {
        public string Name;
        public int Damage;
        public int Defence;
        public int MaxHealth;
        public int CurrentHealth;
        public int Speed;
        public int JumpHeight;

        public Character(string name, int damage, int defence, int maxHealth, int currentHealth, int speed, int jumpHeight)
        {
            Name = name;
            Damage = damage;
            Defence = defence;
            MaxHealth = maxHealth;
            CurrentHealth = currentHealth;
            Speed = speed;
            JumpHeight = jumpHeight;
        }

        public void ShowCharacteristics()
        {
            Console.WriteLine($"Имя персонажа: {Name}\nУрон: {Damage}\nБроня: {Defence}\nМакс. количество жизней: {MaxHealth}" +
                $"\nТекущее количество жизней: {CurrentHealth}\nСкорость: {Speed}\nВысота прыжка: {JumpHeight}\n");
        }
    }
}