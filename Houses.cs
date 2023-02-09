namespace H.W.Part_1__F21
{
    class Houses
    {
        public Houses(int id, int size, string adresse)
        {
            Id = id;
            Size = size;
            Adresse = adresse;
        }
        public int Id { get; set; }
        public int Size { get; set; }
        public string Adresse { get; set; }
        public override string ToString()
        {
            return "Houses ID: " + Id + "    Size: " + Size + "    Adresse:" + Adresse;
        }
    }
}
