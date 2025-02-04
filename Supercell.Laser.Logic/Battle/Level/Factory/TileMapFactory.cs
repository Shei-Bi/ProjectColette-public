﻿using System.IO;

namespace Supercell.Laser.Logic.Battle.Level.Factory
{
    using Supercell.Laser.Logic.Data;
    using Supercell.Laser.Titan.Json;
    using Supercell.Laser.Titan.Util;
    using System.Text;

    public static class TileMapFactory
    {
        public static TileMap CreateTileMap(string mapName)
        {
            string[] map = MapLoader.InitWithMapFromDataTable(null, DataTables.Get(19), mapName);
            return new TileMap(map[0].Length,
                                    map.Length,
                                    string.Concat(map));
        }
        public static TileMap CreatePlayerMap(byte[] compressed)
        {
            ZLibHelper.DecompressInMySQLFormat(compressed, out byte[] output);
            string[] MapData = Encoding.UTF8.GetString(output, 0, output.Length).Split("\n");
            string Data = "";
            int.TryParse(MapData[2],out int Height);
            int.TryParse(MapData[1],out int Width);
            Data =String.Concat(MapData.Skip(3).Take(Height));
            //LogicJSONObject obj = jsonObject.GetJSONObject(mapName);
            //if (obj == null) obj = jsonObject.GetJSONObject("Wanted_9");
            return new TileMap(Width, Height, Data); ;
        }
    }
}
