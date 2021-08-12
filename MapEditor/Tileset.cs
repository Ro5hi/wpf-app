using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace Aeon.Data.Tilesets
{
    /// <summary>
    /// Contains tileset data
    /// </summary>
    public class Tileset : ICloneable, IDisposable
    {
        string _path;
        TilesetIdentifier _identifier;
        TilesetMetadata _metadata;
        Bitmap _bitmap;

        public int Id => _identifier.Id;
        public string Name => _identifier.Name;
        public string Biome => _metadata.Biome;
        
        internal Tileset(string path, TilesetIdentifier identifier, TilesetMetadata metadata)
        {
            _path = path;
            _identifier = identifier;
            _metadata = metadata;
        }

        /// <summary>
        /// A constructor used for cloning
        /// </summary>
        /// <param name="other"></param>
        internal Tileset(Tileset other)
        {
            _path = other._path;
            _identifier = (TilesetIdentifier)other._identifier.Clone();
            _metadata = (TilesetMetadata)other._metadata.Clone();
        }

        /// <summary>
        /// Loads image data from the tilesets path into memory.
        /// </summary>
        /// <returns></returns>
        internal Tileset LoadImage()
        {
            _bitmap = new Bitmap($@"{_path}\image.png");
            return this;
        }
        
        public object Clone()
        {
            return new Tileset(this);
        }
        
        public void Dispose()
        {
            _bitmap?.Dispose();
        }
        
        /// <summary>
        /// Returns bitmaps for every tile within the tileset
        /// </summary>
        /// <returns></returns>
        public Bitmap[] GetAllTiles()
        {
            List<Bitmap> tiles = new List<Bitmap>();
            for (int i = 0; i < _metadata.NumTiles; i++)
            {
                tiles.Add(GetTile(i));
            }

            return tiles.ToArray();
        }

        /// <summary>
        /// Fetches a tile at a given index. Indexes are left to right, top to bottom within the file.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Bitmap GetTile(int index)
        {
            int x = (index % _metadata.NumColumns) * _metadata.TileWidth;
            int y = index / _metadata.NumColumns * _metadata.TileHeight;
            return GetTile(x, y);
        }

        /// <summary>
        /// Fetches a tile at a given x/y coordinate. Returns null if the coordinates are invalid.
        /// </summary>
        /// <param name="x">The X coordinate of the tiles top left corner</param>
        /// <param name="y">The Y coordinate of the tiles top left corner</param>
        /// <returns></returns>
        Bitmap GetTile(int x, int y)
        {
            if (!(x + _metadata.TileWidth > _metadata.FileWidth || x + _metadata.TileWidth < 0))
            {
                if (!(x + _metadata.TileWidth > _metadata.FileWidth || x + _metadata.TileWidth < 0))
                {
                    Rectangle rectangle = new Rectangle(x, y, _metadata.TileWidth, _metadata.TileHeight);
                    return _bitmap.Clone(rectangle, PixelFormat.DontCare);
                }
            }

            return null;
        }
    }
}