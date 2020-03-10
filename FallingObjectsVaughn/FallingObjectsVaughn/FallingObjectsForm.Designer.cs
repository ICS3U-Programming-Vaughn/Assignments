namespace FallingObjectsVaughn
{
    partial class FallingObjectsForm
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
            this.lblInputText_Click = new System.Windows.Forms.Label();
            this.lblQuestionAnswer = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputText_Click
            // 
            this.lblInputText_Click.AutoSize = true;
            this.lblInputText_Click.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputText_Click.Location = new System.Drawing.Point(12, 103);
            this.lblInputText_Click.Name = "lblInputText_Click";
            this.lblInputText_Click.Size = new System.Drawing.Size(561, 25);
            this.lblInputText_Click.TabIndex = 0;
            this.lblInputText_Click.Text = "Enter the time (in seconds) since you released the object:\r\n";
            // 
            // lblQuestionAnswer
            // 
            this.lblQuestionAnswer.AutoSize = true;
            this.lblQuestionAnswer.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionAnswer.Location = new System.Drawing.Point(12, 309);
            this.lblQuestionAnswer.Name = "lblQuestionAnswer";
            this.lblQuestionAnswer.Size = new System.Drawing.Size(445, 25);
            this.lblQuestionAnswer.TabIndex = 1;
            this.lblQuestionAnswer.Text = "The height of the object above the ground is:\r\n";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(648, 103);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(401, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(172, 48);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(541, 309);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(49, 29);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "???";
            this.lblOutput.Click += new System.EventHandler(this.LblAnswer_Click);
            // 
            // FallingObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblQuestionAnswer);
            this.Controls.Add(this.lblInputText_Click);
            this.Name = "FallingObjectsForm";
            this.Text = "Falling objects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputText_Click;
        private System.Windows.Forms.Label lblQuestionAnswer;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOutput;
    }
}

