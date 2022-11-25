public class SmallApartment : House
{
    public SmallApartment(double area) : base(area)
    {
        if (area <= 50)
        { this.area = area; }
        else
        {
            this.area = 50;
        }
    }

    // Nu mi-am dat seama cum sa previn
}