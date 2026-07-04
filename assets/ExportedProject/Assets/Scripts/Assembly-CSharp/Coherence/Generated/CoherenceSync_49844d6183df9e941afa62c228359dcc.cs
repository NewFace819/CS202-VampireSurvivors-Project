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
	public class CoherenceSync_49844d6183df9e941afa62c228359dcc : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _49844d6183df9e941afa62c228359dcc_b7eec73d23954df09e0207e74f91e15d_CommandTarget;

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

		private void BakeCommandBinding__49844d6183df9e941afa62c228359dcc_b7eec73d23954df09e0207e74f91e15d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__49844d6183df9e941afa62c228359dcc_b7eec73d23954df09e0207e74f91e15d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__49844d6183df9e941afa62c228359dcc_b7eec73d23954df09e0207e74f91e15d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__49844d6183df9e941afa62c228359dcc_b7eec73d23954df09e0207e74f91e15d(_49844d6183df9e941afa62c228359dcc_b7eec73d23954df09e0207e74f91e15d command)
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
