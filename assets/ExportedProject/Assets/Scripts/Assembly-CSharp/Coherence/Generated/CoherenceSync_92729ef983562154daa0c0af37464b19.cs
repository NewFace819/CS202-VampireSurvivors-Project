using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_92729ef983562154daa0c0af37464b19 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _92729ef983562154daa0c0af37464b19_2783b59a2792447d9db4e5a4df423569_CommandTarget;

		private NetworkPickup _92729ef983562154daa0c0af37464b19_0e3d4896fd8d4e96a869230de9c597dc_CommandTarget;

		private NetworkPickup _92729ef983562154daa0c0af37464b19_27569c74a4064b8e88a6a0c9433e35ba_CommandTarget;

		private NetworkPickup _92729ef983562154daa0c0af37464b19_e7e415e19a424bc48dea7f77440ee2ea_CommandTarget;

		private NetworkPickup _92729ef983562154daa0c0af37464b19_158c5a7346c04ea2978fc91257c7c2c1_CommandTarget;

		private NetworkPickup _92729ef983562154daa0c0af37464b19_2e4473c3218b4a67b36221afcd680158_CommandTarget;

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

		private void BakeCommandBinding__92729ef983562154daa0c0af37464b19_2783b59a2792447d9db4e5a4df423569(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__92729ef983562154daa0c0af37464b19_2783b59a2792447d9db4e5a4df423569(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__92729ef983562154daa0c0af37464b19_2783b59a2792447d9db4e5a4df423569(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__92729ef983562154daa0c0af37464b19_2783b59a2792447d9db4e5a4df423569(_92729ef983562154daa0c0af37464b19_2783b59a2792447d9db4e5a4df423569 command)
		{
		}

		private void BakeCommandBinding__92729ef983562154daa0c0af37464b19_0e3d4896fd8d4e96a869230de9c597dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__92729ef983562154daa0c0af37464b19_0e3d4896fd8d4e96a869230de9c597dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__92729ef983562154daa0c0af37464b19_0e3d4896fd8d4e96a869230de9c597dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__92729ef983562154daa0c0af37464b19_0e3d4896fd8d4e96a869230de9c597dc(_92729ef983562154daa0c0af37464b19_0e3d4896fd8d4e96a869230de9c597dc command)
		{
		}

		private void BakeCommandBinding__92729ef983562154daa0c0af37464b19_27569c74a4064b8e88a6a0c9433e35ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__92729ef983562154daa0c0af37464b19_27569c74a4064b8e88a6a0c9433e35ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__92729ef983562154daa0c0af37464b19_27569c74a4064b8e88a6a0c9433e35ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__92729ef983562154daa0c0af37464b19_27569c74a4064b8e88a6a0c9433e35ba(_92729ef983562154daa0c0af37464b19_27569c74a4064b8e88a6a0c9433e35ba command)
		{
		}

		private void BakeCommandBinding__92729ef983562154daa0c0af37464b19_e7e415e19a424bc48dea7f77440ee2ea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__92729ef983562154daa0c0af37464b19_e7e415e19a424bc48dea7f77440ee2ea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__92729ef983562154daa0c0af37464b19_e7e415e19a424bc48dea7f77440ee2ea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__92729ef983562154daa0c0af37464b19_e7e415e19a424bc48dea7f77440ee2ea(_92729ef983562154daa0c0af37464b19_e7e415e19a424bc48dea7f77440ee2ea command)
		{
		}

		private void BakeCommandBinding__92729ef983562154daa0c0af37464b19_158c5a7346c04ea2978fc91257c7c2c1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__92729ef983562154daa0c0af37464b19_158c5a7346c04ea2978fc91257c7c2c1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__92729ef983562154daa0c0af37464b19_158c5a7346c04ea2978fc91257c7c2c1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__92729ef983562154daa0c0af37464b19_158c5a7346c04ea2978fc91257c7c2c1(_92729ef983562154daa0c0af37464b19_158c5a7346c04ea2978fc91257c7c2c1 command)
		{
		}

		private void BakeCommandBinding__92729ef983562154daa0c0af37464b19_2e4473c3218b4a67b36221afcd680158(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__92729ef983562154daa0c0af37464b19_2e4473c3218b4a67b36221afcd680158(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__92729ef983562154daa0c0af37464b19_2e4473c3218b4a67b36221afcd680158(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__92729ef983562154daa0c0af37464b19_2e4473c3218b4a67b36221afcd680158(_92729ef983562154daa0c0af37464b19_2e4473c3218b4a67b36221afcd680158 command)
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
