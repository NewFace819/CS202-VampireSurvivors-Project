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
	public class CoherenceSync_6c69a4bfa8374fb4480f3356af296730 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _6c69a4bfa8374fb4480f3356af296730_9002d37e967c453da54a436d548d15ad_CommandTarget;

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

		private void BakeCommandBinding__6c69a4bfa8374fb4480f3356af296730_9002d37e967c453da54a436d548d15ad(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c69a4bfa8374fb4480f3356af296730_9002d37e967c453da54a436d548d15ad(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c69a4bfa8374fb4480f3356af296730_9002d37e967c453da54a436d548d15ad(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c69a4bfa8374fb4480f3356af296730_9002d37e967c453da54a436d548d15ad(_6c69a4bfa8374fb4480f3356af296730_9002d37e967c453da54a436d548d15ad command)
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
