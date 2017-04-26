using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace TeamBuilder
{

	public partial class MainWindow : Window
	{

		private Window other;
		private List<string> teams;

		public MainWindow()
		{
			InitializeComponent();

			teams = new List<string>();
			other = new DisplayTeams(this, teams);
		}

		private void DisplayTeamsButton(object sender, RoutedEventArgs e)
		{
			SwitchWindows();
		}

		private void SwitchWindows()
		{
			this.Hide();
			other.Show();
		}

		private void AddName(object sender, RoutedEventArgs e)
		{
			if (tbNewName.Text != "" && !cbNames.Items.Contains(tbNewName.Text))
			{
				cbNames.Items.Add(tbNewName.Text);
				tbNewName.Text = "";
			}
		}

		private void RemoveName(object sender, RoutedEventArgs e)
		{
			cbNames.Items.Remove(cbNames.Text);
		}

		private void LoadNames(object sender, RoutedEventArgs e)
		{
			if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + tbFileName.Text + ".dat"))
			{
				BinaryReader br = new BinaryReader(new FileStream(AppDomain.CurrentDomain.BaseDirectory + tbFileName.Text + ".dat", FileMode.Open));
				cbNames.Items.Clear();

				try
				{
					string val = br.ReadString();
					while (val != null)
					{
						cbNames.Items.Add(val);
						val = br.ReadString();
					}
				}
				catch (Exception) { }
				br.Close();
			}
			else
			{
				tbFileName.Text = "FileNotFound";
			}
		}

		private void SaveNames(object sender, RoutedEventArgs e)
		{
			BinaryWriter bw = new BinaryWriter(new FileStream(AppDomain.CurrentDomain.BaseDirectory + tbFileName.Text + ".dat", FileMode.Create));

			foreach (string h in cbNames.Items)
			{
				bw.Write(h);
			}

			bw.Close();
		}

		//TODO
		private void CreateTeams(object sender, RoutedEventArgs e)
		{
			teams.Clear();
			Random r = new Random();
			List<string> names = new List<string>();
			foreach (string h in cbNames.Items)
			{
				names.Add(h);
			}
			while(names.Count >= 3)
			{
				int i = r.Next(names.Count);
				string f = names[i];
				names.RemoveAt(i);

				i = r.Next(names.Count);
				f += "," + names[i];
				names.RemoveAt(i);

				i = r.Next(names.Count);
				f += "," + names[i];
				names.RemoveAt(i);

				teams.Add(f);
			}
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			Application.Current.Shutdown();
		}

	}
}