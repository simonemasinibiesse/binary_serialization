namespace BinarySerializationProblem
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
            this.BtnSerialize = new System.Windows.Forms.Button();
            this.BtnDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSerialize
            // 
            this.BtnSerialize.Enabled = false;
            this.BtnSerialize.Location = new System.Drawing.Point(55, 171);
            this.BtnSerialize.Name = "BtnSerialize";
            this.BtnSerialize.Size = new System.Drawing.Size(117, 73);
            this.BtnSerialize.TabIndex = 0;
            this.BtnSerialize.Text = "Serialize";
            this.BtnSerialize.UseVisualStyleBackColor = true;
            this.BtnSerialize.Click += new System.EventHandler(this.BtnSerialize_Click);
            // 
            // BtnDeserialize
            // 
            this.BtnDeserialize.Location = new System.Drawing.Point(55, 48);
            this.BtnDeserialize.Name = "BtnDeserialize";
            this.BtnDeserialize.Size = new System.Drawing.Size(117, 73);
            this.BtnDeserialize.TabIndex = 1;
            this.BtnDeserialize.Text = "Deserialize";
            this.BtnDeserialize.UseVisualStyleBackColor = true;
            this.BtnDeserialize.Click += new System.EventHandler(this.BtnDeserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 303);
            this.Controls.Add(this.BtnDeserialize);
            this.Controls.Add(this.BtnSerialize);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSerialize;
        private System.Windows.Forms.Button BtnDeserialize;
    }
}

