namespace VSCustomControlImporter
{
    partial class VSCCImporter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( VSCCImporter ) );
            this.btnProceed = new System.Windows.Forms.Button();
            this.tbCCLoc = new System.Windows.Forms.TextBox();
            this.btnCCLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProjLoc = new System.Windows.Forms.Button();
            this.tbProjLoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDCCLoc = new System.Windows.Forms.Button();
            this.tbDCCLoc = new System.Windows.Forms.TextBox();
            this.btnGotoProjLoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.Enabled = false;
            this.btnProceed.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "btnProceed.Image" ) ) );
            this.btnProceed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProceed.Location = new System.Drawing.Point( 22, 233 );
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size( 91, 34 );
            this.btnProceed.TabIndex = 0;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceed.UseVisualStyleBackColor = true;
            // 
            // tbCCLoc
            // 
            this.tbCCLoc.Font = new System.Drawing.Font( "Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.tbCCLoc.Location = new System.Drawing.Point( 54, 45 );
            this.tbCCLoc.Name = "tbCCLoc";
            this.tbCCLoc.ReadOnly = true;
            this.tbCCLoc.Size = new System.Drawing.Size( 223, 20 );
            this.tbCCLoc.TabIndex = 1;
            // 
            // btnCCLoc
            // 
            this.btnCCLoc.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "btnCCLoc.Image" ) ) );
            this.btnCCLoc.Location = new System.Drawing.Point( 283, 43 );
            this.btnCCLoc.Name = "btnCCLoc";
            this.btnCCLoc.Size = new System.Drawing.Size( 31, 23 );
            this.btnCCLoc.TabIndex = 2;
            this.btnCCLoc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 22, 7 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 185, 17 );
            this.label1.TabIndex = 3;
            this.label1.Text = "Location of Custom Control*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.Location = new System.Drawing.Point( 40, 24 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 186, 13 );
            this.label2.TabIndex = 4;
            this.label2.Text = "e.g: Ribbon.cs, Ribbon.Designer.cs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point( -4, 220 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 377, 3 );
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label3.Location = new System.Drawing.Point( 40, 98 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 205, 13 );
            this.label3.TabIndex = 9;
            this.label3.Text = "e.g: C:\\Users\\Documents\\VSProjects\\UI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label4.Location = new System.Drawing.Point( 22, 81 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 190, 17 );
            this.label4.TabIndex = 8;
            this.label4.Text = "Destination Project Location*";
            // 
            // btnProjLoc
            // 
            this.btnProjLoc.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "btnProjLoc.Image" ) ) );
            this.btnProjLoc.Location = new System.Drawing.Point( 283, 117 );
            this.btnProjLoc.Name = "btnProjLoc";
            this.btnProjLoc.Size = new System.Drawing.Size( 31, 23 );
            this.btnProjLoc.TabIndex = 7;
            this.btnProjLoc.UseVisualStyleBackColor = true;
            // 
            // tbProjLoc
            // 
            this.tbProjLoc.Font = new System.Drawing.Font( "Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.tbProjLoc.Location = new System.Drawing.Point( 54, 119 );
            this.tbProjLoc.Name = "tbProjLoc";
            this.tbProjLoc.ReadOnly = true;
            this.tbProjLoc.Size = new System.Drawing.Size( 223, 20 );
            this.tbProjLoc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label5.Location = new System.Drawing.Point( 40, 170 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 280, 13 );
            this.label5.TabIndex = 13;
            this.label5.Text = "Ignore if you want it inside the base project location.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label6.Location = new System.Drawing.Point( 22, 153 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 238, 17 );
            this.label6.TabIndex = 12;
            this.label6.Text = "Destination Custom Control Location";
            // 
            // btnDCCLoc
            // 
            this.btnDCCLoc.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "btnDCCLoc.Image" ) ) );
            this.btnDCCLoc.Location = new System.Drawing.Point( 283, 189 );
            this.btnDCCLoc.Name = "btnDCCLoc";
            this.btnDCCLoc.Size = new System.Drawing.Size( 31, 23 );
            this.btnDCCLoc.TabIndex = 11;
            this.btnDCCLoc.UseVisualStyleBackColor = true;
            // 
            // tbDCCLoc
            // 
            this.tbDCCLoc.Font = new System.Drawing.Font( "Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.tbDCCLoc.Location = new System.Drawing.Point( 54, 191 );
            this.tbDCCLoc.Name = "tbDCCLoc";
            this.tbDCCLoc.ReadOnly = true;
            this.tbDCCLoc.Size = new System.Drawing.Size( 223, 20 );
            this.tbDCCLoc.TabIndex = 10;
            // 
            // btnGotoProjLoc
            // 
            this.btnGotoProjLoc.Enabled = false;
            this.btnGotoProjLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGotoProjLoc.Location = new System.Drawing.Point( 178, 233 );
            this.btnGotoProjLoc.Name = "btnGotoProjLoc";
            this.btnGotoProjLoc.Size = new System.Drawing.Size( 168, 34 );
            this.btnGotoProjLoc.TabIndex = 14;
            this.btnGotoProjLoc.Text = "Go To Project Folder";
            this.btnGotoProjLoc.UseVisualStyleBackColor = true;
            // 
            // VSCCImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 369, 277 );
            this.Controls.Add( this.btnGotoProjLoc );
            this.Controls.Add( this.label5 );
            this.Controls.Add( this.label6 );
            this.Controls.Add( this.btnDCCLoc );
            this.Controls.Add( this.tbDCCLoc );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.btnProjLoc );
            this.Controls.Add( this.tbProjLoc );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.btnCCLoc );
            this.Controls.Add( this.tbCCLoc );
            this.Controls.Add( this.btnProceed );
            this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size( 385, 316 );
            this.MinimumSize = new System.Drawing.Size( 385, 316 );
            this.Name = "VSCCImporter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VS CC Importer by MeowthK";
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox tbCCLoc;
        private System.Windows.Forms.Button btnCCLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProjLoc;
        private System.Windows.Forms.TextBox tbProjLoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDCCLoc;
        private System.Windows.Forms.TextBox tbDCCLoc;
        private System.Windows.Forms.Button btnGotoProjLoc;
    }
}

