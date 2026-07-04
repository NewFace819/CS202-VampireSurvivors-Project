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
	public class CoherenceSync_86fed05d1d130f6418432c5115236ad3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _86fed05d1d130f6418432c5115236ad3_37816fce1ca342439f497660e016beb7_CommandTarget;

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

		private void BakeCommandBinding__86fed05d1d130f6418432c5115236ad3_37816fce1ca342439f497660e016beb7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__86fed05d1d130f6418432c5115236ad3_37816fce1ca342439f497660e016beb7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__86fed05d1d130f6418432c5115236ad3_37816fce1ca342439f497660e016beb7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__86fed05d1d130f6418432c5115236ad3_37816fce1ca342439f497660e016beb7(_86fed05d1d130f6418432c5115236ad3_37816fce1ca342439f497660e016beb7 command)
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
