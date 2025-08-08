namespace FlowChart3Excel
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
            radiojsonfile = new RadioButton();
            radioexcelbtn = new RadioButton();
            txtfilepath = new TextBox();
            label1 = new Label();
            browsebutton = new Button();
            generatebutton = new Button();
            samplejsonlink = new LinkLabel();
            sampleexcel = new LinkLabel();
            SuspendLayout();
            // 
            // radiojsonfile
            // 
            radiojsonfile.AutoSize = true;
            radiojsonfile.Location = new Point(48, 47);
            radiojsonfile.Name = "radiojsonfile";
            radiojsonfile.Size = new Size(111, 29);
            radiojsonfile.TabIndex = 0;
            radiojsonfile.TabStop = true;
            radiojsonfile.Text = "JSON File";
            radiojsonfile.UseVisualStyleBackColor = true;
            radiojsonfile.CheckedChanged += radiojsonfile_CheckedChanged;
            // 
            // radioexcelbtn
            // 
            radioexcelbtn.AutoSize = true;
            radioexcelbtn.Location = new Point(207, 47);
            radioexcelbtn.Name = "radioexcelbtn";
            radioexcelbtn.Size = new Size(116, 29);
            radioexcelbtn.TabIndex = 1;
            radioexcelbtn.TabStop = true;
            radioexcelbtn.Text = "EXCEL File";
            radioexcelbtn.UseVisualStyleBackColor = true;
            radioexcelbtn.CheckedChanged += radioexcelbtn_CheckedChanged;
            // 
            // txtfilepath
            // 
            txtfilepath.Location = new Point(48, 117);
            txtfilepath.Name = "txtfilepath";
            txtfilepath.ReadOnly = true;
            txtfilepath.Size = new Size(521, 31);
            txtfilepath.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 89);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 3;
            label1.Text = "File";
            // 
            // browsebutton
            // 
            browsebutton.Location = new Point(575, 114);
            browsebutton.Name = "browsebutton";
            browsebutton.Size = new Size(55, 34);
            browsebutton.TabIndex = 4;
            browsebutton.Text = "...";
            browsebutton.UseVisualStyleBackColor = true;
            browsebutton.Click += browsebutton_Click;
            // 
            // generatebutton
            // 
            generatebutton.Location = new Point(249, 173);
            generatebutton.Name = "generatebutton";
            generatebutton.Size = new Size(166, 51);
            generatebutton.TabIndex = 5;
            generatebutton.Text = "Genrate";
            generatebutton.UseVisualStyleBackColor = true;
            generatebutton.Click += generatebutton_Click;
            // 
            // samplejsonlink
            // 
            samplejsonlink.AutoSize = true;
            samplejsonlink.Location = new Point(375, 49);
            samplejsonlink.Name = "samplejsonlink";
            samplejsonlink.Size = new Size(119, 25);
            samplejsonlink.TabIndex = 6;
            samplejsonlink.TabStop = true;
            samplejsonlink.Text = "Sample JSON";
            samplejsonlink.Visible = false;
            samplejsonlink.LinkClicked += samplejsonlink_LinkClicked;
            // 
            // sampleexcel
            // 
            sampleexcel.AutoSize = true;
            sampleexcel.Location = new Point(380, 49);
            sampleexcel.Name = "sampleexcel";
            sampleexcel.Size = new Size(114, 25);
            sampleexcel.TabIndex = 7;
            sampleexcel.TabStop = true;
            sampleexcel.Text = "Sample Excel";
            sampleexcel.Visible = false;
            sampleexcel.LinkClicked += sampleexcel_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 236);
            Controls.Add(sampleexcel);
            Controls.Add(samplejsonlink);
            Controls.Add(generatebutton);
            Controls.Add(browsebutton);
            Controls.Add(label1);
            Controls.Add(txtfilepath);
            Controls.Add(radioexcelbtn);
            Controls.Add(radiojsonfile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radiojsonfile;
        private RadioButton radioexcelbtn;
        private TextBox txtfilepath;
        private Label label1;
        private Button browsebutton;
        private Button generatebutton;
        private LinkLabel samplejsonlink;
        private LinkLabel sampleexcel;
    }
}
