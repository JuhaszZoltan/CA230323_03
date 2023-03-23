namespace CA230323_03
{
    class Program
    {
        static void Main()
        {
            //Console.Write("írj be egy számot: ");
            //int egyikSzam = int.Parse(Console.ReadLine()!);
            //Console.Write("írj be egy másik számot: ");
            //int masikSzam = int.Parse(Console.ReadLine()!);
            //int osszeg = CA230323_03.Program.Osszead(egyikSzam, masikSzam);
            //Console.WriteLine($"{egyikSzam} + {masikSzam} = {osszeg}");

            Ember e = new();
            e.Nev = "Áron";
            e.SetKor(52);

            Console.WriteLine($"{e.Nev} {e.GetKor()} éves");
        }

        static int Osszead(int x, int y)
        {
            return x + y;
        }
    }

    public class Ember
    {
        private string _nev;
        private int _kor;
        private string kedvencEtel;

        public string KedvencEtel { get => kedvencEtel; set => kedvencEtel = value; }

        public string Nev
        {
            set
            {
                if (value == string.Empty)
                    throw new Exception("mindképp nevet kell adni az ambernek");
                if (value.Length > 30)
                    throw new Exception("ez túl hosszú névnek");
                if (value == "Bodri")
                    throw new Exception("ilyen néven nem lehet embert anyakönyvezni");
                if (value[0] < 65 || value[0] > 90)
                    throw new Exception("egy névnek nagy kezdőbetűvel kell kezdődnie");
                _nev = value;
            }
            get
            {
                return _nev;
            }
        }

        public void SetKor(int kor)
        {
            if (kor < 0)
                throw new Exception("egy ember életkora nem lehet negatív");
            if (kor > 120)
                throw new Exception("ennyi ideig nem szokott élni egy ember");
            _kor = kor;
        }

        public int GetKor()
        {
            return _kor;
        }

    }
}