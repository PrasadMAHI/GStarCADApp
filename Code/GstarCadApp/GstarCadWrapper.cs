using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;


using GrxCAD.Interop;


/// <summary>
/// Developer : Venekata Durga Prasad K
/// Date : Feb 11 , 2023
/// Rev : 01
/// </summary>


namespace GstarCadApp
{
    public class GstarCadWrapper
    {

        public enum GstarAppCommands
        {
            LayerShow,
            LayerHide,
            OpenModel,
            Save,
            UnKnown
        };
        public GcadApplication GcadApp { get; set; }

        private GcadDocument gCadDoc =  null;
        /// <summary>
        /// Launch new Gstar CAD app, if it's not running or else connect to existing one
        /// </summary>
        /// <returns>True - Succcess, False - Failure </returns>
        public bool ConnectToGCad()
        {
            try
            {
                if (IsGStarCadRunning()) //GstarCAD already running 
                {
                    object objGcadApp = Marshal.GetActiveObject("Gcad.GcadApplication");
                    GcadApp = (GcadApplication)objGcadApp;
                }
                else
                { //GstarCAD not running
                    GcadApp = new GcadApplication();
                    GcadApp.Visible = true;
                }

                return GcadApp != null;
            }
            catch (Exception)
            {
            }

            return false;
          }

        /// <summary>
        /// Check GStar CAD is running in the machine or not
        /// </summary>
        /// <returns></returns>
        private bool IsGStarCadRunning()
        {
            try
            {
                Process[] pname = Process.GetProcessesByName("gcad");
                if (pname.Length == 0)
                {
                    return false;
                }
                else
                { 
                    return true; 
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Load/Open  model in Gstar current session
        /// </summary>
        /// <param name="modelPath">DXF/DWG file path to open</param>
        /// <returns>True - Succcess, False - Failure </returns>
        public bool LoadModel(string modelPath)
        {
            if (GcadApp == null)
                return false;
            GcadDocuments gCadDocs = GcadApp.Documents;

             gCadDoc =  gCadDocs.Open(modelPath);

            return  gCadDoc != null;
        }

        /// <summary>
        /// Get all layer names in the active document
        /// </summary>
        /// <returns>list of layers</returns>
        public List<string> GetAllLayers()
        {
            List<string> layerNames = new List<string>();

            if (gCadDoc == null)
                return layerNames;

            GcadLayers gCadLayers = gCadDoc.Layers;

            int layerCount = gCadLayers.Count;

            for (int idx = 0; idx < layerCount; ++idx)
            {
                GcadLayer gCadLayer = gCadLayers.Item(idx);

                string layerName = gCadLayer.Name;

                layerNames.Add(layerName);            
            }

            return layerNames;
        }

        /// <summary>
        /// ON Layers by names in the active/current document
        /// </summary>
        /// <param name="LayerNames">list of Layer Names to show</param>
        /// <param name="allLayers">True - All layers,False - specified layers</param>
        /// <returns></returns>
        public bool TurnOnLayers(List<string> LayerNames, bool allLayers = false)
        {
            return LayersOnAndOFF(LayerNames, true, allLayers);
        }


        /// <summary>
        /// OFF Layers by names in the active/current document
        /// </summary>
        /// <param name="LayerNames">list of Layer Names to hide</param>
        /// <param name="allLayers">True - All layers,False - specified layers</param>
        /// <returns></returns>
        public bool TurnOffLayers(List<string> LayerNames, bool allLayers = false)
        {           
            return LayersOnAndOFF(LayerNames, false, allLayers);
        }

        /// <summary>
        /// Layers hide and show in GStar CAD document...
        /// </summary>
        /// <param name="LayerNames"> list of Layer Names to hide/show</param>
        /// <param name="layerONOrOFF">True : ON, False - Off</param>
        /// <param name="allLayers">True - All layers,False - specified layers</param>
        /// <returns></returns>

        private bool LayersOnAndOFF(List<string> LayerNames, bool layerONOrOFF, bool allLayers = false)
        {
            GcadLayers gCadLayers = gCadDoc.Layers;

            int layerCount = gCadLayers.Count;

            for (int idx = 0; idx < layerCount; ++idx)
            {
                GcadLayer gCadLayer = gCadLayers.Item(idx);
                string layerName = gCadLayer.Name;

                if (allLayers)
                {
                    gCadLayer.LayerOn = layerONOrOFF;
                }
                else if (LayerNames.Contains(layerName))
                {
                    gCadLayer.LayerOn = layerONOrOFF;
                }
            }

            return true;
        }

        /// <summary>
        /// Save active gstar CAD document with latest changes, calling save only in case of document modifies
        /// </summary>
        public void  Save()
        {           

            //if(!gCadDoc.Saved)
            //{
                gCadDoc.Save();
            //}

        }


        /// <summary>
        ///  Convert document to DXF/DWG
        /// </summary>
        /// <param name="modelPath"></param>

        public void SaveAs(string modelPath)
        { 
            if (gCadDoc != null)
            {
               // GcSaveAsType saveAsType;
                gCadDoc.SaveAs(modelPath);
            }

        }

    }
}
