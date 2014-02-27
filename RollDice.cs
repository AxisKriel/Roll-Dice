using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace RollDice
{
	[ApiVersion(1, 15)]
	public class RollDice : TerrariaPlugin
	{
		public override Version Version
		{
			get { return new Version(2, 1); }
		}

		public override string Name
		{
			get { return "Dice Roll"; }
		}

		public override string Author
		{
			get { return "nicatronTg, updated by Enerdy"; }
		}

		public override string Description
		{
			get { return "Roll the magical dice of Random"; }
		}

		public RollDice(Main game) : base(game)
		{
		}

		public override void Initialize()
		{
			TShockAPI.Commands.ChatCommands.Add(new Command("roll", Roll, "roll"));
		}

		private static void Roll(CommandArgs args)
		{
			Random r = new Random();
			TShockAPI.TShock.Utils.Broadcast(args.Player.Name + " rolls a " + r.Next(0, 100), Color.Yellow);
		}
	}
}
