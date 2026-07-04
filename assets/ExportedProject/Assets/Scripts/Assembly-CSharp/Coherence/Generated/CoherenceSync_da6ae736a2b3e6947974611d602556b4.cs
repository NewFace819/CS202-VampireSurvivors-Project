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
	public class CoherenceSync_da6ae736a2b3e6947974611d602556b4 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _da6ae736a2b3e6947974611d602556b4_5d3f3fb486264fffa5cfb6055abd7561_CommandTarget;

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

		private void BakeCommandBinding__da6ae736a2b3e6947974611d602556b4_5d3f3fb486264fffa5cfb6055abd7561(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__da6ae736a2b3e6947974611d602556b4_5d3f3fb486264fffa5cfb6055abd7561(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__da6ae736a2b3e6947974611d602556b4_5d3f3fb486264fffa5cfb6055abd7561(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__da6ae736a2b3e6947974611d602556b4_5d3f3fb486264fffa5cfb6055abd7561(_da6ae736a2b3e6947974611d602556b4_5d3f3fb486264fffa5cfb6055abd7561 command)
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
