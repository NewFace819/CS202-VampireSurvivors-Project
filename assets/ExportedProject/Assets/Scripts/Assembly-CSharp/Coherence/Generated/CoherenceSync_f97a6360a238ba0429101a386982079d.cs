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
	public class CoherenceSync_f97a6360a238ba0429101a386982079d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _f97a6360a238ba0429101a386982079d_9945880286244f138b20f45192c2dc39_CommandTarget;

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

		private void BakeCommandBinding__f97a6360a238ba0429101a386982079d_9945880286244f138b20f45192c2dc39(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f97a6360a238ba0429101a386982079d_9945880286244f138b20f45192c2dc39(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f97a6360a238ba0429101a386982079d_9945880286244f138b20f45192c2dc39(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f97a6360a238ba0429101a386982079d_9945880286244f138b20f45192c2dc39(_f97a6360a238ba0429101a386982079d_9945880286244f138b20f45192c2dc39 command)
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
