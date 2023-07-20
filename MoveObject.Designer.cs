namespace LTGDC5
{
    partial class MoveObject
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
            panelPic = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // panelPic
            // 
            panelPic.AutoScroll = true;
            panelPic.BackColor = Color.FromArgb(255, 192, 192);
            panelPic.FlowDirection = FlowDirection.TopDown;
            panelPic.Location = new Point(664, 12);
            panelPic.Name = "panelPic";
            panelPic.Size = new Size(124, 424);
            panelPic.TabIndex = 0;
            panelPic.MouseDown += panelPic_MouseDown;
            panelPic.MouseMove += panelPic_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 408);
            label1.Name = "label1";
            label1.Size = new Size(655, 28);
            label1.TabIndex = 1;
            label1.Text = "Dung chuot hoac cac phim mui ten di chuyen hinh vao panel ben phai";
            // 
            // MoveObject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panelPic);
            Name = "MoveObject";
            Text = "MoveObject";
            Load += MoveObject_Load;
            KeyDown += MoveObject_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelPic;
        private Label label1;
    }
}