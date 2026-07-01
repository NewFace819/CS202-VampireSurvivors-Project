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
	public class CoherenceSync_1eda5790cee550643b72d0074b518cca : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _1eda5790cee550643b72d0074b518cca_d99ea841ca424bcf819306cb530e6a72_CommandTarget;

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

		private void BakeCommandBinding__1eda5790cee550643b72d0074b518cca_d99ea841ca424bcf819306cb530e6a72(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1eda5790cee550643b72d0074b518cca_d99ea841ca424bcf819306cb530e6a72(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1eda5790cee550643b72d0074b518cca_d99ea841ca424bcf819306cb530e6a72(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1eda5790cee550643b72d0074b518cca_d99ea841ca424bcf819306cb530e6a72(_1eda5790cee550643b72d0074b518cca_d99ea841ca424bcf819306cb530e6a72 command)
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
