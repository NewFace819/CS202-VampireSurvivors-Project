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
	public class CoherenceSync_3c697731337d91d44840227ca0707343 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _3c697731337d91d44840227ca0707343_0fd1245450dc4dccae84d560c352d7c8_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_dc5369b2b20b462ab65b03bdcd77383b_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_f3837b1ca4fd4618afb1113599d39fa4_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_56553b2b5aa846aaad32a4ac9d9e999b_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_ca7a34d81f654324beef4415305f4c8e_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_897a3544a31d4b4686eb0fce6549a343_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_bd6fe328fa8740fb9be8089beae376f0_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_6159cc1c1b56420994cc9dfd0614eb15_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_4d9ab27703804a4ebcf74773aebe2cb6_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_51179fe380d04e22820cc781e73c274b_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_58086d43c32d4850b0e5c003d6941f13_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_a1fb500c63b042e49f42ceeabcff9074_CommandTarget;

		private CharacterController _3c697731337d91d44840227ca0707343_584b5eed7ccf4609bc0f3f16163c0f98_CommandTarget;

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

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_0fd1245450dc4dccae84d560c352d7c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_0fd1245450dc4dccae84d560c352d7c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_0fd1245450dc4dccae84d560c352d7c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_0fd1245450dc4dccae84d560c352d7c8(_3c697731337d91d44840227ca0707343_0fd1245450dc4dccae84d560c352d7c8 command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_dc5369b2b20b462ab65b03bdcd77383b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_dc5369b2b20b462ab65b03bdcd77383b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_dc5369b2b20b462ab65b03bdcd77383b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_dc5369b2b20b462ab65b03bdcd77383b(_3c697731337d91d44840227ca0707343_dc5369b2b20b462ab65b03bdcd77383b command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_f3837b1ca4fd4618afb1113599d39fa4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_f3837b1ca4fd4618afb1113599d39fa4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_f3837b1ca4fd4618afb1113599d39fa4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_f3837b1ca4fd4618afb1113599d39fa4(_3c697731337d91d44840227ca0707343_f3837b1ca4fd4618afb1113599d39fa4 command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_56553b2b5aa846aaad32a4ac9d9e999b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_56553b2b5aa846aaad32a4ac9d9e999b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_56553b2b5aa846aaad32a4ac9d9e999b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_56553b2b5aa846aaad32a4ac9d9e999b(_3c697731337d91d44840227ca0707343_56553b2b5aa846aaad32a4ac9d9e999b command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_ca7a34d81f654324beef4415305f4c8e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_ca7a34d81f654324beef4415305f4c8e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_ca7a34d81f654324beef4415305f4c8e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_ca7a34d81f654324beef4415305f4c8e(_3c697731337d91d44840227ca0707343_ca7a34d81f654324beef4415305f4c8e command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_897a3544a31d4b4686eb0fce6549a343(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_897a3544a31d4b4686eb0fce6549a343(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_897a3544a31d4b4686eb0fce6549a343(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_897a3544a31d4b4686eb0fce6549a343(_3c697731337d91d44840227ca0707343_897a3544a31d4b4686eb0fce6549a343 command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_bd6fe328fa8740fb9be8089beae376f0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_bd6fe328fa8740fb9be8089beae376f0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_bd6fe328fa8740fb9be8089beae376f0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_bd6fe328fa8740fb9be8089beae376f0(_3c697731337d91d44840227ca0707343_bd6fe328fa8740fb9be8089beae376f0 command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_6159cc1c1b56420994cc9dfd0614eb15(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_6159cc1c1b56420994cc9dfd0614eb15(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_6159cc1c1b56420994cc9dfd0614eb15(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_6159cc1c1b56420994cc9dfd0614eb15(_3c697731337d91d44840227ca0707343_6159cc1c1b56420994cc9dfd0614eb15 command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_4d9ab27703804a4ebcf74773aebe2cb6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_4d9ab27703804a4ebcf74773aebe2cb6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_4d9ab27703804a4ebcf74773aebe2cb6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_4d9ab27703804a4ebcf74773aebe2cb6(_3c697731337d91d44840227ca0707343_4d9ab27703804a4ebcf74773aebe2cb6 command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_51179fe380d04e22820cc781e73c274b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_51179fe380d04e22820cc781e73c274b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_51179fe380d04e22820cc781e73c274b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_51179fe380d04e22820cc781e73c274b(_3c697731337d91d44840227ca0707343_51179fe380d04e22820cc781e73c274b command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_58086d43c32d4850b0e5c003d6941f13(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_58086d43c32d4850b0e5c003d6941f13(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_58086d43c32d4850b0e5c003d6941f13(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_58086d43c32d4850b0e5c003d6941f13(_3c697731337d91d44840227ca0707343_58086d43c32d4850b0e5c003d6941f13 command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_a1fb500c63b042e49f42ceeabcff9074(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_a1fb500c63b042e49f42ceeabcff9074(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_a1fb500c63b042e49f42ceeabcff9074(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_a1fb500c63b042e49f42ceeabcff9074(_3c697731337d91d44840227ca0707343_a1fb500c63b042e49f42ceeabcff9074 command)
		{
		}

		private void BakeCommandBinding__3c697731337d91d44840227ca0707343_584b5eed7ccf4609bc0f3f16163c0f98(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3c697731337d91d44840227ca0707343_584b5eed7ccf4609bc0f3f16163c0f98(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3c697731337d91d44840227ca0707343_584b5eed7ccf4609bc0f3f16163c0f98(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3c697731337d91d44840227ca0707343_584b5eed7ccf4609bc0f3f16163c0f98(_3c697731337d91d44840227ca0707343_584b5eed7ccf4609bc0f3f16163c0f98 command)
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
