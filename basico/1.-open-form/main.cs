using System;
using System.Windows.Forms;

public class Ventana : Form
{
    static public void Main()
    {
        Application.Run(new Ventana());
    }

    public Ventana()
    {
        Button b = new Button() { Text = "Click aquí!" };
        b.Click += new EventHandler(Button_Click);
        Controls.Add(b);
    }

    private void Button_Click(object sender, EventArgs e)
    {
        var f = new Form();
        f.Controls.Add(new Label() { Text = "open form" });
        f.ShowDialog();
    }
}