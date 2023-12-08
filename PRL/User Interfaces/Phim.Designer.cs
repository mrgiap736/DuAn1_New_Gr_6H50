namespace PRL.User_Interfaces
{
    partial class Phim
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
            Panel_Scroll = new Panel();
            VSBphim = new VScrollBar();
            Panel_Phim = new Panel();
            FLPanel_DSphim = new FlowLayoutPanel();
            label3 = new Label();
            Panel_Scroll.SuspendLayout();
            Panel_Phim.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Scroll
            // 
            Panel_Scroll.AutoScroll = true;
            Panel_Scroll.Controls.Add(VSBphim);
            Panel_Scroll.Controls.Add(Panel_Phim);
            Panel_Scroll.Location = new Point(1, 0);
            Panel_Scroll.Name = "Panel_Scroll";
            Panel_Scroll.Size = new Size(937, 762);
            Panel_Scroll.TabIndex = 0;
            // 
            // VSBphim
            // 
            VSBphim.Location = new Point(916, 0);
            VSBphim.Name = "VSBphim";
            VSBphim.Size = new Size(21, 726);
            VSBphim.TabIndex = 79;
            // 
            // Panel_Phim
            // 
            Panel_Phim.AutoScroll = true;
            Panel_Phim.AutoSize = true;
            Panel_Phim.Controls.Add(FLPanel_DSphim);
            Panel_Phim.Controls.Add(label3);
            Panel_Phim.Location = new Point(0, 0);
            Panel_Phim.Name = "Panel_Phim";
            Panel_Phim.Size = new Size(913, 1508);
            Panel_Phim.TabIndex = 3;
            // 
            // FLPanel_DSphim
            // 
            FLPanel_DSphim.BackColor = Color.Firebrick;
            FLPanel_DSphim.Location = new Point(23, 49);
            FLPanel_DSphim.Name = "FLPanel_DSphim";
            FLPanel_DSphim.Size = new Size(875, 1420);
            FLPanel_DSphim.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 14);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 50;
            label3.Text = "Phim";
            // 
            // Phim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(937, 714);
            Controls.Add(Panel_Scroll);
            Name = "Phim";
            Text = "Phim";
            Panel_Scroll.ResumeLayout(false);
            Panel_Scroll.PerformLayout();
            Panel_Phim.ResumeLayout(false);
            Panel_Phim.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Scroll;
        private Panel Panel_Phim;
        private VScrollBar VSBphim;
        private Label label3;
        private FlowLayoutPanel FLPanel_DSphim;
    }
}