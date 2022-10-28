namespace ProyectoParqueadero
{
    partial class menuForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tituloTxt = new System.Windows.Forms.Label();
            this.ocasionalToUsualBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGISTRAR VEHICULO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 255);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "PAGAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 327);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tituloTxt
            // 
            this.tituloTxt.AutoSize = true;
            this.tituloTxt.ForeColor = System.Drawing.Color.Black;
            this.tituloTxt.Location = new System.Drawing.Point(129, 60);
            this.tituloTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloTxt.Name = "tituloTxt";
            this.tituloTxt.Size = new System.Drawing.Size(119, 20);
            this.tituloTxt.TabIndex = 3;
            this.tituloTxt.Text = "BIENVENIDO";
            // 
            // ocasionalToUsualBtn
            // 
            this.ocasionalToUsualBtn.Location = new System.Drawing.Point(93, 99);
            this.ocasionalToUsualBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ocasionalToUsualBtn.Name = "ocasionalToUsualBtn";
            this.ocasionalToUsualBtn.Size = new System.Drawing.Size(285, 49);
            this.ocasionalToUsualBtn.TabIndex = 4;
            this.ocasionalToUsualBtn.Text = "PASAR A USUARIO USUAL";
            this.ocasionalToUsualBtn.UseVisualStyleBackColor = true;
            this.ocasionalToUsualBtn.Click += new System.EventHandler(this.ocasionalToUsualBtn_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 506);
            this.Controls.Add(this.ocasionalToUsualBtn);
            this.Controls.Add(this.tituloTxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuForm";
            this.Text = "menuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label tituloTxt;
        private System.Windows.Forms.Button ocasionalToUsualBtn;
    }
}