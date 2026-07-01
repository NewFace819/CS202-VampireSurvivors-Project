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
	public class CoherenceSync_6184a43442d903e4e9e533a91e2bd1b2 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_186efbbc3b7d48a3aeab9d2f00ab3df9_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_abd8feab689f46b2ba90a45c32444da9_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_6b1fb90ff3e145ceb1bffb0e338303a8_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_737e3e4894eb466fbf734352bea243d7_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_59e011dcd903486f815c9f5525a2056a_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_112de470ac894486a0ea3115e5e84a51_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_002151ea7a94425084f446f566a16a9b_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_4f695f2376cf4582889d8734dabd32c6_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_1055763acbbe462297985f85b3c030c6_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_cc19aa4ef03c4d6e9dff5056e55abb39_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_2ea359fc1c50491e86b93f3ecdd3315d_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_b41ae1debd0c4bb9952e609ee121a2f7_CommandTarget;

		private CharacterController _6184a43442d903e4e9e533a91e2bd1b2_01a3fa7f7bc54f4ab604317e99c0fa38_CommandTarget;

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

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_186efbbc3b7d48a3aeab9d2f00ab3df9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_186efbbc3b7d48a3aeab9d2f00ab3df9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_186efbbc3b7d48a3aeab9d2f00ab3df9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_186efbbc3b7d48a3aeab9d2f00ab3df9(_6184a43442d903e4e9e533a91e2bd1b2_186efbbc3b7d48a3aeab9d2f00ab3df9 command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_abd8feab689f46b2ba90a45c32444da9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_abd8feab689f46b2ba90a45c32444da9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_abd8feab689f46b2ba90a45c32444da9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_abd8feab689f46b2ba90a45c32444da9(_6184a43442d903e4e9e533a91e2bd1b2_abd8feab689f46b2ba90a45c32444da9 command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_6b1fb90ff3e145ceb1bffb0e338303a8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_6b1fb90ff3e145ceb1bffb0e338303a8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_6b1fb90ff3e145ceb1bffb0e338303a8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_6b1fb90ff3e145ceb1bffb0e338303a8(_6184a43442d903e4e9e533a91e2bd1b2_6b1fb90ff3e145ceb1bffb0e338303a8 command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_737e3e4894eb466fbf734352bea243d7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_737e3e4894eb466fbf734352bea243d7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_737e3e4894eb466fbf734352bea243d7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_737e3e4894eb466fbf734352bea243d7(_6184a43442d903e4e9e533a91e2bd1b2_737e3e4894eb466fbf734352bea243d7 command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_59e011dcd903486f815c9f5525a2056a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_59e011dcd903486f815c9f5525a2056a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_59e011dcd903486f815c9f5525a2056a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_59e011dcd903486f815c9f5525a2056a(_6184a43442d903e4e9e533a91e2bd1b2_59e011dcd903486f815c9f5525a2056a command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_112de470ac894486a0ea3115e5e84a51(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_112de470ac894486a0ea3115e5e84a51(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_112de470ac894486a0ea3115e5e84a51(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_112de470ac894486a0ea3115e5e84a51(_6184a43442d903e4e9e533a91e2bd1b2_112de470ac894486a0ea3115e5e84a51 command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_002151ea7a94425084f446f566a16a9b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_002151ea7a94425084f446f566a16a9b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_002151ea7a94425084f446f566a16a9b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_002151ea7a94425084f446f566a16a9b(_6184a43442d903e4e9e533a91e2bd1b2_002151ea7a94425084f446f566a16a9b command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_4f695f2376cf4582889d8734dabd32c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_4f695f2376cf4582889d8734dabd32c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_4f695f2376cf4582889d8734dabd32c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_4f695f2376cf4582889d8734dabd32c6(_6184a43442d903e4e9e533a91e2bd1b2_4f695f2376cf4582889d8734dabd32c6 command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_1055763acbbe462297985f85b3c030c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_1055763acbbe462297985f85b3c030c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_1055763acbbe462297985f85b3c030c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_1055763acbbe462297985f85b3c030c6(_6184a43442d903e4e9e533a91e2bd1b2_1055763acbbe462297985f85b3c030c6 command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_cc19aa4ef03c4d6e9dff5056e55abb39(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_cc19aa4ef03c4d6e9dff5056e55abb39(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_cc19aa4ef03c4d6e9dff5056e55abb39(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_cc19aa4ef03c4d6e9dff5056e55abb39(_6184a43442d903e4e9e533a91e2bd1b2_cc19aa4ef03c4d6e9dff5056e55abb39 command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_2ea359fc1c50491e86b93f3ecdd3315d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_2ea359fc1c50491e86b93f3ecdd3315d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_2ea359fc1c50491e86b93f3ecdd3315d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_2ea359fc1c50491e86b93f3ecdd3315d(_6184a43442d903e4e9e533a91e2bd1b2_2ea359fc1c50491e86b93f3ecdd3315d command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_b41ae1debd0c4bb9952e609ee121a2f7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_b41ae1debd0c4bb9952e609ee121a2f7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_b41ae1debd0c4bb9952e609ee121a2f7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_b41ae1debd0c4bb9952e609ee121a2f7(_6184a43442d903e4e9e533a91e2bd1b2_b41ae1debd0c4bb9952e609ee121a2f7 command)
		{
		}

		private void BakeCommandBinding__6184a43442d903e4e9e533a91e2bd1b2_01a3fa7f7bc54f4ab604317e99c0fa38(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6184a43442d903e4e9e533a91e2bd1b2_01a3fa7f7bc54f4ab604317e99c0fa38(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6184a43442d903e4e9e533a91e2bd1b2_01a3fa7f7bc54f4ab604317e99c0fa38(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6184a43442d903e4e9e533a91e2bd1b2_01a3fa7f7bc54f4ab604317e99c0fa38(_6184a43442d903e4e9e533a91e2bd1b2_01a3fa7f7bc54f4ab604317e99c0fa38 command)
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
