namespace AnimalEX
{
    internal class Dog:AnimalName,IAnimal
    {
        public Dog(string name) : base(name) 
        {
        
        }

        public void Sound()
        {
            Console.WriteLine($"{Name} dice: ¡Guau Guau!");
        }
    }
}
