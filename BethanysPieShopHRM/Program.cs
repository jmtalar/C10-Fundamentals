// See https://aka.ms/new-console-template for more information

using BethanysPieShopHRM.HR;
using System.Text;


#region Bethany
//Console.WriteLine("Creating an employee");
//Console.WriteLine("---------------------\n");

//Employee bethany = new Employee("Bethany", "Smith", "janusz@wp.pl", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork(25);

//string name = "bethany";
//string anotherName = name;

//name += " smith";

//Console.Write("Name: " + name + "\n");
//Console.WriteLine("Another name: " + anotherName);

//string upperCase = name.ToUpper();

//string firstName = "Bethany";
//string lastName = "Smith";

//StringBuilder builder = new StringBuilder();

//builder.Append("First name: ");
//builder.Append(firstName);

//builder.Append("Last name: ");
//builder.Append(lastName);  

//string result = builder.ToString();
//Console.WriteLine(result);
//string bethanyAsJson = bethany.ConvertToJson();

//Console.WriteLine(bethanyAsJson);

//Console.Write("Name: " + name + "\n");
//Console.WriteLine("Uppercase: " +  upperCase);

//bethany.firstName = "John";
//bethany.hourlyRate = 10;

//int minimumBonus = 100;
//int bonusTax;

//int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
//Console.WriteLine($"Calculated bonus: {receivedBonus} and related tax: {bonusTax}");

//double receivedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid: {receivedWageBethany}");

//Console.WriteLine("Creating an employee");
//Console.WriteLine("---------------------\n");
#endregion


#region George
//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

//george.DisplayEmployeeDetails();

//george.PerformWork();
//george.PerformWork(5);
//double receivedWageGeorge = george.ReceiveWage(true);
#endregion

//WorkTask task;
//task.description = "Bake delicious pies";
//task.hours = 3;
//task.PerformWorkTask();


//Console.WriteLine("How many employee IDs do you need?");
//int[] sampleArray1 = new int[5];

//int length = int.Parse(Console.ReadLine());

//int[] employeeIds = new int[length];

//var testId = employeeIds[0];

//for(int i = 0; i < length; i++)
//{
//    Console.Write("Enter the employee ID:\n");
//    int id = int.Parse(Console.ReadLine());
//    employeeIds[i] = id;
//}

//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//Array.Sort(employeeIds);

//Console.Write("After sorting: \n");
//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//int[] employeeIdsCopy = new int[length];

//employeeIds.CopyTo(employeeIdsCopy, 0);

//Array.Reverse(employeeIds);

//Console.WriteLine("After reversing original array");

//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//Console.WriteLine("Copy of array");

//for (int i = 0; i < employeeIdsCopy.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIdsCopy[i]}");
//}

//List<int> employeeIds = new List<int>();

//employeeIds.Add(55);
//employeeIds.Add(1);
//employeeIds.Add(546);
//employeeIds.Add(48765); 
//employeeIds.Add(3);

//if (employeeIds.Contains(78))
//{
//    Console.WriteLine("78 is found!");
//};

//int currentAmountOfEmployees = employeeIds.Count;

//var employeeIdsArray = employeeIds.ToArray();

//employeeIds.Clear();

//int length = int.Parse(Console.ReadLine());

//for (int i = 0; i < length; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());
//    employeeIds.Add(id);
//}


Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

bethany.FirstName = "Test";
string fn = bethany.FirstName;

Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);

bethany.DisplayEmployeeDetails();
bethany.PerformWork(25);

mary.DisplayEmployeeDetails();
mary.PerformWork(25);