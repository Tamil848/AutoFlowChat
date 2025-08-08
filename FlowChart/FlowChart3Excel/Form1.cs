
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System.Text.Json;

namespace FlowChart3Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateFlowchartFromExcel(string Path)
        {
            var steps = new List<FlowStep>();
            if (radiojsonfile.Checked)
            {
                var json = File.ReadAllText(Path);
                steps = JsonSerializer.Deserialize<List<FlowStep>>(json);
            }

            else if (radioexcelbtn.Checked)
            {
                ReadExcel readExcel = new ReadExcel();
                steps = readExcel.ReadFlowStepsFromExcel(Path);
            }

            var graph = new Graph("ExcelFlowchart");
            var nodeDict = new Dictionary<string, Node>();

            foreach (var step in steps)
            {
                var node = graph.AddNode(step.Id);
                node.LabelText = step.Text;

                node.Attr.Shape = step.Type.ToLower() switch
                {
                    "start" or "end" => Shape.Ellipse,
                    "decision" => Shape.Diamond,
                    "input" or "output" => Shape.Parallelogram,
                    _ => Shape.Box
                };

                nodeDict[step.Id] = node;
            }

            foreach (var step in steps)
            {
                foreach (var next in step.Next)
                {
                    if (next.Contains(":"))
                    {
                        string[] nexts = next.Split(':');
                        graph.AddEdge(step.Id, nexts[0]).LabelText = nexts[1];
                    }
                    else
                    {
                        graph.AddEdge(step.Id, next);
                    }
                }
            }

            //var viewer = new GViewer { Graph = graph, Dock = DockStyle.Fill };
            //panelFlowchart.Controls.Clear();
            //panelFlowchart.Controls.Add(viewer);

            // Create a viewer
            var viewer = new GViewer();
            viewer.Graph = graph;

            // Display in a WinForms Form
            Form form = new Form();
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            form.ShowDialog();
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {


            OpenFileDialog FileDialog = new OpenFileDialog();
            if (radiojsonfile.Checked)
            {
                FileDialog.Filter = "JSON Documents (*.json)|*.json";//filter
            }
            else if (radioexcelbtn.Checked)
            {
                FileDialog.Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls";//filter
            }
            FileDialog.FilterIndex = 1;
            FileDialog.RestoreDirectory = true;
            DialogResult result = FileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtfilepath.Text = FileDialog.FileName;
            }
        }

        private void radiojsonfile_CheckedChanged(object sender, EventArgs e)
        {
            if (radiojsonfile.Checked)
            {
                samplejsonlink.Visible = true;
                sampleexcel.Visible = radioexcelbtn.Checked = false;
            }
            txtfilepath.Text = "";
        }

        private void radioexcelbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioexcelbtn.Checked)
            {
                sampleexcel.Visible = true;
                samplejsonlink.Visible = radiojsonfile.Checked = false;
            }
            txtfilepath.Text = "";
        }

        private void generatebutton_Click(object sender, EventArgs e)
        {
            GenerateFlowchartFromExcel(txtfilepath.Text);
        }

        private void samplejsonlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SampleFile();
        }

        private void SampleFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string srcpath = "";
                if (radiojsonfile.Checked)
                {
                    saveFileDialog.Filter = "JSON Documents (*.json)|*.json";//filter
                    srcpath = "Sample.json";
                }
                else if (radioexcelbtn.Checked)
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls";//filter
                    srcpath = "Sample.xlsx";
                }
                saveFileDialog.Title = "Save As";
                saveFileDialog.FileName = "Sample";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    // Save your file here
                    File.Copy(srcpath, path); // Example for text
                }
            }
        }

        private void sampleexcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SampleFile();
        }
    }
}
