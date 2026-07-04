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
	public class CoherenceSync_edb4704fa50a08145a80a0f20d97ffbf : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_26485a41d65b4597acb34e6576715e53_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_6be1282c477049df80be5319292e67cf_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_da0096d4966348359b4193464a61a3bf_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_43d9849c67724ba5b04b15ab41aa78bb_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_257573914b6247a2a4fbc44bbac3fc4a_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_102f9f9bdb1244f982e6494e16b7059d_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_8a4a7720953d4e9887f49a2bf8ad404c_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_1d46cc6cfa86434686964cfa50ed8b36_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_a63545f5612b4a5a896f435a44cf4e27_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_f0531e98aee14ead8adf6789b494a65d_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_338894d08c1a4f5baf6906376c78fe23_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_b38f7539eb944071a07557b0a1713eee_CommandTarget;

		private CharacterController _edb4704fa50a08145a80a0f20d97ffbf_299cf39d9b9b4abdba580dc3bb7ab052_CommandTarget;

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

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_26485a41d65b4597acb34e6576715e53(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_26485a41d65b4597acb34e6576715e53(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_26485a41d65b4597acb34e6576715e53(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_26485a41d65b4597acb34e6576715e53(_edb4704fa50a08145a80a0f20d97ffbf_26485a41d65b4597acb34e6576715e53 command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_6be1282c477049df80be5319292e67cf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_6be1282c477049df80be5319292e67cf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_6be1282c477049df80be5319292e67cf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_6be1282c477049df80be5319292e67cf(_edb4704fa50a08145a80a0f20d97ffbf_6be1282c477049df80be5319292e67cf command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_da0096d4966348359b4193464a61a3bf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_da0096d4966348359b4193464a61a3bf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_da0096d4966348359b4193464a61a3bf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_da0096d4966348359b4193464a61a3bf(_edb4704fa50a08145a80a0f20d97ffbf_da0096d4966348359b4193464a61a3bf command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_43d9849c67724ba5b04b15ab41aa78bb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_43d9849c67724ba5b04b15ab41aa78bb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_43d9849c67724ba5b04b15ab41aa78bb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_43d9849c67724ba5b04b15ab41aa78bb(_edb4704fa50a08145a80a0f20d97ffbf_43d9849c67724ba5b04b15ab41aa78bb command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_257573914b6247a2a4fbc44bbac3fc4a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_257573914b6247a2a4fbc44bbac3fc4a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_257573914b6247a2a4fbc44bbac3fc4a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_257573914b6247a2a4fbc44bbac3fc4a(_edb4704fa50a08145a80a0f20d97ffbf_257573914b6247a2a4fbc44bbac3fc4a command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_102f9f9bdb1244f982e6494e16b7059d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_102f9f9bdb1244f982e6494e16b7059d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_102f9f9bdb1244f982e6494e16b7059d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_102f9f9bdb1244f982e6494e16b7059d(_edb4704fa50a08145a80a0f20d97ffbf_102f9f9bdb1244f982e6494e16b7059d command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_8a4a7720953d4e9887f49a2bf8ad404c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_8a4a7720953d4e9887f49a2bf8ad404c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_8a4a7720953d4e9887f49a2bf8ad404c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_8a4a7720953d4e9887f49a2bf8ad404c(_edb4704fa50a08145a80a0f20d97ffbf_8a4a7720953d4e9887f49a2bf8ad404c command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_1d46cc6cfa86434686964cfa50ed8b36(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_1d46cc6cfa86434686964cfa50ed8b36(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_1d46cc6cfa86434686964cfa50ed8b36(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_1d46cc6cfa86434686964cfa50ed8b36(_edb4704fa50a08145a80a0f20d97ffbf_1d46cc6cfa86434686964cfa50ed8b36 command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_a63545f5612b4a5a896f435a44cf4e27(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_a63545f5612b4a5a896f435a44cf4e27(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_a63545f5612b4a5a896f435a44cf4e27(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_a63545f5612b4a5a896f435a44cf4e27(_edb4704fa50a08145a80a0f20d97ffbf_a63545f5612b4a5a896f435a44cf4e27 command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_f0531e98aee14ead8adf6789b494a65d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_f0531e98aee14ead8adf6789b494a65d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_f0531e98aee14ead8adf6789b494a65d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_f0531e98aee14ead8adf6789b494a65d(_edb4704fa50a08145a80a0f20d97ffbf_f0531e98aee14ead8adf6789b494a65d command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_338894d08c1a4f5baf6906376c78fe23(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_338894d08c1a4f5baf6906376c78fe23(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_338894d08c1a4f5baf6906376c78fe23(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_338894d08c1a4f5baf6906376c78fe23(_edb4704fa50a08145a80a0f20d97ffbf_338894d08c1a4f5baf6906376c78fe23 command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_b38f7539eb944071a07557b0a1713eee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_b38f7539eb944071a07557b0a1713eee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_b38f7539eb944071a07557b0a1713eee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_b38f7539eb944071a07557b0a1713eee(_edb4704fa50a08145a80a0f20d97ffbf_b38f7539eb944071a07557b0a1713eee command)
		{
		}

		private void BakeCommandBinding__edb4704fa50a08145a80a0f20d97ffbf_299cf39d9b9b4abdba580dc3bb7ab052(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__edb4704fa50a08145a80a0f20d97ffbf_299cf39d9b9b4abdba580dc3bb7ab052(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__edb4704fa50a08145a80a0f20d97ffbf_299cf39d9b9b4abdba580dc3bb7ab052(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__edb4704fa50a08145a80a0f20d97ffbf_299cf39d9b9b4abdba580dc3bb7ab052(_edb4704fa50a08145a80a0f20d97ffbf_299cf39d9b9b4abdba580dc3bb7ab052 command)
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
