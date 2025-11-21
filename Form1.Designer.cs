namespace XmlCheckXSD;

partial class MainForm
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
        menuStrip = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        loadXmlToolStripMenuItem = new ToolStripMenuItem();
        addListXSDToolStripMenuItem = new ToolStripMenuItem();
        splitContainer = new SplitContainer();
        groupBoxXSD = new GroupBox();
        listBoxXSD = new ListBox();
        panelXSDButtons = new Panel();
        buttonRemoveXSD = new Button();
        groupBoxLog = new GroupBox();
        richTextBoxLog = new RichTextBox();
        panelBottom = new Panel();
        buttonCheckXml = new Button();
        labelXmlFile = new Label();
        menuStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
        splitContainer.Panel1.SuspendLayout();
        splitContainer.Panel2.SuspendLayout();
        splitContainer.SuspendLayout();
        groupBoxXSD.SuspendLayout();
        panelXSDButtons.SuspendLayout();
        groupBoxLog.SuspendLayout();
        panelBottom.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip
        // 
        menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(839, 24);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadXmlToolStripMenuItem, addListXSDToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "File";
        // 
        // loadXmlToolStripMenuItem
        // 
        loadXmlToolStripMenuItem.Name = "loadXmlToolStripMenuItem";
        loadXmlToolStripMenuItem.Size = new Size(141, 22);
        loadXmlToolStripMenuItem.Text = "Load Xml";
        loadXmlToolStripMenuItem.Click += LoadXmlToolStripMenuItem_Click;
        // 
        // addListXSDToolStripMenuItem
        // 
        addListXSDToolStripMenuItem.Name = "addListXSDToolStripMenuItem";
        addListXSDToolStripMenuItem.Size = new Size(141, 22);
        addListXSDToolStripMenuItem.Text = "Add List XSD";
        addListXSDToolStripMenuItem.Click += AddListXSDToolStripMenuItem_Click;
        // 
        // splitContainer
        // 
        splitContainer.Dock = DockStyle.Fill;
        splitContainer.Location = new Point(0, 24);
        splitContainer.Name = "splitContainer";
        splitContainer.Orientation = Orientation.Horizontal;
        // 
        // splitContainer.Panel1
        // 
        splitContainer.Panel1.Controls.Add(groupBoxXSD);
        // 
        // splitContainer.Panel2
        // 
        splitContainer.Panel2.Controls.Add(groupBoxLog);
        splitContainer.Size = new Size(839, 414);
        splitContainer.SplitterDistance = 151;
        splitContainer.TabIndex = 1;
        // 
        // groupBoxXSD
        // 
        groupBoxXSD.Controls.Add(listBoxXSD);
        groupBoxXSD.Controls.Add(panelXSDButtons);
        groupBoxXSD.Dock = DockStyle.Fill;
        groupBoxXSD.Location = new Point(0, 0);
        groupBoxXSD.Name = "groupBoxXSD";
        groupBoxXSD.Size = new Size(839, 151);
        groupBoxXSD.TabIndex = 0;
        groupBoxXSD.TabStop = false;
        groupBoxXSD.Text = "XSD Files";
        // 
        // listBoxXSD
        // 
        listBoxXSD.Dock = DockStyle.Fill;
        listBoxXSD.FormattingEnabled = true;
        listBoxXSD.Location = new Point(3, 19);
        listBoxXSD.Name = "listBoxXSD";
        listBoxXSD.Size = new Size(763, 129);
        listBoxXSD.TabIndex = 0;
        // 
        // panelXSDButtons
        // 
        panelXSDButtons.Controls.Add(buttonRemoveXSD);
        panelXSDButtons.Dock = DockStyle.Right;
        panelXSDButtons.Location = new Point(766, 19);
        panelXSDButtons.Name = "panelXSDButtons";
        panelXSDButtons.Size = new Size(70, 129);
        panelXSDButtons.TabIndex = 1;
        // 
        // buttonRemoveXSD
        // 
        buttonRemoveXSD.Location = new Point(6, 6);
        buttonRemoveXSD.Name = "buttonRemoveXSD";
        buttonRemoveXSD.Size = new Size(60, 30);
        buttonRemoveXSD.TabIndex = 0;
        buttonRemoveXSD.Text = "Remove";
        buttonRemoveXSD.UseVisualStyleBackColor = true;
        buttonRemoveXSD.Click += ButtonRemoveXSD_Click;
        // 
        // groupBoxLog
        // 
        groupBoxLog.Controls.Add(richTextBoxLog);
        groupBoxLog.Dock = DockStyle.Fill;
        groupBoxLog.Location = new Point(0, 0);
        groupBoxLog.Name = "groupBoxLog";
        groupBoxLog.Size = new Size(839, 259);
        groupBoxLog.TabIndex = 0;
        groupBoxLog.TabStop = false;
        groupBoxLog.Text = "Validation Log";
        // 
        // richTextBoxLog
        // 
        richTextBoxLog.Dock = DockStyle.Fill;
        richTextBoxLog.Location = new Point(3, 19);
        richTextBoxLog.Name = "richTextBoxLog";
        richTextBoxLog.ReadOnly = true;
        richTextBoxLog.Size = new Size(833, 237);
        richTextBoxLog.TabIndex = 0;
        richTextBoxLog.Text = "";
        // 
        // panelBottom
        // 
        panelBottom.Controls.Add(buttonCheckXml);
        panelBottom.Controls.Add(labelXmlFile);
        panelBottom.Dock = DockStyle.Bottom;
        panelBottom.Location = new Point(0, 438);
        panelBottom.Name = "panelBottom";
        panelBottom.Size = new Size(839, 50);
        panelBottom.TabIndex = 2;
        // 
        // buttonCheckXml
        // 
        buttonCheckXml.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonCheckXml.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        buttonCheckXml.Location = new Point(709, 10);
        buttonCheckXml.Name = "buttonCheckXml";
        buttonCheckXml.Size = new Size(120, 30);
        buttonCheckXml.TabIndex = 1;
        buttonCheckXml.Text = "Check Xml";
        buttonCheckXml.UseVisualStyleBackColor = true;
        buttonCheckXml.Click += ButtonCheckXml_Click;
        // 
        // labelXmlFile
        // 
        labelXmlFile.AutoSize = true;
        labelXmlFile.Location = new Point(12, 17);
        labelXmlFile.Name = "labelXmlFile";
        labelXmlFile.Size = new Size(108, 15);
        labelXmlFile.TabIndex = 0;
        labelXmlFile.Text = "No XML file loaded";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(839, 488);
        Controls.Add(splitContainer);
        Controls.Add(panelBottom);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        Name = "MainForm";
        Text = "XML Check XSD - XML Validator";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        splitContainer.Panel1.ResumeLayout(false);
        splitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
        splitContainer.ResumeLayout(false);
        groupBoxXSD.ResumeLayout(false);
        panelXSDButtons.ResumeLayout(false);
        groupBoxLog.ResumeLayout(false);
        panelBottom.ResumeLayout(false);
        panelBottom.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem loadXmlToolStripMenuItem;
    private ToolStripMenuItem addListXSDToolStripMenuItem;
    private SplitContainer splitContainer;
    private GroupBox groupBoxXSD;
    private ListBox listBoxXSD;
    private Panel panelXSDButtons;
    private Button buttonRemoveXSD;
    private GroupBox groupBoxLog;
    private RichTextBox richTextBoxLog;
    private Panel panelBottom;
    private Button buttonCheckXml;
    private Label labelXmlFile;
}
