﻿namespace WinDEPT
{
    partial class FrmDept
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpListe = new System.Windows.Forms.TabPage();
            this.gbInfos = new System.Windows.Forms.GroupBox();
            this.txtInfoNom = new System.Windows.Forms.TextBox();
            this.txtInfoNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listDept = new System.Windows.Forms.ListBox();
            this.tbpCreation = new System.Windows.Forms.TabPage();
            this.btnValider = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcPrincipal.SuspendLayout();
            this.tbpListe.SuspendLayout();
            this.gbInfos.SuspendLayout();
            this.tbpCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpListe);
            this.tbcPrincipal.Controls.Add(this.tbpCreation);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(433, 312);
            this.tbcPrincipal.TabIndex = 0;
            this.tbcPrincipal.SelectedIndexChanged += new System.EventHandler(this.tbcPrincipal_SelectedIndexChanged);
            // 
            // tbpListe
            // 
            this.tbpListe.Controls.Add(this.gbInfos);
            this.tbpListe.Controls.Add(this.label8);
            this.tbpListe.Controls.Add(this.listDept);
            this.tbpListe.Location = new System.Drawing.Point(4, 22);
            this.tbpListe.Name = "tbpListe";
            this.tbpListe.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListe.Size = new System.Drawing.Size(425, 286);
            this.tbpListe.TabIndex = 0;
            this.tbpListe.Text = "LISTE DEPARTEMENTS";
            this.tbpListe.UseVisualStyleBackColor = true;
            // 
            // gbInfos
            // 
            this.gbInfos.Controls.Add(this.txtInfoNom);
            this.gbInfos.Controls.Add(this.txtInfoNumero);
            this.gbInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfos.Location = new System.Drawing.Point(186, 53);
            this.gbInfos.Name = "gbInfos";
            this.gbInfos.Size = new System.Drawing.Size(231, 179);
            this.gbInfos.TabIndex = 2;
            this.gbInfos.TabStop = false;
            this.gbInfos.Text = "Informations";
            // 
            // txtInfoNom
            // 
            this.txtInfoNom.Location = new System.Drawing.Point(46, 33);
            this.txtInfoNom.Name = "txtInfoNom";
            this.txtInfoNom.ReadOnly = true;
            this.txtInfoNom.Size = new System.Drawing.Size(179, 23);
            this.txtInfoNom.TabIndex = 1;
            // 
            // txtInfoNumero
            // 
            this.txtInfoNumero.Location = new System.Drawing.Point(6, 33);
            this.txtInfoNumero.Name = "txtInfoNumero";
            this.txtInfoNumero.ReadOnly = true;
            this.txtInfoNumero.Size = new System.Drawing.Size(34, 23);
            this.txtInfoNumero.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Choisir un département :";
            // 
            // listDept
            // 
            this.listDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDept.FormattingEnabled = true;
            this.listDept.ItemHeight = 15;
            this.listDept.Location = new System.Drawing.Point(21, 48);
            this.listDept.Name = "listDept";
            this.listDept.Size = new System.Drawing.Size(145, 184);
            this.listDept.TabIndex = 0;
            this.listDept.SelectedIndexChanged += new System.EventHandler(this.listDept_SelectedIndexChanged);
            // 
            // tbpCreation
            // 
            this.tbpCreation.Controls.Add(this.btnValider);
            this.tbpCreation.Controls.Add(this.label7);
            this.tbpCreation.Controls.Add(this.label6);
            this.tbpCreation.Controls.Add(this.txtRegion);
            this.tbpCreation.Controls.Add(this.label5);
            this.tbpCreation.Controls.Add(this.txtSuperficie);
            this.tbpCreation.Controls.Add(this.txtPopulation);
            this.tbpCreation.Controls.Add(this.txtNom);
            this.tbpCreation.Controls.Add(this.txtNumero);
            this.tbpCreation.Controls.Add(this.label4);
            this.tbpCreation.Controls.Add(this.label3);
            this.tbpCreation.Controls.Add(this.label2);
            this.tbpCreation.Controls.Add(this.label1);
            this.tbpCreation.Location = new System.Drawing.Point(4, 22);
            this.tbpCreation.Name = "tbpCreation";
            this.tbpCreation.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreation.Size = new System.Drawing.Size(425, 286);
            this.tbpCreation.TabIndex = 1;
            this.tbpCreation.Text = "NOUVEAU DEPARTEMENT";
            this.tbpCreation.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(257, 235);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(80, 29);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(178, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "en km²";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "en milliers d\'habitants";
            // 
            // txtRegion
            // 
            this.txtRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.Location = new System.Drawing.Point(93, 193);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(244, 21);
            this.txtRegion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Région";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuperficie.Location = new System.Drawing.Point(96, 149);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(73, 21);
            this.txtSuperficie.TabIndex = 7;
            // 
            // txtPopulation
            // 
            this.txtPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopulation.Location = new System.Drawing.Point(96, 108);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(73, 21);
            this.txtPopulation.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(96, 69);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(241, 21);
            this.txtNom.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(96, 31);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(49, 21);
            this.txtNumero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Superficie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // FrmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 312);
            this.Controls.Add(this.tbcPrincipal);
            this.Name = "FrmDept";
            this.Text = "APPLICATION WinDEPT";
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpListe.ResumeLayout(false);
            this.tbpListe.PerformLayout();
            this.gbInfos.ResumeLayout(false);
            this.gbInfos.PerformLayout();
            this.tbpCreation.ResumeLayout(false);
            this.tbpCreation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpListe;
        private System.Windows.Forms.TabPage tbpCreation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gbInfos;
        private System.Windows.Forms.TextBox txtInfoNom;
        private System.Windows.Forms.TextBox txtInfoNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listDept;
    }
}

