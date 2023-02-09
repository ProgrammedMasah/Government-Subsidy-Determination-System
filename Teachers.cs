namespace H.W.Part_1__F21
{
    class Teachers: Person
    {
        public Teachers (int id, string ferstName, string lastName, int experience, string idCars, string idHouses) 
                         :base(id, ferstName, lastName, idCars, idHouses)
        {
            Experience = experience;
        }
        public Teachers(int id, string firstName, string lastName, int experience, string idCars)
                        : base(id, firstName, lastName, idCars)
        {
            Experience = experience;
        }
        public Teachers(int id, string ferstName, string lastName, int experience)
                        : base(id, ferstName, lastName)
        {
            Experience = experience;
        }
        public int Experience { get; set; }
        public override string ToString()
        {
            return base.ToString() + "    Type: Teacher" + "    Experience: " + Experience;
        }
    }
}
