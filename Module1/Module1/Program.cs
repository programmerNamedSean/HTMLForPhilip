using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            //A list of string variables containing information
            string firstName = "John ", lastName="Doe ", Address_Line1 = "164 Koles Court ", 
                Address_Line2= "N/A ", city="Edwardsville ", state_or_province ="MO ", county ="St.Louis County ";
            //Stores the Birth date inside of a struct
            DateTime BirthDate = new DateTime(1974,8,31);
            //Stores the zip or postal code as an int variable
            int zip_or_postal_code= 62025;
            //Prints out the information of the student such as name, address, birthdate, and zipcode.
            Console.WriteLine(firstName + lastName + BirthDate + " " + Address_Line1 +
                              Address_Line2 + city + state_or_province + county + zip_or_postal_code);
            
        }
    }
}
