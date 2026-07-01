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
	public class CoherenceSync_5f022b074afe9264aa9c4b560a5e03a3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_573391d1b22145388bc1845d2839c62f_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_14b7056294bf47149392e8c25bdc0671_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_69e2b30002ef4d3cafdbf8cfc8a1a04c_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_06a5c534d5cf4e68806a63ba04f340e2_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_3c4474dad1574e5da1ef018d0d14a528_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_284ae848391c40d7bbc7096a35fdb736_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_ff2e6aa2d482454e89981a68cff179bc_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_6e85d7f3814a46b39fde0444283fc607_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_4adfe531308f4d398f6f6e4af3675360_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_bca6b422d03046f7afd369f35a79d51a_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_6ccc38e4138a496da1998b7018fae76c_CommandTarget;

		private CharacterControllerGazebo _5f022b074afe9264aa9c4b560a5e03a3_5b7b946311ec46bfa0a043e294605d28_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_bad78e179dac411299019631ffe156ff_CommandTarget;

		private CharacterController _5f022b074afe9264aa9c4b560a5e03a3_7db7f11e82d04fd8ac6837d9c81f8970_CommandTarget;

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

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_573391d1b22145388bc1845d2839c62f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_573391d1b22145388bc1845d2839c62f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_573391d1b22145388bc1845d2839c62f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_573391d1b22145388bc1845d2839c62f(_5f022b074afe9264aa9c4b560a5e03a3_573391d1b22145388bc1845d2839c62f command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_14b7056294bf47149392e8c25bdc0671(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_14b7056294bf47149392e8c25bdc0671(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_14b7056294bf47149392e8c25bdc0671(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_14b7056294bf47149392e8c25bdc0671(_5f022b074afe9264aa9c4b560a5e03a3_14b7056294bf47149392e8c25bdc0671 command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_69e2b30002ef4d3cafdbf8cfc8a1a04c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_69e2b30002ef4d3cafdbf8cfc8a1a04c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_69e2b30002ef4d3cafdbf8cfc8a1a04c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_69e2b30002ef4d3cafdbf8cfc8a1a04c(_5f022b074afe9264aa9c4b560a5e03a3_69e2b30002ef4d3cafdbf8cfc8a1a04c command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_06a5c534d5cf4e68806a63ba04f340e2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_06a5c534d5cf4e68806a63ba04f340e2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_06a5c534d5cf4e68806a63ba04f340e2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_06a5c534d5cf4e68806a63ba04f340e2(_5f022b074afe9264aa9c4b560a5e03a3_06a5c534d5cf4e68806a63ba04f340e2 command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_3c4474dad1574e5da1ef018d0d14a528(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_3c4474dad1574e5da1ef018d0d14a528(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_3c4474dad1574e5da1ef018d0d14a528(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_3c4474dad1574e5da1ef018d0d14a528(_5f022b074afe9264aa9c4b560a5e03a3_3c4474dad1574e5da1ef018d0d14a528 command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_284ae848391c40d7bbc7096a35fdb736(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_284ae848391c40d7bbc7096a35fdb736(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_284ae848391c40d7bbc7096a35fdb736(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_284ae848391c40d7bbc7096a35fdb736(_5f022b074afe9264aa9c4b560a5e03a3_284ae848391c40d7bbc7096a35fdb736 command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_ff2e6aa2d482454e89981a68cff179bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_ff2e6aa2d482454e89981a68cff179bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_ff2e6aa2d482454e89981a68cff179bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_ff2e6aa2d482454e89981a68cff179bc(_5f022b074afe9264aa9c4b560a5e03a3_ff2e6aa2d482454e89981a68cff179bc command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_6e85d7f3814a46b39fde0444283fc607(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_6e85d7f3814a46b39fde0444283fc607(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_6e85d7f3814a46b39fde0444283fc607(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_6e85d7f3814a46b39fde0444283fc607(_5f022b074afe9264aa9c4b560a5e03a3_6e85d7f3814a46b39fde0444283fc607 command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_4adfe531308f4d398f6f6e4af3675360(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_4adfe531308f4d398f6f6e4af3675360(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_4adfe531308f4d398f6f6e4af3675360(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_4adfe531308f4d398f6f6e4af3675360(_5f022b074afe9264aa9c4b560a5e03a3_4adfe531308f4d398f6f6e4af3675360 command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_bca6b422d03046f7afd369f35a79d51a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_bca6b422d03046f7afd369f35a79d51a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_bca6b422d03046f7afd369f35a79d51a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_bca6b422d03046f7afd369f35a79d51a(_5f022b074afe9264aa9c4b560a5e03a3_bca6b422d03046f7afd369f35a79d51a command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_6ccc38e4138a496da1998b7018fae76c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_6ccc38e4138a496da1998b7018fae76c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_6ccc38e4138a496da1998b7018fae76c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_6ccc38e4138a496da1998b7018fae76c(_5f022b074afe9264aa9c4b560a5e03a3_6ccc38e4138a496da1998b7018fae76c command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_5b7b946311ec46bfa0a043e294605d28(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_5b7b946311ec46bfa0a043e294605d28(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_5b7b946311ec46bfa0a043e294605d28(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_5b7b946311ec46bfa0a043e294605d28(_5f022b074afe9264aa9c4b560a5e03a3_5b7b946311ec46bfa0a043e294605d28 command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_bad78e179dac411299019631ffe156ff(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_bad78e179dac411299019631ffe156ff(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_bad78e179dac411299019631ffe156ff(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_bad78e179dac411299019631ffe156ff(_5f022b074afe9264aa9c4b560a5e03a3_bad78e179dac411299019631ffe156ff command)
		{
		}

		private void BakeCommandBinding__5f022b074afe9264aa9c4b560a5e03a3_7db7f11e82d04fd8ac6837d9c81f8970(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5f022b074afe9264aa9c4b560a5e03a3_7db7f11e82d04fd8ac6837d9c81f8970(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5f022b074afe9264aa9c4b560a5e03a3_7db7f11e82d04fd8ac6837d9c81f8970(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5f022b074afe9264aa9c4b560a5e03a3_7db7f11e82d04fd8ac6837d9c81f8970(_5f022b074afe9264aa9c4b560a5e03a3_7db7f11e82d04fd8ac6837d9c81f8970 command)
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
