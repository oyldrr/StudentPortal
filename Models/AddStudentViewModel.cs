namespace StudentPortal.Models
{
    public class AddStudentViewModel
    {
		public string AdSoyad { get; set; }
		public string Email { get; set; }
		public string Telefon { get; set; }
		public DateOnly DogumTarihi { get; set; }
		public string DogumYeri { get; set; }
		public string Cinsiyet { get; set; }

		public string OkulAdi { get; set; }
		public DateOnly OkulBaslangic { get; set; }
		public DateOnly OkulBitis { get; set; }
		public string OkulOrt { get; set; }
	}
}
