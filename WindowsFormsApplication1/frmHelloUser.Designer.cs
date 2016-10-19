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
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtUserAge = new System.Windows.Forms.TextBox();
            this.lblFavColour = new System.Windows.Forms.Label();
            this.txtUserFavColour = new System.Windows.Forms.TextBox();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWorld
            // 
            this.btnWorld.Location = new System.Drawing.Point(12, 12);
            this.btnWorld.Name = "btnWorld";
            this.btnWorld.Size = new System.Drawing.Size(107, 23);
            this.btnWorld.TabIndex = 0;
            this.btnWorld.Text = "Hello";
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "What is your name?";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(178, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 121);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(90, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "How old are you?";
            // 
            // txtUserAge
            // 
            this.txtUserAge.Location = new System.Drawing.Point(178, 118);
            this.txtUserAge.Name = "txtUserAge";
            this.txtUserAge.Size = new System.Drawing.Size(100, 20);
            this.txtUserAge.TabIndex = 5;
            // 
            // lblFavColour
            // 
            this.lblFavColour.AutoSize = true;
            this.lblFavColour.Location = new System.Drawing.Point(12, 152);
            this.lblFavColour.Name = "lblFavColour";
            this.lblFavColour.Size = new System.Drawing.Size(148, 13);
            this.lblFavColour.TabIndex = 6;
            this.lblFavColour.Text = "What is your favourite colour?";
            // 
            // txtUserFavColour
            // 
            this.txtUserFavColour.Location = new System.Drawing.Point(178, 149);
            this.txtUserFavColour.Name = "txtUserFavColour";
            this.txtUserFavColour.Size = new System.Drawing.Size(100, 20);
            this.txtUserFavColour.TabIndex = 7;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Location = new System.Drawing.Point(12, 260);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(241, 240);
            this.lblUserInfo.TabIndex = 8;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(59, 209);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(219, 23);
            this.btnUserInfo.TabIndex = 9;
            this.btnUserInfo.Text = "Press here for your info card";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // frmAssignmentOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 540);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.txtUserFavColour);
            this.Controls.Add(this.lblFavColour);
            this.Controls.Add(this.txtUserAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblName);
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtUserAge;
        private System.Windows.Forms.Label lblFavColour;
        private System.Windows.Forms.TextBox txtUserFavColour;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnUserInfo;
    }
}

