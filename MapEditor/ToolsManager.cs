using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MapEditor
{
    public enum EditMode
    {
        Draw,
        Fill,
        Erase,
        DeleteFill
    }

    public class ToolsManager
    {
        private EditMode m_EditMode = EditMode.Draw;
        private TileSetManager m_TilesetManager;


        public void Init(TileSetManager tileSetManager)
        {
            m_TilesetManager = tileSetManager;
        }

        public EditMode DrawOnGrid(EditMode editMode)
        {
            m_EditMode = editMode;
            return m_EditMode; 
        }

        public EditMode DrawOnGridActive() { return m_EditMode; }

        public EditMode DrawOnGridNew(EditMode editMode)
        {
            m_EditMode = editMode;
            return m_EditMode;
        }

        public void MouseOverGrid(object sender, MouseEventArgs e)
        {
            bool mouseDown = System.Windows.Input.Mouse.LeftButton == MouseButtonState.Pressed;

            if (mouseDown)
            {
                Image img = (Image)sender;
                double x = Canvas.GetLeft(img);
                double y = Canvas.GetTop(img);


            }
        }

        public void DrawTileBasedOnID(TileSetElement element, int id)
        {
            if (id == -1)
            {

            }
            else
            {

            }
        }

        
    }

}