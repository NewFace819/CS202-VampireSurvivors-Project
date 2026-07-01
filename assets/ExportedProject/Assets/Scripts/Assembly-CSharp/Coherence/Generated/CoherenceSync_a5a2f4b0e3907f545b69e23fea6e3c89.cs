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
	public class CoherenceSync_a5a2f4b0e3907f545b69e23fea6e3c89 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_0a570f2cf4194d8d9ced68dfa00186c8_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_176e0f22cc7e4ffaaa092ba64d338cb7_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_d905c67cf3054fba8a496eb3f49d0e37_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_eb102948cefc45a9bf0cf14de2e570bd_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_04eccbe76a5b459888e473e4446446d5_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_2ea286f9b1ed495cacb9046af3d899ca_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_a09d653b0af0441189c2fd8c779707e9_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_dea3a1333b05412d834d5093d0526e35_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_815816e0453f4f8e83656a6408608aba_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_d4d3ab71151142ccaeef7a2a782666ca_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_e9d825b54a1044d4864b4b7b2e6a623b_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_bc550ab8e6de46cba3182a7af5c74cb5_CommandTarget;

		private CharacterController _a5a2f4b0e3907f545b69e23fea6e3c89_67e686155c3a4230bd8f77b382cc0e03_CommandTarget;

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

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_0a570f2cf4194d8d9ced68dfa00186c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_0a570f2cf4194d8d9ced68dfa00186c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_0a570f2cf4194d8d9ced68dfa00186c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_0a570f2cf4194d8d9ced68dfa00186c8(_a5a2f4b0e3907f545b69e23fea6e3c89_0a570f2cf4194d8d9ced68dfa00186c8 command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_176e0f22cc7e4ffaaa092ba64d338cb7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_176e0f22cc7e4ffaaa092ba64d338cb7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_176e0f22cc7e4ffaaa092ba64d338cb7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_176e0f22cc7e4ffaaa092ba64d338cb7(_a5a2f4b0e3907f545b69e23fea6e3c89_176e0f22cc7e4ffaaa092ba64d338cb7 command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_d905c67cf3054fba8a496eb3f49d0e37(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_d905c67cf3054fba8a496eb3f49d0e37(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_d905c67cf3054fba8a496eb3f49d0e37(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_d905c67cf3054fba8a496eb3f49d0e37(_a5a2f4b0e3907f545b69e23fea6e3c89_d905c67cf3054fba8a496eb3f49d0e37 command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_eb102948cefc45a9bf0cf14de2e570bd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_eb102948cefc45a9bf0cf14de2e570bd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_eb102948cefc45a9bf0cf14de2e570bd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_eb102948cefc45a9bf0cf14de2e570bd(_a5a2f4b0e3907f545b69e23fea6e3c89_eb102948cefc45a9bf0cf14de2e570bd command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_04eccbe76a5b459888e473e4446446d5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_04eccbe76a5b459888e473e4446446d5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_04eccbe76a5b459888e473e4446446d5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_04eccbe76a5b459888e473e4446446d5(_a5a2f4b0e3907f545b69e23fea6e3c89_04eccbe76a5b459888e473e4446446d5 command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_2ea286f9b1ed495cacb9046af3d899ca(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_2ea286f9b1ed495cacb9046af3d899ca(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_2ea286f9b1ed495cacb9046af3d899ca(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_2ea286f9b1ed495cacb9046af3d899ca(_a5a2f4b0e3907f545b69e23fea6e3c89_2ea286f9b1ed495cacb9046af3d899ca command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_a09d653b0af0441189c2fd8c779707e9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_a09d653b0af0441189c2fd8c779707e9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_a09d653b0af0441189c2fd8c779707e9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_a09d653b0af0441189c2fd8c779707e9(_a5a2f4b0e3907f545b69e23fea6e3c89_a09d653b0af0441189c2fd8c779707e9 command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_dea3a1333b05412d834d5093d0526e35(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_dea3a1333b05412d834d5093d0526e35(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_dea3a1333b05412d834d5093d0526e35(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_dea3a1333b05412d834d5093d0526e35(_a5a2f4b0e3907f545b69e23fea6e3c89_dea3a1333b05412d834d5093d0526e35 command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_815816e0453f4f8e83656a6408608aba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_815816e0453f4f8e83656a6408608aba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_815816e0453f4f8e83656a6408608aba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_815816e0453f4f8e83656a6408608aba(_a5a2f4b0e3907f545b69e23fea6e3c89_815816e0453f4f8e83656a6408608aba command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_d4d3ab71151142ccaeef7a2a782666ca(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_d4d3ab71151142ccaeef7a2a782666ca(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_d4d3ab71151142ccaeef7a2a782666ca(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_d4d3ab71151142ccaeef7a2a782666ca(_a5a2f4b0e3907f545b69e23fea6e3c89_d4d3ab71151142ccaeef7a2a782666ca command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_e9d825b54a1044d4864b4b7b2e6a623b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_e9d825b54a1044d4864b4b7b2e6a623b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_e9d825b54a1044d4864b4b7b2e6a623b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_e9d825b54a1044d4864b4b7b2e6a623b(_a5a2f4b0e3907f545b69e23fea6e3c89_e9d825b54a1044d4864b4b7b2e6a623b command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_bc550ab8e6de46cba3182a7af5c74cb5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_bc550ab8e6de46cba3182a7af5c74cb5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_bc550ab8e6de46cba3182a7af5c74cb5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_bc550ab8e6de46cba3182a7af5c74cb5(_a5a2f4b0e3907f545b69e23fea6e3c89_bc550ab8e6de46cba3182a7af5c74cb5 command)
		{
		}

		private void BakeCommandBinding__a5a2f4b0e3907f545b69e23fea6e3c89_67e686155c3a4230bd8f77b382cc0e03(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5a2f4b0e3907f545b69e23fea6e3c89_67e686155c3a4230bd8f77b382cc0e03(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5a2f4b0e3907f545b69e23fea6e3c89_67e686155c3a4230bd8f77b382cc0e03(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5a2f4b0e3907f545b69e23fea6e3c89_67e686155c3a4230bd8f77b382cc0e03(_a5a2f4b0e3907f545b69e23fea6e3c89_67e686155c3a4230bd8f77b382cc0e03 command)
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
