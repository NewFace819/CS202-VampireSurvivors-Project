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
	public class CoherenceSync_474d43b64f754e242b41c82db0906434 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _474d43b64f754e242b41c82db0906434_9685f2564e4946f58b6c530e38e0ecad_CommandTarget;

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

		private void BakeCommandBinding__474d43b64f754e242b41c82db0906434_9685f2564e4946f58b6c530e38e0ecad(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__474d43b64f754e242b41c82db0906434_9685f2564e4946f58b6c530e38e0ecad(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__474d43b64f754e242b41c82db0906434_9685f2564e4946f58b6c530e38e0ecad(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__474d43b64f754e242b41c82db0906434_9685f2564e4946f58b6c530e38e0ecad(_474d43b64f754e242b41c82db0906434_9685f2564e4946f58b6c530e38e0ecad command)
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
