namespace Air_Heater_Black_Box_Model
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
            this.textControlSignal = new System.Windows.Forms.TextBox();
            this.textTimeDelay = new System.Windows.Forms.TextBox();
            this.textGain = new System.Windows.Forms.TextBox();
            this.textTimeConstant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTemparature = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textControlSignal
            // 
            this.textControlSignal.Location = new System.Drawing.Point(216, 123);
            this.textControlSignal.Name = "textControlSignal";
            this.textControlSignal.Size = new System.Drawing.Size(100, 22);
            this.textControlSignal.TabIndex = 0;
            this.textControlSignal.Text = "52";
            // 
            // textTimeDelay
            // 
            this.textTimeDelay.Location = new System.Drawing.Point(216, 312);
            this.textTimeDelay.Name = "textTimeDelay";
            this.textTimeDelay.Size = new System.Drawing.Size(100, 22);
            this.textTimeDelay.TabIndex = 1;
            this.textTimeDelay.Text = "4.1";            // 
            // textGain
            // 
            this.textGain.Location = new System.Drawing.Point(216, 256);
            this.textGain.Name = "textGain";
            this.textGain.Size = new System.Drawing.Size(100, 22);
            this.textGain.TabIndex = 2;
            this.textGain.Text = "2.33";
            // 
            // textTimeConstant
            // 
            this.textTimeConstant.Location = new System.Drawing.Point(216, 189);
            this.textTimeConstant.Name = "textTimeConstant";
            this.textTimeConstant.Size = new System.Drawing.Size(100, 22);
            this.textTimeConstant.TabIndex = 3;
            this.textTimeConstant.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Control Signal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Out Temparature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Delay";

            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heater Gain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Time Constant";
            // 
            // textTemparature
            // 
            this.textTemparature.Location = new System.Drawing.Point(625, 142);
            this.textTemparature.Multiline = true;
            this.textTemparature.Name = "textTemparature";
            this.textTemparature.Size = new System.Drawing.Size(100, 22);
            this.textTemparature.TabIndex = 9;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(604, 256);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(132, 54);
            this.buttonExecute.TabIndex = 10;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textTemparature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTimeConstant);
            this.Controls.Add(this.textGain);
            this.Controls.Add(this.textTimeDelay);
            this.Controls.Add(this.textControlSignal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textControlSignal;
        private System.Windows.Forms.TextBox textTimeDelay;
        private System.Windows.Forms.TextBox textGain;
        private System.Windows.Forms.TextBox textTimeConstant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTemparature;
        private System.Windows.Forms.Button buttonExecute;
    }
}

