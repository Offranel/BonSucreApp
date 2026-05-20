namespace BonSucreApp
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
            lblCustomer = new Label();
            lblDessert = new Label();
            lblReviewScore = new Label();
            cmbCustomer = new ComboBox();
            cboDessert = new ComboBox();
            txtReviewScore = new TextBox();
            groupBox1 = new GroupBox();
            btnAddReview = new Button();
            btnAddCustomer = new Button();
            btnAddDessert = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(0, 49);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(147, 41);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer";
            // 
            // lblDessert
            // 
            lblDessert.AutoSize = true;
            lblDessert.Location = new Point(6, 126);
            lblDessert.Name = "lblDessert";
            lblDessert.Size = new Size(117, 41);
            lblDessert.TabIndex = 1;
            lblDessert.Text = "Dessert";
            // 
            // lblReviewScore
            // 
            lblReviewScore.AutoSize = true;
            lblReviewScore.Location = new Point(0, 209);
            lblReviewScore.Name = "lblReviewScore";
            lblReviewScore.Size = new Size(192, 41);
            lblReviewScore.TabIndex = 2;
            lblReviewScore.Text = "Review Score";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(181, 46);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(302, 49);
            cmbCustomer.TabIndex = 3;
            // 
            // cboDessert
            // 
            cboDessert.FormattingEnabled = true;
            cboDessert.Location = new Point(181, 126);
            cboDessert.Name = "cboDessert";
            cboDessert.Size = new Size(302, 49);
            cboDessert.TabIndex = 4;
            // 
            // txtReviewScore
            // 
            txtReviewScore.Location = new Point(181, 203);
            txtReviewScore.Name = "txtReviewScore";
            txtReviewScore.Size = new Size(302, 47);
            txtReviewScore.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddReview);
            groupBox1.Controls.Add(cmbCustomer);
            groupBox1.Controls.Add(lblReviewScore);
            groupBox1.Controls.Add(txtReviewScore);
            groupBox1.Controls.Add(lblCustomer);
            groupBox1.Controls.Add(cboDessert);
            groupBox1.Controls.Add(lblDessert);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 384);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Review";
            // 
            // btnAddReview
            // 
            btnAddReview.Location = new Point(131, 292);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(210, 69);
            btnAddReview.TabIndex = 6;
            btnAddReview.Text = "Add Review";
            btnAddReview.UseVisualStyleBackColor = true;
            btnAddReview.Click += btnAddReview_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(623, 93);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(217, 115);
            btnAddCustomer.TabIndex = 7;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddReview_Click;
            // 
            // btnAddDessert
            // 
            btnAddDessert.Location = new Point(632, 304);
            btnAddDessert.Name = "btnAddDessert";
            btnAddDessert.Size = new Size(207, 113);
            btnAddDessert.TabIndex = 8;
            btnAddDessert.Text = "Add Dessert";
            btnAddDessert.UseVisualStyleBackColor = true;
            btnAddDessert.Click += btnAddReview_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 488);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnAddDessert);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "BonSucreApp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCustomer;
        private Label lblDessert;
        private Label lblReviewScore;
        private ComboBox cmbCustomer;
        private ComboBox cboDessert;
        private TextBox txtReviewScore;
        private GroupBox groupBox1;
        private Button btnAddReview;
        private Button btnAddCustomer;
        private Button btnAddDessert;
    }
}
