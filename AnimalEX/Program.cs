using AnimalEX;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances.
        Dog dog = new Dog("Coco");
        Cat cat = new Cat("Whiskas");

        // Calling the method Sound through the interface.
        ((IAnimal)dog).Sound();
        ((IAnimal)cat).Sound();
    }
}