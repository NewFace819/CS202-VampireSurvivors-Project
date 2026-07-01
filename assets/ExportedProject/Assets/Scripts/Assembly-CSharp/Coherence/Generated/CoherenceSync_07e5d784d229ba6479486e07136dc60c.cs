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
	public class CoherenceSync_07e5d784d229ba6479486e07136dc60c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_cd14d2956c09449b8894c28ac9cdfe61_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_1794d7794615416eb78ad09cbc4aee40_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_993d80c514b14499ab532a2f8084dfaa_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_4d559cf1f6124680a17879cf6bfdff17_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_dbf3aa26aef54d5b9e89082ba97bffa6_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_97176c055b5f4f4b922fd35865d6d8fe_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_1f215959caf3468c9f929c4f601c699d_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_021ebd8f009f4ecd9adc0edcce531104_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_51c9625bec88456aa1d8a2ce68cae3ef_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_aaca220403894e0cbb3062bc5e7e1e08_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_41442029975a40c79c46b8e1753502e6_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_85402fbf6cb94020a28d1d0080277cb6_CommandTarget;

		private CharacterController _07e5d784d229ba6479486e07136dc60c_5fed014983d64e52947116129caed3a0_CommandTarget;

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

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_cd14d2956c09449b8894c28ac9cdfe61(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_cd14d2956c09449b8894c28ac9cdfe61(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_cd14d2956c09449b8894c28ac9cdfe61(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_cd14d2956c09449b8894c28ac9cdfe61(_07e5d784d229ba6479486e07136dc60c_cd14d2956c09449b8894c28ac9cdfe61 command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_1794d7794615416eb78ad09cbc4aee40(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_1794d7794615416eb78ad09cbc4aee40(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_1794d7794615416eb78ad09cbc4aee40(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_1794d7794615416eb78ad09cbc4aee40(_07e5d784d229ba6479486e07136dc60c_1794d7794615416eb78ad09cbc4aee40 command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_993d80c514b14499ab532a2f8084dfaa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_993d80c514b14499ab532a2f8084dfaa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_993d80c514b14499ab532a2f8084dfaa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_993d80c514b14499ab532a2f8084dfaa(_07e5d784d229ba6479486e07136dc60c_993d80c514b14499ab532a2f8084dfaa command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_4d559cf1f6124680a17879cf6bfdff17(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_4d559cf1f6124680a17879cf6bfdff17(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_4d559cf1f6124680a17879cf6bfdff17(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_4d559cf1f6124680a17879cf6bfdff17(_07e5d784d229ba6479486e07136dc60c_4d559cf1f6124680a17879cf6bfdff17 command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_dbf3aa26aef54d5b9e89082ba97bffa6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_dbf3aa26aef54d5b9e89082ba97bffa6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_dbf3aa26aef54d5b9e89082ba97bffa6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_dbf3aa26aef54d5b9e89082ba97bffa6(_07e5d784d229ba6479486e07136dc60c_dbf3aa26aef54d5b9e89082ba97bffa6 command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_97176c055b5f4f4b922fd35865d6d8fe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_97176c055b5f4f4b922fd35865d6d8fe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_97176c055b5f4f4b922fd35865d6d8fe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_97176c055b5f4f4b922fd35865d6d8fe(_07e5d784d229ba6479486e07136dc60c_97176c055b5f4f4b922fd35865d6d8fe command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_1f215959caf3468c9f929c4f601c699d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_1f215959caf3468c9f929c4f601c699d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_1f215959caf3468c9f929c4f601c699d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_1f215959caf3468c9f929c4f601c699d(_07e5d784d229ba6479486e07136dc60c_1f215959caf3468c9f929c4f601c699d command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_021ebd8f009f4ecd9adc0edcce531104(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_021ebd8f009f4ecd9adc0edcce531104(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_021ebd8f009f4ecd9adc0edcce531104(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_021ebd8f009f4ecd9adc0edcce531104(_07e5d784d229ba6479486e07136dc60c_021ebd8f009f4ecd9adc0edcce531104 command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_51c9625bec88456aa1d8a2ce68cae3ef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_51c9625bec88456aa1d8a2ce68cae3ef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_51c9625bec88456aa1d8a2ce68cae3ef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_51c9625bec88456aa1d8a2ce68cae3ef(_07e5d784d229ba6479486e07136dc60c_51c9625bec88456aa1d8a2ce68cae3ef command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_aaca220403894e0cbb3062bc5e7e1e08(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_aaca220403894e0cbb3062bc5e7e1e08(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_aaca220403894e0cbb3062bc5e7e1e08(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_aaca220403894e0cbb3062bc5e7e1e08(_07e5d784d229ba6479486e07136dc60c_aaca220403894e0cbb3062bc5e7e1e08 command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_41442029975a40c79c46b8e1753502e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_41442029975a40c79c46b8e1753502e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_41442029975a40c79c46b8e1753502e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_41442029975a40c79c46b8e1753502e6(_07e5d784d229ba6479486e07136dc60c_41442029975a40c79c46b8e1753502e6 command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_85402fbf6cb94020a28d1d0080277cb6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_85402fbf6cb94020a28d1d0080277cb6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_85402fbf6cb94020a28d1d0080277cb6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_85402fbf6cb94020a28d1d0080277cb6(_07e5d784d229ba6479486e07136dc60c_85402fbf6cb94020a28d1d0080277cb6 command)
		{
		}

		private void BakeCommandBinding__07e5d784d229ba6479486e07136dc60c_5fed014983d64e52947116129caed3a0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07e5d784d229ba6479486e07136dc60c_5fed014983d64e52947116129caed3a0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07e5d784d229ba6479486e07136dc60c_5fed014983d64e52947116129caed3a0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07e5d784d229ba6479486e07136dc60c_5fed014983d64e52947116129caed3a0(_07e5d784d229ba6479486e07136dc60c_5fed014983d64e52947116129caed3a0 command)
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
