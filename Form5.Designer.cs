
namespace setupevent00
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.full_Name = new System.Windows.Forms.TextBox();
            this.phone_Number = new System.Windows.Forms.TextBox();
            this.event_Name = new System.Windows.Forms.TextBox();
            this.event_Date = new System.Windows.Forms.TextBox();
            this.guest_Number = new System.Windows.Forms.TextBox();
            this.receipt = new System.Windows.Forms.RichTextBox();
            this.event_Type = new System.Windows.Forms.ComboBox();
            this.Packages = new System.Windows.Forms.ComboBox();
            this.print = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.fees = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FULL NAME :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "PHONE NUMBER :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "EVENT NAME :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "EVENT TYPE :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "EVENT DATE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "PACKAGES :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "NO. OF GUESTS :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(550, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 44);
            this.label8.TabIndex = 7;
            this.label8.Text = "EVENT SET UP\r\n";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // full_Name
            // 
            this.full_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_Name.Location = new System.Drawing.Point(532, 169);
            this.full_Name.Name = "full_Name";
            this.full_Name.Size = new System.Drawing.Size(270, 35);
            this.full_Name.TabIndex = 8;
            this.full_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // phone_Number
            // 
            this.phone_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_Number.Location = new System.Drawing.Point(575, 236);
            this.phone_Number.Name = "phone_Number";
            this.phone_Number.Size = new System.Drawing.Size(230, 35);
            this.phone_Number.TabIndex = 9;
            this.phone_Number.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // event_Name
            // 
            this.event_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_Name.Location = new System.Drawing.Point(573, 297);
            this.event_Name.Name = "event_Name";
            this.event_Name.Size = new System.Drawing.Size(230, 35);
            this.event_Name.TabIndex = 10;
            this.event_Name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // event_Date
            // 
            this.event_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_Date.Location = new System.Drawing.Point(572, 419);
            this.event_Date.Name = "event_Date";
            this.event_Date.Size = new System.Drawing.Size(230, 35);
            this.event_Date.TabIndex = 12;
            this.event_Date.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // guest_Number
            // 
            this.guest_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_Number.Location = new System.Drawing.Point(573, 551);
            this.guest_Number.Name = "guest_Number";
            this.guest_Number.Size = new System.Drawing.Size(230, 35);
            this.guest_Number.TabIndex = 14;
            this.guest_Number.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // receipt
            // 
            this.receipt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.Location = new System.Drawing.Point(891, 169);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(455, 517);
            this.receipt.TabIndex = 15;
            this.receipt.Text = "";
            this.receipt.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // event_Type
            // 
            this.event_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.event_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_Type.FormattingEnabled = true;
            this.event_Type.Items.AddRange(new object[] {
            "Workshop",
            "Conference",
            "Seminar",
            "Celebration"});
            this.event_Type.Location = new System.Drawing.Point(572, 353);
            this.event_Type.Name = "event_Type";
            this.event_Type.Size = new System.Drawing.Size(230, 37);
            this.event_Type.TabIndex = 16;
            // 
            // Packages
            // 
            this.Packages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Packages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Packages.FormattingEnabled = true;
            this.Packages.Items.AddRange(new object[] {
            "KEP 1",
            "KEP 2",
            "KEP 3",
            "KEP 4"});
            this.Packages.Location = new System.Drawing.Point(572, 486);
            this.Packages.Name = "Packages";
            this.Packages.Size = new System.Drawing.Size(230, 37);
            this.Packages.TabIndex = 17;
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(656, 663);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(147, 54);
            this.print.TabIndex = 18;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(476, 663);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(147, 54);
            this.clear.TabIndex = 19;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.generate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(296, 663);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(147, 54);
            this.generate.TabIndex = 20;
            this.generate.Text = "GENERATE";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // fees
            // 
            this.fees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fees.FormattingEnabled = true;
            this.fees.Items.AddRange(new object[] {
            "20000",
            "25000",
            "30000"});
            this.fees.Location = new System.Drawing.Point(575, 607);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(227, 37);
            this.fees.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(314, 613);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "FEES :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 23;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 713);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fees);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.print);
            this.Controls.Add(this.Packages);
            this.Controls.Add(this.event_Type);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.guest_Number);
            this.Controls.Add(this.event_Date);
            this.Controls.Add(this.event_Name);
            this.Controls.Add(this.phone_Number);
            this.Controls.Add(this.full_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox full_Name;
        private System.Windows.Forms.TextBox phone_Number;
        private System.Windows.Forms.TextBox event_Name;
        private System.Windows.Forms.TextBox event_Date;
        private System.Windows.Forms.TextBox guest_Number;
        private System.Windows.Forms.RichTextBox receipt;
        private System.Windows.Forms.ComboBox event_Type;
        private System.Windows.Forms.ComboBox Packages;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.ComboBox fees;
        private System.Windows.Forms.Label label9;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
    }
}