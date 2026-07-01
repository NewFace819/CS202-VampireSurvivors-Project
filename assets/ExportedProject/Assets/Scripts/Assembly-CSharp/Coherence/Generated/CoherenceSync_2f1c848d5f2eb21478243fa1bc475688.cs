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
	public class CoherenceSync_2f1c848d5f2eb21478243fa1bc475688 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_0ce23ff63559410fad4d2f6bbac8d7a1_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_de6fec4bc8094cc89dd47e770a96729e_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_f2074a895c8b4133977b5ef6f4e644da_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_40d7b4a5ccdd4d178b446ac1eb898082_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_646160a3c039496a9311665020e4ab76_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_d7d4698a96db4a95b75df2c7b7e13008_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_be997adf5b4c4b0c9770bec7253b3246_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_34d2ce7400b64610a7d370b9af6dc25b_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_9eac0e3b2aeb4e27864d8fd236371356_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_1799e2daa01140b59a80fb70529c63a9_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_f567cf6754d045fbba7278fd84d5700e_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_0142415f2c904fe68919724f1478ea28_CommandTarget;

		private CharacterController _2f1c848d5f2eb21478243fa1bc475688_1d7473e353694446b5e9896087ae278c_CommandTarget;

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

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_0ce23ff63559410fad4d2f6bbac8d7a1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_0ce23ff63559410fad4d2f6bbac8d7a1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_0ce23ff63559410fad4d2f6bbac8d7a1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_0ce23ff63559410fad4d2f6bbac8d7a1(_2f1c848d5f2eb21478243fa1bc475688_0ce23ff63559410fad4d2f6bbac8d7a1 command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_de6fec4bc8094cc89dd47e770a96729e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_de6fec4bc8094cc89dd47e770a96729e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_de6fec4bc8094cc89dd47e770a96729e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_de6fec4bc8094cc89dd47e770a96729e(_2f1c848d5f2eb21478243fa1bc475688_de6fec4bc8094cc89dd47e770a96729e command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_f2074a895c8b4133977b5ef6f4e644da(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_f2074a895c8b4133977b5ef6f4e644da(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_f2074a895c8b4133977b5ef6f4e644da(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_f2074a895c8b4133977b5ef6f4e644da(_2f1c848d5f2eb21478243fa1bc475688_f2074a895c8b4133977b5ef6f4e644da command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_40d7b4a5ccdd4d178b446ac1eb898082(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_40d7b4a5ccdd4d178b446ac1eb898082(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_40d7b4a5ccdd4d178b446ac1eb898082(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_40d7b4a5ccdd4d178b446ac1eb898082(_2f1c848d5f2eb21478243fa1bc475688_40d7b4a5ccdd4d178b446ac1eb898082 command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_646160a3c039496a9311665020e4ab76(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_646160a3c039496a9311665020e4ab76(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_646160a3c039496a9311665020e4ab76(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_646160a3c039496a9311665020e4ab76(_2f1c848d5f2eb21478243fa1bc475688_646160a3c039496a9311665020e4ab76 command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_d7d4698a96db4a95b75df2c7b7e13008(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_d7d4698a96db4a95b75df2c7b7e13008(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_d7d4698a96db4a95b75df2c7b7e13008(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_d7d4698a96db4a95b75df2c7b7e13008(_2f1c848d5f2eb21478243fa1bc475688_d7d4698a96db4a95b75df2c7b7e13008 command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_be997adf5b4c4b0c9770bec7253b3246(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_be997adf5b4c4b0c9770bec7253b3246(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_be997adf5b4c4b0c9770bec7253b3246(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_be997adf5b4c4b0c9770bec7253b3246(_2f1c848d5f2eb21478243fa1bc475688_be997adf5b4c4b0c9770bec7253b3246 command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_34d2ce7400b64610a7d370b9af6dc25b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_34d2ce7400b64610a7d370b9af6dc25b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_34d2ce7400b64610a7d370b9af6dc25b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_34d2ce7400b64610a7d370b9af6dc25b(_2f1c848d5f2eb21478243fa1bc475688_34d2ce7400b64610a7d370b9af6dc25b command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_9eac0e3b2aeb4e27864d8fd236371356(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_9eac0e3b2aeb4e27864d8fd236371356(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_9eac0e3b2aeb4e27864d8fd236371356(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_9eac0e3b2aeb4e27864d8fd236371356(_2f1c848d5f2eb21478243fa1bc475688_9eac0e3b2aeb4e27864d8fd236371356 command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_1799e2daa01140b59a80fb70529c63a9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_1799e2daa01140b59a80fb70529c63a9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_1799e2daa01140b59a80fb70529c63a9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_1799e2daa01140b59a80fb70529c63a9(_2f1c848d5f2eb21478243fa1bc475688_1799e2daa01140b59a80fb70529c63a9 command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_f567cf6754d045fbba7278fd84d5700e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_f567cf6754d045fbba7278fd84d5700e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_f567cf6754d045fbba7278fd84d5700e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_f567cf6754d045fbba7278fd84d5700e(_2f1c848d5f2eb21478243fa1bc475688_f567cf6754d045fbba7278fd84d5700e command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_0142415f2c904fe68919724f1478ea28(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_0142415f2c904fe68919724f1478ea28(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_0142415f2c904fe68919724f1478ea28(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_0142415f2c904fe68919724f1478ea28(_2f1c848d5f2eb21478243fa1bc475688_0142415f2c904fe68919724f1478ea28 command)
		{
		}

		private void BakeCommandBinding__2f1c848d5f2eb21478243fa1bc475688_1d7473e353694446b5e9896087ae278c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f1c848d5f2eb21478243fa1bc475688_1d7473e353694446b5e9896087ae278c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f1c848d5f2eb21478243fa1bc475688_1d7473e353694446b5e9896087ae278c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f1c848d5f2eb21478243fa1bc475688_1d7473e353694446b5e9896087ae278c(_2f1c848d5f2eb21478243fa1bc475688_1d7473e353694446b5e9896087ae278c command)
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
