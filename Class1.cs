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
        private const double MaxVízNyomas = 7.5; 
        private const double MaxHomerseklet = 700.0;
        //Konstruktor
        public Reaktor(double VizNyomas, double MegtermeltEnergia, double Homerseklet) {
            this.VizNyomas = VizNyomas;
            this.MegtermeltEnergia = MegtermeltEnergia;
            this.Homerseklet = Homerseklet;
        }
        public void NyomasAllitas(double nyomas) {
            if (nyomas < 0 || nyomas > MaxVízNyomas)
                throw new ArgumentOutOfRangeException(nameof(nyomas), "A víznyomásnak 0 és 7.5 MPa között kell lennie.");
            VizNyomas = nyomas;
        }
        public void Energia(double UzemanyagRudDB, double ReaktorHatasfok) {
            if (UzemanyagRudDB <= 0)
                throw new ArgumentOutOfRangeException(nameof(UzemanyagRudDB), "A fűtőelemek száma nem lehet nulla vagy negatív.");
            if (ReaktorHatasfok < 0 || ReaktorHatasfok > 1)
                throw new ArgumentOutOfRangeException(nameof(ReaktorHatasfok), "A hatékonyságnak 0 és 1 között kell lennie.");
            MegtermeltEnergia = UzemanyagRudDB * ReaktorHatasfok * 2.5;
        }
        public void Homersekletallitas(double HoValtozas) {
            Homerseklet += HoValtozas;
            if (Homerseklet > MaxHomerseklet) throw new InvalidOperationException("A reaktor hőmérséklete meghaladta a kritikus szintet!");
        }
        public string Kiiras() {
            return $"Víznyomás: {VizNyomas} MPa, Kimeneti energia: {MegtermeltEnergia} MW, Maghőmérséklet: {Homerseklet} °C";
        }
    }
}
