using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Custumer : IPerson
{
    public string FName { get; init; }
    public string LName { get; init; }
    public string SocialSecNum { get; init; }

    public Custumer(string fName, string lName, string socialSecNum) => 
        (FName, LName, SocialSecNum) = 
        (fName, lName, socialSecNum);



}
