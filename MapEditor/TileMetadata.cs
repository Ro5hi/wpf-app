using System;
using Newtonsoft.Json;

namespace Aeon.Data.Tilesets
{
    /// <summary>
    /// Contains metadata for a given tileset
    /// </summary>
    class TileMetadata : ICloneable
    {
        [JsonProperty("top_left")]
        Point _topLeft;

        public Point TopLeft => _topLeft;

        public TileMetadata()
        {
            
        }
        
        
        /// <summary>
        /// A constructor used for cloning
        /// </summary>
        /// <param name="other"></param>
        internal TileMetadata(TileMetadata other)
        {
            _topLeft = other._topLeft;
        }
        
        public object Clone()
        {
            return new TileMetadata(this);
        }
    }
}