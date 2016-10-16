namespace _12_Employee
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }

        public Employee()
        { }
        public Employee(string name,string type)
        {
            Name = name;
            Type = type;
        }
    }
}