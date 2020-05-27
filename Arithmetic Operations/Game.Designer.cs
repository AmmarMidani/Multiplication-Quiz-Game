namespace Arithmetic_Operations
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.tbox_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_second_number = new System.Windows.Forms.Label();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.lbl_first_number = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_result = new System.Windows.Forms.Label();
            this.timer_loop = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox_result
            // 
            this.tbox_result.Font = new System.Drawing.Font("Tahoma", 20F);
            this.tbox_result.Location = new System.Drawing.Point(199, 10);
            this.tbox_result.MaxLength = 3;
            this.tbox_result.Multiline = true;
            this.tbox_result.Name = "tbox_result";
            this.tbox_result.Size = new System.Drawing.Size(96, 43);
            this.tbox_result.TabIndex = 0;
            this.tbox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_result.TextChanged += new System.EventHandler(this.tbox_result_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.Location = new System.Drawing.Point(150, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_second_number
            // 
            this.lbl_second_number.AutoSize = true;
            this.lbl_second_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_second_number.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbl_second_number.Location = new System.Drawing.Point(105, 10);
            this.lbl_second_number.Name = "lbl_second_number";
            this.lbl_second_number.Size = new System.Drawing.Size(2, 43);
            this.lbl_second_number.TabIndex = 3;
            this.lbl_second_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_operation
            // 
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_operation.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbl_operation.Location = new System.Drawing.Point(59, 10);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(40, 43);
            this.lbl_operation.TabIndex = 4;
            this.lbl_operation.Text = "X";
            this.lbl_operation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_first_number
            // 
            this.lbl_first_number.AutoSize = true;
            this.lbl_first_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_first_number.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbl_first_number.Location = new System.Drawing.Point(14, 10);
            this.lbl_first_number.Name = "lbl_first_number";
            this.lbl_first_number.Size = new System.Drawing.Size(2, 43);
            this.lbl_first_number.TabIndex = 5;
            this.lbl_first_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(117, 70);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_result
            // 
            this.btn_result.Enabled = false;
            this.btn_result.Location = new System.Drawing.Point(222, 97);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(75, 23);
            this.btn_result.TabIndex = 7;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(16, 107);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 8;
            // 
            // timer_loop
            // 
            this.timer_loop.Interval = 1000;
            this.timer_loop.Tick += new System.EventHandler(this.timer_loop_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(16, 70);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(0, 13);
            this.lbl_timer.TabIndex = 9;
            // 
            // Game
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 132);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_first_number);
            this.Controls.Add(this.lbl_operation);
            this.Controls.Add(this.lbl_second_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 160);
            this.MinimumSize = new System.Drawing.Size(315, 160);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_second_number;
        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.Label lbl_first_number;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Timer timer_loop;
        private System.Windows.Forms.Label lbl_timer;
    }
}

