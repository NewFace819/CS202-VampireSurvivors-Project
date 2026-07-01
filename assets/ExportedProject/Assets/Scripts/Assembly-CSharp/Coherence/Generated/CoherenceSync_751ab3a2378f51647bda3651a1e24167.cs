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
	public class CoherenceSync_751ab3a2378f51647bda3651a1e24167 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _751ab3a2378f51647bda3651a1e24167_13cbf7b7948346f39e84d1739dcf7b8e_CommandTarget;

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

		private void BakeCommandBinding__751ab3a2378f51647bda3651a1e24167_13cbf7b7948346f39e84d1739dcf7b8e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__751ab3a2378f51647bda3651a1e24167_13cbf7b7948346f39e84d1739dcf7b8e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__751ab3a2378f51647bda3651a1e24167_13cbf7b7948346f39e84d1739dcf7b8e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__751ab3a2378f51647bda3651a1e24167_13cbf7b7948346f39e84d1739dcf7b8e(_751ab3a2378f51647bda3651a1e24167_13cbf7b7948346f39e84d1739dcf7b8e command)
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
