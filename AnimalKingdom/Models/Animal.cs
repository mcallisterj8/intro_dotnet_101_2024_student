using AnimalKingdom.Interfaces;

namespace AnimalKingdom.Models;

public abstract class Animal : IAnimal {
    public string Name { get; set; }
    public abstract List<string> SuitableHabitats { get; set; }

    public Animal(string name) {
        this.Name = name;
    }
    public abstract bool Eat(string food);
    public abstract bool IsHabitatSuitable(string habitat);
}