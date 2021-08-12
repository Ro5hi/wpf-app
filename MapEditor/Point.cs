using Newtonsoft.Json;

namespace Aeon.Data.Tilesets
{
    /// <summary>
    /// Represents an XY Coordinate
    /// </summary>
    class Point
    {
        [JsonProperty("x")]
        string _x;
        
        [JsonProperty("y")]
        string _y;

        public string X => _x;
        public string Y => _y;
    }
}