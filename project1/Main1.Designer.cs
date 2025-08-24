namespace Project1
{
    partial class Main1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main1));
            btnLogin = new Button();
            btnResistar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(94, 561);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(328, 47);
            btnLogin.TabIndex = 0;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnPhone_Click;
            // 
            // btnResistar
            // 
            btnResistar.BackColor = Color.Transparent;
            btnResistar.Image = (Image)resources.GetObject("btnResistar.Image");
            btnResistar.Location = new Point(94, 614);
            btnResistar.Name = "btnResistar";
            btnResistar.Size = new Size(328, 38);
            btnResistar.TabIndex = 0;
            btnResistar.UseVisualStyleBackColor = false;
            btnResistar.Click += btnResistar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(527, 541);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // Main1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 681);
            Controls.Add(pictureBox1);
            Controls.Add(btnResistar);
            Controls.Add(btnLogin);
            Name = "Main1";
            Text = "Main1";
            Load += Main1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnResistar;
        private PictureBox pictureBox1;
    }
}