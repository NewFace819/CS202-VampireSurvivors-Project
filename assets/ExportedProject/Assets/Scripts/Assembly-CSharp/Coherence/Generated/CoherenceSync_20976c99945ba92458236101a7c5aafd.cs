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
	public class CoherenceSync_20976c99945ba92458236101a7c5aafd : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _20976c99945ba92458236101a7c5aafd_a4431b9820d04c1db7c2e0ffc5d09d14_CommandTarget;

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

		private void BakeCommandBinding__20976c99945ba92458236101a7c5aafd_a4431b9820d04c1db7c2e0ffc5d09d14(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20976c99945ba92458236101a7c5aafd_a4431b9820d04c1db7c2e0ffc5d09d14(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20976c99945ba92458236101a7c5aafd_a4431b9820d04c1db7c2e0ffc5d09d14(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20976c99945ba92458236101a7c5aafd_a4431b9820d04c1db7c2e0ffc5d09d14(_20976c99945ba92458236101a7c5aafd_a4431b9820d04c1db7c2e0ffc5d09d14 command)
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
