using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Characters;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_3b1b4803df14c314f9c8257e88fcbf13 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_11cf91c33b7547959c5ccf0873956021_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_d8aa8febc1354e8b9cdb242c13aadf07_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_bcf076bb7b68451e819e28254ac34682_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_96b408b6eb3f43e88bd67e53495705f4_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_3ea96f48f3c94fc797b23b4d7cc37d2b_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_60cee840545c4d31a67e48d8a9780d1d_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_1ceff119d37047a692ce99a7617c1085_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_99706a1e244546d281578b0cf95814a7_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_9103b77c387e483a90efef373934e769_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_ef95874f2b4a4087bfd5b74050827d56_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_5183ba0057ba48bb8b8c31db2499f5eb_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_1c74b3c3d69f4285b7283f692166454d_CommandTarget;

		private CharacterController _3b1b4803df14c314f9c8257e88fcbf13_1f12811b48e241969e7dd38d7a99f940_CommandTarget;

		private IClient client;

		private CoherenceBridge bridge;

		private readonly Dictionary<string, Binding> bakedValueBindings;

		private Dictionary<string, Action<CommandBinding, CommandsHandler>> bakedCommandBindings;

		public override Binding BakeValueBinding(Binding valueBinding)
		{
			return null;
		}

		public override void BakeCommandBinding(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_11cf91c33b7547959c5ccf0873956021(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_11cf91c33b7547959c5ccf0873956021(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_11cf91c33b7547959c5ccf0873956021(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_11cf91c33b7547959c5ccf0873956021(_3b1b4803df14c314f9c8257e88fcbf13_11cf91c33b7547959c5ccf0873956021 command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_d8aa8febc1354e8b9cdb242c13aadf07(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_d8aa8febc1354e8b9cdb242c13aadf07(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_d8aa8febc1354e8b9cdb242c13aadf07(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_d8aa8febc1354e8b9cdb242c13aadf07(_3b1b4803df14c314f9c8257e88fcbf13_d8aa8febc1354e8b9cdb242c13aadf07 command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_bcf076bb7b68451e819e28254ac34682(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_bcf076bb7b68451e819e28254ac34682(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_bcf076bb7b68451e819e28254ac34682(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_bcf076bb7b68451e819e28254ac34682(_3b1b4803df14c314f9c8257e88fcbf13_bcf076bb7b68451e819e28254ac34682 command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_96b408b6eb3f43e88bd67e53495705f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_96b408b6eb3f43e88bd67e53495705f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_96b408b6eb3f43e88bd67e53495705f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_96b408b6eb3f43e88bd67e53495705f4(_3b1b4803df14c314f9c8257e88fcbf13_96b408b6eb3f43e88bd67e53495705f4 command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_3ea96f48f3c94fc797b23b4d7cc37d2b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_3ea96f48f3c94fc797b23b4d7cc37d2b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_3ea96f48f3c94fc797b23b4d7cc37d2b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_3ea96f48f3c94fc797b23b4d7cc37d2b(_3b1b4803df14c314f9c8257e88fcbf13_3ea96f48f3c94fc797b23b4d7cc37d2b command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_60cee840545c4d31a67e48d8a9780d1d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_60cee840545c4d31a67e48d8a9780d1d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_60cee840545c4d31a67e48d8a9780d1d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_60cee840545c4d31a67e48d8a9780d1d(_3b1b4803df14c314f9c8257e88fcbf13_60cee840545c4d31a67e48d8a9780d1d command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_1ceff119d37047a692ce99a7617c1085(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_1ceff119d37047a692ce99a7617c1085(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_1ceff119d37047a692ce99a7617c1085(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_1ceff119d37047a692ce99a7617c1085(_3b1b4803df14c314f9c8257e88fcbf13_1ceff119d37047a692ce99a7617c1085 command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_99706a1e244546d281578b0cf95814a7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_99706a1e244546d281578b0cf95814a7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_99706a1e244546d281578b0cf95814a7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_99706a1e244546d281578b0cf95814a7(_3b1b4803df14c314f9c8257e88fcbf13_99706a1e244546d281578b0cf95814a7 command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_9103b77c387e483a90efef373934e769(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_9103b77c387e483a90efef373934e769(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_9103b77c387e483a90efef373934e769(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_9103b77c387e483a90efef373934e769(_3b1b4803df14c314f9c8257e88fcbf13_9103b77c387e483a90efef373934e769 command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_ef95874f2b4a4087bfd5b74050827d56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_ef95874f2b4a4087bfd5b74050827d56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_ef95874f2b4a4087bfd5b74050827d56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_ef95874f2b4a4087bfd5b74050827d56(_3b1b4803df14c314f9c8257e88fcbf13_ef95874f2b4a4087bfd5b74050827d56 command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_5183ba0057ba48bb8b8c31db2499f5eb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_5183ba0057ba48bb8b8c31db2499f5eb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_5183ba0057ba48bb8b8c31db2499f5eb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_5183ba0057ba48bb8b8c31db2499f5eb(_3b1b4803df14c314f9c8257e88fcbf13_5183ba0057ba48bb8b8c31db2499f5eb command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_1c74b3c3d69f4285b7283f692166454d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_1c74b3c3d69f4285b7283f692166454d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_1c74b3c3d69f4285b7283f692166454d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_1c74b3c3d69f4285b7283f692166454d(_3b1b4803df14c314f9c8257e88fcbf13_1c74b3c3d69f4285b7283f692166454d command)
		{
		}

		private void BakeCommandBinding__3b1b4803df14c314f9c8257e88fcbf13_1f12811b48e241969e7dd38d7a99f940(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b1b4803df14c314f9c8257e88fcbf13_1f12811b48e241969e7dd38d7a99f940(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b1b4803df14c314f9c8257e88fcbf13_1f12811b48e241969e7dd38d7a99f940(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b1b4803df14c314f9c8257e88fcbf13_1f12811b48e241969e7dd38d7a99f940(_3b1b4803df14c314f9c8257e88fcbf13_1f12811b48e241969e7dd38d7a99f940 command)
		{
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
		}

		public override void CreateEntity(bool usesLodsAtRuntime, string archetypeName, AbsoluteSimulationFrame simFrame, List<ICoherenceComponentData> components)
		{
		}

		public override void Dispose()
		{
		}

		public override void Initialize(Entity entityId, CoherenceBridge bridge, IClient client, CoherenceInput input, Logger logger)
		{
		}
	}
}
