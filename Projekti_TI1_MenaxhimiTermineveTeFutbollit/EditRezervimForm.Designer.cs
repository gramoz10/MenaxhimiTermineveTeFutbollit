namespace Projekti_TI1_MenaxhimiTermineveTeFutbollit
{
    partial class EditRezervimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRezervimForm));
            this.dtMbarimiRezervimit = new System.Windows.Forms.DateTimePicker();
            this.btnEdito = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.lblShowR = new Telerik.WinControls.UI.RadLabel();
            this.btnHelp = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblShowR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMbarimiRezervimit
            // 
            this.dtMbarimiRezervimit.CustomFormat = "MM/dd/yyyy | HH:mm:ss";
            this.dtMbarimiRezervimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMbarimiRezervimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMbarimiRezervimit.Location = new System.Drawing.Point(266, 142);
            this.dtMbarimiRezervimit.Name = "dtMbarimiRezervimit";
            this.dtMbarimiRezervimit.Size = new System.Drawing.Size(304, 26);
            this.dtMbarimiRezervimit.TabIndex = 43;
            this.dtMbarimiRezervimit.Value = new System.DateTime(2018, 6, 16, 15, 45, 31, 0);
            // 
            // btnEdito
            // 
            this.btnEdito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdito.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnEdito.Location = new System.Drawing.Point(266, 223);
            this.btnEdito.Name = "btnEdito";
            this.btnEdito.Size = new System.Drawing.Size(304, 47);
            this.btnEdito.TabIndex = 41;
            this.btnEdito.Text = "Edito Rezervimin";
            this.btnEdito.Click += new System.EventHandler(this.btnEdito_Click);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabel5.Location = new System.Drawing.Point(83, 139);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(100, 27);
            this.radLabel5.TabIndex = 39;
            this.radLabel5.Text = "Kohezgjatja";
            // 
            // lblShowR
            // 
            this.lblShowR.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblShowR.Location = new System.Drawing.Point(83, 29);
            this.lblShowR.Name = "lblShowR";
            this.lblShowR.Size = new System.Drawing.Size(111, 27);
            this.lblShowR.TabIndex = 44;
            this.lblShowR.Text = "RezervimiID: ";
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnHelp.Location = new System.Drawing.Point(596, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(48, 46);
            this.btnHelp.TabIndex = 32;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // EditRezervimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(656, 363);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblShowR);
            this.Controls.Add(this.dtMbarimiRezervimit);
            this.Controls.Add(this.btnEdito);
            this.Controls.Add(this.radLabel5);
            this.MaximizeBox = false;
            this.Name = "EditRezervimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRezervimForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnEdito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblShowR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtMbarimiRezervimit;
        private Telerik.WinControls.UI.RadButton btnEdito;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel lblShowR;
        private Telerik.WinControls.UI.RadButton btnHelp;
    }
}