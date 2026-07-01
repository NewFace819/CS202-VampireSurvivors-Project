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
	public class CoherenceSync_1465ff0cbb85b3843bb20d3fb47dd7fa : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_133fb2b294f845698ab2e5e84737eab3_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_7e6e7984b4eb4e4ab401006c34323926_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_a2900a1dd41d4846a40423c51ee0d8b3_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_fdc787bee0e7457a84cc5b941a38302a_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_826890ae76374bff90dc2f51448c832b_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_05d4722fe47e4533ac4a0e93e8ad2ae1_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_30a25435eb3c40a9974c13f7e73b5802_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_725a9a6f277a41c4ae5e5e02f749b370_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_eb9dbe92a48a4d4dafef4096d9c83931_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_eeb2c41c182243b6a7a376bda82b2bb3_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_11e26d0f7bc2425ebbefec0c2ff6be5c_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_f0b9900c53fd41d5b58cc87045cc8cd3_CommandTarget;

		private CharacterController _1465ff0cbb85b3843bb20d3fb47dd7fa_bdf4982ecd374f22852d599654607a18_CommandTarget;

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

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_133fb2b294f845698ab2e5e84737eab3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_133fb2b294f845698ab2e5e84737eab3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_133fb2b294f845698ab2e5e84737eab3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_133fb2b294f845698ab2e5e84737eab3(_1465ff0cbb85b3843bb20d3fb47dd7fa_133fb2b294f845698ab2e5e84737eab3 command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_7e6e7984b4eb4e4ab401006c34323926(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_7e6e7984b4eb4e4ab401006c34323926(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_7e6e7984b4eb4e4ab401006c34323926(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_7e6e7984b4eb4e4ab401006c34323926(_1465ff0cbb85b3843bb20d3fb47dd7fa_7e6e7984b4eb4e4ab401006c34323926 command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_a2900a1dd41d4846a40423c51ee0d8b3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_a2900a1dd41d4846a40423c51ee0d8b3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_a2900a1dd41d4846a40423c51ee0d8b3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_a2900a1dd41d4846a40423c51ee0d8b3(_1465ff0cbb85b3843bb20d3fb47dd7fa_a2900a1dd41d4846a40423c51ee0d8b3 command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_fdc787bee0e7457a84cc5b941a38302a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_fdc787bee0e7457a84cc5b941a38302a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_fdc787bee0e7457a84cc5b941a38302a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_fdc787bee0e7457a84cc5b941a38302a(_1465ff0cbb85b3843bb20d3fb47dd7fa_fdc787bee0e7457a84cc5b941a38302a command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_826890ae76374bff90dc2f51448c832b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_826890ae76374bff90dc2f51448c832b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_826890ae76374bff90dc2f51448c832b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_826890ae76374bff90dc2f51448c832b(_1465ff0cbb85b3843bb20d3fb47dd7fa_826890ae76374bff90dc2f51448c832b command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_05d4722fe47e4533ac4a0e93e8ad2ae1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_05d4722fe47e4533ac4a0e93e8ad2ae1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_05d4722fe47e4533ac4a0e93e8ad2ae1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_05d4722fe47e4533ac4a0e93e8ad2ae1(_1465ff0cbb85b3843bb20d3fb47dd7fa_05d4722fe47e4533ac4a0e93e8ad2ae1 command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_30a25435eb3c40a9974c13f7e73b5802(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_30a25435eb3c40a9974c13f7e73b5802(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_30a25435eb3c40a9974c13f7e73b5802(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_30a25435eb3c40a9974c13f7e73b5802(_1465ff0cbb85b3843bb20d3fb47dd7fa_30a25435eb3c40a9974c13f7e73b5802 command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_725a9a6f277a41c4ae5e5e02f749b370(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_725a9a6f277a41c4ae5e5e02f749b370(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_725a9a6f277a41c4ae5e5e02f749b370(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_725a9a6f277a41c4ae5e5e02f749b370(_1465ff0cbb85b3843bb20d3fb47dd7fa_725a9a6f277a41c4ae5e5e02f749b370 command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_eb9dbe92a48a4d4dafef4096d9c83931(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_eb9dbe92a48a4d4dafef4096d9c83931(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_eb9dbe92a48a4d4dafef4096d9c83931(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_eb9dbe92a48a4d4dafef4096d9c83931(_1465ff0cbb85b3843bb20d3fb47dd7fa_eb9dbe92a48a4d4dafef4096d9c83931 command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_eeb2c41c182243b6a7a376bda82b2bb3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_eeb2c41c182243b6a7a376bda82b2bb3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_eeb2c41c182243b6a7a376bda82b2bb3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_eeb2c41c182243b6a7a376bda82b2bb3(_1465ff0cbb85b3843bb20d3fb47dd7fa_eeb2c41c182243b6a7a376bda82b2bb3 command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_11e26d0f7bc2425ebbefec0c2ff6be5c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_11e26d0f7bc2425ebbefec0c2ff6be5c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_11e26d0f7bc2425ebbefec0c2ff6be5c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_11e26d0f7bc2425ebbefec0c2ff6be5c(_1465ff0cbb85b3843bb20d3fb47dd7fa_11e26d0f7bc2425ebbefec0c2ff6be5c command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_f0b9900c53fd41d5b58cc87045cc8cd3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_f0b9900c53fd41d5b58cc87045cc8cd3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_f0b9900c53fd41d5b58cc87045cc8cd3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_f0b9900c53fd41d5b58cc87045cc8cd3(_1465ff0cbb85b3843bb20d3fb47dd7fa_f0b9900c53fd41d5b58cc87045cc8cd3 command)
		{
		}

		private void BakeCommandBinding__1465ff0cbb85b3843bb20d3fb47dd7fa_bdf4982ecd374f22852d599654607a18(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_bdf4982ecd374f22852d599654607a18(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_bdf4982ecd374f22852d599654607a18(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1465ff0cbb85b3843bb20d3fb47dd7fa_bdf4982ecd374f22852d599654607a18(_1465ff0cbb85b3843bb20d3fb47dd7fa_bdf4982ecd374f22852d599654607a18 command)
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
