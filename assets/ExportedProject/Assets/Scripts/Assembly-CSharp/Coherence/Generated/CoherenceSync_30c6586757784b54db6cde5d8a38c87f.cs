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
	public class CoherenceSync_30c6586757784b54db6cde5d8a38c87f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_e249dc8111fe449d875718f16de8853a_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_d986b18b027842fb99d1699da611ca14_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_e839277a62d94643b9e9224d8d65d744_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_e5531f69c31b4062924562e402eef103_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_1e11f8bec69e4b3085cfcd0294284d1d_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_823527c14f884a9794ad42edea13e0dc_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_b7abc64ef5ec473ea48b032dafa63180_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_ab7e0a5c4222473faf3a935e2d01800c_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_ef60b1d32611495e8e8b4f39beb30bfa_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_7922396081c140c4b3bf35bd52ac0028_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_2cb32d4597f041cd906f68df0019c10d_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_80c3f2d14d984a8d9fcefa9ef9a64d0a_CommandTarget;

		private CharacterController _30c6586757784b54db6cde5d8a38c87f_cc5f269e870d4251970fe0376809284b_CommandTarget;

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

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_e249dc8111fe449d875718f16de8853a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_e249dc8111fe449d875718f16de8853a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_e249dc8111fe449d875718f16de8853a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_e249dc8111fe449d875718f16de8853a(_30c6586757784b54db6cde5d8a38c87f_e249dc8111fe449d875718f16de8853a command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_d986b18b027842fb99d1699da611ca14(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_d986b18b027842fb99d1699da611ca14(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_d986b18b027842fb99d1699da611ca14(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_d986b18b027842fb99d1699da611ca14(_30c6586757784b54db6cde5d8a38c87f_d986b18b027842fb99d1699da611ca14 command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_e839277a62d94643b9e9224d8d65d744(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_e839277a62d94643b9e9224d8d65d744(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_e839277a62d94643b9e9224d8d65d744(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_e839277a62d94643b9e9224d8d65d744(_30c6586757784b54db6cde5d8a38c87f_e839277a62d94643b9e9224d8d65d744 command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_e5531f69c31b4062924562e402eef103(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_e5531f69c31b4062924562e402eef103(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_e5531f69c31b4062924562e402eef103(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_e5531f69c31b4062924562e402eef103(_30c6586757784b54db6cde5d8a38c87f_e5531f69c31b4062924562e402eef103 command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_1e11f8bec69e4b3085cfcd0294284d1d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_1e11f8bec69e4b3085cfcd0294284d1d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_1e11f8bec69e4b3085cfcd0294284d1d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_1e11f8bec69e4b3085cfcd0294284d1d(_30c6586757784b54db6cde5d8a38c87f_1e11f8bec69e4b3085cfcd0294284d1d command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_823527c14f884a9794ad42edea13e0dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_823527c14f884a9794ad42edea13e0dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_823527c14f884a9794ad42edea13e0dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_823527c14f884a9794ad42edea13e0dc(_30c6586757784b54db6cde5d8a38c87f_823527c14f884a9794ad42edea13e0dc command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_b7abc64ef5ec473ea48b032dafa63180(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_b7abc64ef5ec473ea48b032dafa63180(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_b7abc64ef5ec473ea48b032dafa63180(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_b7abc64ef5ec473ea48b032dafa63180(_30c6586757784b54db6cde5d8a38c87f_b7abc64ef5ec473ea48b032dafa63180 command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_ab7e0a5c4222473faf3a935e2d01800c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_ab7e0a5c4222473faf3a935e2d01800c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_ab7e0a5c4222473faf3a935e2d01800c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_ab7e0a5c4222473faf3a935e2d01800c(_30c6586757784b54db6cde5d8a38c87f_ab7e0a5c4222473faf3a935e2d01800c command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_ef60b1d32611495e8e8b4f39beb30bfa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_ef60b1d32611495e8e8b4f39beb30bfa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_ef60b1d32611495e8e8b4f39beb30bfa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_ef60b1d32611495e8e8b4f39beb30bfa(_30c6586757784b54db6cde5d8a38c87f_ef60b1d32611495e8e8b4f39beb30bfa command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_7922396081c140c4b3bf35bd52ac0028(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_7922396081c140c4b3bf35bd52ac0028(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_7922396081c140c4b3bf35bd52ac0028(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_7922396081c140c4b3bf35bd52ac0028(_30c6586757784b54db6cde5d8a38c87f_7922396081c140c4b3bf35bd52ac0028 command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_2cb32d4597f041cd906f68df0019c10d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_2cb32d4597f041cd906f68df0019c10d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_2cb32d4597f041cd906f68df0019c10d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_2cb32d4597f041cd906f68df0019c10d(_30c6586757784b54db6cde5d8a38c87f_2cb32d4597f041cd906f68df0019c10d command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_80c3f2d14d984a8d9fcefa9ef9a64d0a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_80c3f2d14d984a8d9fcefa9ef9a64d0a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_80c3f2d14d984a8d9fcefa9ef9a64d0a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_80c3f2d14d984a8d9fcefa9ef9a64d0a(_30c6586757784b54db6cde5d8a38c87f_80c3f2d14d984a8d9fcefa9ef9a64d0a command)
		{
		}

		private void BakeCommandBinding__30c6586757784b54db6cde5d8a38c87f_cc5f269e870d4251970fe0376809284b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__30c6586757784b54db6cde5d8a38c87f_cc5f269e870d4251970fe0376809284b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__30c6586757784b54db6cde5d8a38c87f_cc5f269e870d4251970fe0376809284b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__30c6586757784b54db6cde5d8a38c87f_cc5f269e870d4251970fe0376809284b(_30c6586757784b54db6cde5d8a38c87f_cc5f269e870d4251970fe0376809284b command)
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
