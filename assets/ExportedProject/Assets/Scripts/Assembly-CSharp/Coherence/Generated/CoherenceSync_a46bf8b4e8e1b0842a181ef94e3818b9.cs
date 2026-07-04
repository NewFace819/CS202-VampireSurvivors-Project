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
	public class CoherenceSync_a46bf8b4e8e1b0842a181ef94e3818b9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_c3f0b7c391634067bf17a348ff4dd15c_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_45f7d8ee282b4f37bb140902d73ac9a4_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_dcba747a4ac9478bb4f6fe09822f2db2_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_3c3089264fb84589bcafb291c6c92355_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_b89ef14eed4e4aed8a2852da1a784785_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_7c7a984f05cc48378b2c26208345cc56_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_a1fbac1321c24cac98b2f59f14d5587f_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_b95d9241b52a47ad96c88a72651c5590_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_c2fd7b75ccc7403c8da6ca0aa05f4cfa_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_9cff097cd33345bd9371635a24adaaa1_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_3b326a96c46f4cd9829af7672e217092_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_d90a9b16c0ce4684b8016636df558c27_CommandTarget;

		private CharacterController _a46bf8b4e8e1b0842a181ef94e3818b9_74db9c989b6747e78bf7a4048959ee19_CommandTarget;

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

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_c3f0b7c391634067bf17a348ff4dd15c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_c3f0b7c391634067bf17a348ff4dd15c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_c3f0b7c391634067bf17a348ff4dd15c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_c3f0b7c391634067bf17a348ff4dd15c(_a46bf8b4e8e1b0842a181ef94e3818b9_c3f0b7c391634067bf17a348ff4dd15c command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_45f7d8ee282b4f37bb140902d73ac9a4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_45f7d8ee282b4f37bb140902d73ac9a4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_45f7d8ee282b4f37bb140902d73ac9a4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_45f7d8ee282b4f37bb140902d73ac9a4(_a46bf8b4e8e1b0842a181ef94e3818b9_45f7d8ee282b4f37bb140902d73ac9a4 command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_dcba747a4ac9478bb4f6fe09822f2db2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_dcba747a4ac9478bb4f6fe09822f2db2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_dcba747a4ac9478bb4f6fe09822f2db2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_dcba747a4ac9478bb4f6fe09822f2db2(_a46bf8b4e8e1b0842a181ef94e3818b9_dcba747a4ac9478bb4f6fe09822f2db2 command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_3c3089264fb84589bcafb291c6c92355(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_3c3089264fb84589bcafb291c6c92355(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_3c3089264fb84589bcafb291c6c92355(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_3c3089264fb84589bcafb291c6c92355(_a46bf8b4e8e1b0842a181ef94e3818b9_3c3089264fb84589bcafb291c6c92355 command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_b89ef14eed4e4aed8a2852da1a784785(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_b89ef14eed4e4aed8a2852da1a784785(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_b89ef14eed4e4aed8a2852da1a784785(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_b89ef14eed4e4aed8a2852da1a784785(_a46bf8b4e8e1b0842a181ef94e3818b9_b89ef14eed4e4aed8a2852da1a784785 command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_7c7a984f05cc48378b2c26208345cc56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_7c7a984f05cc48378b2c26208345cc56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_7c7a984f05cc48378b2c26208345cc56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_7c7a984f05cc48378b2c26208345cc56(_a46bf8b4e8e1b0842a181ef94e3818b9_7c7a984f05cc48378b2c26208345cc56 command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_a1fbac1321c24cac98b2f59f14d5587f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_a1fbac1321c24cac98b2f59f14d5587f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_a1fbac1321c24cac98b2f59f14d5587f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_a1fbac1321c24cac98b2f59f14d5587f(_a46bf8b4e8e1b0842a181ef94e3818b9_a1fbac1321c24cac98b2f59f14d5587f command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_b95d9241b52a47ad96c88a72651c5590(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_b95d9241b52a47ad96c88a72651c5590(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_b95d9241b52a47ad96c88a72651c5590(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_b95d9241b52a47ad96c88a72651c5590(_a46bf8b4e8e1b0842a181ef94e3818b9_b95d9241b52a47ad96c88a72651c5590 command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_c2fd7b75ccc7403c8da6ca0aa05f4cfa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_c2fd7b75ccc7403c8da6ca0aa05f4cfa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_c2fd7b75ccc7403c8da6ca0aa05f4cfa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_c2fd7b75ccc7403c8da6ca0aa05f4cfa(_a46bf8b4e8e1b0842a181ef94e3818b9_c2fd7b75ccc7403c8da6ca0aa05f4cfa command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_9cff097cd33345bd9371635a24adaaa1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_9cff097cd33345bd9371635a24adaaa1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_9cff097cd33345bd9371635a24adaaa1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_9cff097cd33345bd9371635a24adaaa1(_a46bf8b4e8e1b0842a181ef94e3818b9_9cff097cd33345bd9371635a24adaaa1 command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_3b326a96c46f4cd9829af7672e217092(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_3b326a96c46f4cd9829af7672e217092(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_3b326a96c46f4cd9829af7672e217092(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_3b326a96c46f4cd9829af7672e217092(_a46bf8b4e8e1b0842a181ef94e3818b9_3b326a96c46f4cd9829af7672e217092 command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_d90a9b16c0ce4684b8016636df558c27(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_d90a9b16c0ce4684b8016636df558c27(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_d90a9b16c0ce4684b8016636df558c27(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_d90a9b16c0ce4684b8016636df558c27(_a46bf8b4e8e1b0842a181ef94e3818b9_d90a9b16c0ce4684b8016636df558c27 command)
		{
		}

		private void BakeCommandBinding__a46bf8b4e8e1b0842a181ef94e3818b9_74db9c989b6747e78bf7a4048959ee19(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a46bf8b4e8e1b0842a181ef94e3818b9_74db9c989b6747e78bf7a4048959ee19(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a46bf8b4e8e1b0842a181ef94e3818b9_74db9c989b6747e78bf7a4048959ee19(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a46bf8b4e8e1b0842a181ef94e3818b9_74db9c989b6747e78bf7a4048959ee19(_a46bf8b4e8e1b0842a181ef94e3818b9_74db9c989b6747e78bf7a4048959ee19 command)
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
