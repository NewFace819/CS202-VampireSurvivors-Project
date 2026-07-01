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
	public class CoherenceSync_09ea12a13f6a5fd44b59c28af1170922 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_230b128bcd504060849c5a22fd2fc98c_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_488aa17d4b634d1f80cb3d20c774836e_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_b2f87fbddddf43539b8918c5f2116843_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_c82d602cb3114584aa7fabcec2cf10c0_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_1629f5ecf5674d8e866290563f14c4e0_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_d2a415a7e0da4d28aeac27340ff10ecf_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_32b701a9a71647b4884dc044f2f0bcf1_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_3c4fee421cb64578a516635978ca618e_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_9010c95d9a7b4e14a6f5515c65c37550_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_abd677f4a2334592b057437c1ce59391_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_4c17104922cc46a58c6900eb236f0e8f_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_44587af291e0443b94b9f56cafad76a8_CommandTarget;

		private CharacterController _09ea12a13f6a5fd44b59c28af1170922_c27067cfc2ca445d967939f124b682de_CommandTarget;

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

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_230b128bcd504060849c5a22fd2fc98c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_230b128bcd504060849c5a22fd2fc98c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_230b128bcd504060849c5a22fd2fc98c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_230b128bcd504060849c5a22fd2fc98c(_09ea12a13f6a5fd44b59c28af1170922_230b128bcd504060849c5a22fd2fc98c command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_488aa17d4b634d1f80cb3d20c774836e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_488aa17d4b634d1f80cb3d20c774836e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_488aa17d4b634d1f80cb3d20c774836e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_488aa17d4b634d1f80cb3d20c774836e(_09ea12a13f6a5fd44b59c28af1170922_488aa17d4b634d1f80cb3d20c774836e command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_b2f87fbddddf43539b8918c5f2116843(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_b2f87fbddddf43539b8918c5f2116843(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_b2f87fbddddf43539b8918c5f2116843(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_b2f87fbddddf43539b8918c5f2116843(_09ea12a13f6a5fd44b59c28af1170922_b2f87fbddddf43539b8918c5f2116843 command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_c82d602cb3114584aa7fabcec2cf10c0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_c82d602cb3114584aa7fabcec2cf10c0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_c82d602cb3114584aa7fabcec2cf10c0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_c82d602cb3114584aa7fabcec2cf10c0(_09ea12a13f6a5fd44b59c28af1170922_c82d602cb3114584aa7fabcec2cf10c0 command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_1629f5ecf5674d8e866290563f14c4e0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_1629f5ecf5674d8e866290563f14c4e0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_1629f5ecf5674d8e866290563f14c4e0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_1629f5ecf5674d8e866290563f14c4e0(_09ea12a13f6a5fd44b59c28af1170922_1629f5ecf5674d8e866290563f14c4e0 command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_d2a415a7e0da4d28aeac27340ff10ecf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_d2a415a7e0da4d28aeac27340ff10ecf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_d2a415a7e0da4d28aeac27340ff10ecf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_d2a415a7e0da4d28aeac27340ff10ecf(_09ea12a13f6a5fd44b59c28af1170922_d2a415a7e0da4d28aeac27340ff10ecf command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_32b701a9a71647b4884dc044f2f0bcf1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_32b701a9a71647b4884dc044f2f0bcf1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_32b701a9a71647b4884dc044f2f0bcf1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_32b701a9a71647b4884dc044f2f0bcf1(_09ea12a13f6a5fd44b59c28af1170922_32b701a9a71647b4884dc044f2f0bcf1 command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_3c4fee421cb64578a516635978ca618e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_3c4fee421cb64578a516635978ca618e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_3c4fee421cb64578a516635978ca618e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_3c4fee421cb64578a516635978ca618e(_09ea12a13f6a5fd44b59c28af1170922_3c4fee421cb64578a516635978ca618e command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_9010c95d9a7b4e14a6f5515c65c37550(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_9010c95d9a7b4e14a6f5515c65c37550(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_9010c95d9a7b4e14a6f5515c65c37550(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_9010c95d9a7b4e14a6f5515c65c37550(_09ea12a13f6a5fd44b59c28af1170922_9010c95d9a7b4e14a6f5515c65c37550 command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_abd677f4a2334592b057437c1ce59391(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_abd677f4a2334592b057437c1ce59391(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_abd677f4a2334592b057437c1ce59391(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_abd677f4a2334592b057437c1ce59391(_09ea12a13f6a5fd44b59c28af1170922_abd677f4a2334592b057437c1ce59391 command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_4c17104922cc46a58c6900eb236f0e8f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_4c17104922cc46a58c6900eb236f0e8f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_4c17104922cc46a58c6900eb236f0e8f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_4c17104922cc46a58c6900eb236f0e8f(_09ea12a13f6a5fd44b59c28af1170922_4c17104922cc46a58c6900eb236f0e8f command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_44587af291e0443b94b9f56cafad76a8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_44587af291e0443b94b9f56cafad76a8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_44587af291e0443b94b9f56cafad76a8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_44587af291e0443b94b9f56cafad76a8(_09ea12a13f6a5fd44b59c28af1170922_44587af291e0443b94b9f56cafad76a8 command)
		{
		}

		private void BakeCommandBinding__09ea12a13f6a5fd44b59c28af1170922_c27067cfc2ca445d967939f124b682de(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__09ea12a13f6a5fd44b59c28af1170922_c27067cfc2ca445d967939f124b682de(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__09ea12a13f6a5fd44b59c28af1170922_c27067cfc2ca445d967939f124b682de(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__09ea12a13f6a5fd44b59c28af1170922_c27067cfc2ca445d967939f124b682de(_09ea12a13f6a5fd44b59c28af1170922_c27067cfc2ca445d967939f124b682de command)
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
