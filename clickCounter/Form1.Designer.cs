namespace clickCounter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            clickbtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            timelbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 51);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 27);
            label1.TabIndex = 0;
            label1.Text = "Current times：";
            // 
            // clickbtn
            // 
            clickbtn.Location = new Point(60, 121);
            clickbtn.Name = "clickbtn";
            clickbtn.Size = new Size(213, 63);
            clickbtn.TabIndex = 1;
            clickbtn.Text = "click";
            clickbtn.UseVisualStyleBackColor = true;
            clickbtn.Click += clickbtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.ForeColor = Color.Red;
            clearBtn.Location = new Point(60, 210);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(102, 45);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.ForeColor = Color.Red;
            exitBtn.Location = new Point(171, 210);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(102, 45);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // timelbl
            // 
            timelbl.AutoSize = true;
            timelbl.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timelbl.Location = new Point(3, 335);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(97, 16);
            timelbl.TabIndex = 4;
            timelbl.Text = "System time：";
            timelbl.Click += timelbl_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(184, 54);
            label2.Name = "label2";
            label2.Size = new Size(21, 22);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 354);
            Controls.Add(label2);
            Controls.Add(timelbl);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(clickbtn);
            Controls.Add(label1);
            Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Click Counter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button clickbtn;
        private Button clearBtn;
        private Button exitBtn;
        private Label timelbl;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}
