namespace H.W.Part_1__F21
{
    class Merchants: Person
    {
        public Merchants(int id, string firstName, string lastName, int income, string idCars, string idHouses) 
                         :base(id, firstName, lastName, idCars, idHouses)
        {
            Income = income;
        }
        public Merchants(int id, string firstName, string lastName, int income, string idCars)
                        : base(id, firstName, lastName, idCars)
        {
            Income = income;
        }
        public Merchants(int id, string firstName, string lastName, int income)
                        : base(id, firstName, lastName)
        {
            Income = income;
        }
        public int Income { get; set; }
        public override string ToString()
        {
            return base.ToString() + "    Type: Merchant" + "    Income: " + Income;
        }
    }
}
