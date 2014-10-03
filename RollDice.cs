using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace RollDice
{
	[ApiVersion(1, 16)]
	public class RollDice : TerrariaPlugin
	{
		public override string Author
		{
			get { return "nicatronTg, updated by Enerdy"; }
		}

		public override string Description
		{
			get { return "Roll the magical dice of Random"; }
		}

		public override string Name
		{
			get { return "Dice Roll"; }
		}

		public override Version Version
		{
			get { return new Version(2, 3); }
		}

		public RollDice(Main game)
			: base(game)
		{

		}

		public override void Initialize()
		{
			Commands.ChatCommands.Add(new Command("roll", Roll, "roll"));
		}

		void Roll(CommandArgs args)
		{
			Random r = new Random();
			TSPlayer.All.SendInfoMessage(args.Player.Name + " rolls a " + r.Next(1, 101));
		}
	}
}
