namespace Yaffle
{
    partial class frmYaffle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYaffle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeriesName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.txtBaseEpisode = new System.Windows.Forms.TextBox();
            this.lvwOutput = new System.Windows.Forms.ListView();
            this.clmSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOutput = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRename = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drop files in here!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Series Name:";
            // 
            // txtSeriesName
            // 
            this.txtSeriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeriesName.Location = new System.Drawing.Point(142, 24);
            this.txtSeriesName.Name = "txtSeriesName";
            this.txtSeriesName.Size = new System.Drawing.Size(315, 29);
            this.txtSeriesName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Season:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Base Episode:";
            // 
            // txtSeason
            // 
            this.txtSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeason.Location = new System.Drawing.Point(548, 24);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(42, 29);
            this.txtSeason.TabIndex = 6;
            this.txtSeason.Text = "1";
            // 
            // txtBaseEpisode
            // 
            this.txtBaseEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseEpisode.Location = new System.Drawing.Point(734, 24);
            this.txtBaseEpisode.Name = "txtBaseEpisode";
            this.txtBaseEpisode.Size = new System.Drawing.Size(42, 29);
            this.txtBaseEpisode.TabIndex = 7;
            this.txtBaseEpisode.Text = "1";
            // 
            // lvwOutput
            // 
            this.lvwOutput.AllowDrop = true;
            this.lvwOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSource,
            this.clmOutput});
            this.lvwOutput.Location = new System.Drawing.Point(16, 110);
            this.lvwOutput.Name = "lvwOutput";
            this.lvwOutput.Size = new System.Drawing.Size(767, 279);
            this.lvwOutput.TabIndex = 8;
            this.lvwOutput.UseCompatibleStateImageBehavior = false;
            this.lvwOutput.View = System.Windows.Forms.View.Details;
            this.lvwOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvwOutput_DragDrop);
            this.lvwOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvwOutput_DragEnter);
            // 
            // clmSource
            // 
            this.clmSource.Text = "Source File";
            this.clmSource.Width = 534;
            // 
            // clmOutput
            // 
            this.clmOutput.Text = "Output";
            this.clmOutput.Width = 229;
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Location = new System.Drawing.Point(531, 395);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(252, 52);
            this.btnRename.TabIndex = 10;
            this.btnRename.Text = "Rename!";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(16, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(252, 52);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmYaffle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 452);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.lvwOutput);
            this.Controls.Add(this.txtBaseEpisode);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSeriesName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmYaffle";
            this.Text = "Yaffle!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeriesName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.TextBox txtBaseEpisode;
        private System.Windows.Forms.ListView lvwOutput;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ColumnHeader clmSource;
        private System.Windows.Forms.ColumnHeader clmOutput;
    }
}

