namespace TEC.ControlesBase
{
    partial class frm_base_lcunyas
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
            this.ucBoton1 = new TEC.ControlesBase.ucBoton();
            this.SuspendLayout();
            // 
            // ucBoton1
            // 
            this.ucBoton1.Location = new System.Drawing.Point(12, 23);
            this.ucBoton1.Name = "ucBoton1";
            this.ucBoton1.Size = new System.Drawing.Size(31, 30);
            this.ucBoton1.TabIndex = 0;
            this.ucBoton1.Text = "ucBoton1";
            this.ucBoton1.UseVisualStyleBackColor = true;
            // 
            // frm_base_lcunyas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ucBoton1);
            this.Name = "frm_base_lcunyas";
            this.Text = "frm_base_lcunyas";
            this.ResumeLayout(false);

        }

        #endregion

        private ucBoton ucBoton1;
    }
}