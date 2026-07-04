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
	public class CoherenceSync_b85e1821d5c51c64bae206b6a8b601c1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _b85e1821d5c51c64bae206b6a8b601c1_aa81906bc76e47cbb837ac325fbb0c38_CommandTarget;

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

		private void BakeCommandBinding__b85e1821d5c51c64bae206b6a8b601c1_aa81906bc76e47cbb837ac325fbb0c38(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b85e1821d5c51c64bae206b6a8b601c1_aa81906bc76e47cbb837ac325fbb0c38(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b85e1821d5c51c64bae206b6a8b601c1_aa81906bc76e47cbb837ac325fbb0c38(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b85e1821d5c51c64bae206b6a8b601c1_aa81906bc76e47cbb837ac325fbb0c38(_b85e1821d5c51c64bae206b6a8b601c1_aa81906bc76e47cbb837ac325fbb0c38 command)
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
