
namespace Projeto_Web
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DropdownMenu = new System.Windows.Forms.ComboBox();
            this.Filmesbtn = new System.Windows.Forms.Button();
            this.Seriesbtn = new System.Windows.Forms.Button();
            this.Animebtn = new System.Windows.Forms.Button();
            this.Solicitacoesbtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.Solicitacoesbtn);
            this.panel2.Controls.Add(this.Animebtn);
            this.panel2.Controls.Add(this.Seriesbtn);
            this.panel2.Controls.Add(this.Filmesbtn);
            this.panel2.Controls.Add(this.DropdownMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 411);
            this.panel2.TabIndex = 1;
            // 
            // DropdownMenu
            // 
            this.DropdownMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.DropdownMenu.FormattingEnabled = true;
            this.DropdownMenu.Location = new System.Drawing.Point(0, 0);
            this.DropdownMenu.Name = "DropdownMenu";
            this.DropdownMenu.Size = new System.Drawing.Size(154, 23);
            this.DropdownMenu.TabIndex = 2;
            // 
            // Filmesbtn
            // 
            this.Filmesbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filmesbtn.Location = new System.Drawing.Point(0, 23);
            this.Filmesbtn.Name = "Filmesbtn";
            this.Filmesbtn.Size = new System.Drawing.Size(154, 41);
            this.Filmesbtn.TabIndex = 3;
            this.Filmesbtn.Text = "Filmes";
            this.Filmesbtn.UseVisualStyleBackColor = true;
            // 
            // Seriesbtn
            // 
            this.Seriesbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Seriesbtn.Location = new System.Drawing.Point(0, 64);
            this.Seriesbtn.Name = "Seriesbtn";
            this.Seriesbtn.Size = new System.Drawing.Size(154, 41);
            this.Seriesbtn.TabIndex = 4;
            this.Seriesbtn.Text = "Séries";
            this.Seriesbtn.UseVisualStyleBackColor = true;
            // 
            // Animebtn
            // 
            this.Animebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Animebtn.Location = new System.Drawing.Point(0, 105);
            this.Animebtn.Name = "Animebtn";
            this.Animebtn.Size = new System.Drawing.Size(154, 41);
            this.Animebtn.TabIndex = 5;
            this.Animebtn.Text = "Animes";
            this.Animebtn.UseVisualStyleBackColor = true;
            // 
            // Solicitacoesbtn
            // 
            this.Solicitacoesbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Solicitacoesbtn.Location = new System.Drawing.Point(0, 370);
            this.Solicitacoesbtn.Name = "Solicitacoesbtn";
            this.Solicitacoesbtn.Size = new System.Drawing.Size(154, 41);
            this.Solicitacoesbtn.TabIndex = 6;
            this.Solicitacoesbtn.Text = "Solicitações";
            this.Solicitacoesbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Solicitacoesbtn;
        private System.Windows.Forms.Button Animebtn;
        private System.Windows.Forms.Button Seriesbtn;
        private System.Windows.Forms.Button Filmesbtn;
        private System.Windows.Forms.ComboBox DropdownMenu;
    }
}

