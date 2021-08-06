using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tools
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
        private MapEditor.TileSetElement.TileSetManager m_TilesetManager;


        public void Init(MapEditor.TileSetElement.TileSetManager tileSetManager,
                         MapEditor.TileSetElement.TileSetManager m_TileSetManager)
        {
            m_TileSetManager = tileSetManager;
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


        
    }

}