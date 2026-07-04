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
	public class CoherenceSync_681fb067cbba7f147916b4995c9b2aaa : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _681fb067cbba7f147916b4995c9b2aaa_3b89c96f509f4b9387aa8b6fffcffd05_CommandTarget;

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

		private void BakeCommandBinding__681fb067cbba7f147916b4995c9b2aaa_3b89c96f509f4b9387aa8b6fffcffd05(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__681fb067cbba7f147916b4995c9b2aaa_3b89c96f509f4b9387aa8b6fffcffd05(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__681fb067cbba7f147916b4995c9b2aaa_3b89c96f509f4b9387aa8b6fffcffd05(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__681fb067cbba7f147916b4995c9b2aaa_3b89c96f509f4b9387aa8b6fffcffd05(_681fb067cbba7f147916b4995c9b2aaa_3b89c96f509f4b9387aa8b6fffcffd05 command)
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
