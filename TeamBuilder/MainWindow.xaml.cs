using System.Windows;
using System.Collections;
using System;
using System.IO;

namespace TeamBuilder
{

	public partial class MainWindow : Window
	{

		private Window other;
		private ArrayList teams;

		public MainWindow()
		{
			InitializeComponent();

			other = new DisplayTeams(this);
			teams = new ArrayList();
		}

		private void DisplayTeamsButton(object sender, RoutedEventArgs e)
		{
			SwitchWindows();
		}

		private void SwitchWindows()
		{
			this.Close();
			other.Show();
		}

		private void AddStudent(object sender, RoutedEventArgs e)
		{
			if (tbNewStudent.Text != "" && !cbStudents.Items.Contains(tbNewStudent.Text))
			{
				cbStudents.Items.Add(tbNewStudent.Text);
			}
		}

		private void RemoveStudent(object sender, RoutedEventArgs e)
		{
			cbStudents.Items.Remove(cbStudents.Text);
		}

		private void LoadNames(object sender, RoutedEventArgs e)
		{
			if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + tbFileName.Text + ".dat"))
			{
				BinaryReader br = new BinaryReader(new FileStream(AppDomain.CurrentDomain.BaseDirectory + tbFileName.Text + ".dat", FileMode.Open));
				cbStudents.Items.Clear();

				try
				{
					string val = br.ReadString();
					while(val != null)
					{
						cbStudents.Items.Add(val);
						val = br.ReadString();
					}
				}
				catch(Exception) {}
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

			foreach (string h in cbStudents.Items)
			{
				bw.Write(h);
			}

			bw.Close();
		}

		private void CreateTeams(object sender, RoutedEventArgs e)
		{

		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			Application.Current.Shutdown();
		}

	}
}