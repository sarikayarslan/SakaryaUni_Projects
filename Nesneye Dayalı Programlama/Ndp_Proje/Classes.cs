using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Odev
{//Atık sınıfı
	public class Atik : IAtik
	{
		public Atik(int hacim, Image image)
		{
			this.Hacim = hacim;
			this.Image = image;
		}
		public int Hacim { get; }
		public Image Image { get; }
	}
	//Cam Kutusu Sınıfı 
	class CamKutusu : IAtikKutusu
	{
		
		public int Kapasite { get { return 2200; } }

		public int DoluHacim { get; set; }

		public int DolulukOrani { get { return (DoluHacim*100 / Kapasite); } }
		public int BosaltmaPuani { get {return 600;}}
		//Ekle Fonksiyonu eğer kutuda yer varsa kutuya atık ekler.
		public bool Ekle(Atik atik)
		{
			if (atik.Hacim < Kapasite - DoluHacim) {
				DoluHacim += atik.Hacim;
				
				return true;
			}
			else
			{
				return false;
			}
		}
		//Eğer dolululuk oranı %75 ve üzeriyse dolu hacimi boşaltır. 
		public bool Bosalt()
		{
			if (DolulukOrani>=75)
			{
				DoluHacim = 0;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	//Organik Kutusu Sınıfı 

	class OrganikKutusu : IAtikKutusu
	{
		public int Kapasite { get { return 700; } }

		public int DoluHacim { get; set; }

		public int DolulukOrani { get { return (DoluHacim*100 / Kapasite); } }
		public int BosaltmaPuani { get { return 0; } }
		//Ekle Fonksiyonu eğer kutuda yer varsa kutuya atık ekler.

		public bool Ekle(Atik atik)
		{
			if (atik.Hacim < Kapasite - DoluHacim)
			{
				DoluHacim += atik.Hacim;
				return true;
			}
			else
			{
				return false;
			}
		}
		//Eğer dolululuk oranı %75 ve üzeriyse dolu hacimi boşaltır. 

		public bool Bosalt()
		{
			if (DolulukOrani >= 75)
			{
				DoluHacim = 0;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	//Metal Kutusu Sınıfı 
	class MetalKutusu : IAtikKutusu
	{
		public int Kapasite { get { return 2300; } }

		public int DoluHacim { get; set; }

		public int DolulukOrani { get { return (DoluHacim * 100 / Kapasite); } }

		public int BosaltmaPuani { get { return 800; } }
		//Ekle Fonksiyonu eğer kutuda yer varsa kutuya atık ekler.

		public bool Ekle(Atik atik)
		{
			if (atik.Hacim < Kapasite - DoluHacim)
			{
				DoluHacim+= atik.Hacim;
				return true;
			}
			else
			{
				return false;
			}
		}
		//Eğer dolululuk oranı %75 ve üzeriyse dolu hacimi boşaltır. 

		public bool Bosalt()
		{
			if (DolulukOrani >= 75)
			{
				DoluHacim = 0;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	//Kağıt Kutusu Sınıfı 
	class KagitKutusu : IAtikKutusu
	{
		public int Kapasite { get { return 1200; } }

		public int DoluHacim { get; set; }

		public int DolulukOrani { get { return (DoluHacim * 100 / Kapasite); } }

		public int BosaltmaPuani { get { return 1000; } }

		//Ekle Fonksiyonu eğer kutuda yer varsa kutuya atık ekler.

		public bool Ekle(Atik atik)
		{
			if (atik.Hacim < Kapasite - DoluHacim)
			{
				DoluHacim += atik.Hacim;
				return true;
			}
			else
			{
				return false;
			}
		}
		//Eğer dolululuk oranı %75 ve üzeriyse dolu hacimi boşaltır. 

		public bool Bosalt()
		{
			if (DolulukOrani >= 75)
			{
				DoluHacim = 0;
				return true;
			}
			else
			{
				return false;
			}
		}
	}

}
