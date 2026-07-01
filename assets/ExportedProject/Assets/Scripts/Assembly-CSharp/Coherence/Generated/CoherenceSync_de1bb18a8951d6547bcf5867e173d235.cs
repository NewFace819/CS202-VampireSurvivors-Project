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
	public class CoherenceSync_de1bb18a8951d6547bcf5867e173d235 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _de1bb18a8951d6547bcf5867e173d235_dddee61c51ec4e9f9e888ace7b45d0eb_CommandTarget;

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

		private void BakeCommandBinding__de1bb18a8951d6547bcf5867e173d235_dddee61c51ec4e9f9e888ace7b45d0eb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de1bb18a8951d6547bcf5867e173d235_dddee61c51ec4e9f9e888ace7b45d0eb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de1bb18a8951d6547bcf5867e173d235_dddee61c51ec4e9f9e888ace7b45d0eb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de1bb18a8951d6547bcf5867e173d235_dddee61c51ec4e9f9e888ace7b45d0eb(_de1bb18a8951d6547bcf5867e173d235_dddee61c51ec4e9f9e888ace7b45d0eb command)
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
