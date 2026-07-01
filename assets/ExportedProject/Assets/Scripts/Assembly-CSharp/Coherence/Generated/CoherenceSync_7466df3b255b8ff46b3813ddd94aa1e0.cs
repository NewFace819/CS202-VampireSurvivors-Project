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
	public class CoherenceSync_7466df3b255b8ff46b3813ddd94aa1e0 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _7466df3b255b8ff46b3813ddd94aa1e0_40759bac49dc43c68938fa860865253b_CommandTarget;

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

		private void BakeCommandBinding__7466df3b255b8ff46b3813ddd94aa1e0_40759bac49dc43c68938fa860865253b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7466df3b255b8ff46b3813ddd94aa1e0_40759bac49dc43c68938fa860865253b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7466df3b255b8ff46b3813ddd94aa1e0_40759bac49dc43c68938fa860865253b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7466df3b255b8ff46b3813ddd94aa1e0_40759bac49dc43c68938fa860865253b(_7466df3b255b8ff46b3813ddd94aa1e0_40759bac49dc43c68938fa860865253b command)
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
