namespace SayisalLotoWinForm;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>

    TextBox txtSayi1 = new TextBox();
    Label lblSayi1 = new Label();
    TextBox txtSayi2 = new TextBox();
    Label lblSayi2 = new Label();
    TextBox txtSayi3 = new TextBox();
    Label lblSayi3 = new Label();
    TextBox txtSayi4 = new TextBox();
    Label lblSayi4 = new Label();
    TextBox txtSayi5 = new TextBox();
    Label lblSayi5 = new Label();
    TextBox txtSayi6 = new TextBox();
    TextBox txtsonuc = new TextBox();
    TextBox txttahmin = new TextBox();
    TextBox txtpuan = new TextBox();
    Label lblSayi6 = new Label();
    TextBox txtKredi = new TextBox();
    Button btnMakinaniOynat = new Button();
    Button btnBaslat = new Button();
    Button btnBitir = new Button();
    Label lblSonuc = new Label();
    Panel panelLeft = new Panel();
    Panel panelRight = new Panel();
    
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 800);
        this.Text = "SayisalLoto";
        this.Controls.Add(panelLeft);
        this.Controls.Add(panelRight);

        //panelRight
        panelLeft.Size = new Size(450, 350);
        panelLeft.Location = new Point(10, 10);
        panelLeft.Padding = new Padding(20);
        panelLeft.Font = new Font("Arial", 12, FontStyle.Bold);
        panelLeft.AutoSize = false;
        panelLeft.Controls.Add(txtSayi1);
        panelLeft.Controls.Add(lblSayi1);
        panelLeft.Controls.Add(txtSayi2);
        panelLeft.Controls.Add(lblSayi2);
        panelLeft.Controls.Add(txtSayi3);
        panelLeft.Controls.Add(lblSayi3);
        panelLeft.Controls.Add(txtSayi4);
        panelLeft.Controls.Add(lblSayi4);
        panelLeft.Controls.Add(txtSayi5);
        panelLeft.Controls.Add(lblSayi5);
        panelLeft.Controls.Add(txtSayi6);
        panelLeft.Controls.Add(lblSayi6);

        //panelRight
        panelRight.Size = new Size(450, 350);
        panelRight.Location = new Point(460, 10);
        panelRight.Padding = new Padding(20);
        panelRight.Font = new Font("Arial", 12, FontStyle.Bold);
        panelRight.AutoSize = false;
        panelRight.Controls.Add(btnMakinaniOynat);
        panelRight.Controls.Add(btnBaslat);
        panelRight.Controls.Add(btnBitir);
        panelRight.Controls.Add(lblSonuc);
        panelRight.Controls.Add(txtKredi);
        panelRight.Controls.Add(txtsonuc);
        panelRight.Controls.Add(txttahmin);
        panelRight.Controls.Add(txtpuan);

        //txtSayi1
        txtSayi1.AutoSize = false;
        txtSayi1.Size = new Size(100, 30);
        txtSayi1.Location = new Point(0, 20);
        txtSayi1.Font = new Font("Arial", 16, FontStyle.Bold);
        txtSayi1.Text = " ";
        lblSayi1.Location = new Point(0, 0);
        lblSayi1.Font = new Font("Arial", 12, FontStyle.Bold);
        lblSayi1.Text = "Sayı 1";

        //txtSayi2
        txtSayi2.AutoSize = false;
        txtSayi2.Size = new Size(100, 30);
        txtSayi2.Location = new Point(0, 80);
        txtSayi2.Font = new Font("Arial", 16, FontStyle.Bold);
        txtSayi2.Text = " ";
        lblSayi2.Location = new Point(0, 50);
        lblSayi2.Font = new Font("Arial", 12, FontStyle.Bold);
        lblSayi2.Text = "Sayı 2";

        //txtSayi3
        txtSayi3.AutoSize = false;
        txtSayi3.Size = new Size(100, 30);
        txtSayi3.Location = new Point(0, 140);
        txtSayi3.Font = new Font("Arial", 16, FontStyle.Bold);
        txtSayi3.Text = " ";
        lblSayi3.Location = new Point(0, 115);
        lblSayi3.Font = new Font("Arial", 12, FontStyle.Bold);
        lblSayi3.Text = "Sayı 3";

        //txtSayi4
        txtSayi4.AutoSize = false;
        txtSayi4.Size = new Size(100, 30);
        txtSayi4.Location = new Point(0, 200);
        txtSayi4.Font = new Font("Arial", 16, FontStyle.Bold);
        txtSayi4.Text = " ";
        lblSayi4.Location = new Point(0, 175);
        lblSayi4.Font = new Font("Arial", 12, FontStyle.Bold);
        lblSayi4.Text = "Sayı 4";

        //txtSayi5
        txtSayi5.AutoSize = false;
        txtSayi5.Size = new Size(100, 30);
        txtSayi5.Location = new Point(0, 260);
        txtSayi5.Font = new Font("Arial", 16, FontStyle.Bold);
        txtSayi5.Text = " ";
        lblSayi5.Location = new Point(0, 230);
        lblSayi5.Font = new Font("Arial", 12, FontStyle.Bold);
        lblSayi5.Text = "Sayı 5";

        //txtSayi6
        txtSayi6.AutoSize = false;
        txtSayi6.Size = new Size(100, 30);
        txtSayi6.Location = new Point(0, 320);
        txtSayi6.Font = new Font("Arial", 16, FontStyle.Bold);
        txtSayi6.Text = " ";
        lblSayi6.Location = new Point(0, 295);
        lblSayi6.Font = new Font("Arial", 12, FontStyle.Bold);
        lblSayi6.Text = "Sayı 6";
        //txtKredi
        txtKredi.AutoSize = false;
        txtKredi.Size = new Size(300, 40);
        txtKredi.Location = new Point(38, 20);
        txtKredi.Font = new Font("Arial", 12, FontStyle.Bold);
        txtKredi.Text = "başlangıç krediniz:       100 TL ";

        //btnMakinaniOynat
        btnMakinaniOynat.Size = new Size(200, 40);
        btnMakinaniOynat.Location = new Point(100, 90);
        btnMakinaniOynat.Text = "MakinaniOynat!";
        btnMakinaniOynat.Font = new Font("Arial", 12, FontStyle.Bold);
        btnMakinaniOynat.ForeColor = Color.Black;
        btnMakinaniOynat.BackColor = Color.Yellow;

        //btnBaslat
        btnBaslat.Size = new Size(200, 40);
        btnBaslat.Location = new Point(10, 150);
        btnBaslat.Text = "Oyunu Baslat!";
        btnBaslat.Font = new Font("Arial", 12, FontStyle.Bold);
        btnBaslat.ForeColor = Color.Black;
        btnBaslat.BackColor = Color.Green;

        //btnBitir
        btnBitir.Size = new Size(200, 40);
        btnBitir.Location = new Point(220, 150);
        btnBitir.Text = " OyunuBitir!";
        btnBitir.Font = new Font("Arial", 12, FontStyle.Bold);
        btnBitir.ForeColor = Color.Black;
        btnBitir.BackColor = Color.Red;

        //lblSonuc
        txtsonuc.AutoSize = false;
        txtsonuc.Size = new Size(100, 40);
        lblSonuc.Location = new Point(150, 300);
        lblSonuc.Text = "Sonuç:";
        
        txtsonuc.AutoSize = false;
        txtsonuc.Size = new Size(40, 40);
        txtsonuc.Location = new Point(250, 290);
        txtsonuc.Font = new Font("Arial", 16, FontStyle.Bold);
        txtsonuc.Text = " 0 ";

        txttahmin.AutoSize = false;
        txttahmin.Size = new Size(400, 30);
        txttahmin.Location = new Point(30, 200);
        txttahmin.Font = new Font("Arial", 10, FontStyle.Bold);
        txttahmin.Text = " Oyundan aldığınız sayılar: ";

        txtpuan.AutoSize = false;
        txtpuan.Size = new Size(400, 35);
        txtpuan.Location = new Point(30, 250);
        txtpuan.Font = new Font("Arial", 10, FontStyle.Bold);
        txtpuan.Text = " Eşit Olan sayıların sayısı ";
    }


    #endregion
}
