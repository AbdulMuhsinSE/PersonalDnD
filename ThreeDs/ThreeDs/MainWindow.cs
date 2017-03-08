using System;
using Gtk;
using ThreeDs.Utils;

public partial class MainWindow : Gtk.Window
{
    public static Table MainTable
    {
        get;set;
    }

    private static  Notebook MainNotebook
    {
        get;set;
    }

    private static ComboBox dieTypeComboBox
    {
        get;set;
    }

    private static Entry numberofdieTextBox
    {
        get;set;
    }

    private static TextView dieRollTextBox
    {
        get;set;
    }

    private static DieGenerator dg
    {
        get;set;
    }


    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();


        MainNotebook = new Notebook();
        dg = DieGenerator.getDieGenerator();
        //MainNotebook.AppendPage(new Button("Meowth"), new Label("Meowth"));
        MainNotebook.AppendPage(new Table(3, 3, false), new Label("Character Table"));
        MainNotebook.ShowAll();


        dieTypeComboBox = new ComboBox(new string[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20",
            "d100"
        });
        numberofdieTextBox = new Entry();


        VBox vertDieFormula = new VBox(false, 2);
        vertDieFormula.PackStart(new Label("Number of Die"), false, false, 3);
        vertDieFormula.PackStart(numberofdieTextBox, false, false, 1);
        vertDieFormula.PackStart(new Label("Die Type"), false, false, 3);
        vertDieFormula.PackStart(dieTypeComboBox, false, false, 1);
        //vertDieFormula.PackStart(new Entry(), false, false, 1);

        Button rolldieButton = new Button("Roll");
        rolldieButton.Clicked += callback;

        ScrolledWindow sw = new ScrolledWindow();
        dieRollTextBox = new Gtk.TextView();
        dieRollTextBox.Editable = false;
        dieRollTextBox.BorderWidth = 3;
        dieRollTextBox.WrapMode = WrapMode.Word;
        sw.Add(dieRollTextBox);

        MainTable = new Table(5, 3, true);
        MainTable.ColumnSpacing = 20;
        MainTable.RowSpacing = 10;
        MainTable.BorderWidth = 10;
        MainTable.Attach(MainNotebook, 0, 3, 0, 4);
        MainTable.Attach(vertDieFormula, 0, 1, 4, 5);
        MainTable.Attach(rolldieButton, 1, 2, 4, 5);
        MainTable.Attach(sw, 2, 3, 4, 5);

        MainTable.ShowAll();
        this.Add(MainTable);

        this.DeleteEvent += delegate (object o, DeleteEventArgs args)
        {
            MessageDialog md = new MessageDialog(this, DialogFlags.Modal,
                MessageType.Question, ButtonsType.YesNo,
                "Are you sure you would like to exit?");
            int toDestroy = md.Run();

            if (toDestroy == (int)ResponseType.Yes)
            {
                Console.WriteLine("THIS SHOULD RUN");
                Application.Quit();
            }
            else
            {
                args.RetVal = true;
                md.Destroy();
            }
        };
    }

    static void callback(object obj, EventArgs args)
    {
        Dice die;
        Console.WriteLine(dieTypeComboBox.ActiveText);
        Console.WriteLine(numberofdieTextBox.Text);
        int num = 0;
        bool isNumeric = int.TryParse(numberofdieTextBox.Text, out num);

        if (isNumeric == false)
        {
            numberofdieTextBox.Text = "1";
        }

        switch (dieTypeComboBox.ActiveText)
        {
            case "d4":
                {
                    die = Dice.d4;
                    break;
                }
            case "d6":
                {
                    die = Dice.d6;
                    break;
                }
            case "d8":
                {
                    die = Dice.d8;
                    break;
                }
            case "d10":
                {
                    die = Dice.d10;
                    break;
                }
            case "d12":
                {
                    die = Dice.d12;
                    break;
                }
            case "d20":
                {
                    die = Dice.d20;
                    break;
                }
            case "d100":
                {
                    die = Dice.d100;
                    break;
                }
            default:
                {
                    die = Dice.d20;
                    break;
                }

        }
        dieRollTextBox.Buffer.Text = dg.rollDie(Int32.Parse(numberofdieTextBox.Text), die);
    }

}
