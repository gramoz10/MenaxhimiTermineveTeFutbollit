namespace Projekti_TI1_MenaxhimiTermineveTeFutbollit
{
    partial class AddRezervimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRezervimForm));
            this.btnShto = new Telerik.WinControls.UI.RadButton();
            this.dtDataeRezervimit = new System.Windows.Forms.DateTimePicker();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.cmbKlientat = new System.Windows.Forms.ComboBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.cmbFushat = new System.Windows.Forms.ComboBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtMbarimiRezervimit = new System.Windows.Forms.DateTimePicker();
            this.dtFillimiRezervimit = new System.Windows.Forms.DateTimePicker();
            this.btnHelp = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnShto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShto
            // 
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnShto.Location = new System.Drawing.Point(195, 303);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(304, 47);
            this.btnShto.TabIndex = 25;
            this.btnShto.Text = "Shto Rezervim";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // dtDataeRezervimit
            // 
            this.dtDataeRezervimit.CustomFormat = "MM/dd/yyyy | HH:mm:ss";
            this.dtDataeRezervimit.Enabled = false;
            this.dtDataeRezervimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataeRezervimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataeRezervimit.Location = new System.Drawing.Point(195, 159);
            this.dtDataeRezervimit.MinDate = new System.DateTime(2018, 5, 2, 0, 0, 0, 0);
            this.dtDataeRezervimit.Name = "dtDataeRezervimit";
            this.dtDataeRezervimit.Size = new System.Drawing.Size(304, 26);
            this.dtDataeRezervimit.TabIndex = 23;
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabel7.Location = new System.Drawing.Point(12, 153);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(142, 27);
            this.radLabel7.TabIndex = 16;
            this.radLabel7.Text = "Data e rezervimit";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabel4.Location = new System.Drawing.Point(12, 186);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(146, 27);
            this.radLabel4.TabIndex = 16;
            this.radLabel4.Text = "Fillimi i rezervimit";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabel5.Location = new System.Drawing.Point(12, 219);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(166, 27);
            this.radLabel5.TabIndex = 16;
            this.radLabel5.Text = "Mbarimi i rezervimit";
            // 
            // cmbKlientat
            // 
            this.cmbKlientat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKlientat.FormattingEnabled = true;
            this.cmbKlientat.Location = new System.Drawing.Point(195, 123);
            this.cmbKlientat.Name = "cmbKlientat";
            this.cmbKlientat.Size = new System.Drawing.Size(304, 26);
            this.cmbKlientat.TabIndex = 27;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabel6.Location = new System.Drawing.Point(12, 120);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(57, 27);
            this.radLabel6.TabIndex = 26;
            this.radLabel6.Text = "Klienti";
            // 
            // cmbFushat
            // 
            this.cmbFushat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFushat.FormattingEnabled = true;
            this.cmbFushat.Location = new System.Drawing.Point(195, 90);
            this.cmbFushat.Name = "cmbFushat";
            this.cmbFushat.Size = new System.Drawing.Size(304, 26);
            this.cmbFushat.TabIndex = 29;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabel1.Location = new System.Drawing.Point(12, 87);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 27);
            this.radLabel1.TabIndex = 28;
            this.radLabel1.Text = "Fusha";
            // 
            // cmbUsers
            // 
            this.cmbUsers.Enabled = false;
            this.cmbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(195, 57);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(304, 26);
            this.cmbUsers.TabIndex = 31;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabel2.Location = new System.Drawing.Point(12, 54);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(44, 27);
            this.radLabel2.TabIndex = 30;
            this.radLabel2.Text = "User";
            // 
            // dtMbarimiRezervimit
            // 
            this.dtMbarimiRezervimit.CustomFormat = "MM/dd/yyyy | HH:mm:ss";
            this.dtMbarimiRezervimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMbarimiRezervimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMbarimiRezervimit.Location = new System.Drawing.Point(195, 222);
            this.dtMbarimiRezervimit.Name = "dtMbarimiRezervimit";
            this.dtMbarimiRezervimit.Size = new System.Drawing.Size(304, 26);
            this.dtMbarimiRezervimit.TabIndex = 33;
            this.dtMbarimiRezervimit.Value = new System.DateTime(2018, 6, 16, 15, 45, 31, 0);
            // 
            // dtFillimiRezervimit
            // 
            this.dtFillimiRezervimit.CustomFormat = "MM/dd/yyyy | HH:mm:ss";
            this.dtFillimiRezervimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFillimiRezervimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFillimiRezervimit.Location = new System.Drawing.Point(195, 191);
            this.dtFillimiRezervimit.Name = "dtFillimiRezervimit";
            this.dtFillimiRezervimit.Size = new System.Drawing.Size(304, 26);
            this.dtFillimiRezervimit.TabIndex = 33;
            this.dtFillimiRezervimit.Value = new System.DateTime(2018, 6, 16, 15, 45, 27, 0);
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnHelp.Location = new System.Drawing.Point(580, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(48, 46);
            this.btnHelp.TabIndex = 34;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // AddRezervimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 404);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.dtFillimiRezervimit);
            this.Controls.Add(this.dtMbarimiRezervimit);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.cmbFushat);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.cmbKlientat);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.dtDataeRezervimit);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddRezervimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRezervimForm";
            this.Load += new System.EventHandler(this.AddRezervimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnShto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnShto;
        private System.Windows.Forms.DateTimePicker dtDataeRezervimit;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.ComboBox cmbKlientat;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private System.Windows.Forms.ComboBox cmbFushat;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.ComboBox cmbUsers;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.DateTimePicker dtMbarimiRezervimit;
        private System.Windows.Forms.DateTimePicker dtFillimiRezervimit;
        private Telerik.WinControls.UI.RadButton btnHelp;
    }
}