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
	public class CoherenceSync_20bcb04d7eca75d4791a6b8471eb2720 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_330b54c68b0f496496b1190297f7159f_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_b51aa0f22e844ba8954d99ec1d738269_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_c19a423fc8e5417e9f79770a372dd5ae_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_1942302c95524b479fdee2cbd751c4e0_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_e42fed794ce442309e1128f6d2165cb3_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_cdb9184884d14006b0877bfb5bfa713e_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_7224b314c30e431f8507da3e74c8f772_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_2464c78e7f5d45c2801ae0fc3a29de90_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_553f9c0a89f44aa1bea5d24bedba2bf6_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_99bd73d5bcfc4364988520a2e2a5ce32_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_f7e81283199d4f5e94fb993f1effec03_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_f308949dc84e499eb5a2e52fdc5a964d_CommandTarget;

		private CharacterController _20bcb04d7eca75d4791a6b8471eb2720_8260e0658f114bfea2be117505e9f91d_CommandTarget;

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

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_330b54c68b0f496496b1190297f7159f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_330b54c68b0f496496b1190297f7159f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_330b54c68b0f496496b1190297f7159f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_330b54c68b0f496496b1190297f7159f(_20bcb04d7eca75d4791a6b8471eb2720_330b54c68b0f496496b1190297f7159f command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_b51aa0f22e844ba8954d99ec1d738269(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_b51aa0f22e844ba8954d99ec1d738269(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_b51aa0f22e844ba8954d99ec1d738269(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_b51aa0f22e844ba8954d99ec1d738269(_20bcb04d7eca75d4791a6b8471eb2720_b51aa0f22e844ba8954d99ec1d738269 command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_c19a423fc8e5417e9f79770a372dd5ae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_c19a423fc8e5417e9f79770a372dd5ae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_c19a423fc8e5417e9f79770a372dd5ae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_c19a423fc8e5417e9f79770a372dd5ae(_20bcb04d7eca75d4791a6b8471eb2720_c19a423fc8e5417e9f79770a372dd5ae command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_1942302c95524b479fdee2cbd751c4e0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_1942302c95524b479fdee2cbd751c4e0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_1942302c95524b479fdee2cbd751c4e0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_1942302c95524b479fdee2cbd751c4e0(_20bcb04d7eca75d4791a6b8471eb2720_1942302c95524b479fdee2cbd751c4e0 command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_e42fed794ce442309e1128f6d2165cb3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_e42fed794ce442309e1128f6d2165cb3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_e42fed794ce442309e1128f6d2165cb3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_e42fed794ce442309e1128f6d2165cb3(_20bcb04d7eca75d4791a6b8471eb2720_e42fed794ce442309e1128f6d2165cb3 command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_cdb9184884d14006b0877bfb5bfa713e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_cdb9184884d14006b0877bfb5bfa713e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_cdb9184884d14006b0877bfb5bfa713e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_cdb9184884d14006b0877bfb5bfa713e(_20bcb04d7eca75d4791a6b8471eb2720_cdb9184884d14006b0877bfb5bfa713e command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_7224b314c30e431f8507da3e74c8f772(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_7224b314c30e431f8507da3e74c8f772(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_7224b314c30e431f8507da3e74c8f772(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_7224b314c30e431f8507da3e74c8f772(_20bcb04d7eca75d4791a6b8471eb2720_7224b314c30e431f8507da3e74c8f772 command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_2464c78e7f5d45c2801ae0fc3a29de90(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_2464c78e7f5d45c2801ae0fc3a29de90(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_2464c78e7f5d45c2801ae0fc3a29de90(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_2464c78e7f5d45c2801ae0fc3a29de90(_20bcb04d7eca75d4791a6b8471eb2720_2464c78e7f5d45c2801ae0fc3a29de90 command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_553f9c0a89f44aa1bea5d24bedba2bf6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_553f9c0a89f44aa1bea5d24bedba2bf6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_553f9c0a89f44aa1bea5d24bedba2bf6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_553f9c0a89f44aa1bea5d24bedba2bf6(_20bcb04d7eca75d4791a6b8471eb2720_553f9c0a89f44aa1bea5d24bedba2bf6 command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_99bd73d5bcfc4364988520a2e2a5ce32(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_99bd73d5bcfc4364988520a2e2a5ce32(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_99bd73d5bcfc4364988520a2e2a5ce32(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_99bd73d5bcfc4364988520a2e2a5ce32(_20bcb04d7eca75d4791a6b8471eb2720_99bd73d5bcfc4364988520a2e2a5ce32 command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_f7e81283199d4f5e94fb993f1effec03(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_f7e81283199d4f5e94fb993f1effec03(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_f7e81283199d4f5e94fb993f1effec03(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_f7e81283199d4f5e94fb993f1effec03(_20bcb04d7eca75d4791a6b8471eb2720_f7e81283199d4f5e94fb993f1effec03 command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_f308949dc84e499eb5a2e52fdc5a964d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_f308949dc84e499eb5a2e52fdc5a964d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_f308949dc84e499eb5a2e52fdc5a964d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_f308949dc84e499eb5a2e52fdc5a964d(_20bcb04d7eca75d4791a6b8471eb2720_f308949dc84e499eb5a2e52fdc5a964d command)
		{
		}

		private void BakeCommandBinding__20bcb04d7eca75d4791a6b8471eb2720_8260e0658f114bfea2be117505e9f91d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20bcb04d7eca75d4791a6b8471eb2720_8260e0658f114bfea2be117505e9f91d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20bcb04d7eca75d4791a6b8471eb2720_8260e0658f114bfea2be117505e9f91d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20bcb04d7eca75d4791a6b8471eb2720_8260e0658f114bfea2be117505e9f91d(_20bcb04d7eca75d4791a6b8471eb2720_8260e0658f114bfea2be117505e9f91d command)
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
