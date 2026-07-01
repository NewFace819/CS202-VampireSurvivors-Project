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
	public class CoherenceSync_4a7ccbbb54abd9e4d8ef2f18fc2d555e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _4a7ccbbb54abd9e4d8ef2f18fc2d555e_105e0ab7dff44b2ab00a9aedc0f4572b_CommandTarget;

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

		private void BakeCommandBinding__4a7ccbbb54abd9e4d8ef2f18fc2d555e_105e0ab7dff44b2ab00a9aedc0f4572b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4a7ccbbb54abd9e4d8ef2f18fc2d555e_105e0ab7dff44b2ab00a9aedc0f4572b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4a7ccbbb54abd9e4d8ef2f18fc2d555e_105e0ab7dff44b2ab00a9aedc0f4572b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4a7ccbbb54abd9e4d8ef2f18fc2d555e_105e0ab7dff44b2ab00a9aedc0f4572b(_4a7ccbbb54abd9e4d8ef2f18fc2d555e_105e0ab7dff44b2ab00a9aedc0f4572b command)
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
