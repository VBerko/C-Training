namespace HW01_1._1
{
    partial class Form1
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
            this.byte_ = new System.Windows.Forms.Button();
            this.short_ = new System.Windows.Forms.Button();
            this.ulong_ = new System.Windows.Forms.Button();
            this.uint_ = new System.Windows.Forms.Button();
            this.long_ = new System.Windows.Forms.Button();
            this.sbyte_ = new System.Windows.Forms.Button();
            this.ushort_ = new System.Windows.Forms.Button();
            this.int_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // byte_
            // 
            this.byte_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byte_.Location = new System.Drawing.Point(105, 77);
            this.byte_.Name = "byte_";
            this.byte_.Size = new System.Drawing.Size(307, 73);
            this.byte_.TabIndex = 0;
            this.byte_.Text = "BYTE";
            this.byte_.UseVisualStyleBackColor = true;
            this.byte_.Click += new System.EventHandler(this.byte__Click);
            // 
            // short_
            // 
            this.short_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.short_.Location = new System.Drawing.Point(542, 77);
            this.short_.Name = "short_";
            this.short_.Size = new System.Drawing.Size(307, 73);
            this.short_.TabIndex = 1;
            this.short_.Text = "SHORT";
            this.short_.UseVisualStyleBackColor = true;
            this.short_.Click += new System.EventHandler(this.short__Click);
            // 
            // ulong_
            // 
            this.ulong_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulong_.Location = new System.Drawing.Point(542, 443);
            this.ulong_.Name = "ulong_";
            this.ulong_.Size = new System.Drawing.Size(307, 78);
            this.ulong_.TabIndex = 2;
            this.ulong_.Text = "ULONG";
            this.ulong_.UseVisualStyleBackColor = true;
            this.ulong_.Click += new System.EventHandler(this.ulong__Click);
            // 
            // uint_
            // 
            this.uint_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uint_.Location = new System.Drawing.Point(105, 443);
            this.uint_.Name = "uint_";
            this.uint_.Size = new System.Drawing.Size(307, 73);
            this.uint_.TabIndex = 3;
            this.uint_.Text = "UINT";
            this.uint_.UseVisualStyleBackColor = true;
            this.uint_.Click += new System.EventHandler(this.uint__Click);
            // 
            // long_
            // 
            this.long_.BackColor = System.Drawing.SystemColors.Control;
            this.long_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long_.Location = new System.Drawing.Point(542, 324);
            this.long_.Name = "long_";
            this.long_.Size = new System.Drawing.Size(307, 73);
            this.long_.TabIndex = 4;
            this.long_.Text = "LONG";
            this.long_.UseVisualStyleBackColor = false;
            this.long_.Click += new System.EventHandler(this.long__Click);
            // 
            // sbyte_
            // 
            this.sbyte_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbyte_.Location = new System.Drawing.Point(105, 197);
            this.sbyte_.Name = "sbyte_";
            this.sbyte_.Size = new System.Drawing.Size(307, 73);
            this.sbyte_.TabIndex = 5;
            this.sbyte_.Text = "SBYTE";
            this.sbyte_.UseVisualStyleBackColor = true;
            this.sbyte_.Click += new System.EventHandler(this.sbyte__Click);
            // 
            // ushort_
            // 
            this.ushort_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ushort_.Location = new System.Drawing.Point(542, 197);
            this.ushort_.Name = "ushort_";
            this.ushort_.Size = new System.Drawing.Size(307, 73);
            this.ushort_.TabIndex = 6;
            this.ushort_.Text = "USHORT";
            this.ushort_.UseVisualStyleBackColor = true;
            this.ushort_.Click += new System.EventHandler(this.ushort__Click);
            // 
            // int_
            // 
            this.int_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.int_.Location = new System.Drawing.Point(105, 324);
            this.int_.Name = "int_";
            this.int_.Size = new System.Drawing.Size(307, 73);
            this.int_.TabIndex = 7;
            this.int_.Text = "INT";
            this.int_.UseVisualStyleBackColor = true;
            this.int_.Click += new System.EventHandler(this.int__Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(943, 569);
            this.Controls.Add(this.int_);
            this.Controls.Add(this.ushort_);
            this.Controls.Add(this.sbyte_);
            this.Controls.Add(this.long_);
            this.Controls.Add(this.uint_);
            this.Controls.Add(this.ulong_);
            this.Controls.Add(this.short_);
            this.Controls.Add(this.byte_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HW01_1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button byte_;
        private System.Windows.Forms.Button short_;
        private System.Windows.Forms.Button ulong_;
        private System.Windows.Forms.Button uint_;
        private System.Windows.Forms.Button long_;
        private System.Windows.Forms.Button sbyte_;
        private System.Windows.Forms.Button ushort_;
        private System.Windows.Forms.Button int_;
    }
}

