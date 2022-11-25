public class Person
{
    House house;
    string name;

    public Person(House house, string name)
    {
        this.house = house;
        this.name = name;
    }

    public string ShowData()
    {
        return $"My name is {this.name}.\n{this.house.ShowData()}\n{this.house.getDoor()}";
    }
}