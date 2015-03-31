namespace SLAM5_SCNF.SNCF.Vue
{
    partial class Vue_inscription
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_num_session = new System.Windows.Forms.TextBox();
            this.txt_activite_session = new System.Windows.Forms.TextBox();
            this.txt_action_session = new System.Windows.Forms.TextBox();
            this.txt_date_session = new System.Windows.Forms.TextBox();
            this.txt_lieu_session = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ok_session = new System.Windows.Forms.Button();
            this.txt_nb_max_participant_effectif = new System.Windows.Forms.TextBox();
            this.txt_nb_inscrit_effectif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_agent = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox_inscrit = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_ajouter_aux_inscrits = new System.Windows.Forms.Button();
            this.btn_supprimer_des_inscrits = new System.Windows.Forms.Button();
            this.bnt_imprimer_liste_emargement = new System.Windows.Forms.Button();
            this.btn_imprimer_convocation = new System.Windows.Forms.Button();
            this.btn_imprimer_toutes_convocations = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ok_session);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_lieu_session);
            this.groupBox1.Controls.Add(this.txt_date_session);
            this.groupBox1.Controls.Add(this.txt_action_session);
            this.groupBox1.Controls.Add(this.txt_activite_session);
            this.groupBox1.Controls.Add(this.txt_num_session);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche session";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_nb_inscrit_effectif);
            this.groupBox2.Controls.Add(this.txt_nb_max_participant_effectif);
            this.groupBox2.Location = new System.Drawing.Point(33, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Effectif";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_imprimer_toutes_convocations);
            this.groupBox3.Controls.Add(this.btn_imprimer_convocation);
            this.groupBox3.Controls.Add(this.bnt_imprimer_liste_emargement);
            this.groupBox3.Controls.Add(this.btn_supprimer_des_inscrits);
            this.groupBox3.Controls.Add(this.btn_ajouter_aux_inscrits);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.listBox_inscrit);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.listBox_agent);
            this.groupBox3.Location = new System.Drawing.Point(33, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selection des participants à la session";
            // 
            // txt_num_session
            // 
            this.txt_num_session.Location = new System.Drawing.Point(73, 35);
            this.txt_num_session.Name = "txt_num_session";
            this.txt_num_session.Size = new System.Drawing.Size(100, 20);
            this.txt_num_session.TabIndex = 0;
            // 
            // txt_activite_session
            // 
            this.txt_activite_session.Location = new System.Drawing.Point(73, 61);
            this.txt_activite_session.Name = "txt_activite_session";
            this.txt_activite_session.Size = new System.Drawing.Size(427, 20);
            this.txt_activite_session.TabIndex = 1;
            // 
            // txt_action_session
            // 
            this.txt_action_session.Location = new System.Drawing.Point(73, 87);
            this.txt_action_session.Name = "txt_action_session";
            this.txt_action_session.Size = new System.Drawing.Size(427, 20);
            this.txt_action_session.TabIndex = 2;
            // 
            // txt_date_session
            // 
            this.txt_date_session.Location = new System.Drawing.Point(73, 113);
            this.txt_date_session.Name = "txt_date_session";
            this.txt_date_session.Size = new System.Drawing.Size(100, 20);
            this.txt_date_session.TabIndex = 3;
            // 
            // txt_lieu_session
            // 
            this.txt_lieu_session.Location = new System.Drawing.Point(232, 113);
            this.txt_lieu_session.Name = "txt_lieu_session";
            this.txt_lieu_session.Size = new System.Drawing.Size(268, 20);
            this.txt_lieu_session.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° session :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Activité :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Action : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lieu :";
            // 
            // btn_ok_session
            // 
            this.btn_ok_session.Location = new System.Drawing.Point(182, 33);
            this.btn_ok_session.Name = "btn_ok_session";
            this.btn_ok_session.Size = new System.Drawing.Size(57, 23);
            this.btn_ok_session.TabIndex = 10;
            this.btn_ok_session.Text = "Ok";
            this.btn_ok_session.UseVisualStyleBackColor = true;
            // 
            // txt_nb_max_participant_effectif
            // 
            this.txt_nb_max_participant_effectif.Location = new System.Drawing.Point(147, 21);
            this.txt_nb_max_participant_effectif.Name = "txt_nb_max_participant_effectif";
            this.txt_nb_max_participant_effectif.Size = new System.Drawing.Size(57, 20);
            this.txt_nb_max_participant_effectif.TabIndex = 0;
            // 
            // txt_nb_inscrit_effectif
            // 
            this.txt_nb_inscrit_effectif.Location = new System.Drawing.Point(323, 21);
            this.txt_nb_inscrit_effectif.Name = "txt_nb_inscrit_effectif";
            this.txt_nb_inscrit_effectif.Size = new System.Drawing.Size(53, 20);
            this.txt_nb_inscrit_effectif.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre max participants :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre d\'inscrits :";
            // 
            // listBox_agent
            // 
            this.listBox_agent.FormattingEnabled = true;
            this.listBox_agent.Location = new System.Drawing.Point(21, 42);
            this.listBox_agent.Name = "listBox_agent";
            this.listBox_agent.Size = new System.Drawing.Size(191, 186);
            this.listBox_agent.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Agents";
            // 
            // listBox_inscrit
            // 
            this.listBox_inscrit.FormattingEnabled = true;
            this.listBox_inscrit.Location = new System.Drawing.Point(291, 42);
            this.listBox_inscrit.Name = "listBox_inscrit";
            this.listBox_inscrit.Size = new System.Drawing.Size(191, 186);
            this.listBox_inscrit.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Inscrits";
            // 
            // btn_ajouter_aux_inscrits
            // 
            this.btn_ajouter_aux_inscrits.Location = new System.Drawing.Point(232, 97);
            this.btn_ajouter_aux_inscrits.Name = "btn_ajouter_aux_inscrits";
            this.btn_ajouter_aux_inscrits.Size = new System.Drawing.Size(35, 23);
            this.btn_ajouter_aux_inscrits.TabIndex = 4;
            this.btn_ajouter_aux_inscrits.Text = ">";
            this.btn_ajouter_aux_inscrits.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer_des_inscrits
            // 
            this.btn_supprimer_des_inscrits.Location = new System.Drawing.Point(232, 126);
            this.btn_supprimer_des_inscrits.Name = "btn_supprimer_des_inscrits";
            this.btn_supprimer_des_inscrits.Size = new System.Drawing.Size(35, 23);
            this.btn_supprimer_des_inscrits.TabIndex = 5;
            this.btn_supprimer_des_inscrits.Text = "<";
            this.btn_supprimer_des_inscrits.UseVisualStyleBackColor = true;
            // 
            // bnt_imprimer_liste_emargement
            // 
            this.bnt_imprimer_liste_emargement.Location = new System.Drawing.Point(523, 44);
            this.bnt_imprimer_liste_emargement.Name = "bnt_imprimer_liste_emargement";
            this.bnt_imprimer_liste_emargement.Size = new System.Drawing.Size(96, 46);
            this.bnt_imprimer_liste_emargement.TabIndex = 6;
            this.bnt_imprimer_liste_emargement.Text = "Imprimer liste emargements";
            this.bnt_imprimer_liste_emargement.UseVisualStyleBackColor = true;
            // 
            // btn_imprimer_convocation
            // 
            this.btn_imprimer_convocation.Location = new System.Drawing.Point(523, 106);
            this.btn_imprimer_convocation.Name = "btn_imprimer_convocation";
            this.btn_imprimer_convocation.Size = new System.Drawing.Size(96, 43);
            this.btn_imprimer_convocation.TabIndex = 7;
            this.btn_imprimer_convocation.Text = "Imprimer une covocation";
            this.btn_imprimer_convocation.UseVisualStyleBackColor = true;
            // 
            // btn_imprimer_toutes_convocations
            // 
            this.btn_imprimer_toutes_convocations.Location = new System.Drawing.Point(523, 164);
            this.btn_imprimer_toutes_convocations.Name = "btn_imprimer_toutes_convocations";
            this.btn_imprimer_toutes_convocations.Size = new System.Drawing.Size(96, 55);
            this.btn_imprimer_toutes_convocations.TabIndex = 8;
            this.btn_imprimer_toutes_convocations.Text = "Imprimer toutes les convocations";
            this.btn_imprimer_toutes_convocations.UseVisualStyleBackColor = true;
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(603, 515);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(96, 23);
            this.btn_quitter.TabIndex = 3;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            // 
            // Vue_inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 550);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vue_inscription";
            this.Text = "Enregistrement des inscriptions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lieu_session;
        private System.Windows.Forms.TextBox txt_date_session;
        private System.Windows.Forms.TextBox txt_action_session;
        private System.Windows.Forms.TextBox txt_activite_session;
        private System.Windows.Forms.TextBox txt_num_session;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ok_session;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nb_inscrit_effectif;
        private System.Windows.Forms.TextBox txt_nb_max_participant_effectif;
        private System.Windows.Forms.ListBox listBox_agent;
        private System.Windows.Forms.Button btn_imprimer_toutes_convocations;
        private System.Windows.Forms.Button btn_imprimer_convocation;
        private System.Windows.Forms.Button bnt_imprimer_liste_emargement;
        private System.Windows.Forms.Button btn_supprimer_des_inscrits;
        private System.Windows.Forms.Button btn_ajouter_aux_inscrits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox_inscrit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_quitter;
    }
}