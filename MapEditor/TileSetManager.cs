using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Aeon.Data.Tilesets
{
    public static class TilesetManager
    {
        static Dictionary<int, Tileset> _tilesets 
            = new Dictionary<int, Tileset>();
            
        public static void Init(string tilesetDirectory)
        {
            string json = File.ReadAllText($@"{tilesetDirectory}\meta.json");
            TilesetIdentifier[] identifiers = JsonConvert.DeserializeObject<TilesetIdentifier[]>(json);

            foreach (TilesetIdentifier identifier in identifiers)
            {
                string path = $@"{tilesetDirectory}\{identifier.Name}";
                json = File.ReadAllText($@"{path}\meta.json");
                TilesetMetadata metadata = JsonConvert.DeserializeObject<TilesetMetadata>(json);
                Tileset ts = new Tileset(path, identifier, metadata);
                _tilesets.Add(ts.Id, ts);
            }
        }

        public static Tileset GetTilesetById(int id)
        {
            if (_tilesets.ContainsKey(id))
            {
                return ((Tileset)_tilesets[id].Clone()).LoadImage();
            }

            return null;
        }

        public static Tileset GetTilesetByName(string name)
        {
            foreach (Tileset tileset in _tilesets.Values)
            {
                if (tileset.Name == name)
                {
                    return ((Tileset)tileset.Clone()).LoadImage();
                }
            }

            return null;
        }

        public static Tileset[] GetAllTilesetsOfBiomeType(string biome)
        {
            List<Tileset> tilesets = new List<Tileset>();
            foreach (Tileset tileset in _tilesets.Values)
            {
                if (tileset.Biome.Equals(biome))
                {
                    tilesets.Add(((Tileset)tileset.Clone()).LoadImage());
                }
            }

            return tilesets.ToArray();
        }
    }
}