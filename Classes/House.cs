public class House
{
    public double area { get; set; }
    public Door door;
    public House(double area)
    {
        this.area = area;
        this.door = new Door("brown");
    }

    public string ShowData() {
        return $"I am a house, my area is {this.area} m2.";
    }

    public string getDoor() {
        return this.door.ShowData();
    }
}