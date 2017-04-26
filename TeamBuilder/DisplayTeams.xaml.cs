using System;
using System.Collections.Generic;
using System.Media;
using System.Windows;

namespace TeamBuilder
{

	public partial class DisplayTeams : Window
	{

		private SoundPlayer spGood, spNormal, spBad;
		private Window other;
		private List<string> teams;
		private int count = 0;

		public DisplayTeams(Window from, List<string> t)
		{
			InitializeComponent();
			other = from;
			teams = t;

			spGood = new SoundPlayer(Properties.Resources.bridge);
			spNormal = new SoundPlayer(Properties.Resources.normal);
			spBad = new SoundPlayer(Properties.Resources.sad);
		}

		private void NextTeam(object sender, RoutedEventArgs e)
		{
			if (teams.Count > count)
			{
				PlaySound();
				string[] team = teams[count++].Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				lFirst.Content = team[0];
				lSecond.Content = team[1];
				lThird.Content = team[2];
			}
			else
			{
				lFirst.Content = "No more teams";
				lSecond.Content = "No more teams";
				lThird.Content = "No more teams";
				count = 0;
			}
		}

		private void Back(object sender, RoutedEventArgs e)
		{
			SwitchWindows();
		}

		private void SwitchWindows()
		{
			count = 0;
			lFirst.Content = "";
			lSecond.Content = "";
			lThird.Content = "";
			this.Hide();
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
				case 5:
				case 6:
				case 7:
					spNormal.Play();
					break;

				case 8:
				case 9:
					spBad.Play();
					break;
			}
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			Application.Current.Shutdown();
		}

	}

}