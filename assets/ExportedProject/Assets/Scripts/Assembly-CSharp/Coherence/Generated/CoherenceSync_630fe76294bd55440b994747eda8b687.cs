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
	public class CoherenceSync_630fe76294bd55440b994747eda8b687 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _630fe76294bd55440b994747eda8b687_5f48a1cec5c64554a04bba0f1a8769d1_CommandTarget;

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

		private void BakeCommandBinding__630fe76294bd55440b994747eda8b687_5f48a1cec5c64554a04bba0f1a8769d1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__630fe76294bd55440b994747eda8b687_5f48a1cec5c64554a04bba0f1a8769d1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__630fe76294bd55440b994747eda8b687_5f48a1cec5c64554a04bba0f1a8769d1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__630fe76294bd55440b994747eda8b687_5f48a1cec5c64554a04bba0f1a8769d1(_630fe76294bd55440b994747eda8b687_5f48a1cec5c64554a04bba0f1a8769d1 command)
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
