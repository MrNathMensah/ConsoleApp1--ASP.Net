using System.Collections;
using CalculatorClassLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        /*
     int age;

     var myage2 = 56;

     dynamic myage3 = 64;

    int sum = myage2 + myage3;

    int subtraction = myage3 - myage2;

    Console.WriteLine("The sum of age 2 and age 3 is " + sum);

    Console.WriteLine("Age 3 minus Age 2 is " + subtraction);


//Monday

    Console.WriteLine("Please type your number 1 and number 2");
    int mynumber1, mynumber2, result;
    int myage;

    mynumber1 = Convert.ToInt32(Console.ReadLine());
    mynumber2 = Convert.ToInt32(Console.ReadLine());
    result = mynumber1 + mynumber2;
    Console.WriteLine(result);

    String name = Console.ReadLine();


    Console.WriteLine("Please type your age");
    myage = Convert.ToInt32(Console.ReadLine());
    string myageinstring = myage.ToString();
    string words = "Type ' get-help NuGet' to see all available NuGet commands.";
    string wordinlowercase = words.ToLower();
    string wordinuppercase = words.ToUpper();
    int count = wordinlowercase.Length;

    Console.WriteLine("Hello, World!  {0}, {1}, {2}", myage, result, name);
    Console.ReadLine();

    var partofstring = words.Substring(0, 14);
    Console.WriteLine(partofstring); */

        //Conditional Statements - IF
        //Console.WriteLine("Please type in some word(s)");
        //string userword = Console.ReadLine();

        /*

        if(userword.Length > 0)
        {
            Console.WriteLine("Weldone user, you typed something");
        }
        if(userword.Length > 0 && userword.Length < 10)
        {
            Console.WriteLine("Weldone user, you typed less than 9 characters");
        }
        if(userword.Length > 0 && userword.Length > 11)
        {
            Console.WriteLine("Weldone user you typed more than 11 words");
        }
        //Else - If
        else if (userword.Length > 11 && userword.Length < 50)
        {
            Console.WriteLine("Weldone user, you typed more than 11 letters");
        }
        else
        {
            Console.WriteLine("Master be careful you did not type anything");
        } */

        //Switch - Statement
        /*
        switch(userword.Length)
        {
            case > 10:
                Console.WriteLine("your word has a lenght of 10");
                break;

            default:
                Console.WriteLine("Something");
                break;
         } */

        /* //work that accepts two inputs and an operation and does the calculations for your per the operation

        Console.WriteLine("Please type First Number");
        int fnum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please type Second Number");
        int snum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please type Enter an Operation either Addition, Subtraction, Multiplication and Division");
        string operation = Console.ReadLine();
        if (operation=="Addition")
        {
            int sum = fnum + snum;
            Console.WriteLine("The Sum of the First Number You Enter and the Second is: " + sum);
        }
        else if (operation=="Subtraction")
        {
            int sub = fnum - snum;
            Console.WriteLine("The First Number minus the Second Number is: " + sub);
        }
        else if (operation == "Multiplication")
        {
            int mult = fnum * snum;
            Console.WriteLine("The multiplication of the First Number and the Second Number is: " + mult);
        }
        else if (operation == "Division")
        {
            int div = fnum / snum;
            Console.WriteLine("The First Number divided the Second Number is: " + div);
        }   */


        /* // for and while loops
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);

            if (i == 5)
            {
                continue;
                //break;
            }

            Console.WriteLine(i);
        }

        int a =0;
        while(a < 10)
        {
            Console.WriteLine(a);
            a++;
        }

        do
        {
           Console.WriteLine(a);
            a++;

        } while (a < 10);

        int x = 1;
        int y = 2;

        x += y;
        Console.WriteLine(x); */

        
        var mycalculate = new Calculatorclasslibrary();
        Console.WriteLine("Please type in two numbers");
        double numb1, numb2, result;
        numb1 = Convert.ToDouble(Console.ReadLine());
        numb2 = Convert.ToDouble(Console.ReadLine());

        result = mycalculate.Additions(numb1, numb2);
        Console.WriteLine(result);


        /*
        int[] myarry = new int[7];
        myarry[0] = 9;

        string[] mystringarry1 = new string[] { "Come", "Love", "Sweet", "Soap" };

        string[] mystringarry2 = new string[3] { "Come", "Love", "Sweet" };

        foreach(string word in mystringarry1)
        {
            Console.WriteLine(word);
        }
        foreach(var text in mystringarry2)
        {
            Console.WriteLine(text);
        }

        var myarrylist = new ArrayList();
        myarrylist.Add("Come");
        myarrylist.Add(67);
        myarrylist.Add(true);

        foreach(var list in myarrylist)
        {
            
            Console.WriteLine(list);
        } */

        /*
        //List collections
        var mylist = new List<int>();
        mylist.Add(2);
        mylist.Add(44);
        mylist.Add(55);
        mylist.Add(66);
        mylist.Add(77);

        //alternative way of the above
        List<int> mylist2 = new List<int>();
        mylist.Add(88);
        mylist.Add(99);
        mylist.Add(100);

        foreach (var list in mylist)
        {
            Console.WriteLine(list);
        }

        //Dictionary
        var mydictionary = new Dictionary<int, string>();
        Dictionary<int, string> mydictionary2 = new Dictionary<int,string>();
        mydictionary.Add(1, "Data");
        mydictionary.Add(2, "Bundle");
        mydictionary.Add(3, "MTN");
        mydictionary.Add(4, "Vodaphone");
        mydictionary.Add(5, "Tigo");
      
        foreach (var dictionary in mydictionary)
        {
            Console.WriteLine(dictionary);
            Console.WriteLine(dictionary.Key);
            Console.WriteLine(dictionary.Value);
        } */


        /*
        var myemployee = new Employee();
        myemployee.EmployeeID = 1;

        var myemp = new Employee
        {
            EmployeeID = 5,
            FirstName = "Nathaniel",
            LastName = "Nyarkoh"
        };

        Console.WriteLine("ID: " + myemp.EmployeeID + " First Name: " + myemp.FirstName + " Last Name:" + myemp.LastName);

        
        var cal = new CalculatorImplementor();
        double result = cal.Addition2(14, 5);
        Console.WriteLine(result);



        var myemplist2 = new List<Employee>
         {
             new Employee
             {
               EmployeeID = 1,
               FirstName ="Cliff",
               LastName = "Owusu Bright",
               Gender = "Male",
               PhoneNo = "0245367489",
             }, new Employee
             {
               EmployeeID = 2,
               FirstName ="Cosmos",
               LastName = "Antoh",
               Gender = "Male",
               PhoneNo = "0245001189",
             }, new Employee
             {
               EmployeeID = 3,
               FirstName ="Cambel",
               LastName = "Veronica",
               Gender = "Female",
               PhoneNo = "0245444589",
             }
             };
        foreach (var emp in myemplist2)
        {
            Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.Gender + " " + emp.PhoneNo);
        }
        Console.WriteLine(myemplist2.Count); */

    }
}


// Creating classes


public class Employee
{
    private int employeeID;
    private string firstName;
    private string lastName;
    private string gender;
    private string phoneNo;

    public int EmployeeID { get => employeeID; set => employeeID = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Gender { get => gender; set => gender = value; }
    public string PhoneNo { get => phoneNo; set => phoneNo = value; }
}

public class Vehicle
{
    public string VehicleId { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public DateTime DateofManufacture { get; set; }
    public string CountryofOrigin { get; set; }

}


//Interface - its nameing begins with I
public interface ICalculator
{
    public double Addition2(double num1, double num2);
    public double Subtraction2(double num1, double num2);
}

public class CalculatorImplementor : ICalculator
{
    public double Addition2(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtraction2(double num1, double num2)
    {
        return num1 - num2;
    }
}



