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
	public class CoherenceSync_caa33b0f80bb9184397c5ef77b881389 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_0e2a1c9aaa1549c4bfba655fe344d380_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_c7de2cf8658d4edcaf16d9028242c812_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_a5e542d7ceb84f4fa88bcda837b4c424_CommandTarget;

		private CharacterControllerSanta _caa33b0f80bb9184397c5ef77b881389_22e810435e854dcc9a5a02bdb16824b5_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_00b0a7ff2ddb40cab1dcd2e574f9f554_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_46c6a8254e09468985c6c613b50a4b14_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_3f9ce31d4e564714acd129f56ba45118_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_f5b306a647a94a1496f16656462dcf59_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_eb006bf6c80f4599b7eba9ca41c797e7_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_b9c281c0c90b4bd599b79a8737c36292_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_81894db23de441fc8c79fd50c9fab61a_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_877514829d934a0cb20868d4142d177c_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_743ae97f228843029120a11309f1a2b1_CommandTarget;

		private CharacterController _caa33b0f80bb9184397c5ef77b881389_b24d42eba6d24cfaafa8bee47c0884fe_CommandTarget;

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

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_0e2a1c9aaa1549c4bfba655fe344d380(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_0e2a1c9aaa1549c4bfba655fe344d380(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_0e2a1c9aaa1549c4bfba655fe344d380(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_0e2a1c9aaa1549c4bfba655fe344d380(_caa33b0f80bb9184397c5ef77b881389_0e2a1c9aaa1549c4bfba655fe344d380 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_c7de2cf8658d4edcaf16d9028242c812(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_c7de2cf8658d4edcaf16d9028242c812(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_c7de2cf8658d4edcaf16d9028242c812(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_c7de2cf8658d4edcaf16d9028242c812(_caa33b0f80bb9184397c5ef77b881389_c7de2cf8658d4edcaf16d9028242c812 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_a5e542d7ceb84f4fa88bcda837b4c424(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_a5e542d7ceb84f4fa88bcda837b4c424(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_a5e542d7ceb84f4fa88bcda837b4c424(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_a5e542d7ceb84f4fa88bcda837b4c424(_caa33b0f80bb9184397c5ef77b881389_a5e542d7ceb84f4fa88bcda837b4c424 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_22e810435e854dcc9a5a02bdb16824b5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_22e810435e854dcc9a5a02bdb16824b5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_22e810435e854dcc9a5a02bdb16824b5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_22e810435e854dcc9a5a02bdb16824b5(_caa33b0f80bb9184397c5ef77b881389_22e810435e854dcc9a5a02bdb16824b5 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_00b0a7ff2ddb40cab1dcd2e574f9f554(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_00b0a7ff2ddb40cab1dcd2e574f9f554(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_00b0a7ff2ddb40cab1dcd2e574f9f554(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_00b0a7ff2ddb40cab1dcd2e574f9f554(_caa33b0f80bb9184397c5ef77b881389_00b0a7ff2ddb40cab1dcd2e574f9f554 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_46c6a8254e09468985c6c613b50a4b14(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_46c6a8254e09468985c6c613b50a4b14(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_46c6a8254e09468985c6c613b50a4b14(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_46c6a8254e09468985c6c613b50a4b14(_caa33b0f80bb9184397c5ef77b881389_46c6a8254e09468985c6c613b50a4b14 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_3f9ce31d4e564714acd129f56ba45118(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_3f9ce31d4e564714acd129f56ba45118(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_3f9ce31d4e564714acd129f56ba45118(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_3f9ce31d4e564714acd129f56ba45118(_caa33b0f80bb9184397c5ef77b881389_3f9ce31d4e564714acd129f56ba45118 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_f5b306a647a94a1496f16656462dcf59(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_f5b306a647a94a1496f16656462dcf59(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_f5b306a647a94a1496f16656462dcf59(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_f5b306a647a94a1496f16656462dcf59(_caa33b0f80bb9184397c5ef77b881389_f5b306a647a94a1496f16656462dcf59 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_eb006bf6c80f4599b7eba9ca41c797e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_eb006bf6c80f4599b7eba9ca41c797e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_eb006bf6c80f4599b7eba9ca41c797e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_eb006bf6c80f4599b7eba9ca41c797e7(_caa33b0f80bb9184397c5ef77b881389_eb006bf6c80f4599b7eba9ca41c797e7 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_b9c281c0c90b4bd599b79a8737c36292(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_b9c281c0c90b4bd599b79a8737c36292(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_b9c281c0c90b4bd599b79a8737c36292(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_b9c281c0c90b4bd599b79a8737c36292(_caa33b0f80bb9184397c5ef77b881389_b9c281c0c90b4bd599b79a8737c36292 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_81894db23de441fc8c79fd50c9fab61a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_81894db23de441fc8c79fd50c9fab61a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_81894db23de441fc8c79fd50c9fab61a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_81894db23de441fc8c79fd50c9fab61a(_caa33b0f80bb9184397c5ef77b881389_81894db23de441fc8c79fd50c9fab61a command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_877514829d934a0cb20868d4142d177c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_877514829d934a0cb20868d4142d177c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_877514829d934a0cb20868d4142d177c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_877514829d934a0cb20868d4142d177c(_caa33b0f80bb9184397c5ef77b881389_877514829d934a0cb20868d4142d177c command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_743ae97f228843029120a11309f1a2b1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_743ae97f228843029120a11309f1a2b1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_743ae97f228843029120a11309f1a2b1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_743ae97f228843029120a11309f1a2b1(_caa33b0f80bb9184397c5ef77b881389_743ae97f228843029120a11309f1a2b1 command)
		{
		}

		private void BakeCommandBinding__caa33b0f80bb9184397c5ef77b881389_b24d42eba6d24cfaafa8bee47c0884fe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__caa33b0f80bb9184397c5ef77b881389_b24d42eba6d24cfaafa8bee47c0884fe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__caa33b0f80bb9184397c5ef77b881389_b24d42eba6d24cfaafa8bee47c0884fe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__caa33b0f80bb9184397c5ef77b881389_b24d42eba6d24cfaafa8bee47c0884fe(_caa33b0f80bb9184397c5ef77b881389_b24d42eba6d24cfaafa8bee47c0884fe command)
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
