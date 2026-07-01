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
	public class CoherenceSync_7764e078a4b461f4f9a8b27880fcf7a1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Destructible _7764e078a4b461f4f9a8b27880fcf7a1_491339f7c3ba4f76baee2e63ca7a9d19_CommandTarget;

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

		private void BakeCommandBinding__7764e078a4b461f4f9a8b27880fcf7a1_491339f7c3ba4f76baee2e63ca7a9d19(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7764e078a4b461f4f9a8b27880fcf7a1_491339f7c3ba4f76baee2e63ca7a9d19(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7764e078a4b461f4f9a8b27880fcf7a1_491339f7c3ba4f76baee2e63ca7a9d19(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7764e078a4b461f4f9a8b27880fcf7a1_491339f7c3ba4f76baee2e63ca7a9d19(_7764e078a4b461f4f9a8b27880fcf7a1_491339f7c3ba4f76baee2e63ca7a9d19 command)
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
