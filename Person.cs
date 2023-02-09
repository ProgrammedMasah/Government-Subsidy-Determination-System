namespace H.W.Part_1__F21
{
    class Person
    {
        public Person(int id, string ferstName, string lastName, string idCars, string idHouses)
        {
            Id = id;
            FerstName = ferstName;
            LastName = lastName;
            IdCars = idCars;
            IdHouses = idHouses;
        }
        public Person(int id, string ferstName, string lastName, string idCars)
        {
            Id = id;
            FerstName = ferstName;
            LastName = lastName;
            IdCars = idCars;
            IdHouses = "-1";
        }
        public Person(int id, string ferstName, string lastName)
        {
            Id = id;
            FerstName = ferstName;
            LastName = lastName;
            IdCars = "-1";
            IdHouses = "-1";
        }
        public int Id { get; set; }
        public string FerstName { get; set; }
        public string LastName { get; set; }
        public string IdCars { get; set; }
        public string IdHouses { get; set; }
        public override string ToString()
        {
            return "ID: " + Id + "    First Name: " + FerstName + "    Last Name: " + LastName +
                   "    Cars: " + IdCars + "    Houses: " + IdHouses;
        }

    }
}
