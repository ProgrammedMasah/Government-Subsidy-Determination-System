namespace H.W.Part_1__F21
{
    class Cars
    {
        public Cars(int id,  string carModel, int productionYear, int capacity)
        {
            Id = id;
            CarModel = carModel;
            ProductionYear = productionYear;
            Capacity = capacity;
        }
        public int Id { get; set; }
        public int ProductionYear { get; set; }
        public string CarModel { get; set; }
        public int Capacity { get; set; }
        public override string ToString()
        {
            return "Car ID: " + Id + "    Car Model:" + CarModel +
                   "    Production Year:" + ProductionYear + "    Capacity:" + Capacity;
        }
    }
}
