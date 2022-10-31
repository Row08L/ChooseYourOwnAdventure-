
namespace ChooseYourOwnAdventure__
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.choiceButton1 = new System.Windows.Forms.Button();
            this.choiceButton2 = new System.Windows.Forms.Button();
            this.choiceButton3 = new System.Windows.Forms.Button();
            this.choiceButton4 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.endingBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.endingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // choiceButton1
            // 
            this.choiceButton1.Location = new System.Drawing.Point(12, 384);
            this.choiceButton1.Name = "choiceButton1";
            this.choiceButton1.Size = new System.Drawing.Size(776, 54);
            this.choiceButton1.TabIndex = 0;
            this.choiceButton1.Text = "button1";
            this.choiceButton1.UseVisualStyleBackColor = true;
            this.choiceButton1.Click += new System.EventHandler(this.choiceButton1_Click);
            // 
            // choiceButton2
            // 
            this.choiceButton2.Location = new System.Drawing.Point(12, 324);
            this.choiceButton2.Name = "choiceButton2";
            this.choiceButton2.Size = new System.Drawing.Size(776, 54);
            this.choiceButton2.TabIndex = 1;
            this.choiceButton2.Text = "button2";
            this.choiceButton2.UseVisualStyleBackColor = true;
            this.choiceButton2.Click += new System.EventHandler(this.choiceButton2_Click);
            // 
            // choiceButton3
            // 
            this.choiceButton3.Location = new System.Drawing.Point(12, 264);
            this.choiceButton3.Name = "choiceButton3";
            this.choiceButton3.Size = new System.Drawing.Size(776, 54);
            this.choiceButton3.TabIndex = 2;
            this.choiceButton3.Text = "button3";
            this.choiceButton3.UseVisualStyleBackColor = true;
            this.choiceButton3.Click += new System.EventHandler(this.choiceButton3_Click);
            // 
            // choiceButton4
            // 
            this.choiceButton4.Location = new System.Drawing.Point(12, 204);
            this.choiceButton4.Name = "choiceButton4";
            this.choiceButton4.Size = new System.Drawing.Size(776, 54);
            this.choiceButton4.TabIndex = 3;
            this.choiceButton4.Text = "button4";
            this.choiceButton4.UseVisualStyleBackColor = true;
            this.choiceButton4.Click += new System.EventHandler(this.choiceButton4_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Bauhaus LT Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(0, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(801, 191);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingBox
            // 
            this.endingBox.Location = new System.Drawing.Point(-3, 0);
            this.endingBox.Name = "endingBox";
            this.endingBox.Size = new System.Drawing.Size(83, 27);
            this.endingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.endingBox.TabIndex = 5;
            this.endingBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endingBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.choiceButton4);
            this.Controls.Add(this.choiceButton3);
            this.Controls.Add(this.choiceButton2);
            this.Controls.Add(this.choiceButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Game";
            ((System.ComponentModel.ISupportInitialize)(this.endingBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choiceButton1;
        private System.Windows.Forms.Button choiceButton2;
        private System.Windows.Forms.Button choiceButton3;
        private System.Windows.Forms.Button choiceButton4;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox endingBox;
    }
}

