namespace GuessTheNumber
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
            menuStrip1 = new MenuStrip();
            NewGameToolStripMenuItem = new ToolStripMenuItem();
            RulesToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            enterNumberLabel = new Label();
            NumberNumericUpDown = new NumericUpDown();
            acceptButton = new Button();
            triesTextLabel = new Label();
            triesCountLabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { NewGameToolStripMenuItem, RulesToolStripMenuItem, ExitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // NewGameToolStripMenuItem
            // 
            NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            NewGameToolStripMenuItem.Size = new Size(81, 20);
            NewGameToolStripMenuItem.Text = "Новая игра";
            NewGameToolStripMenuItem.Click += NewGameToolStripMenuItem_Click;
            // 
            // RulesToolStripMenuItem
            // 
            RulesToolStripMenuItem.Name = "RulesToolStripMenuItem";
            RulesToolStripMenuItem.Size = new Size(67, 20);
            RulesToolStripMenuItem.Text = "Правила";
            RulesToolStripMenuItem.Click += RulesToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(54, 20);
            ExitToolStripMenuItem.Text = "Выход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // enterNumberLabel
            // 
            enterNumberLabel.AutoSize = true;
            enterNumberLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            enterNumberLabel.Location = new Point(265, 158);
            enterNumberLabel.Name = "enterNumberLabel";
            enterNumberLabel.Size = new Size(148, 25);
            enterNumberLabel.TabIndex = 1;
            enterNumberLabel.Text = "Введите число :";
            // 
            // NumberNumericUpDown
            // 
            NumberNumericUpDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumberNumericUpDown.Location = new Point(419, 156);
            NumberNumericUpDown.Name = "NumberNumericUpDown";
            NumberNumericUpDown.Size = new Size(120, 33);
            NumberNumericUpDown.TabIndex = 2;
            // 
            // acceptButton
            // 
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            acceptButton.Location = new Point(362, 225);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(107, 47);
            acceptButton.TabIndex = 3;
            acceptButton.Text = "Принять";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // triesTextLabel
            // 
            triesTextLabel.AutoSize = true;
            triesTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            triesTextLabel.Location = new Point(265, 104);
            triesTextLabel.Name = "triesTextLabel";
            triesTextLabel.Size = new Size(166, 21);
            triesTextLabel.TabIndex = 4;
            triesTextLabel.Text = "Количество попыток :";
            // 
            // triesCountLabel
            // 
            triesCountLabel.AutoSize = true;
            triesCountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            triesCountLabel.Location = new Point(437, 105);
            triesCountLabel.Name = "triesCountLabel";
            triesCountLabel.Size = new Size(19, 21);
            triesCountLabel.TabIndex = 5;
            triesCountLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(triesCountLabel);
            Controls.Add(triesTextLabel);
            Controls.Add(acceptButton);
            Controls.Add(NumberNumericUpDown);
            Controls.Add(enterNumberLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem NewGameToolStripMenuItem;
        private ToolStripMenuItem RulesToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private Label enterNumberLabel;
        private NumericUpDown NumberNumericUpDown;
        private Button acceptButton;
        private Label triesTextLabel;
        private Label triesCountLabel;
    }
}
