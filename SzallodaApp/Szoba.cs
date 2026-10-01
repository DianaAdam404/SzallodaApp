namespace SzallodaApp
{
    public class Szoba
    {
       
        public int Szobaszam { get; set; }
        protected int alapar { get; set; }
        public int Alapar
        {
            get =>alapar;
            set
            {
               
                if (value > 0)
                {
                    alapar = value;
                }
            }
        }

        public Szoba(int szobaszam, int alapAr)
        {
            Szobaszam = szobaszam;
            Alapar = alapAr; 
        }

        public virtual int ArKiszamitas(int ejszakakSzama)
        {
            return ejszakakSzama * Alapar;
        }

        public override string ToString()
        {
            return $"Szoba [{Szobaszam}] | Alapár: [{Alapar}] Ft/éj";
        }
    }
}

