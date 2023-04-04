namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Foto { get; set; }
        public double Prezzo { get; set; }

        public Pizza() { }

        public Pizza(string name, string description, string foto, double prezzo)
        {
            this.Name = name;
            this.Description = description;
            this.Foto = foto;
            this.Prezzo = prezzo;
        }
    }
}
