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
	public class CoherenceSync_4a799019cd97c1c40b88d42581de95fc : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _4a799019cd97c1c40b88d42581de95fc_b701d1d3d0f5419ab873ef6a635aec32_CommandTarget;

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

		private void BakeCommandBinding__4a799019cd97c1c40b88d42581de95fc_b701d1d3d0f5419ab873ef6a635aec32(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4a799019cd97c1c40b88d42581de95fc_b701d1d3d0f5419ab873ef6a635aec32(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4a799019cd97c1c40b88d42581de95fc_b701d1d3d0f5419ab873ef6a635aec32(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4a799019cd97c1c40b88d42581de95fc_b701d1d3d0f5419ab873ef6a635aec32(_4a799019cd97c1c40b88d42581de95fc_b701d1d3d0f5419ab873ef6a635aec32 command)
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
