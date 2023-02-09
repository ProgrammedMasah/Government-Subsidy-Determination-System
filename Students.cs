namespace H.W.Part_1__F21
{
    class Students: Person
    {
        public Students(int id, string ferstName, string lastName, int year, string idCars, string idHouses)
                       :base(id, ferstName, lastName, idCars, idHouses)
        {
            Year = year;
        }
        public Students(int id, string firstName, string lastName, int year, string idCars)
                        : base(id, firstName, lastName, idCars)
        {
            Year = year;
        }
        public Students(int id, string ferstName, string lastName, int year)
                       : base(id, ferstName, lastName)
        {
            Year = year;
        }
        public int Year { get; set; }
        public override string ToString()
        {
            return base.ToString() + "    Type: Student" + "    Year: " + Year;
        }
    }
}
