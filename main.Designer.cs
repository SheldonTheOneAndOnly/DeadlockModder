namespace DeadlockModder
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            label1 = new Label();
            modButton = new Button();
            modFileDialog = new OpenFileDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            modCount = new Label();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            directoryText = new TextBox();
            directoryButton = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            fixButton = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label4 = new Label();
            moveCheckbox = new CheckBox();
            clearCheckbox = new CheckBox();
            installButton = new Button();
            directoryDialog = new FolderBrowserDialog();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Name = "label1";
            // 
            // modButton
            // 
            resources.ApplyResources(modButton, "modButton");
            modButton.AllowDrop = true;
            modButton.BackColor = Color.FromArgb(255, 225, 225);
            modButton.Name = "modButton";
            modButton.UseVisualStyleBackColor = false;
            modButton.Click += modButton_Click;
            // 
            // modFileDialog
            // 
            resources.ApplyResources(modFileDialog, "modFileDialog");
            modFileDialog.Multiselect = true;
            modFileDialog.OkRequiresInteraction = true;
            modFileDialog.FileOk += modSelected;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(modButton);
            flowLayoutPanel1.Controls.Add(modCount);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(installButton);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // modCount
            // 
            resources.ApplyResources(modCount, "modCount");
            modCount.Name = "modCount";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
            flowLayoutPanel2.Controls.Add(directoryText);
            flowLayoutPanel2.Controls.Add(directoryButton);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // directoryText
            // 
            resources.ApplyResources(directoryText, "directoryText");
            directoryText.BorderStyle = BorderStyle.FixedSingle;
            directoryText.Name = "directoryText";
            // 
            // directoryButton
            // 
            resources.ApplyResources(directoryButton, "directoryButton");
            directoryButton.Name = "directoryButton";
            directoryButton.UseVisualStyleBackColor = true;
            directoryButton.Click += directoryButtonClick;
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(flowLayoutPanel3, "flowLayoutPanel3");
            flowLayoutPanel3.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // flowLayoutPanel4
            // 
            resources.ApplyResources(flowLayoutPanel4, "flowLayoutPanel4");
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(fixButton);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // fixButton
            // 
            resources.ApplyResources(fixButton, "fixButton");
            fixButton.Name = "fixButton";
            fixButton.UseVisualStyleBackColor = true;
            fixButton.Click += fixButton_Click;
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(flowLayoutPanel5, "flowLayoutPanel5");
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(moveCheckbox);
            flowLayoutPanel5.Controls.Add(clearCheckbox);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // moveCheckbox
            // 
            resources.ApplyResources(moveCheckbox, "moveCheckbox");
            moveCheckbox.Name = "moveCheckbox";
            moveCheckbox.UseVisualStyleBackColor = true;
            // 
            // clearCheckbox
            // 
            resources.ApplyResources(clearCheckbox, "clearCheckbox");
            clearCheckbox.Name = "clearCheckbox";
            clearCheckbox.UseVisualStyleBackColor = true;
            // 
            // installButton
            // 
            resources.ApplyResources(installButton, "installButton");
            installButton.Name = "installButton";
            installButton.UseVisualStyleBackColor = true;
            installButton.Click += installButton_Click;
            // 
            // directoryDialog
            // 
            resources.ApplyResources(directoryDialog, "directoryDialog");
            // 
            // main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "main";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button modButton;
        private OpenFileDialog modFileDialog;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label modCount;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox directoryText;
        private Button directoryButton;
        private FolderBrowserDialog directoryDialog;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label3;
        private Button fixButton;
        private Label label4;
        private CheckBox moveCheckbox;
        private CheckBox clearCheckbox;
        private Button installButton;
    }
}
