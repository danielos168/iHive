using System;
namespace iHive
{
	public class Ul
	{
		string Nazwa;
		int Id;
		int Ilosc_ramek { get; set; }
		string Rasa_pszczol { get; set; }
		string Kolor_ula { get; set; }
		DateTime Data_zalozenia { get; set; }
		DateTime Ostatni_przeglad { get; }
		DateTime Ostatnia_wymiana_matki { get; set; }
		string Kolor_matki { get; set; }
		string Opis { get; set; }

		public Ul(string Nazwa, int Id, string Kolor_ula)
		{
			this.Nazwa = Nazwa;
			this.Id = Id;
			this.Kolor_ula = Kolor_ula;
		}
        public Ul(string Nazwa, int Id, string Kolor_ula, int Ilosc_ramek, string Rasa_pszczol, DateTime Data_zalozenia, DateTime Ostatni_przeglad, DateTime Ostatnia_wymiana_matki, string Kolor_matki, string Opis)
        {
			this.Nazwa = Nazwa;
			this.Id = Id;
			this.Kolor_ula = Kolor_ula;
			this.Ilosc_ramek = Ilosc_ramek;
			this.Rasa_pszczol = Rasa_pszczol;
			this.Data_zalozenia = Data_zalozenia;
			this.Ostatni_przeglad = Ostatni_przeglad;
			this.Ostatnia_wymiana_matki = Ostatnia_wymiana_matki;
			this.Kolor_matki = Kolor_matki;
			this.Opis = Opis;
		}
	}
}

