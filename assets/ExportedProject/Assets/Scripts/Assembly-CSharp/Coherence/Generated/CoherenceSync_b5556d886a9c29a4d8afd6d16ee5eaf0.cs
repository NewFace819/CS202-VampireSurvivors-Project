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
	public class CoherenceSync_b5556d886a9c29a4d8afd6d16ee5eaf0 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_515123fbd5994d76a65c3e9284c7fd7f_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_f7f639bc9fdc417b8e9583668b1d591c_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_aadebea26a104b8ba2674325a33543aa_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_8fbce78a7e2d482e93bec86b461d4783_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_5dd3f2c44cb34ec2be2507ddabc1fca4_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_fb655421b9164471812be89922e2a592_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_fba681ac820c474480637f94f34fc8bf_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_b3dacf5f776f4bb580515e92d9b3c103_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_f0dbe96c6b3343cbaede3c35dd2dc877_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_bff9dded50d14d3abca24e44099d8ab0_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_e5efd4735a8c43659d7dc1a7c94cbf23_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_24e0108e8714442fa9fec63a746c132e_CommandTarget;

		private CharacterController _b5556d886a9c29a4d8afd6d16ee5eaf0_f5249735a0af4315b16ff736ad8a1cda_CommandTarget;

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

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_515123fbd5994d76a65c3e9284c7fd7f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_515123fbd5994d76a65c3e9284c7fd7f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_515123fbd5994d76a65c3e9284c7fd7f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_515123fbd5994d76a65c3e9284c7fd7f(_b5556d886a9c29a4d8afd6d16ee5eaf0_515123fbd5994d76a65c3e9284c7fd7f command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_f7f639bc9fdc417b8e9583668b1d591c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_f7f639bc9fdc417b8e9583668b1d591c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_f7f639bc9fdc417b8e9583668b1d591c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_f7f639bc9fdc417b8e9583668b1d591c(_b5556d886a9c29a4d8afd6d16ee5eaf0_f7f639bc9fdc417b8e9583668b1d591c command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_aadebea26a104b8ba2674325a33543aa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_aadebea26a104b8ba2674325a33543aa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_aadebea26a104b8ba2674325a33543aa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_aadebea26a104b8ba2674325a33543aa(_b5556d886a9c29a4d8afd6d16ee5eaf0_aadebea26a104b8ba2674325a33543aa command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_8fbce78a7e2d482e93bec86b461d4783(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_8fbce78a7e2d482e93bec86b461d4783(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_8fbce78a7e2d482e93bec86b461d4783(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_8fbce78a7e2d482e93bec86b461d4783(_b5556d886a9c29a4d8afd6d16ee5eaf0_8fbce78a7e2d482e93bec86b461d4783 command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_5dd3f2c44cb34ec2be2507ddabc1fca4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_5dd3f2c44cb34ec2be2507ddabc1fca4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_5dd3f2c44cb34ec2be2507ddabc1fca4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_5dd3f2c44cb34ec2be2507ddabc1fca4(_b5556d886a9c29a4d8afd6d16ee5eaf0_5dd3f2c44cb34ec2be2507ddabc1fca4 command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_fb655421b9164471812be89922e2a592(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_fb655421b9164471812be89922e2a592(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_fb655421b9164471812be89922e2a592(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_fb655421b9164471812be89922e2a592(_b5556d886a9c29a4d8afd6d16ee5eaf0_fb655421b9164471812be89922e2a592 command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_fba681ac820c474480637f94f34fc8bf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_fba681ac820c474480637f94f34fc8bf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_fba681ac820c474480637f94f34fc8bf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_fba681ac820c474480637f94f34fc8bf(_b5556d886a9c29a4d8afd6d16ee5eaf0_fba681ac820c474480637f94f34fc8bf command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_b3dacf5f776f4bb580515e92d9b3c103(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_b3dacf5f776f4bb580515e92d9b3c103(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_b3dacf5f776f4bb580515e92d9b3c103(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_b3dacf5f776f4bb580515e92d9b3c103(_b5556d886a9c29a4d8afd6d16ee5eaf0_b3dacf5f776f4bb580515e92d9b3c103 command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_f0dbe96c6b3343cbaede3c35dd2dc877(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_f0dbe96c6b3343cbaede3c35dd2dc877(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_f0dbe96c6b3343cbaede3c35dd2dc877(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_f0dbe96c6b3343cbaede3c35dd2dc877(_b5556d886a9c29a4d8afd6d16ee5eaf0_f0dbe96c6b3343cbaede3c35dd2dc877 command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_bff9dded50d14d3abca24e44099d8ab0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_bff9dded50d14d3abca24e44099d8ab0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_bff9dded50d14d3abca24e44099d8ab0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_bff9dded50d14d3abca24e44099d8ab0(_b5556d886a9c29a4d8afd6d16ee5eaf0_bff9dded50d14d3abca24e44099d8ab0 command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_e5efd4735a8c43659d7dc1a7c94cbf23(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_e5efd4735a8c43659d7dc1a7c94cbf23(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_e5efd4735a8c43659d7dc1a7c94cbf23(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_e5efd4735a8c43659d7dc1a7c94cbf23(_b5556d886a9c29a4d8afd6d16ee5eaf0_e5efd4735a8c43659d7dc1a7c94cbf23 command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_24e0108e8714442fa9fec63a746c132e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_24e0108e8714442fa9fec63a746c132e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_24e0108e8714442fa9fec63a746c132e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_24e0108e8714442fa9fec63a746c132e(_b5556d886a9c29a4d8afd6d16ee5eaf0_24e0108e8714442fa9fec63a746c132e command)
		{
		}

		private void BakeCommandBinding__b5556d886a9c29a4d8afd6d16ee5eaf0_f5249735a0af4315b16ff736ad8a1cda(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_f5249735a0af4315b16ff736ad8a1cda(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_f5249735a0af4315b16ff736ad8a1cda(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b5556d886a9c29a4d8afd6d16ee5eaf0_f5249735a0af4315b16ff736ad8a1cda(_b5556d886a9c29a4d8afd6d16ee5eaf0_f5249735a0af4315b16ff736ad8a1cda command)
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
