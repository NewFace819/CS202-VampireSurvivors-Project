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
	public class CoherenceSync_47ae6df4fda0e37429de0bfba196b45c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _47ae6df4fda0e37429de0bfba196b45c_20a2be7daa2f41039c2f7fadf19c5009_CommandTarget;

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

		private void BakeCommandBinding__47ae6df4fda0e37429de0bfba196b45c_20a2be7daa2f41039c2f7fadf19c5009(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__47ae6df4fda0e37429de0bfba196b45c_20a2be7daa2f41039c2f7fadf19c5009(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__47ae6df4fda0e37429de0bfba196b45c_20a2be7daa2f41039c2f7fadf19c5009(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__47ae6df4fda0e37429de0bfba196b45c_20a2be7daa2f41039c2f7fadf19c5009(_47ae6df4fda0e37429de0bfba196b45c_20a2be7daa2f41039c2f7fadf19c5009 command)
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
