using System;
using Newtonsoft.Json;

namespace Aeon.Data.Tilesets
{
    public class TilesetIdentifier : ICloneable
    {
        [JsonProperty("id")]
        int _id;
        
        [JsonProperty("name")]
        string _name;
        
        public int Id => _id;
        public string Name => _name;

        public TilesetIdentifier()
        {
            
        }
        
        internal TilesetIdentifier(TilesetIdentifier other)
        {
            _id = other._id;
            _name = other._name;
        }

        public object Clone()
        {
            return new TilesetIdentifier(this);
        }
    }
}