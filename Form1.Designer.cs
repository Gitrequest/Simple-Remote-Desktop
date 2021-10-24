
namespace Simple_Remote_Desktop
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.rdp_box = new AxMSTSCLib.AxMsRdpClient8();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_box)).BeginInit();
            this.SuspendLayout();
            // 
            // rdp_box
            // 
            this.rdp_box.Enabled = true;
            this.rdp_box.Location = new System.Drawing.Point(1, 38);
            this.rdp_box.Name = "rdp_box";
            this.rdp_box.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp_box.OcxState")));
            this.rdp_box.Size = new System.Drawing.Size(1181, 849);
            this.rdp_box.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(893, 1);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(125, 36);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(128)))), ((int)(((byte)(29)))));
            this.lbl_ip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip.Location = new System.Drawing.Point(8, 9);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(40, 25);
            this.lbl_ip.TabIndex = 10;
            this.lbl_ip.Text = "IP:";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(54, 12);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(127, 20);
            this.txt_ip.TabIndex = 1;
            this.txt_ip.TextChanged += new System.EventHandler(this.txt_ip_TextChanged);
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(128)))), ((int)(((byte)(29)))));
            this.lbl_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pw.Location = new System.Drawing.Point(561, 9);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(121, 25);
            this.lbl_pw.TabIndex = 12;
            this.lbl_pw.Text = "Password:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(128)))), ((int)(((byte)(29)))));
            this.lbl_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(218, 9);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(125, 25);
            this.lbl_user.TabIndex = 11;
            this.lbl_user.Text = "Username:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(349, 12);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(184, 20);
            this.txt_user.TabIndex = 2;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(688, 12);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(199, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.FlatAppearance.BorderSize = 0;
            this.btn_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.Location = new System.Drawing.Point(1034, 1);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(123, 36);
            this.btn_disconnect.TabIndex = 5;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(19)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1184, 881);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.rdp_box);
            this.Name = "MainFrame";
            this.Text = "Simple Remote Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.rdp_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient8 rdp_box;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_disconnect;
    }
}

