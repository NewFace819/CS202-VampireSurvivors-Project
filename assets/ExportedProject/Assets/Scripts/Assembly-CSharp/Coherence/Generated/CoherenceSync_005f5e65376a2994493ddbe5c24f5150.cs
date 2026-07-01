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
	public class CoherenceSync_005f5e65376a2994493ddbe5c24f5150 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _005f5e65376a2994493ddbe5c24f5150_8ce674dca0ac4563a25e9ef7657b8337_CommandTarget;

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

		private void BakeCommandBinding__005f5e65376a2994493ddbe5c24f5150_8ce674dca0ac4563a25e9ef7657b8337(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__005f5e65376a2994493ddbe5c24f5150_8ce674dca0ac4563a25e9ef7657b8337(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__005f5e65376a2994493ddbe5c24f5150_8ce674dca0ac4563a25e9ef7657b8337(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__005f5e65376a2994493ddbe5c24f5150_8ce674dca0ac4563a25e9ef7657b8337(_005f5e65376a2994493ddbe5c24f5150_8ce674dca0ac4563a25e9ef7657b8337 command)
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
