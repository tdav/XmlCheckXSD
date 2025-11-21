using System.Xml;
using System.Xml.Schema;

namespace XmlCheckXSD;

public partial class MainForm : Form
{
    private string? xmlFilePath;
    private readonly List<string> xsdFilePaths = new();
    private readonly List<ValidationEventArgs> validationErrors = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void LoadXmlToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new()
        {
            Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
            Title = "Select XML File"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            xmlFilePath = openFileDialog.FileName;
            labelXmlFile.Text = $"XML File: {Path.GetFileName(xmlFilePath)}";
            LogMessage($"Loaded XML file: {xmlFilePath}", Color.Blue);
        }
    }

    private void AddListXSDToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new()
        {
            Filter = "XSD Files (*.xsd)|*.xsd|All Files (*.*)|*.*",
            Title = "Select XSD File(s)",
            Multiselect = true
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            foreach (string file in openFileDialog.FileNames)
            {
                if (!xsdFilePaths.Contains(file))
                {
                    xsdFilePaths.Add(file);
                    listBoxXSD.Items.Add(Path.GetFileName(file));
                    LogMessage($"Added XSD file: {file}", Color.Green);
                }
            }
        }
    }

    private void ButtonRemoveXSD_Click(object? sender, EventArgs e)
    {
        if (listBoxXSD.SelectedIndex >= 0)
        {
            int index = listBoxXSD.SelectedIndex;
            string removedFile = xsdFilePaths[index];
            xsdFilePaths.RemoveAt(index);
            listBoxXSD.Items.RemoveAt(index);
            LogMessage($"Removed XSD file: {removedFile}", Color.Orange);
        }
    }

    private void ButtonCheckXml_Click(object? sender, EventArgs e)
    {
        richTextBoxLog.Clear();
        validationErrors.Clear();

        if (string.IsNullOrEmpty(xmlFilePath))
        {
            LogMessage("Error: No XML file loaded!", Color.Red);
            MessageBox.Show("Please load an XML file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (xsdFilePaths.Count == 0)
        {
            LogMessage("Error: No XSD files added!", Color.Red);
            MessageBox.Show("Please add at least one XSD file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        LogMessage("Starting XML validation...", Color.Blue);
        LogMessage($"XML File: {xmlFilePath}", Color.Black);
        LogMessage($"XSD Files: {xsdFilePaths.Count}", Color.Black);
        LogMessage(new string('-', 80), Color.Gray);

        try
        {
            ValidateXmlAgainstXsd();

            if (validationErrors.Count == 0)
            {
                LogMessage(new string('-', 80), Color.Gray);
                LogMessage("✓ Validation successful! No errors found.", Color.Green);
                MessageBox.Show("XML validation successful! No errors found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LogMessage(new string('-', 80), Color.Gray);
                LogMessage($"✗ Validation failed with {validationErrors.Count} error(s).", Color.Red);
                MessageBox.Show($"XML validation failed with {validationErrors.Count} error(s). See log for details.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            LogMessage(new string('-', 80), Color.Gray);
            LogMessage($"Exception: {ex.Message}", Color.Red);
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ValidateXmlAgainstXsd()
    {
        XmlReaderSettings settings = new()
        {
            ValidationType = ValidationType.Schema,
            ValidationFlags = XmlSchemaValidationFlags.ProcessInlineSchema |
                            XmlSchemaValidationFlags.ProcessSchemaLocation |
                            XmlSchemaValidationFlags.ReportValidationWarnings
        };

        // Add all XSD schemas
        foreach (string xsdPath in xsdFilePaths)
        {
            try
            {
                settings.Schemas.Add(null, xsdPath);
                LogMessage($"Loaded schema: {Path.GetFileName(xsdPath)}", Color.Green);
            }
            catch (Exception ex)
            {
                LogMessage($"Error loading schema {Path.GetFileName(xsdPath)}: {ex.Message}", Color.Red);
            }
        }

        // Set up validation event handler
        settings.ValidationEventHandler += ValidationEventHandler;

        // Validate XML
        try
        {
            using XmlReader reader = XmlReader.Create(xmlFilePath!, settings);
            while (reader.Read())
            {
                // Read through the document to trigger validation
            }
        }
        catch (XmlException ex)
        {
            LogMessage($"XML Error at line {ex.LineNumber}, position {ex.LinePosition}: {ex.Message}", Color.Red);
        }
    }

    private void ValidationEventHandler(object? sender, ValidationEventArgs e)
    {
        validationErrors.Add(e);
        
        Color color = e.Severity == XmlSeverityType.Error ? Color.Red : Color.Orange;
        string severity = e.Severity == XmlSeverityType.Error ? "ERROR" : "WARNING";
        
        if (e.Exception != null)
        {
            LogMessage($"[{severity}] Line {e.Exception.LineNumber}, Position {e.Exception.LinePosition}:", color);
        }
        else
        {
            LogMessage($"[{severity}]:", color);
        }
        LogMessage($"  {e.Message}", color);
    }

    private void LogMessage(string message, Color color)
    {
        richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
        richTextBoxLog.SelectionLength = 0;
        richTextBoxLog.SelectionColor = color;
        richTextBoxLog.AppendText(message + Environment.NewLine);
        richTextBoxLog.SelectionColor = richTextBoxLog.ForeColor;
        richTextBoxLog.ScrollToCaret();
    }
}
