using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MapEditor
{

    public class TileSetElement
    {
        public int m_ID;
        public Image m_Image;
        public NameScope m_Name;

        public TileSetElement(int ID, Image img, NameScope name)
        {
            m_ID = ID;
            m_Image = img;
            m_Name = name;
        }

        public class TileSetManager
        {
            private Canvas m_TileSetCanvas;

            private List<TileSetElement> m_TileSetElements = new List<TileSetElement>();

            public TileSetElement m_SelectedTileSetElement;

            public string m_LoadTileSet;

            public void Init(Canvas tileSetCanvas)
            {
                m_TileSetCanvas = tileSetCanvas;
            }
        }
    }
}