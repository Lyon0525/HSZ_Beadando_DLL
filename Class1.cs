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
        private const double Fajho = 4186;
        //Konstruktor
        public Reaktor(double VizNyomas, double MegtermeltEnergia, double Homerseklet) {
            this.VizNyomas = VizNyomas;
            this.MegtermeltEnergia = MegtermeltEnergia;
            this.Homerseklet = Homerseklet;
            this.VizNyomasLog.Add(VizNyomas);
            this.MegtermeltEnergiaLog.Add(MegtermeltEnergia);
            this.HomersekletLog.Add(Homerseklet);
        }
        public void NyomasAllitas(double nyomas) {
            VizNyomas += nyomas;
            VizNyomasLog.Add(nyomas);
        }
        public void EnergiaValtozas(double homersekletvaltozas) {
            MegtermeltEnergia += homersekletvaltozas;
            MegtermeltEnergiaLog.Add(homersekletvaltozas);
        }
        public void Homersekletallitas(double HoValtozas) {
            Homerseklet += HoValtozas;
            HomersekletLog.Add(HoValtozas);
        }
        public void Kiiras() {
            Console.WriteLine($"Kezdeti víznyomás: {VizNyomas} MPa, kimeneti energia: {MegtermeltEnergia} MW, hőmérséklet: {Homerseklet} °C");
        }
    }
}
