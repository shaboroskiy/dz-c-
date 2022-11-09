using System.Diagnostics.Metrics;

namespace _09._11
{
    public class MusicalInstrument
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public double Weight { get; set; }

        public string CountryInventor { get; set; }
        public MusicalInstrument() { }

        public MusicalInstrument(string name,string countryinventor,int size=0,int weignt =0)
        {
            this.Name = name;
            this.Weight = weignt;
            this.Size= size;
            this.CountryInventor = countryinventor;
        }
        public virtual void ShowTypeName()
        {
            Console.WriteLine("My type is class Instrument!");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Size: " + Size+ "cm");
            Console.WriteLine("Weight: " + Weight + "kg");
            Console.WriteLine("Country: " + CountryInventor);

        }

    }
    public class Chordophone : MusicalInstrument
    { 
    public float NumberOfString { get; set; }
        public string Specialisation { get; set; }

        public Chordophone(string name , float s=0)
        {
            this.NumberOfString = s;
        }

        public Chordophone()
        {
        }

        
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Number of string: " + NumberOfString);
            
        }
        public void Chord()
        {
            if (NumberOfString <= 12)
            {
                Console.WriteLine("Type: standart");
            }
            else
            {
                Console.WriteLine("Type:non-standard");
            }
        }
        public override void ShowTypeName()
        {
            Console.WriteLine("My type is class Chordophone ");
        }
    }
    public class Aerophones : MusicalInstrument
    { 
    public float AirVolume { get; set; }

        public Aerophones() { }
        public Aerophones(float airVolume=0) 
        {
        this.AirVolume=airVolume;
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Air volume:"+ AirVolume+"ml");
            
        }
        public override void ShowTypeName()
        {
            Console.WriteLine("My type is class Aerophones");
        }
    }
    public class Idiophones : MusicalInstrument
    { 
    public int diapason { get; set; }

        public Idiophones() { }

        public Idiophones(int diapason)
        {
            this.diapason = diapason;
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Diapason:" + diapason + "Hz");

        }
        public override void ShowTypeName()
        {
            Console.WriteLine("My type is class Idiophones");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            MusicalInstrument m = new MusicalInstrument()
            {
                 
            Name = "Drum",
                CountryInventor = "Sumerians",
                Size = 200,
                Weight= 0.5
            };
            Console.WriteLine(m);
            m.ShowInfo();
            Console.WriteLine("---------------------------");
            Chordophone c = new Chordophone()
            {
                Name="Guitar",
                CountryInventor = "Ispania",
                Weight=1.3,
                Size=300,
                NumberOfString=8
                
                
                
            };
            c.Chord();
            c.ShowInfo();
            c.ShowTypeName();

            Console.WriteLine("---------------------------");
            Idiophones i = new Idiophones()
            { 
            Name="triangle",
            CountryInventor="France",
            Weight=150,
            Size=115,
            diapason=9800
            };
        }
    }
}