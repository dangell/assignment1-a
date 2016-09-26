namespace WindowsFormsApplication1
{
    partial class frmAssignmentOne
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
            this.btnWorld = new System.Windows.Forms.Button();
            this.lblWorldbtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWorld
            // 
            this.btnWorld.Location = new System.Drawing.Point(12, 12);
            this.btnWorld.Name = "btnWorld";
            this.btnWorld.Size = new System.Drawing.Size(260, 23);
            this.btnWorld.TabIndex = 0;
            this.btnWorld.Text = "Arnold????";
            this.btnWorld.UseVisualStyleBackColor = true;
            this.btnWorld.Click += new System.EventHandler(this.btnWorld_Click);
            // 
            // lblWorldbtn
            // 
            this.lblWorldbtn.AutoSize = true;
            this.lblWorldbtn.Location = new System.Drawing.Point(34, 73);
            this.lblWorldbtn.Name = "lblWorldbtn";
            this.lblWorldbtn.Size = new System.Drawing.Size(0, 13);
            this.lblWorldbtn.TabIndex = 1;
            // 
            // frmAssignmentOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblWorldbtn);
            this.Controls.Add(this.btnWorld);
            this.Name = "frmAssignmentOne";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWorld;
        private System.Windows.Forms.Label lblWorldbtn;
    }
}

