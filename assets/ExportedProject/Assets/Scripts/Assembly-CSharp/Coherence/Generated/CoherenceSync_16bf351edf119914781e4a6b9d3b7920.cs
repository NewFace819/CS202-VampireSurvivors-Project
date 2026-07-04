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
	public class CoherenceSync_16bf351edf119914781e4a6b9d3b7920 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _16bf351edf119914781e4a6b9d3b7920_db4d14448fcd42cebd2bb64b316e1112_CommandTarget;

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

		private void BakeCommandBinding__16bf351edf119914781e4a6b9d3b7920_db4d14448fcd42cebd2bb64b316e1112(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__16bf351edf119914781e4a6b9d3b7920_db4d14448fcd42cebd2bb64b316e1112(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__16bf351edf119914781e4a6b9d3b7920_db4d14448fcd42cebd2bb64b316e1112(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__16bf351edf119914781e4a6b9d3b7920_db4d14448fcd42cebd2bb64b316e1112(_16bf351edf119914781e4a6b9d3b7920_db4d14448fcd42cebd2bb64b316e1112 command)
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
