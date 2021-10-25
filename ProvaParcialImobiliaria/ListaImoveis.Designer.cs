
namespace ProvaParcialImobiliaria
{
    partial class ListaImoveis
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
            this.listImoveis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listImoveis
            // 
            this.listImoveis.FormattingEnabled = true;
            this.listImoveis.ItemHeight = 25;
            this.listImoveis.Location = new System.Drawing.Point(34, 34);
            this.listImoveis.Name = "listImoveis";
            this.listImoveis.Size = new System.Drawing.Size(613, 379);
            this.listImoveis.TabIndex = 0;
            this.listImoveis.SelectedIndexChanged += new System.EventHandler(this.ListaImoveis_Load);
            // 
            // ListaImoveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 470);
            this.Controls.Add(this.listImoveis);
            this.Name = "ListaImoveis";
            this.Text = "ListaImoveis";
            this.Load += new System.EventHandler(this.ListaImoveis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listImoveis;
    }
}