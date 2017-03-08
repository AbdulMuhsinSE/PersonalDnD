using System;
using Gtk;

namespace ThreeDs
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
            Console.WriteLine("Here");
			MainWindow win = new MainWindow();
            win.Resize(720, 480);

            Label myLabel = new Label();
            myLabel.Text = "Hello World!!";

           // win.Add(myLabel);
            win.ShowAll();

			win.Show();
			Application.Run();
		}
	}
}
