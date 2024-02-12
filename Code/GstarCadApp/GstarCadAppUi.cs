using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Developer : Venekata Durga Prasad K
/// Date : Feb 11 , 2023
/// Rev : 01
/// </summary>

namespace GstarCadApp
{
    public partial class GstarCadAppUi : Form
    {

       
        GstarCadWrapper gstarCadWrapper ;
        public GstarCadAppUi()
        {
            InitializeComponent();
            gstarCadWrapper = new GstarCadWrapper();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel_Layers.Hide();
            gstarCadWrapper.ConnectToGCad();          
        }

        GstarCadWrapper.GstarAppCommands strGstarCadCmd = GstarCadWrapper.GstarAppCommands.UnKnown;

        /// <summary>
        /// Load Model Command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click_1(object sender, EventArgs e)
        {
            strGstarCadCmd = GstarCadWrapper.GstarAppCommands.OpenModel;
            Panel_LoadInputs.Show();
            Panel_Layers.Hide();
        }


        /// <summary>
        /// Show Layers Command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            checkBox_AllLayers.Checked = false;
            Panel_LoadInputs.Hide();
            Panel_Layers.Show();

            strGstarCadCmd = GstarCadWrapper.GstarAppCommands.LayerShow;

            listBox_LayerNames.Items.Clear();

            List<string> allLayers =  gstarCadWrapper.GetAllLayers();

            listBox_LayerNames.Items.AddRange(allLayers.ToArray());

        }


        /// <summary>
        /// Select DWG file to Load into session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {               
                Title = "Browse DWG Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "dwg",
                Filter = "dwg files (*.dwg)|*.dwg",
                FilterIndex = 2,
                RestoreDirectory = true,
                
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }


        /// <summary>
        /// Hide Layers Command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_HideLayers_Click(object sender, EventArgs e)
        {
            Panel_LoadInputs.Hide();
            Panel_Layers.Show();

            checkBox_AllLayers.Checked = false;

            strGstarCadCmd = GstarCadWrapper.GstarAppCommands.LayerHide;
            listBox_LayerNames.Items.Clear();

            List<string> allLayers = gstarCadWrapper.GetAllLayers();

            listBox_LayerNames.Items.AddRange(allLayers.ToArray());            

        }

        /// <summary>
        /// Save Command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {

            gstarCadWrapper.Save();

            MessageBox.Show("Successfully completed the Commnad : Save" , "GStarCadApp");

        }


        /// <summary>
        /// Command Execution using Apply button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Apply_Click(object sender, EventArgs e)
        {
            bool allLayers = false;
            List<string> layerNames = new List<string>();
            if (checkBox_AllLayers.Checked)
            {
                allLayers = true;
            }
            else if(listBox_LayerNames.SelectedItems.Count > 0)
            {                
                foreach (var item in listBox_LayerNames.SelectedItems)
                {
                    layerNames.Add(item.ToString());
                }
            }
           

            string CmdName = string.Empty;
            switch (strGstarCadCmd)
            {
                case GstarCadWrapper.GstarAppCommands.LayerShow:
                    {
                        CmdName = "Show Layers";
                        gstarCadWrapper.TurnOnLayers(layerNames, allLayers);
                        break;
                    }
                case GstarCadWrapper.GstarAppCommands.LayerHide:
                    {
                        CmdName = "Hide Layers";
                        gstarCadWrapper.TurnOffLayers(layerNames, allLayers);
                        break;
                    }
                case GstarCadWrapper.GstarAppCommands.OpenModel:
                    {
                        CmdName = "Load Model";
                        if (!string.IsNullOrEmpty(textBox1.Text))
                        { gstarCadWrapper.LoadModel(textBox1.Text); }
                        break;
                    }
                case GstarCadWrapper.GstarAppCommands.UnKnown:
                    {
                        break;
                    }

                   
            }

            MessageBox.Show("Successfully completed the Commnad : " + CmdName, "GStarCadApp");

        }

        /// <summary>
        /// Check box value change event to get layer info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_AllLayers_CheckedChanged(object sender, EventArgs e)
        {
            bool selectAll = false;
            if (checkBox_AllLayers.Checked)
            {

                selectAll = true;              
            }

            for (int val = 0; val < listBox_LayerNames.Items.Count; val++)
            {
                listBox_LayerNames.SetSelected(val, selectAll);
            }

        }
    }
}
