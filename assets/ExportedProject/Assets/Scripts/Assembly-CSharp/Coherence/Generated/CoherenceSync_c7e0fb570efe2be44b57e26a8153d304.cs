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
	public class CoherenceSync_c7e0fb570efe2be44b57e26a8153d304 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _c7e0fb570efe2be44b57e26a8153d304_abfef8cbe065455abf123f9fd7b82359_CommandTarget;

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

		private void BakeCommandBinding__c7e0fb570efe2be44b57e26a8153d304_abfef8cbe065455abf123f9fd7b82359(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7e0fb570efe2be44b57e26a8153d304_abfef8cbe065455abf123f9fd7b82359(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7e0fb570efe2be44b57e26a8153d304_abfef8cbe065455abf123f9fd7b82359(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7e0fb570efe2be44b57e26a8153d304_abfef8cbe065455abf123f9fd7b82359(_c7e0fb570efe2be44b57e26a8153d304_abfef8cbe065455abf123f9fd7b82359 command)
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
