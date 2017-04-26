using System.Windows;
using System.Collections;

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
			if(tbNewStudent.Text != "" && !cbStudents.Items.Contains(tbNewStudent.Text))
			{
				cbStudents.Items.Add(tbNewStudent.Text);
			}
		}

		private void RemoveStudent(object sender, RoutedEventArgs e)
		{
			cbStudents.Items.Remove(cbStudents.Text);
		}

	}
}