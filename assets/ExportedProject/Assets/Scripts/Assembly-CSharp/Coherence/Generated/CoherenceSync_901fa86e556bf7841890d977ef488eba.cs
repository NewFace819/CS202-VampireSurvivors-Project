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
	public class CoherenceSync_901fa86e556bf7841890d977ef488eba : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _901fa86e556bf7841890d977ef488eba_e3f58fcd9a094b33a0f86dca20fca219_CommandTarget;

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

		private void BakeCommandBinding__901fa86e556bf7841890d977ef488eba_e3f58fcd9a094b33a0f86dca20fca219(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__901fa86e556bf7841890d977ef488eba_e3f58fcd9a094b33a0f86dca20fca219(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__901fa86e556bf7841890d977ef488eba_e3f58fcd9a094b33a0f86dca20fca219(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__901fa86e556bf7841890d977ef488eba_e3f58fcd9a094b33a0f86dca20fca219(_901fa86e556bf7841890d977ef488eba_e3f58fcd9a094b33a0f86dca20fca219 command)
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
