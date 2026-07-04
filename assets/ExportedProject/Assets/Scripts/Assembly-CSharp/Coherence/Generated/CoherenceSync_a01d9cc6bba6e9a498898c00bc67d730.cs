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
	public class CoherenceSync_a01d9cc6bba6e9a498898c00bc67d730 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _a01d9cc6bba6e9a498898c00bc67d730_7d2717eb61a24d5880ae140e83e7047d_CommandTarget;

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

		private void BakeCommandBinding__a01d9cc6bba6e9a498898c00bc67d730_7d2717eb61a24d5880ae140e83e7047d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a01d9cc6bba6e9a498898c00bc67d730_7d2717eb61a24d5880ae140e83e7047d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a01d9cc6bba6e9a498898c00bc67d730_7d2717eb61a24d5880ae140e83e7047d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a01d9cc6bba6e9a498898c00bc67d730_7d2717eb61a24d5880ae140e83e7047d(_a01d9cc6bba6e9a498898c00bc67d730_7d2717eb61a24d5880ae140e83e7047d command)
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
