public class Door
{
    public string color { get; set; }
    public Door(string color)
    {
        this.color = color;
    }

    public string ShowData() {
        return $"I am a door, my color is {this.color}.";
    }
}