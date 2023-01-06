
//TASK 1

//using OperatorOverloadingCollectionsTasks;
//using OperatorOverloadingCollectionsTasks.Models;

//Celsius celcius = new Celsius(127);
//Kelvin kelvin = celcius;
//Console.WriteLine(kelvin.Degree);



//TASK 2 : Authors

//using OperatorOverloadingCollectionsTasks.Models;

//static List<Author> GetAllAuthors()
//{
//    List<Author> authors = new();

//    Author author1 = new Author()
//    {
//        Id = 1,
//        FullName = "Roya Meherremova",
//        Age= 26,
//    };
//    Author author2 = new Author()
//    {
//        Id = 2,
//        FullName = "Cavid ISmayilzade",
//        Age = 56,
//    };
//    Author author3 = new Author()
//    {
//        Id = 3,
//        FullName = "Konul Ibrahimova",
//        Age = 26
//    };
//    Author author4 = new Author()
//    {
//        Id = 4,
//        FullName = "Shaiq Kazimov",
//        Age = 45,
//    };
//    Author author5 = new Author()
//    {
//        Id = 5,
//        FullName = "Elcan Qurbanov",
//        Age = 66
//    };

//    authors.Add(author1);
//    authors.Add(author2);
//    authors.Add(author3);
//    authors.Add(author4);
//    authors.Add(author5);

//    return authors;
//}



//GetFilteredAuthors(); 
//static void GetFilteredAuthors()
//{
//    var authors= GetAllAuthors();
//    foreach (var item in authors)
//    {
//        if (item.Age > 40)
//        {
//            Console.WriteLine(item.FullName);
//        }
//    }
//}



//TASK 3 : Employee

//using OperatorOverloadingCollectionsTasks.Models;

//static List<Employee> GetAllEmployees()
//{
//    List<Employee> employees = new();

//    Employee emp1 = new Employee()
//    {
//        FullName= "Roya Meherremova",
//        Birthday=new DateTime(1996,05,20),
//        Salary=4200
//    };
//    Employee emp2 = new Employee()
//    {
//        FullName = "Aqshin Hummetov",
//        Birthday = new DateTime(1995, 03, 19),
//        Salary = 4100
//    };
//    Employee emp3 = new Employee()
//    {
//        FullName = "Konul Ibrahimova",
//        Birthday = new DateTime(1996, 11, 20),
//        Salary = 3500
//    };
//    Employee emp4 = new Employee()
//    {
//        FullName = "Elcan Qurbanov",
//        Birthday = new DateTime(2003, 03, 25),
//        Salary = 2500
//    };
//    Employee emp5 = new Employee()
//    {
//        FullName = "Mubariz Agayev",
//        Birthday = new DateTime(2004, 12, 02),
//        Salary = 7300
//    };

//    employees.Add(emp1);
//    employees.Add(emp2);
//    employees.Add(emp3);
//    employees.Add(emp4);
//    employees.Add(emp5);
//    return employees;
//}



//Console.WriteLine("Add start date :");
//DateTime startDate=DateTime.Parse(Console.ReadLine());
//Console.WriteLine("Add end date :");
//DateTime endDate=DateTime.Parse(Console.ReadLine());
//Console.WriteLine("Add minimum salary :");
//int minSalary=int.Parse(Console.ReadLine());

//Console.WriteLine("Count of filtered employees :");
//Console.WriteLine(GetFilteredEmployeesCount(startDate, endDate, minSalary));
//static int GetFilteredEmployeesCount(DateTime startDate,DateTime endDate,int minSalary)
//{
//    int count = 0;
//    var employees=GetAllEmployees();
//    foreach (var item in employees)
//    {
//        if(item.Birthday>startDate && item.Birthday<endDate && item.Salary > minSalary)
//        {
//            count++;
//        }
//    }
//    return count;
//}










