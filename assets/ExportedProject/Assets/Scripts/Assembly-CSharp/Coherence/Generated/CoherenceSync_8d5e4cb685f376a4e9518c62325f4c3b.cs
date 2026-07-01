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
	public class CoherenceSync_8d5e4cb685f376a4e9518c62325f4c3b : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _8d5e4cb685f376a4e9518c62325f4c3b_b9c1510a79ac4e2e87efb081e033ef80_CommandTarget;

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

		private void BakeCommandBinding__8d5e4cb685f376a4e9518c62325f4c3b_b9c1510a79ac4e2e87efb081e033ef80(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8d5e4cb685f376a4e9518c62325f4c3b_b9c1510a79ac4e2e87efb081e033ef80(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8d5e4cb685f376a4e9518c62325f4c3b_b9c1510a79ac4e2e87efb081e033ef80(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8d5e4cb685f376a4e9518c62325f4c3b_b9c1510a79ac4e2e87efb081e033ef80(_8d5e4cb685f376a4e9518c62325f4c3b_b9c1510a79ac4e2e87efb081e033ef80 command)
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
