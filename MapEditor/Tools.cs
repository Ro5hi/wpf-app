using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tools
{
    public class Element
    {
        public int ID;
        public Image image;
        public Name name;

        <param name="id">ID</param>
        <param name="img">Image</param>
        <param name="name">Name</param>
        
        public TileSetElement(int id, Image img, Name name)
            ID = id;
            Image = img; 
            Name = name;
    }

    public class 
}