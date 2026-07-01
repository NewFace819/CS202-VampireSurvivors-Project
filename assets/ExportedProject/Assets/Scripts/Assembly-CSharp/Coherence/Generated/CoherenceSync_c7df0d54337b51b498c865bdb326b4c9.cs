using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_c7df0d54337b51b498c865bdb326b4c9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Destructible _c7df0d54337b51b498c865bdb326b4c9_8899dccfef9a4314a7b57c0f9bca6ea6_CommandTarget;

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

		private void BakeCommandBinding__c7df0d54337b51b498c865bdb326b4c9_8899dccfef9a4314a7b57c0f9bca6ea6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7df0d54337b51b498c865bdb326b4c9_8899dccfef9a4314a7b57c0f9bca6ea6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7df0d54337b51b498c865bdb326b4c9_8899dccfef9a4314a7b57c0f9bca6ea6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7df0d54337b51b498c865bdb326b4c9_8899dccfef9a4314a7b57c0f9bca6ea6(_c7df0d54337b51b498c865bdb326b4c9_8899dccfef9a4314a7b57c0f9bca6ea6 command)
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
