using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace space
{
    class Commands : Script
    {
        [Command("veh", "/veh um ein Fahrzeug zu spawnen.")]
        public void cmd_veh(Player player, string vehname, int color1, int color2)
        {
            uint vehash = NAPI.Util.GetHashKey(vehname);
            if(vehash <= 0)
            {
                player.SendChatMessage("~r~Ungültiger Fahrzeugname!");
                return;
            }
            Vehicle veh = NAPI.Vehicle.CreateVehicle(vehash, player.Position, player.Heading, color1, color2);
            veh.NumberPlate = "SpaceRoleplay";
            veh.Locked = false;
            veh.EngineStatus = true;
            player.SetIntoVehicle(veh, (int)VehicleSeat.Driver);
        }
    }
}
