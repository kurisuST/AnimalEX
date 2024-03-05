namespace AnimalEX
{
    internal class Cat:AnimalName,IAnimal
    {
        public Cat(string name) : base(name) 
        {
        
        }

        public void Sound()
        {
            Console.WriteLine($"{Name} dice: ¡Miau Miau!");
        }
    }
}
