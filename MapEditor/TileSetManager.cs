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

            public TileSetElement GetTileSetFromImage(Image img)
            {
                for (int i = 0; i < m_TileSetElements.Count; i++)
                {
                    if (m_TileSetElements[i].m_Image == img)
                    {
                        return m_TileSetElements[i];
                    }
                }
                return null;
            }

            public TileSetElement GetTileSetID(int id)
            {
                for (int i = 0; i < m_TileSetElements.Count; i++)
                {
                    if (m_TileSetElements[i].m_ID == id)
                    {
                        return m_TileSetElements[i];
                    }
                }
                return null;
            }

            public void LoadTile(int tileWidth, int tileHeight, string loadedPath)
            {
                BitmapImage img = new BitmapImage(new Uri(loadedPath, UriKind.Absolute));

                m_LoadTileSet = loadedPath;

                double xAmountOfTile = img.PixelWidth / tileWidth;
                double yAmountOfTile = img.PixelHeight / tileHeight;

                int positionX = -1;
                int positionY = 0;

                if (m_TileSetCanvas.Children.Count > 0)
                {
                    m_TileSetCanvas.Children.Clear();
                    m_TileSetElements.Clear();
                }
            }

        }
}