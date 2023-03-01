namespace WinFormsApp5
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
            panelLayout = new FlowLayoutPanel();
            kirmiziButton = new Button();
            maviButton = new Button();
            yesilButton = new Button();
            sariButton = new Button();
            originalButton = new Button();
            SuspendLayout();
            // 
            // panelLayout
            // 
            panelLayout.Location = new Point(50, 31);
            panelLayout.Margin = new Padding(4, 4, 4, 4);
            panelLayout.Name = "panelLayout";
            panelLayout.Size = new Size(319, 567);
            panelLayout.TabIndex = 0;
            // 
            // kirmiziButton
            // 
            kirmiziButton.Location = new Point(422, 45);
            kirmiziButton.Name = "kirmiziButton";
            kirmiziButton.Size = new Size(197, 53);
            kirmiziButton.TabIndex = 1;
            kirmiziButton.Text = "Kirmizi";
            kirmiziButton.UseVisualStyleBackColor = true;
            kirmiziButton.Click += kirmiziButton_Click;
            // 
            // maviButton
            // 
            maviButton.Location = new Point(422, 104);
            maviButton.Name = "maviButton";
            maviButton.Size = new Size(197, 53);
            maviButton.TabIndex = 2;
            maviButton.Text = "Mavi";
            maviButton.UseVisualStyleBackColor = true;
            maviButton.Click += maviButton_Click;
            // 
            // yesilButton
            // 
            yesilButton.Location = new Point(422, 163);
            yesilButton.Name = "yesilButton";
            yesilButton.Size = new Size(197, 53);
            yesilButton.TabIndex = 3;
            yesilButton.Text = "Yeşil";
            yesilButton.UseVisualStyleBackColor = true;
            yesilButton.Click += yesilButton_Click;
            // 
            // sariButton
            // 
            sariButton.Location = new Point(422, 222);
            sariButton.Name = "sariButton";
            sariButton.Size = new Size(197, 53);
            sariButton.TabIndex = 4;
            sariButton.Text = "Sarı";
            sariButton.UseVisualStyleBackColor = true;
            sariButton.Click += sariButton_Click;
            // 
            // originalButton
            // 
            originalButton.Location = new Point(422, 281);
            originalButton.Name = "originalButton";
            originalButton.Size = new Size(197, 53);
            originalButton.TabIndex = 5;
            originalButton.Text = "Orginal";
            originalButton.UseVisualStyleBackColor = true;
            originalButton.Click += originalButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 665);
            Controls.Add(originalButton);
            Controls.Add(sariButton);
            Controls.Add(yesilButton);
            Controls.Add(maviButton);
            Controls.Add(kirmiziButton);
            Controls.Add(panelLayout);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelLayout;
        private Button kirmiziButton;
        private Button maviButton;
        private Button yesilButton;
        private Button sariButton;
        private Button originalButton;
    }
}