namespace AnimalKingdom.Models;
public class Lion : Animal {
    public override List<string> SuitableHabitats { get; set; }

    public Lion(string name, List<string> habitatList): base(name) {
        // this.SuitableHabitats = habitatList;
        this.SuitableHabitats = new List<string>();
        foreach(string habitat in habitatList) {
            this.SuitableHabitats.Add(habitat);
        }
    }

    public override bool Eat(string food) {
        throw new NotImplementedException();
    }

    public override bool IsHabitatSuitable(string habitat) {
        throw new NotImplementedException();
    }
}
