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
	public class CoherenceSync_41c1970ce948ae942875b8332185ec4c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_c28834274d824638bcdbbea5f8b4bcd8_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_11b73a58f63e4515a091a177e961d2ab_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_3c521e02abbc4af5ad377442c6e44803_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_f7fa604fffde44f18050707d4b8f0ddb_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_7887db1d490e4bacae2b3509ca2a5ec9_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_4565581e04c1470b9f8ffdd768ae2cb7_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_bf8652064ba34abca93ed81d1177d6cf_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_7b35a9796fcf40f48bbbc4365e37d9a0_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_98bfcb5888144759b01488b10e075947_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_a0fd5d88e9e74290b8f3d74fe22921e5_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_7fe50c64176640bc8e091450327bf8c5_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_a582437328e84b06806cd56e60e7c5e8_CommandTarget;

		private CharacterController _41c1970ce948ae942875b8332185ec4c_cba8d24f27c04c94988b0425d81c9697_CommandTarget;

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

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_c28834274d824638bcdbbea5f8b4bcd8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_c28834274d824638bcdbbea5f8b4bcd8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_c28834274d824638bcdbbea5f8b4bcd8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_c28834274d824638bcdbbea5f8b4bcd8(_41c1970ce948ae942875b8332185ec4c_c28834274d824638bcdbbea5f8b4bcd8 command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_11b73a58f63e4515a091a177e961d2ab(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_11b73a58f63e4515a091a177e961d2ab(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_11b73a58f63e4515a091a177e961d2ab(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_11b73a58f63e4515a091a177e961d2ab(_41c1970ce948ae942875b8332185ec4c_11b73a58f63e4515a091a177e961d2ab command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_3c521e02abbc4af5ad377442c6e44803(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_3c521e02abbc4af5ad377442c6e44803(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_3c521e02abbc4af5ad377442c6e44803(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_3c521e02abbc4af5ad377442c6e44803(_41c1970ce948ae942875b8332185ec4c_3c521e02abbc4af5ad377442c6e44803 command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_f7fa604fffde44f18050707d4b8f0ddb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_f7fa604fffde44f18050707d4b8f0ddb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_f7fa604fffde44f18050707d4b8f0ddb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_f7fa604fffde44f18050707d4b8f0ddb(_41c1970ce948ae942875b8332185ec4c_f7fa604fffde44f18050707d4b8f0ddb command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_7887db1d490e4bacae2b3509ca2a5ec9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_7887db1d490e4bacae2b3509ca2a5ec9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_7887db1d490e4bacae2b3509ca2a5ec9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_7887db1d490e4bacae2b3509ca2a5ec9(_41c1970ce948ae942875b8332185ec4c_7887db1d490e4bacae2b3509ca2a5ec9 command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_4565581e04c1470b9f8ffdd768ae2cb7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_4565581e04c1470b9f8ffdd768ae2cb7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_4565581e04c1470b9f8ffdd768ae2cb7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_4565581e04c1470b9f8ffdd768ae2cb7(_41c1970ce948ae942875b8332185ec4c_4565581e04c1470b9f8ffdd768ae2cb7 command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_bf8652064ba34abca93ed81d1177d6cf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_bf8652064ba34abca93ed81d1177d6cf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_bf8652064ba34abca93ed81d1177d6cf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_bf8652064ba34abca93ed81d1177d6cf(_41c1970ce948ae942875b8332185ec4c_bf8652064ba34abca93ed81d1177d6cf command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_7b35a9796fcf40f48bbbc4365e37d9a0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_7b35a9796fcf40f48bbbc4365e37d9a0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_7b35a9796fcf40f48bbbc4365e37d9a0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_7b35a9796fcf40f48bbbc4365e37d9a0(_41c1970ce948ae942875b8332185ec4c_7b35a9796fcf40f48bbbc4365e37d9a0 command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_98bfcb5888144759b01488b10e075947(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_98bfcb5888144759b01488b10e075947(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_98bfcb5888144759b01488b10e075947(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_98bfcb5888144759b01488b10e075947(_41c1970ce948ae942875b8332185ec4c_98bfcb5888144759b01488b10e075947 command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_a0fd5d88e9e74290b8f3d74fe22921e5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_a0fd5d88e9e74290b8f3d74fe22921e5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_a0fd5d88e9e74290b8f3d74fe22921e5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_a0fd5d88e9e74290b8f3d74fe22921e5(_41c1970ce948ae942875b8332185ec4c_a0fd5d88e9e74290b8f3d74fe22921e5 command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_7fe50c64176640bc8e091450327bf8c5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_7fe50c64176640bc8e091450327bf8c5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_7fe50c64176640bc8e091450327bf8c5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_7fe50c64176640bc8e091450327bf8c5(_41c1970ce948ae942875b8332185ec4c_7fe50c64176640bc8e091450327bf8c5 command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_a582437328e84b06806cd56e60e7c5e8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_a582437328e84b06806cd56e60e7c5e8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_a582437328e84b06806cd56e60e7c5e8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_a582437328e84b06806cd56e60e7c5e8(_41c1970ce948ae942875b8332185ec4c_a582437328e84b06806cd56e60e7c5e8 command)
		{
		}

		private void BakeCommandBinding__41c1970ce948ae942875b8332185ec4c_cba8d24f27c04c94988b0425d81c9697(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__41c1970ce948ae942875b8332185ec4c_cba8d24f27c04c94988b0425d81c9697(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__41c1970ce948ae942875b8332185ec4c_cba8d24f27c04c94988b0425d81c9697(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__41c1970ce948ae942875b8332185ec4c_cba8d24f27c04c94988b0425d81c9697(_41c1970ce948ae942875b8332185ec4c_cba8d24f27c04c94988b0425d81c9697 command)
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
