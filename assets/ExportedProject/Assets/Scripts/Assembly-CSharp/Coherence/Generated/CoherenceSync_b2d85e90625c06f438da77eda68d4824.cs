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
	public class CoherenceSync_b2d85e90625c06f438da77eda68d4824 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _b2d85e90625c06f438da77eda68d4824_4e886148e69b463485d2ce405674458e_CommandTarget;

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

		private void BakeCommandBinding__b2d85e90625c06f438da77eda68d4824_4e886148e69b463485d2ce405674458e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b2d85e90625c06f438da77eda68d4824_4e886148e69b463485d2ce405674458e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b2d85e90625c06f438da77eda68d4824_4e886148e69b463485d2ce405674458e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b2d85e90625c06f438da77eda68d4824_4e886148e69b463485d2ce405674458e(_b2d85e90625c06f438da77eda68d4824_4e886148e69b463485d2ce405674458e command)
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
