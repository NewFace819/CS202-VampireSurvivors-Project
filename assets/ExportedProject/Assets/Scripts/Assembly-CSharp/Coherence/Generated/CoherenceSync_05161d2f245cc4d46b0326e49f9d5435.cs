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
	public class CoherenceSync_05161d2f245cc4d46b0326e49f9d5435 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _05161d2f245cc4d46b0326e49f9d5435_293b2dd26c9b47de98f27af10750dc4f_CommandTarget;

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

		private void BakeCommandBinding__05161d2f245cc4d46b0326e49f9d5435_293b2dd26c9b47de98f27af10750dc4f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__05161d2f245cc4d46b0326e49f9d5435_293b2dd26c9b47de98f27af10750dc4f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__05161d2f245cc4d46b0326e49f9d5435_293b2dd26c9b47de98f27af10750dc4f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__05161d2f245cc4d46b0326e49f9d5435_293b2dd26c9b47de98f27af10750dc4f(_05161d2f245cc4d46b0326e49f9d5435_293b2dd26c9b47de98f27af10750dc4f command)
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
