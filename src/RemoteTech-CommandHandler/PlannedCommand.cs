﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteTech.CommandHandler
{
    class PlannedCommand
    {
        public const string configNodeName = "PlannedCommand";

        public readonly ICommand command;
        public readonly ICondition condition;
        public readonly Guid vesselId;

        public PlannedCommand(ConfigNode node)
        {

        }

        public PlannedCommand(ICommand cmd, ICondition cond, Guid vesselGuid)
        {
            command = cmd;
            condition = cond;
            vesselId = vesselGuid;
        }

        public void Save(ConfigNode node)
        {
            var cmdNode = node.AddNode(Command.commandNodeName);
            Command.Save(command, cmdNode);
            //var condNode = node.AddNode(Condition.conditionNodeName);
        }
    }
}
