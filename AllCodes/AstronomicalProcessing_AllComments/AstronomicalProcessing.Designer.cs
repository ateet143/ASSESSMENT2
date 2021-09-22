
namespace AstronomicalProcessing
{
    partial class AstronomicalProcessing
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
            this.ListBoxHours = new System.Windows.Forms.ListBox();
            this.TextBoxHours = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonModify = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAutofill = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxHours
            // 
            this.ListBoxHours.FormattingEnabled = true;
            this.ListBoxHours.Location = new System.Drawing.Point(167, 69);
            this.ListBoxHours.Name = "ListBoxHours";
            this.ListBoxHours.Size = new System.Drawing.Size(188, 316);
            this.ListBoxHours.TabIndex = 0;
            this.ListBoxHours.Click += new System.EventHandler(this.ListBoxHours_Click);
            // 
            // TextBoxHours
            // 
            this.TextBoxHours.Location = new System.Drawing.Point(167, 424);
            this.TextBoxHours.Name = "TextBoxHours";
            this.TextBoxHours.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHours.TabIndex = 1;
            this.TextBoxHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHours_KeyPress);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(22, 70);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 42);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonModify
            // 
            this.ButtonModify.BackColor = System.Drawing.Color.White;
            this.ButtonModify.Location = new System.Drawing.Point(22, 157);
            this.ButtonModify.Name = "ButtonModify";
            this.ButtonModify.Size = new System.Drawing.Size(75, 42);
            this.ButtonModify.TabIndex = 3;
            this.ButtonModify.Text = "MODIFY";
            this.ButtonModify.UseVisualStyleBackColor = false;
            this.ButtonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(22, 244);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 42);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.BackColor = System.Drawing.Color.White;
            this.ButtonSort.Location = new System.Drawing.Point(22, 329);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(75, 42);
            this.ButtonSort.TabIndex = 5;
            this.ButtonSort.Text = "SORT";
            this.ButtonSort.UseVisualStyleBackColor = false;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type Number";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.White;
            this.ButtonSearch.Location = new System.Drawing.Point(280, 423);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 20);
            this.ButtonSearch.TabIndex = 7;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(99, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ASTRONOMICAL PROCESSING";
            // 
            // ButtonAutofill
            // 
            this.ButtonAutofill.ForeColor = System.Drawing.Color.Green;
            this.ButtonAutofill.Location = new System.Drawing.Point(356, 30);
            this.ButtonAutofill.Name = "ButtonAutofill";
            this.ButtonAutofill.Size = new System.Drawing.Size(75, 23);
            this.ButtonAutofill.TabIndex = 9;
            this.ButtonAutofill.Text = "AutoFill";
            this.ButtonAutofill.UseVisualStyleBackColor = true;
            this.ButtonAutofill.Click += new System.EventHandler(this.ButtonAutofill_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 463);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(456, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Message";
            // 
            // AstronomicalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(456, 485);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ButtonAutofill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonModify);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxHours);
            this.Controls.Add(this.ListBoxHours);
            this.Name = "AstronomicalProcessing";
            this.Text = "AstronomicalProcessing";
            this.Load += new System.EventHandler(this.AstronomicalProcessing_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AstronomicalProcessing_MouseMove);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxHours;
        private System.Windows.Forms.TextBox TextBoxHours;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonModify;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAutofill;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

