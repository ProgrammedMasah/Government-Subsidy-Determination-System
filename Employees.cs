namespace H.W.Part_1__F21
{
    class Employees:Person
    {
        public Employees(int id, string ferstName, string lastName, int salary, string idCars, string idHouses)
                        :base(id, ferstName, lastName, idCars, idHouses)
        {
            Salary = salary;
        }
        public Employees(int id, string firstName, string lastName, int salary, string idCars)
                       : base(id, firstName, lastName, idCars)
        {
            Salary = salary;
        }
        public Employees(int id, string ferstName, string lastName, int salary)
                       : base(id, ferstName, lastName)
        {
            Salary = salary;
        }
        int Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + "    Type: Employee" + "    Salary: " + Salary;
        }
    }
}
