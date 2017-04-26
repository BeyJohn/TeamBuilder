using System.Media;
using System.Windows;
using System;

namespace TeamBuilder
{

	public partial class DisplayTeams : Window
	{

		private SoundPlayer spGood, spNormal, spBad;
		private Window other;

		public DisplayTeams(Window from)
		{
			InitializeComponent();
			other = from;

			spGood = new SoundPlayer(Properties.Resources.bridge);
			spNormal = new SoundPlayer(Properties.Resources.normal);
			spBad = new SoundPlayer(Properties.Resources.sad);
		}

		private void SwitchWindows()
		{
			this.Close();
			other.Show();
		}

		private void PlaySound()
		{
			switch (new Random().Next(10))
			{
				case 0:
					spGood.Play();
					break;

				case 1:
				case 2:
				case 3:
				case 4:
					spNormal.Play();
					break;

				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
					spBad.Play();
					break;
			}
		}

	}

}