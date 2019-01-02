namespace Autoskola
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.butBack = new System.Windows.Forms.Button();
            this.butNext = new System.Windows.Forms.Button();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pBCisloOtazky = new System.Windows.Forms.Label();
            this.blokOtazky = new System.Windows.Forms.GroupBox();
            this.textOtazky = new System.Windows.Forms.Label();
            this.butA = new System.Windows.Forms.Button();
            this.butB = new System.Windows.Forms.Button();
            this.butC = new System.Windows.Forms.Button();
            this.butEnd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.blokOtazky.SuspendLayout();
            this.SuspendLayout();
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(12, 12);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(44, 26);
            this.butBack.TabIndex = 0;
            this.butBack.Text = "<<";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(791, 12);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(44, 26);
            this.butNext.TabIndex = 1;
            this.butNext.Text = ">>";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // pBar1
            // 
            this.pBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pBar1.Location = new System.Drawing.Point(62, 12);
            this.pBar1.MarqueeAnimationSpeed = 0;
            this.pBar1.Maximum = 290;
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(723, 26);
            this.pBar1.TabIndex = 2;
            this.pBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Číslo otázky: ";
            // 
            // pBCisloOtazky
            // 
            this.pBCisloOtazky.AutoSize = true;
            this.pBCisloOtazky.Location = new System.Drawing.Point(461, 19);
            this.pBCisloOtazky.Name = "pBCisloOtazky";
            this.pBCisloOtazky.Size = new System.Drawing.Size(77, 13);
            this.pBCisloOtazky.TabIndex = 4;
            this.pBCisloOtazky.Text = "%cisloOtazky%";
            // 
            // blokOtazky
            // 
            this.blokOtazky.Controls.Add(this.butEnd);
            this.blokOtazky.Controls.Add(this.textOtazky);
            this.blokOtazky.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blokOtazky.Location = new System.Drawing.Point(12, 44);
            this.blokOtazky.Name = "blokOtazky";
            this.blokOtazky.Size = new System.Drawing.Size(822, 294);
            this.blokOtazky.TabIndex = 5;
            this.blokOtazky.TabStop = false;
            this.blokOtazky.Text = "Otázka %cislootazky%";
            // 
            // textOtazky
            // 
            this.textOtazky.AutoSize = true;
            this.textOtazky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textOtazky.Location = new System.Drawing.Point(45, 43);
            this.textOtazky.Name = "textOtazky";
            this.textOtazky.Size = new System.Drawing.Size(112, 20);
            this.textOtazky.TabIndex = 0;
            this.textOtazky.Text = "%textOtazky%";
            // 
            // butA
            // 
            this.butA.Location = new System.Drawing.Point(12, 343);
            this.butA.Name = "butA";
            this.butA.Size = new System.Drawing.Size(823, 50);
            this.butA.TabIndex = 6;
            this.butA.Text = "%odpovedA%";
            this.butA.UseVisualStyleBackColor = true;
            // 
            // butB
            // 
            this.butB.Location = new System.Drawing.Point(12, 399);
            this.butB.Name = "butB";
            this.butB.Size = new System.Drawing.Size(823, 50);
            this.butB.TabIndex = 7;
            this.butB.Text = "%odpovedB%";
            this.butB.UseVisualStyleBackColor = true;
            // 
            // butC
            // 
            this.butC.Location = new System.Drawing.Point(11, 455);
            this.butC.Name = "butC";
            this.butC.Size = new System.Drawing.Size(823, 50);
            this.butC.TabIndex = 8;
            this.butC.Text = "%odpovedC%";
            this.butC.UseVisualStyleBackColor = true;
            // 
            // butEnd
            // 
            this.butEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butEnd.Location = new System.Drawing.Point(728, 0);
            this.butEnd.Name = "butEnd";
            this.butEnd.Size = new System.Drawing.Size(95, 21);
            this.butEnd.TabIndex = 1;
            this.butEnd.Text = "Odejit";
            this.butEnd.UseVisualStyleBackColor = true;
            this.butEnd.Click += new System.EventHandler(this.button7_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(847, 513);
            this.Controls.Add(this.butC);
            this.Controls.Add(this.butB);
            this.Controls.Add(this.butA);
            this.Controls.Add(this.blokOtazky);
            this.Controls.Add(this.pBCisloOtazky);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butBack);
            this.Name = "Form1";
            this.Text = "Testy autoškoly";
            this.blokOtazky.ResumeLayout(false);
            this.blokOtazky.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pBCisloOtazky;
        private System.Windows.Forms.GroupBox blokOtazky;
        private System.Windows.Forms.Label textOtazky;
        private System.Windows.Forms.Button butA;
        private System.Windows.Forms.Button butB;
        private System.Windows.Forms.Button butC;
        private System.Windows.Forms.Button butEnd;
        private System.Windows.Forms.Timer timer1;
    }
}

        #endregion


