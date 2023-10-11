using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes
{
    public class Custumer : IPerson
    {
        public string FName { get; init; }
        public string LName { get; init; }
        public int SocialSecNum { get; init; }

        public Custumer(string fName, string lName, int socialSecNum) => 
            (FName, LName, SocialSecNum) = 
            (fName, lName, socialSecNum);
        Custumer custumer1 = new("Lucja", "Zawiasa", 000318);
        Custumer customer2 = new("Tobias", "Lindius", 010514);



    }
}
