using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace space
{
    class Events : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnected(Player player)
        {
            player.SendChatMessage("Erfolgreich verbunden!");
        }

        [ServerEvent(Event.PlayerSpawn)]
        public void OnPlayerSpawn(Player player)
        {
            player.Health = 50;
            player.Armor = 25;
        }
    }
}
