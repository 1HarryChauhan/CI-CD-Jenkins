// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


public class Employee{
    private string name;
    private int age;

    Employee(string n,int a){
        name = n;
        age=a;
    }

    Employee(){
        name="Default Employee";
        age=10;
    }

    public string get_name(){
        return name;
    }

    public void set_name(){
        
        
        name = Console.ReadLine();
    }

    public int get_age(){
        return age;
    }

    public void set_age(){
        
        
        age =Convert.ToInt32(Console.ReadLine());
    }


    Employee (Employee s){
        name = s.get_name();
        age = s.get_age();
    }
    static void Main(string[] args){

        Employee e1 = new Employee();
        Employee e2 = new Employee("New_Employee",22);

        Console.WriteLine(e1.get_name());
        Console.WriteLine(e2.get_name());

        Console.WriteLine("Change Name of the Default Employee");

        

        e1.set_name();
        Console.WriteLine(" ");
        Console.WriteLine("New Employees");
        
        Console.WriteLine(e1.get_name());
        Console.WriteLine(e2.get_name());
        // Console.WriteLine(e1.get_name());
    
        Employee copy_employee = new Employee(e2);
        Console.WriteLine(" ");
        Console.WriteLine(" ");


        Console.WriteLine("Copy Employee");
        Console.WriteLine("");

        Console.WriteLine(copy_employee.get_name());
        Console.WriteLine(copy_employee.get_age());


    }
}
