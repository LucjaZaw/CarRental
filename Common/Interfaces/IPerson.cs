using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Interfaces
{
    public interface IPerson
    {
        string FName { get; init; }
        string LName { get; init; }
        int SocialSecNum { get; init; }


    }
}
