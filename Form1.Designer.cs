
namespace Hello_World_GUI
{
    partial class SayHi
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
        private void InitializeComponent()
        {
            this.LabelHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelHello
            // 
            this.LabelHello.AllowDrop = true;
            this.LabelHello.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelHello.ForeColor = System.Drawing.Color.LightPink;
            this.LabelHello.Location = new System.Drawing.Point(294, 184);
            this.LabelHello.Name = "LabelHello";
            this.LabelHello.Size = new System.Drawing.Size(167, 37);
            this.LabelHello.TabIndex = 0;
            this.LabelHello.Text = "Hello World!";
            this.LabelHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // SayHi
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelHello);
            this.Name = "SayHi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Say Hi";
            this.Load += new System.EventHandler(this.Saludo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelHello;
    }
}

