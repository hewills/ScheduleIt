namespace ScheduleIt
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.bAbout = new System.Windows.Forms.Button();
            this.bRooms = new System.Windows.Forms.Button();
            this.bClasses = new System.Windows.Forms.Button();
            this.bInstructors = new System.Windows.Forms.Button();
            this.bBuild = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bxView = new System.Windows.Forms.GroupBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAbout
            // 
            this.bAbout.Location = new System.Drawing.Point(21, 340);
            this.bAbout.Name = "BAbout";
            this.bAbout.Size = new System.Drawing.Size(143, 33);
            this.bAbout.TabIndex = 0;
            this.bAbout.Text = "About";
            this.bAbout.UseVisualStyleBackColor = true;
            this.bAbout.Click += new System.EventHandler(this.BAbout_Click);
            // 
            // bRooms
            // 
            this.bRooms.Location = new System.Drawing.Point(9, 26);
            this.bRooms.Name = "BRooms";
            this.bRooms.Size = new System.Drawing.Size(143, 41);
            this.bRooms.TabIndex = 1;
            this.bRooms.Text = "Rooms";
            this.bRooms.UseVisualStyleBackColor = true;
            this.bRooms.Click += new System.EventHandler(this.BRooms_Click);
            // 
            // bClasses
            // 
            this.bClasses.Location = new System.Drawing.Point(9, 85);
            this.bClasses.Name = "BClasses";
            this.bClasses.Size = new System.Drawing.Size(143, 41);
            this.bClasses.TabIndex = 2;
            this.bClasses.Text = "Classes";
            this.bClasses.UseVisualStyleBackColor = true;
            this.bClasses.Click += new System.EventHandler(this.BClasses_Click);
            // 
            // bInstructors
            // 
            this.bInstructors.Location = new System.Drawing.Point(9, 144);
            this.bInstructors.Name = "BInstructors";
            this.bInstructors.Size = new System.Drawing.Size(143, 41);
            this.bInstructors.TabIndex = 3;
            this.bInstructors.Text = "Instructors";
            this.bInstructors.UseVisualStyleBackColor = true;
            this.bInstructors.Click += new System.EventHandler(this.BInstructors_Click);
            // 
            // bBuild
            // 
            this.bBuild.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuild.Location = new System.Drawing.Point(232, 52);
            this.bBuild.Name = "bBuild";
            this.bBuild.Size = new System.Drawing.Size(143, 70);
            this.bBuild.TabIndex = 5;
            this.bBuild.Text = "Build!";
            this.bBuild.UseVisualStyleBackColor = false;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(232, 204);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(143, 41);
            this.bLoad.TabIndex = 6;
            this.bLoad.Text = "Load Schedule";
            this.bLoad.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(232, 261);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(143, 41);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Save Schedule";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bxView
            // 
            this.bxView.Controls.Add(this.bInstructors);
            this.bxView.Controls.Add(this.bClasses);
            this.bxView.Controls.Add(this.bRooms);
            this.bxView.Location = new System.Drawing.Point(12, 26);
            this.bxView.Name = "bxView";
            this.bxView.Size = new System.Drawing.Size(169, 206);
            this.bxView.TabIndex = 8;
            this.bxView.TabStop = false;
            this.bxView.Text = "VIEW/MODIFY";
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(232, 320);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(143, 41);
            this.bPrint.TabIndex = 9;
            this.bPrint.Text = "Print Schedule";
            this.bPrint.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(21, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 98);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bxView);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bBuild);
            this.Controls.Add(this.bAbout);
            this.Name = "formMain";
            this.Text = "Scheduler";
            this.bxView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAbout;
        private System.Windows.Forms.Button bRooms;
        private System.Windows.Forms.Button bClasses;
        private System.Windows.Forms.Button bInstructors;
        private System.Windows.Forms.Button bBuild;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.GroupBox bxView;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

