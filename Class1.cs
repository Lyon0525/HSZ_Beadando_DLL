using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DLL fájlt írta: Kristóf
namespace HSZ_Beadando_DLL {
    public class Reaktor {
        

        //Változók
        public double VizNyomas { get; set; } //MPa
        public double MegtermeltEnergia { get; set; } //MW
        public double Homerseklet { get; set; } //Celsius
        public List<double> VizNyomasLog = new List<double>();
        public List<double> MegtermeltEnergiaLog = new List<double>();
        public List<double> HomersekletLog = new List<double>();
        private const double MaxVízNyomas = 11; 
        private const double MaxHomerseklet = 700.0;
        private Random r = new Random();
        //Konstruktor
        public Reaktor(double VizNyomas, double MegtermeltEnergia, double Homerseklet) {
            this.VizNyomas = VizNyomas;
            this.MegtermeltEnergia = MegtermeltEnergia;
            this.Homerseklet = Homerseklet;
            this.VizNyomasLog.Add(VizNyomas);
            this.MegtermeltEnergiaLog.Add(MegtermeltEnergia);
            this.HomersekletLog.Add(Homerseklet);
        }
        //Delegált: Zoli
        public delegate void Valtozas(bool seged);
        public void Delegalt(bool seged) {
            Valtozas del = new Valtozas(NyomasAllitas);
            del += EnergiaValtozas;
            del += Homersekletallitas;
        }
        public void NyomasAllitas(bool seged) {
            double random = r.NextDouble();
            VizNyomas += random;
            VizNyomasLog.Add(random);
        }
        public void EnergiaValtozas(bool seged) {
            double random = r.NextDouble();
            MegtermeltEnergia += random;
            MegtermeltEnergiaLog.Add(random);
        }
        public void Homersekletallitas(bool seged) {
            double random = r.NextDouble();
            Homerseklet += random;
            HomersekletLog.Add(random);
        }
        public void Kiiras() {
            Console.WriteLine($"Kezdeti víznyomás: {VizNyomas} MPa, kimeneti energia: {MegtermeltEnergia} MW, hőmérséklet: {Homerseklet} °C");
        }
        //Eseménykezelés: Zoli
    }
}
