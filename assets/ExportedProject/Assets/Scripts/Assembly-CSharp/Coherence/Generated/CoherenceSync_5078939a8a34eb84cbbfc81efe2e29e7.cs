using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_5078939a8a34eb84cbbfc81efe2e29e7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _5078939a8a34eb84cbbfc81efe2e29e7_98c1b9e539304c5da140b483529a7c03_CommandTarget;

		private NetworkPickup _5078939a8a34eb84cbbfc81efe2e29e7_7f9bb871878940b1a76f8de4d11a5a75_CommandTarget;

		private NetworkPickup _5078939a8a34eb84cbbfc81efe2e29e7_7c1ba14834b3422aadf11d4c515b7748_CommandTarget;

		private NetworkPickup _5078939a8a34eb84cbbfc81efe2e29e7_89a175cdf861429e908d248dda6369f9_CommandTarget;

		private NetworkPickup _5078939a8a34eb84cbbfc81efe2e29e7_9e79884ee9c64dbe979bc6d21306f4bc_CommandTarget;

		private NetworkPickup _5078939a8a34eb84cbbfc81efe2e29e7_9d136cd11c724c17befd4f13be98a3ed_CommandTarget;

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

		private void BakeCommandBinding__5078939a8a34eb84cbbfc81efe2e29e7_98c1b9e539304c5da140b483529a7c03(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5078939a8a34eb84cbbfc81efe2e29e7_98c1b9e539304c5da140b483529a7c03(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5078939a8a34eb84cbbfc81efe2e29e7_98c1b9e539304c5da140b483529a7c03(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5078939a8a34eb84cbbfc81efe2e29e7_98c1b9e539304c5da140b483529a7c03(_5078939a8a34eb84cbbfc81efe2e29e7_98c1b9e539304c5da140b483529a7c03 command)
		{
		}

		private void BakeCommandBinding__5078939a8a34eb84cbbfc81efe2e29e7_7f9bb871878940b1a76f8de4d11a5a75(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5078939a8a34eb84cbbfc81efe2e29e7_7f9bb871878940b1a76f8de4d11a5a75(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5078939a8a34eb84cbbfc81efe2e29e7_7f9bb871878940b1a76f8de4d11a5a75(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5078939a8a34eb84cbbfc81efe2e29e7_7f9bb871878940b1a76f8de4d11a5a75(_5078939a8a34eb84cbbfc81efe2e29e7_7f9bb871878940b1a76f8de4d11a5a75 command)
		{
		}

		private void BakeCommandBinding__5078939a8a34eb84cbbfc81efe2e29e7_7c1ba14834b3422aadf11d4c515b7748(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5078939a8a34eb84cbbfc81efe2e29e7_7c1ba14834b3422aadf11d4c515b7748(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5078939a8a34eb84cbbfc81efe2e29e7_7c1ba14834b3422aadf11d4c515b7748(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5078939a8a34eb84cbbfc81efe2e29e7_7c1ba14834b3422aadf11d4c515b7748(_5078939a8a34eb84cbbfc81efe2e29e7_7c1ba14834b3422aadf11d4c515b7748 command)
		{
		}

		private void BakeCommandBinding__5078939a8a34eb84cbbfc81efe2e29e7_89a175cdf861429e908d248dda6369f9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5078939a8a34eb84cbbfc81efe2e29e7_89a175cdf861429e908d248dda6369f9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5078939a8a34eb84cbbfc81efe2e29e7_89a175cdf861429e908d248dda6369f9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5078939a8a34eb84cbbfc81efe2e29e7_89a175cdf861429e908d248dda6369f9(_5078939a8a34eb84cbbfc81efe2e29e7_89a175cdf861429e908d248dda6369f9 command)
		{
		}

		private void BakeCommandBinding__5078939a8a34eb84cbbfc81efe2e29e7_9e79884ee9c64dbe979bc6d21306f4bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5078939a8a34eb84cbbfc81efe2e29e7_9e79884ee9c64dbe979bc6d21306f4bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5078939a8a34eb84cbbfc81efe2e29e7_9e79884ee9c64dbe979bc6d21306f4bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5078939a8a34eb84cbbfc81efe2e29e7_9e79884ee9c64dbe979bc6d21306f4bc(_5078939a8a34eb84cbbfc81efe2e29e7_9e79884ee9c64dbe979bc6d21306f4bc command)
		{
		}

		private void BakeCommandBinding__5078939a8a34eb84cbbfc81efe2e29e7_9d136cd11c724c17befd4f13be98a3ed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5078939a8a34eb84cbbfc81efe2e29e7_9d136cd11c724c17befd4f13be98a3ed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5078939a8a34eb84cbbfc81efe2e29e7_9d136cd11c724c17befd4f13be98a3ed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5078939a8a34eb84cbbfc81efe2e29e7_9d136cd11c724c17befd4f13be98a3ed(_5078939a8a34eb84cbbfc81efe2e29e7_9d136cd11c724c17befd4f13be98a3ed command)
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
