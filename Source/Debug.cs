﻿using System;
using ColossalFramework;

namespace DistrictRCI
{
	public class Debug{
		static bool  DEBUG = true;
		public static void Print(object obj){
			if(DEBUG){
				DebugOutputPanel.AddMessage (ColossalFramework.Plugins.PluginManager.MessageType.Message, obj.ToString ());
			}
		}
	}
}

