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
	public class CoherenceSync_4f42f2e9b2e0946439001747825b8c25 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _4f42f2e9b2e0946439001747825b8c25_a2fd526333044738948cac4b84d83c78_CommandTarget;

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

		private void BakeCommandBinding__4f42f2e9b2e0946439001747825b8c25_a2fd526333044738948cac4b84d83c78(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f42f2e9b2e0946439001747825b8c25_a2fd526333044738948cac4b84d83c78(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f42f2e9b2e0946439001747825b8c25_a2fd526333044738948cac4b84d83c78(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f42f2e9b2e0946439001747825b8c25_a2fd526333044738948cac4b84d83c78(_4f42f2e9b2e0946439001747825b8c25_a2fd526333044738948cac4b84d83c78 command)
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
