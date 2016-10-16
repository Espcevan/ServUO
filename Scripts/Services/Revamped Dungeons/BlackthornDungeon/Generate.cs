using Server;
using System;
using System.Collections.Generic;
using Server.Mobiles;
using Server.Items;
using Server.Gumps;
using System.Linq;
using Server.Commands;

namespace Server.Engines.Blackthorn
{
    public static class GenerateBlackthornDungeon
    {
        public static void Initialize()
        {
            CommandSystem.Register("GenBlackthorn", AccessLevel.Administrator, Generate);
        }

        public static void Generate(CommandEventArgs e)
        {
            Mobile m = e.Mobile;

            Generate(Map.Trammel);
            Generate(Map.Felucca);

            CommandSystem.Handle(m, Server.Commands.CommandSystem.Prefix + "XmlLoad Spawns/BlackthornDungeon.xml");
        }

        public static void Generate(Map map)
        {
            DungeonHitchingPost post = new DungeonHitchingPost();
            post.MoveToWorld(new Point3D(6428, 2677, 0), map);

            MetalDoor door = new MetalDoor(DoorFacing.WestCCW);
            door.MoveToWorld(new Point3D(6409, 2695, 0), map);

            door = new MetalDoor(DoorFacing.EastCW);
            door.MoveToWorld(new Point3D(6410, 2695, 0), map);

            door = new MetalDoor(DoorFacing.WestCW);
            door.MoveToWorld(new Point3D(6409, 2664, 0), map);

            door = new MetalDoor(DoorFacing.EastCCW);
            door.MoveToWorld(new Point3D(6410, 2664, 0), map);

            door = new MetalDoor(DoorFacing.NorthCW);
            door.MoveToWorld(new Point3D(6425, 2679, 0), map);

            door = new MetalDoor(DoorFacing.SouthCCW);
            door.MoveToWorld(new Point3D(6425, 2680, 0), map);

            door = new MetalDoor(DoorFacing.SouthCW);
            door.MoveToWorld(new Point3D(6394, 2680, 0), map);

            door = new MetalDoor(DoorFacing.NorthCCW);
            door.MoveToWorld(new Point3D(6394, 2679, 0), map);
        }
    }
}