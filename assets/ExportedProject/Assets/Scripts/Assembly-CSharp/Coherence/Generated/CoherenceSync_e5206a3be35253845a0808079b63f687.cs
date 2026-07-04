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
	public class CoherenceSync_e5206a3be35253845a0808079b63f687 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _e5206a3be35253845a0808079b63f687_dd33091a2b64458e857cce91c752669f_CommandTarget;

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

		private void BakeCommandBinding__e5206a3be35253845a0808079b63f687_dd33091a2b64458e857cce91c752669f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e5206a3be35253845a0808079b63f687_dd33091a2b64458e857cce91c752669f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e5206a3be35253845a0808079b63f687_dd33091a2b64458e857cce91c752669f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e5206a3be35253845a0808079b63f687_dd33091a2b64458e857cce91c752669f(_e5206a3be35253845a0808079b63f687_dd33091a2b64458e857cce91c752669f command)
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
