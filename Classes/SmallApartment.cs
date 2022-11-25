public class SmallApartment : House
{
    // override public double area
    // {
    //     get
    //     {
    //         return area;
    //     }
    //     set
    //     {
    //         if (value > 50)
    //         {
    //             Console.WriteLine("A small apartment can't be bigger than 50mp2.");
    //             area = 50;
    //         }
    //         else
    //         {
    //             area = value;
    //         }
    //     }
    // }
    public SmallApartment(double area) : base(area)
    {
        if (area <= 50)
        { this.area = area; }
        else
        {
            this.area = 50;
        }
    }
    override public string ShowData() {
        return $"I am a small apartment, my area is {this.area} m2.";
    }
}