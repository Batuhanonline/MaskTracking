// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System.Xml.Linq;
internal class Program
{
    private static void Main(string[] args)
    {

        Person person = new Person();
        person.NationalIdentity = 11111111111;
        person.FirstName = "Batuhan";
        person.LastName = "Güven";
        person.DateOfBirthYear = 1999;
        

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);



    }
}
