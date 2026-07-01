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
using VampireSurvivors.Objects.Stages;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_fa1018d12a6c87e48a6fecb56fb40cd8 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private DraculaCutscene _fa1018d12a6c87e48a6fecb56fb40cd8_300190d8d8404538807a0f306c5f8196_CommandTarget;

		private DraculaCutscene _fa1018d12a6c87e48a6fecb56fb40cd8_d2dea74fb0e34b60a927fb74c351a82d_CommandTarget;

		private PlatformZoneMovement _fa1018d12a6c87e48a6fecb56fb40cd8_879582440d624b1d9dc4b6de7cb698e3_CommandTarget;

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

		private void BakeCommandBinding__fa1018d12a6c87e48a6fecb56fb40cd8_300190d8d8404538807a0f306c5f8196(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fa1018d12a6c87e48a6fecb56fb40cd8_300190d8d8404538807a0f306c5f8196(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fa1018d12a6c87e48a6fecb56fb40cd8_300190d8d8404538807a0f306c5f8196(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fa1018d12a6c87e48a6fecb56fb40cd8_300190d8d8404538807a0f306c5f8196(_fa1018d12a6c87e48a6fecb56fb40cd8_300190d8d8404538807a0f306c5f8196 command)
		{
		}

		private void BakeCommandBinding__fa1018d12a6c87e48a6fecb56fb40cd8_d2dea74fb0e34b60a927fb74c351a82d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fa1018d12a6c87e48a6fecb56fb40cd8_d2dea74fb0e34b60a927fb74c351a82d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fa1018d12a6c87e48a6fecb56fb40cd8_d2dea74fb0e34b60a927fb74c351a82d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fa1018d12a6c87e48a6fecb56fb40cd8_d2dea74fb0e34b60a927fb74c351a82d(_fa1018d12a6c87e48a6fecb56fb40cd8_d2dea74fb0e34b60a927fb74c351a82d command)
		{
		}

		private void BakeCommandBinding__fa1018d12a6c87e48a6fecb56fb40cd8_879582440d624b1d9dc4b6de7cb698e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fa1018d12a6c87e48a6fecb56fb40cd8_879582440d624b1d9dc4b6de7cb698e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fa1018d12a6c87e48a6fecb56fb40cd8_879582440d624b1d9dc4b6de7cb698e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fa1018d12a6c87e48a6fecb56fb40cd8_879582440d624b1d9dc4b6de7cb698e3(_fa1018d12a6c87e48a6fecb56fb40cd8_879582440d624b1d9dc4b6de7cb698e3 command)
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
