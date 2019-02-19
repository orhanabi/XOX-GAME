namespace XOX_oyunu
{
    partial class info
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "                                         OYUN HAKKINDA",
            "         ",
            "  OXO, XOX gibi isimlerle de bilinen Tic Tac Toe ",
            "",
            "  oyununda X ve O harflerini iki oyuncudan birisi seçer.",
            "",
            "  9 tane kareye sırayla her oyuncu kendi harfini yerleştirmeye başlar. ",
            "",
            "  Her oyuncunun 3 tane aynı harften yanyana getirmeye çalıştığı oyunda ",
            "",
            "  bu o kadar da kolay olmuyor ne yazıkki. ",
            "",
            "  Kendi harflerinizi sıralarken rakibinizi engellemek için bazen sıra size ",
            "",
            "  geldiğinizda harfi başka yere koymanız gerekebilir. ",
            "",
            "  Oyunda her XXX veya OOO yapan oyuncu 10 puan kazanır.",
            "",
            "  5 saniye gecikme yapan oyuncu ise 5 puan ceza yer."});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(683, 466);
            this.listBox1.TabIndex = 0;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 493);
            this.Controls.Add(this.listBox1);
            this.Name = "info";
            this.Text = "info";
            this.Load += new System.EventHandler(this.info_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}