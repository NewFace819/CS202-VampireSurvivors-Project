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
	public class CoherenceSync_49890ed44d1bdf44096c0c292df0a92d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_0902b566ea9c458795b8535e6678c6a7_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_a34d2056b13a4e2b85ad91577590b3b3_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_30e0c5969fba48f19638fcefe948a44e_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_05ac85c9ed00476189a1286e330d1064_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_b0c2b92cfac14cce8856fccf135635e9_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_9b26327776da4b4eab4cb5b23b3fd48f_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_6975183ed03d44d386ead9f2556412c8_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_d6a008c9d9594261ac2d0b7f017ac0a6_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_379d36f9b7864da6b29ae6485459e082_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_fc2c473b359a4da18a695be722db80f6_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_718159c0d5a4403594e6077cfb1b7d03_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_a904c4bd36164b409275376badf38081_CommandTarget;

		private CharacterController _49890ed44d1bdf44096c0c292df0a92d_6619d888629f44888083fc50746efac8_CommandTarget;

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

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_0902b566ea9c458795b8535e6678c6a7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_0902b566ea9c458795b8535e6678c6a7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_0902b566ea9c458795b8535e6678c6a7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_0902b566ea9c458795b8535e6678c6a7(_49890ed44d1bdf44096c0c292df0a92d_0902b566ea9c458795b8535e6678c6a7 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_a34d2056b13a4e2b85ad91577590b3b3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_a34d2056b13a4e2b85ad91577590b3b3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_a34d2056b13a4e2b85ad91577590b3b3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_a34d2056b13a4e2b85ad91577590b3b3(_49890ed44d1bdf44096c0c292df0a92d_a34d2056b13a4e2b85ad91577590b3b3 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_30e0c5969fba48f19638fcefe948a44e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_30e0c5969fba48f19638fcefe948a44e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_30e0c5969fba48f19638fcefe948a44e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_30e0c5969fba48f19638fcefe948a44e(_49890ed44d1bdf44096c0c292df0a92d_30e0c5969fba48f19638fcefe948a44e command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_05ac85c9ed00476189a1286e330d1064(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_05ac85c9ed00476189a1286e330d1064(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_05ac85c9ed00476189a1286e330d1064(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_05ac85c9ed00476189a1286e330d1064(_49890ed44d1bdf44096c0c292df0a92d_05ac85c9ed00476189a1286e330d1064 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_b0c2b92cfac14cce8856fccf135635e9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_b0c2b92cfac14cce8856fccf135635e9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_b0c2b92cfac14cce8856fccf135635e9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_b0c2b92cfac14cce8856fccf135635e9(_49890ed44d1bdf44096c0c292df0a92d_b0c2b92cfac14cce8856fccf135635e9 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_9b26327776da4b4eab4cb5b23b3fd48f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_9b26327776da4b4eab4cb5b23b3fd48f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_9b26327776da4b4eab4cb5b23b3fd48f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_9b26327776da4b4eab4cb5b23b3fd48f(_49890ed44d1bdf44096c0c292df0a92d_9b26327776da4b4eab4cb5b23b3fd48f command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_6975183ed03d44d386ead9f2556412c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_6975183ed03d44d386ead9f2556412c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_6975183ed03d44d386ead9f2556412c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_6975183ed03d44d386ead9f2556412c8(_49890ed44d1bdf44096c0c292df0a92d_6975183ed03d44d386ead9f2556412c8 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_d6a008c9d9594261ac2d0b7f017ac0a6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_d6a008c9d9594261ac2d0b7f017ac0a6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_d6a008c9d9594261ac2d0b7f017ac0a6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_d6a008c9d9594261ac2d0b7f017ac0a6(_49890ed44d1bdf44096c0c292df0a92d_d6a008c9d9594261ac2d0b7f017ac0a6 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_379d36f9b7864da6b29ae6485459e082(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_379d36f9b7864da6b29ae6485459e082(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_379d36f9b7864da6b29ae6485459e082(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_379d36f9b7864da6b29ae6485459e082(_49890ed44d1bdf44096c0c292df0a92d_379d36f9b7864da6b29ae6485459e082 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_fc2c473b359a4da18a695be722db80f6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_fc2c473b359a4da18a695be722db80f6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_fc2c473b359a4da18a695be722db80f6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_fc2c473b359a4da18a695be722db80f6(_49890ed44d1bdf44096c0c292df0a92d_fc2c473b359a4da18a695be722db80f6 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_718159c0d5a4403594e6077cfb1b7d03(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_718159c0d5a4403594e6077cfb1b7d03(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_718159c0d5a4403594e6077cfb1b7d03(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_718159c0d5a4403594e6077cfb1b7d03(_49890ed44d1bdf44096c0c292df0a92d_718159c0d5a4403594e6077cfb1b7d03 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_a904c4bd36164b409275376badf38081(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_a904c4bd36164b409275376badf38081(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_a904c4bd36164b409275376badf38081(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_a904c4bd36164b409275376badf38081(_49890ed44d1bdf44096c0c292df0a92d_a904c4bd36164b409275376badf38081 command)
		{
		}

		private void BakeCommandBinding__49890ed44d1bdf44096c0c292df0a92d_6619d888629f44888083fc50746efac8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49890ed44d1bdf44096c0c292df0a92d_6619d888629f44888083fc50746efac8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49890ed44d1bdf44096c0c292df0a92d_6619d888629f44888083fc50746efac8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49890ed44d1bdf44096c0c292df0a92d_6619d888629f44888083fc50746efac8(_49890ed44d1bdf44096c0c292df0a92d_6619d888629f44888083fc50746efac8 command)
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
