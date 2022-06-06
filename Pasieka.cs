using System;
namespace iHive
{
	public class Pasieka
	{
		string nazwa;
		int id;
		double lokalizacjaX { get; set; }
		double lokalizacjaY {get; set;}
		List<Ul> lista_uli { get; set; }
		DateTime data_zalozenia { get; }
		public Pasieka(string nazwa, int id)
		{
			this.nazwa = nazwa;
			this.id = id;
		}
        public Pasieka(string nazwa, int id, double lokalizacjaX, double lokalizacjaY, List<Ul> lista_uli, DateTime data_zalozenia)
        {
			this.nazwa = nazwa;
			this.id = id;
			this.lokalizacjaX = lokalizacjaX;
			this.lokalizacjaY = lokalizacjaY;
			this.lista_uli = lista_uli;
			this.data_zalozenia = data_zalozenia;
        }
	}
}

