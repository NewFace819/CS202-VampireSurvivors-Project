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
	public class CoherenceSync_f9ec6d652b4728240ba9ca99a2eb9480 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_47adc78acc844f13872150984c4215fc_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_231c90e9388d45118408c95baeb4491a_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_c7446c4711b4459d97bbfb5d8e817468_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_da16b36a030841a88b04c5b8d14aa412_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_70085a5f7ae14d81b03ca9d704e50a7c_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_08ec7f35ebcf4305bb31df5b833678fd_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_abf79231ab8b4321a2ebf149a68f1b0f_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_0ea5333a0a7f459b8b356f15ac7aed86_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_010bd71f0b82474eb359bad3a64edd0f_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_05bfde6bb92d43b98e426f4d87dec209_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_79c0be5092174940b3bfbc288ca68f12_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_3f9d171778ec4da1b882e55ceed45413_CommandTarget;

		private CharacterController _f9ec6d652b4728240ba9ca99a2eb9480_5dc19b64c4c340d0a44f1297f9610d9c_CommandTarget;

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

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_47adc78acc844f13872150984c4215fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_47adc78acc844f13872150984c4215fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_47adc78acc844f13872150984c4215fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_47adc78acc844f13872150984c4215fc(_f9ec6d652b4728240ba9ca99a2eb9480_47adc78acc844f13872150984c4215fc command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_231c90e9388d45118408c95baeb4491a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_231c90e9388d45118408c95baeb4491a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_231c90e9388d45118408c95baeb4491a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_231c90e9388d45118408c95baeb4491a(_f9ec6d652b4728240ba9ca99a2eb9480_231c90e9388d45118408c95baeb4491a command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_c7446c4711b4459d97bbfb5d8e817468(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_c7446c4711b4459d97bbfb5d8e817468(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_c7446c4711b4459d97bbfb5d8e817468(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_c7446c4711b4459d97bbfb5d8e817468(_f9ec6d652b4728240ba9ca99a2eb9480_c7446c4711b4459d97bbfb5d8e817468 command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_da16b36a030841a88b04c5b8d14aa412(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_da16b36a030841a88b04c5b8d14aa412(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_da16b36a030841a88b04c5b8d14aa412(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_da16b36a030841a88b04c5b8d14aa412(_f9ec6d652b4728240ba9ca99a2eb9480_da16b36a030841a88b04c5b8d14aa412 command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_70085a5f7ae14d81b03ca9d704e50a7c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_70085a5f7ae14d81b03ca9d704e50a7c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_70085a5f7ae14d81b03ca9d704e50a7c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_70085a5f7ae14d81b03ca9d704e50a7c(_f9ec6d652b4728240ba9ca99a2eb9480_70085a5f7ae14d81b03ca9d704e50a7c command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_08ec7f35ebcf4305bb31df5b833678fd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_08ec7f35ebcf4305bb31df5b833678fd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_08ec7f35ebcf4305bb31df5b833678fd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_08ec7f35ebcf4305bb31df5b833678fd(_f9ec6d652b4728240ba9ca99a2eb9480_08ec7f35ebcf4305bb31df5b833678fd command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_abf79231ab8b4321a2ebf149a68f1b0f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_abf79231ab8b4321a2ebf149a68f1b0f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_abf79231ab8b4321a2ebf149a68f1b0f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_abf79231ab8b4321a2ebf149a68f1b0f(_f9ec6d652b4728240ba9ca99a2eb9480_abf79231ab8b4321a2ebf149a68f1b0f command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_0ea5333a0a7f459b8b356f15ac7aed86(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_0ea5333a0a7f459b8b356f15ac7aed86(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_0ea5333a0a7f459b8b356f15ac7aed86(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_0ea5333a0a7f459b8b356f15ac7aed86(_f9ec6d652b4728240ba9ca99a2eb9480_0ea5333a0a7f459b8b356f15ac7aed86 command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_010bd71f0b82474eb359bad3a64edd0f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_010bd71f0b82474eb359bad3a64edd0f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_010bd71f0b82474eb359bad3a64edd0f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_010bd71f0b82474eb359bad3a64edd0f(_f9ec6d652b4728240ba9ca99a2eb9480_010bd71f0b82474eb359bad3a64edd0f command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_05bfde6bb92d43b98e426f4d87dec209(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_05bfde6bb92d43b98e426f4d87dec209(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_05bfde6bb92d43b98e426f4d87dec209(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_05bfde6bb92d43b98e426f4d87dec209(_f9ec6d652b4728240ba9ca99a2eb9480_05bfde6bb92d43b98e426f4d87dec209 command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_79c0be5092174940b3bfbc288ca68f12(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_79c0be5092174940b3bfbc288ca68f12(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_79c0be5092174940b3bfbc288ca68f12(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_79c0be5092174940b3bfbc288ca68f12(_f9ec6d652b4728240ba9ca99a2eb9480_79c0be5092174940b3bfbc288ca68f12 command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_3f9d171778ec4da1b882e55ceed45413(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_3f9d171778ec4da1b882e55ceed45413(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_3f9d171778ec4da1b882e55ceed45413(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_3f9d171778ec4da1b882e55ceed45413(_f9ec6d652b4728240ba9ca99a2eb9480_3f9d171778ec4da1b882e55ceed45413 command)
		{
		}

		private void BakeCommandBinding__f9ec6d652b4728240ba9ca99a2eb9480_5dc19b64c4c340d0a44f1297f9610d9c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f9ec6d652b4728240ba9ca99a2eb9480_5dc19b64c4c340d0a44f1297f9610d9c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f9ec6d652b4728240ba9ca99a2eb9480_5dc19b64c4c340d0a44f1297f9610d9c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f9ec6d652b4728240ba9ca99a2eb9480_5dc19b64c4c340d0a44f1297f9610d9c(_f9ec6d652b4728240ba9ca99a2eb9480_5dc19b64c4c340d0a44f1297f9610d9c command)
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
