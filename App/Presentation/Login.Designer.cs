namespace Presentation
{
    partial class Login
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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.pbOcultar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMostrar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Animated = true;
            this.BtnLogin.AutoRoundedCorners = true;
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.IndicateFocus = true;
            this.BtnLogin.Location = new System.Drawing.Point(290, 402);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(85, 37);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Iniciar";
            this.BtnLogin.UseTransparentBackground = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pbOcultar
            // 
            this.pbOcultar.BackColor = System.Drawing.Color.Transparent;
            this.pbOcultar.Image = global::Presentation.Properties.Resources.invisible;
            this.pbOcultar.ImageRotate = 0F;
            this.pbOcultar.Location = new System.Drawing.Point(447, 339);
            this.pbOcultar.Name = "pbOcultar";
            this.pbOcultar.Size = new System.Drawing.Size(25, 25);
            this.pbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOcultar.TabIndex = 5;
            this.pbOcultar.TabStop = false;
            this.pbOcultar.UseTransparentBackground = true;
            this.pbOcultar.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // pbMostrar
            // 
            this.pbMostrar.BackColor = System.Drawing.Color.Transparent;
            this.pbMostrar.Image = global::Presentation.Properties.Resources.ojo;
            this.pbMostrar.ImageRotate = 0F;
            this.pbMostrar.Location = new System.Drawing.Point(447, 339);
            this.pbMostrar.Name = "pbMostrar";
            this.pbMostrar.Size = new System.Drawing.Size(25, 25);
            this.pbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrar.TabIndex = 4;
            this.pbMostrar.TabStop = false;
            this.pbMostrar.UseTransparentBackground = true;
            this.pbMostrar.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Animated = true;
            this.txtContraseña.AutoRoundedCorners = true;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.DefaultText = "";
            this.txtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña.IconLeft = global::Presentation.Properties.Resources.candado_abierto;
            this.txtContraseña.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.txtContraseña.Location = new System.Drawing.Point(212, 327);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceholderText = "Contraseña";
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.Size = new System.Drawing.Size(229, 48);
            this.txtContraseña.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Animated = true;
            this.txtUser.AutoRoundedCorners = true;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.IconLeft = global::Presentation.Properties.Resources.usuarioPequeño;
            this.txtUser.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.txtUser.Location = new System.Drawing.Point(212, 238);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Usuario";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(220, 48);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(274, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 496);
            this.Controls.Add(this.pbOcultar);
            this.Controls.Add(this.pbMostrar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox pbMostrar;
        private Guna.UI2.WinForms.Guna2PictureBox pbOcultar;
    }
}