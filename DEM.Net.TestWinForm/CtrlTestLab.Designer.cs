﻿namespace DEM.Net.TestWinForm
{
    partial class CtrlTestLab
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
            this.components = new System.ComponentModel.Container();
            this.btn_genererPoints = new System.Windows.Forms.Button();
            this.lb_srid = new System.Windows.Forms.ListBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.tb_NbrePoints = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pointBasGaucheX = new System.Windows.Forms.TextBox();
            this.tb_pointHautDroitX = new System.Windows.Forms.TextBox();
            this.tb_pointBasGaucheY = new System.Windows.Forms.TextBox();
            this.tb_pointHautDroitY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_hauteurMinEnM = new System.Windows.Forms.TextBox();
            this.lb_modeGenerationXY = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_seed = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_recalageMaxY = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_recalageMinY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_recalageMaxX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_recalageMinX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_coeffY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_coeffX = new System.Windows.Forms.TextBox();
            this.lb_modeGenerationZ = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_visualisationSpatialTrace = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_genererPoints
            // 
            this.btn_genererPoints.Location = new System.Drawing.Point(35, 188);
            this.btn_genererPoints.Name = "btn_genererPoints";
            this.btn_genererPoints.Size = new System.Drawing.Size(118, 37);
            this.btn_genererPoints.TabIndex = 0;
            this.btn_genererPoints.Text = "Génerer points";
            this.btn_genererPoints.UseVisualStyleBackColor = true;
            this.btn_genererPoints.Click += new System.EventHandler(this.btn_genererPoints_Click);
            // 
            // lb_srid
            // 
            this.lb_srid.FormattingEnabled = true;
            this.lb_srid.Location = new System.Drawing.Point(37, 117);
            this.lb_srid.Name = "lb_srid";
            this.lb_srid.Size = new System.Drawing.Size(78, 30);
            this.lb_srid.TabIndex = 1;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(34, 101);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(28, 13);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "Srid:";
            // 
            // tb_NbrePoints
            // 
            this.tb_NbrePoints.Location = new System.Drawing.Point(6, 78);
            this.tb_NbrePoints.Name = "tb_NbrePoints";
            this.tb_NbrePoints.Size = new System.Drawing.Size(60, 20);
            this.tb_NbrePoints.TabIndex = 3;
            this.tb_NbrePoints.Text = "1000";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nbre points:";
            // 
            // tb_pointBasGaucheX
            // 
            this.tb_pointBasGaucheX.Location = new System.Drawing.Point(37, 76);
            this.tb_pointBasGaucheX.Name = "tb_pointBasGaucheX";
            this.tb_pointBasGaucheX.Size = new System.Drawing.Size(54, 20);
            this.tb_pointBasGaucheX.TabIndex = 6;
            this.tb_pointBasGaucheX.Text = "800000";
            // 
            // tb_pointHautDroitX
            // 
            this.tb_pointHautDroitX.Location = new System.Drawing.Point(37, 31);
            this.tb_pointHautDroitX.Name = "tb_pointHautDroitX";
            this.tb_pointHautDroitX.Size = new System.Drawing.Size(54, 20);
            this.tb_pointHautDroitX.TabIndex = 7;
            this.tb_pointHautDroitX.Text = "801000";
            // 
            // tb_pointBasGaucheY
            // 
            this.tb_pointBasGaucheY.Location = new System.Drawing.Point(134, 76);
            this.tb_pointBasGaucheY.Name = "tb_pointBasGaucheY";
            this.tb_pointBasGaucheY.Size = new System.Drawing.Size(54, 20);
            this.tb_pointBasGaucheY.TabIndex = 8;
            this.tb_pointBasGaucheY.Text = "6000000";
            // 
            // tb_pointHautDroitY
            // 
            this.tb_pointHautDroitY.Location = new System.Drawing.Point(134, 31);
            this.tb_pointHautDroitY.Name = "tb_pointHautDroitY";
            this.tb_pointHautDroitY.Size = new System.Drawing.Size(54, 20);
            this.tb_pointHautDroitY.TabIndex = 9;
            this.tb_pointHautDroitY.Text = "6001000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Point haut droit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Point bas gauche:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "X:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_pointHautDroitX);
            this.groupBox1.Controls.Add(this.lb_srid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lab1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_pointBasGaucheX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_pointBasGaucheY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_pointHautDroitY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 154);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limite de zone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Altitude de base en m:";
            // 
            // tb_hauteurMinEnM
            // 
            this.tb_hauteurMinEnM.Location = new System.Drawing.Point(118, 85);
            this.tb_hauteurMinEnM.Name = "tb_hauteurMinEnM";
            this.tb_hauteurMinEnM.Size = new System.Drawing.Size(39, 20);
            this.tb_hauteurMinEnM.TabIndex = 16;
            this.tb_hauteurMinEnM.Text = "100";
            // 
            // lb_modeGenerationXY
            // 
            this.lb_modeGenerationXY.FormattingEnabled = true;
            this.lb_modeGenerationXY.Location = new System.Drawing.Point(6, 28);
            this.lb_modeGenerationXY.Name = "lb_modeGenerationXY";
            this.lb_modeGenerationXY.Size = new System.Drawing.Size(152, 30);
            this.lb_modeGenerationXY.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Mode de gérération en X et Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Seed:";
            // 
            // tb_seed
            // 
            this.tb_seed.Location = new System.Drawing.Point(124, 78);
            this.tb_seed.Name = "tb_seed";
            this.tb_seed.Size = new System.Drawing.Size(34, 20);
            this.tb_seed.TabIndex = 24;
            this.tb_seed.Text = "13";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tb_recalageMaxY);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tb_recalageMinY);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_recalageMaxX);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_recalageMinX);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tb_coeffY);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tb_coeffX);
            this.groupBox2.Controls.Add(this.lb_modeGenerationZ);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_hauteurMinEnM);
            this.groupBox2.Location = new System.Drawing.Point(445, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 154);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Détermination des Z";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(253, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Max Y:";
            // 
            // tb_recalageMaxY
            // 
            this.tb_recalageMaxY.Location = new System.Drawing.Point(304, 45);
            this.tb_recalageMaxY.Name = "tb_recalageMaxY";
            this.tb_recalageMaxY.Size = new System.Drawing.Size(26, 20);
            this.tb_recalageMaxY.TabIndex = 38;
            this.tb_recalageMaxY.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(166, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Min Y:";
            // 
            // tb_recalageMinY
            // 
            this.tb_recalageMinY.Location = new System.Drawing.Point(217, 43);
            this.tb_recalageMinY.Name = "tb_recalageMinY";
            this.tb_recalageMinY.Size = new System.Drawing.Size(26, 20);
            this.tb_recalageMinY.TabIndex = 36;
            this.tb_recalageMinY.Text = "-1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Max X:";
            // 
            // tb_recalageMaxX
            // 
            this.tb_recalageMaxX.Location = new System.Drawing.Point(304, 24);
            this.tb_recalageMaxX.Name = "tb_recalageMaxX";
            this.tb_recalageMaxX.Size = new System.Drawing.Size(26, 20);
            this.tb_recalageMaxX.TabIndex = 34;
            this.tb_recalageMaxX.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Min X:";
            // 
            // tb_recalageMinX
            // 
            this.tb_recalageMinX.Location = new System.Drawing.Point(217, 22);
            this.tb_recalageMinX.Name = "tb_recalageMinX";
            this.tb_recalageMinX.Size = new System.Drawing.Size(26, 20);
            this.tb_recalageMinX.TabIndex = 32;
            this.tb_recalageMinX.Text = "-1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(256, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Coeff Y:";
            // 
            // tb_coeffY
            // 
            this.tb_coeffY.Location = new System.Drawing.Point(307, 87);
            this.tb_coeffY.Name = "tb_coeffY";
            this.tb_coeffY.Size = new System.Drawing.Size(26, 20);
            this.tb_coeffY.TabIndex = 30;
            this.tb_coeffY.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(169, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Coeff X:";
            // 
            // tb_coeffX
            // 
            this.tb_coeffX.Location = new System.Drawing.Point(220, 85);
            this.tb_coeffX.Name = "tb_coeffX";
            this.tb_coeffX.Size = new System.Drawing.Size(26, 20);
            this.tb_coeffX.TabIndex = 28;
            this.tb_coeffX.Text = "1";
            // 
            // lb_modeGenerationZ
            // 
            this.lb_modeGenerationZ.FormattingEnabled = true;
            this.lb_modeGenerationZ.Location = new System.Drawing.Point(8, 32);
            this.lb_modeGenerationZ.Name = "lb_modeGenerationZ";
            this.lb_modeGenerationZ.Size = new System.Drawing.Size(152, 43);
            this.lb_modeGenerationZ.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Mode de gérération en Z";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.lb_modeGenerationXY);
            this.groupBox4.Controls.Add(this.tb_NbrePoints);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tb_seed);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(230, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 154);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Détermination XY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Pas de séparation entre points (en m):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "10";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_visualisationSpatialTrace);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btn_genererPoints);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 231);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Génération points tests:";
            // 
            // btn_visualisationSpatialTrace
            // 
            this.btn_visualisationSpatialTrace.Location = new System.Drawing.Point(230, 188);
            this.btn_visualisationSpatialTrace.Name = "btn_visualisationSpatialTrace";
            this.btn_visualisationSpatialTrace.Size = new System.Drawing.Size(118, 37);
            this.btn_visualisationSpatialTrace.TabIndex = 29;
            this.btn_visualisationSpatialTrace.Text = "Visualisation spatialtrace";
            this.btn_visualisationSpatialTrace.UseVisualStyleBackColor = true;
            this.btn_visualisationSpatialTrace.Click += new System.EventHandler(this.btn_visualisationSpatialTrace_Click);
            // 
            // CtrlTestLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "CtrlTestLab";
            this.Size = new System.Drawing.Size(803, 428);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_genererPoints;
        private System.Windows.Forms.ListBox lb_srid;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox tb_NbrePoints;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pointBasGaucheX;
        private System.Windows.Forms.TextBox tb_pointHautDroitX;
        private System.Windows.Forms.TextBox tb_pointBasGaucheY;
        private System.Windows.Forms.TextBox tb_pointHautDroitY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_hauteurMinEnM;
        private System.Windows.Forms.ListBox lb_modeGenerationXY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_seed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_modeGenerationZ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_coeffY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_coeffX;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_recalageMaxY;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_recalageMinY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_recalageMaxX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_recalageMinX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_visualisationSpatialTrace;
    }
}
