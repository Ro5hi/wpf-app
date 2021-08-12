using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aeon.Data.Tilesets
{
    public class TilesetMetadata : ICloneable
    {
        [JsonProperty("biome")]
        string _biome;
        
        [JsonProperty("tile_width")] 
        int _tileWidth;
            
        [JsonProperty("tile_height")]
        int _tileHeight;
        
        [JsonProperty("file_width")]
        int _fileWidth;
        
        [JsonProperty("file_height")]
        int _fileHeight;

        [JsonProperty("tiles")] Dictionary<int, TileMetadata> _tileMetadata = new Dictionary<int, TileMetadata>();
        
        public TilesetIdentifier Identifier { get; internal set; }
        public string Biome => _biome;
        public int TileWidth => _tileWidth;
        public int TileHeight => _tileHeight;
        public int FileWidth => _fileWidth;
        public int FileHeight => _fileHeight;
        public int NumRows => _fileWidth / _tileHeight;
        public int NumColumns => _fileHeight / _tileHeight;
        public int NumTiles => NumRows * NumColumns;
        internal Dictionary<int, TileMetadata> TileMetadata => _tileMetadata;

        public TilesetMetadata()
        {
            
        }
        
        /// <summary>
        /// A constructor used for cloning
        /// </summary>
        /// <param name="other"></param>
        internal TilesetMetadata(TilesetMetadata other)
        {
            _biome = other._biome;
            _fileWidth = other._fileWidth;
            _fileHeight = other._fileHeight;
            _tileWidth = other._tileWidth;
            _tileHeight = other._tileHeight;

            //foreach over a value type is not efficient,  will suffice for now
            foreach (int key in other._tileMetadata.Keys)
            {
                _tileMetadata.Add(key, (TileMetadata)other._tileMetadata[key].Clone());
            }
        }

        public object Clone()
        {
            return new TilesetMetadata(this);
        }
    }
}