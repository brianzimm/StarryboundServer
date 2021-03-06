﻿/* 
 * Starrybound Server
 * Copyright 2013, Avilance Ltd
 * Created by Zidonuke (zidonuke@gmail.com) and Crashdoom (crashdoom@avilance.com)
 * 
 * This file is a part of Starrybound Server.
 * Starrybound Server is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
 * Starrybound Server is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 * You should have received a copy of the GNU General Public License along with Starrybound Server. If not, see http://www.gnu.org/licenses/.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.avilance.Starrybound.Commands
{
    class Me : CommandBase
    {
        public Me(Client client)
        {
            this.name = "me";
            this.HelpText = " <message>: Sends an emote message.";
            this.Permission = new List<string>();
            this.Permission.Add("chat.emote");

            this.client = client;
            this.player = client.playerData;
        }

        public override bool doProcess(string[] args)
        {
            //if (!hasPermission()) { permissionError(); return false; }

            string message = string.Join(" ", args).Trim();

            if (message == null || message.Length < 1) { showHelpText(); return false; }

            StarryboundServer.sendGlobalMessage(this.player.name + " " + message, "#f49413");
            return true;
        }
    }
}
