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
	public class CoherenceSync_650fd14cc5732be4e9ed054245597183 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _650fd14cc5732be4e9ed054245597183_47cf6366933645faa5b687ed272c680a_CommandTarget;

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

		private void BakeCommandBinding__650fd14cc5732be4e9ed054245597183_47cf6366933645faa5b687ed272c680a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__650fd14cc5732be4e9ed054245597183_47cf6366933645faa5b687ed272c680a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__650fd14cc5732be4e9ed054245597183_47cf6366933645faa5b687ed272c680a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__650fd14cc5732be4e9ed054245597183_47cf6366933645faa5b687ed272c680a(_650fd14cc5732be4e9ed054245597183_47cf6366933645faa5b687ed272c680a command)
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
