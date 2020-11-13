namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(998, 48);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
