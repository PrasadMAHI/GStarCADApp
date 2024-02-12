
namespace GstarCadApp
{
    partial class GstarCadAppUi
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
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_ShowLayers = new System.Windows.Forms.Button();
            this.Btn_HideLayers = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.GroupBox_GStartCadApp_ = new System.Windows.Forms.GroupBox();
            this.GroupBox_Inputs = new System.Windows.Forms.GroupBox();
            this.Panel_Layers = new System.Windows.Forms.Panel();
            this.checkBox_AllLayers = new System.Windows.Forms.CheckBox();
            this.listBox_LayerNames = new System.Windows.Forms.ListBox();
            this.Panel_LoadInputs = new System.Windows.Forms.Panel();
            this.Button_Select = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_SelectFile = new System.Windows.Forms.Label();
            this.Button_Apply = new System.Windows.Forms.Button();
            this.GroupBox_GStartCadApp_.SuspendLayout();
            this.GroupBox_Inputs.SuspendLayout();
            this.Panel_Layers.SuspendLayout();
            this.Panel_LoadInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(18, 42);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(115, 47);
            this.Btn_Load.TabIndex = 0;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Btn_ShowLayers
            // 
            this.Btn_ShowLayers.Location = new System.Drawing.Point(18, 115);
            this.Btn_ShowLayers.Name = "Btn_ShowLayers";
            this.Btn_ShowLayers.Size = new System.Drawing.Size(115, 42);
            this.Btn_ShowLayers.TabIndex = 1;
            this.Btn_ShowLayers.Text = "Show Layers";
            this.Btn_ShowLayers.UseVisualStyleBackColor = true;
            this.Btn_ShowLayers.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Btn_HideLayers
            // 
            this.Btn_HideLayers.Location = new System.Drawing.Point(18, 189);
            this.Btn_HideLayers.Name = "Btn_HideLayers";
            this.Btn_HideLayers.Size = new System.Drawing.Size(115, 44);
            this.Btn_HideLayers.TabIndex = 2;
            this.Btn_HideLayers.Text = "Hide Layers";
            this.Btn_HideLayers.UseVisualStyleBackColor = true;
            this.Btn_HideLayers.Click += new System.EventHandler(this.Btn_HideLayers_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(18, 259);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(115, 45);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // GroupBox_GStartCadApp_
            // 
            this.GroupBox_GStartCadApp_.Controls.Add(this.Btn_Save);
            this.GroupBox_GStartCadApp_.Controls.Add(this.Btn_Load);
            this.GroupBox_GStartCadApp_.Controls.Add(this.Btn_HideLayers);
            this.GroupBox_GStartCadApp_.Controls.Add(this.Btn_ShowLayers);
            this.GroupBox_GStartCadApp_.Location = new System.Drawing.Point(12, 30);
            this.GroupBox_GStartCadApp_.Name = "GroupBox_GStartCadApp_";
            this.GroupBox_GStartCadApp_.Size = new System.Drawing.Size(153, 332);
            this.GroupBox_GStartCadApp_.TabIndex = 1;
            this.GroupBox_GStartCadApp_.TabStop = false;
            this.GroupBox_GStartCadApp_.Text = "Tasks";
            // 
            // GroupBox_Inputs
            // 
            this.GroupBox_Inputs.Controls.Add(this.Panel_Layers);
            this.GroupBox_Inputs.Controls.Add(this.Panel_LoadInputs);
            this.GroupBox_Inputs.Location = new System.Drawing.Point(256, 30);
            this.GroupBox_Inputs.Name = "GroupBox_Inputs";
            this.GroupBox_Inputs.Size = new System.Drawing.Size(361, 332);
            this.GroupBox_Inputs.TabIndex = 2;
            this.GroupBox_Inputs.TabStop = false;
            this.GroupBox_Inputs.Text = "Inputs";
            // 
            // Panel_Layers
            // 
            this.Panel_Layers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Layers.Controls.Add(this.checkBox_AllLayers);
            this.Panel_Layers.Controls.Add(this.listBox_LayerNames);
            this.Panel_Layers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Layers.Location = new System.Drawing.Point(3, 16);
            this.Panel_Layers.Name = "Panel_Layers";
            this.Panel_Layers.Size = new System.Drawing.Size(355, 313);
            this.Panel_Layers.TabIndex = 1;
            // 
            // checkBox_AllLayers
            // 
            this.checkBox_AllLayers.AutoSize = true;
            this.checkBox_AllLayers.Location = new System.Drawing.Point(28, 66);
            this.checkBox_AllLayers.Name = "checkBox_AllLayers";
            this.checkBox_AllLayers.Size = new System.Drawing.Size(71, 17);
            this.checkBox_AllLayers.TabIndex = 1;
            this.checkBox_AllLayers.Text = "All Layers";
            this.checkBox_AllLayers.UseVisualStyleBackColor = true;
            this.checkBox_AllLayers.CheckedChanged += new System.EventHandler(this.checkBox_AllLayers_CheckedChanged);
            // 
            // listBox_LayerNames
            // 
            this.listBox_LayerNames.FormattingEnabled = true;
            this.listBox_LayerNames.Location = new System.Drawing.Point(209, -3);
            this.listBox_LayerNames.Name = "listBox_LayerNames";
            this.listBox_LayerNames.ScrollAlwaysVisible = true;
            this.listBox_LayerNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_LayerNames.Size = new System.Drawing.Size(138, 316);
            this.listBox_LayerNames.TabIndex = 0;
            // 
            // Panel_LoadInputs
            // 
            this.Panel_LoadInputs.Controls.Add(this.Button_Select);
            this.Panel_LoadInputs.Controls.Add(this.textBox1);
            this.Panel_LoadInputs.Controls.Add(this.label_SelectFile);
            this.Panel_LoadInputs.Location = new System.Drawing.Point(15, 43);
            this.Panel_LoadInputs.Name = "Panel_LoadInputs";
            this.Panel_LoadInputs.Size = new System.Drawing.Size(309, 182);
            this.Panel_LoadInputs.TabIndex = 0;
            // 
            // Button_Select
            // 
            this.Button_Select.Location = new System.Drawing.Point(197, 75);
            this.Button_Select.Name = "Button_Select";
            this.Button_Select.Size = new System.Drawing.Size(97, 31);
            this.Button_Select.TabIndex = 2;
            this.Button_Select.Text = "Select";
            this.Button_Select.UseVisualStyleBackColor = true;
            this.Button_Select.Click += new System.EventHandler(this.Button_Select_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label_SelectFile
            // 
            this.label_SelectFile.AutoSize = true;
            this.label_SelectFile.Location = new System.Drawing.Point(3, 23);
            this.label_SelectFile.Name = "label_SelectFile";
            this.label_SelectFile.Size = new System.Drawing.Size(75, 13);
            this.label_SelectFile.TabIndex = 0;
            this.label_SelectFile.Text = "Model to Load";
            // 
            // Button_Apply
            // 
            this.Button_Apply.Location = new System.Drawing.Point(484, 370);
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.Size = new System.Drawing.Size(95, 45);
            this.Button_Apply.TabIndex = 2;
            this.Button_Apply.Text = "Apply";
            this.Button_Apply.UseVisualStyleBackColor = true;
            this.Button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // GstarCadAppUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 427);
            this.Controls.Add(this.Button_Apply);
            this.Controls.Add(this.GroupBox_Inputs);
            this.Controls.Add(this.GroupBox_GStartCadApp_);
            this.Name = "GstarCadAppUi";
            this.Text = "GstarCadApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_GStartCadApp_.ResumeLayout(false);
            this.GroupBox_Inputs.ResumeLayout(false);
            this.Panel_Layers.ResumeLayout(false);
            this.Panel_Layers.PerformLayout();
            this.Panel_LoadInputs.ResumeLayout(false);
            this.Panel_LoadInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button Btn_ShowLayers;
        private System.Windows.Forms.Button Btn_HideLayers;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.GroupBox GroupBox_GStartCadApp_;
        private System.Windows.Forms.GroupBox GroupBox_Inputs;
        private System.Windows.Forms.Panel Panel_LoadInputs;
        private System.Windows.Forms.Button Button_Select;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_SelectFile;
        private System.Windows.Forms.Panel Panel_Layers;
        private System.Windows.Forms.CheckBox checkBox_AllLayers;
        private System.Windows.Forms.ListBox listBox_LayerNames;
        private System.Windows.Forms.Button Button_Apply;
    }
}

