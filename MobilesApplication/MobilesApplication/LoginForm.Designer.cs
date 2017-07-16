namespace MobilesApplication
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUse = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnXlogIn = new DevComponents.DotNetBar.ButtonX();
            this.btnXCancel = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // tbxUse
            // 
            this.tbxUse.Location = new System.Drawing.Point(75, 12);
            this.tbxUse.Name = "tbxUse";
            this.tbxUse.Size = new System.Drawing.Size(183, 20);
            this.tbxUse.TabIndex = 1;
            this.tbxUse.Text = "ping5";
            this.tbxUse.Validating += new System.ComponentModel.CancelEventHandler(this.tbxUse_Validating);
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(75, 41);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(183, 20);
            this.tbxPass.TabIndex = 1;
            this.tbxPass.Text = "Nguyen";
            this.tbxPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPass_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnXlogIn
            // 
            this.btnXlogIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXlogIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXlogIn.Enabled = false;
            this.btnXlogIn.Location = new System.Drawing.Point(75, 67);
            this.btnXlogIn.Name = "btnXlogIn";
            this.btnXlogIn.Size = new System.Drawing.Size(75, 23);
            this.btnXlogIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXlogIn.TabIndex = 3;
            this.btnXlogIn.Text = "Log In";
            this.btnXlogIn.Click += new System.EventHandler(this.btnXlogIn_Click);
            // 
            // btnXCancel
            // 
            this.btnXCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXCancel.Location = new System.Drawing.Point(183, 67);
            this.btnXCancel.Name = "btnXCancel";
            this.btnXCancel.Size = new System.Drawing.Size(75, 23);
            this.btnXCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXCancel.TabIndex = 3;
            this.btnXCancel.Text = "Cancel";
            this.btnXCancel.Click += new System.EventHandler(this.btnXCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.btnXCancel);
            this.Controls.Add(this.btnXlogIn);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxUse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUse;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.ButtonX btnXlogIn;
        private DevComponents.DotNetBar.ButtonX btnXCancel;
    }
}