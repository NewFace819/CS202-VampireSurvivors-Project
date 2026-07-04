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
	public class CoherenceSync_4201c659f38294943adf4fd75ad8fff8 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _4201c659f38294943adf4fd75ad8fff8_a06c834700c640a0891bd1e81ce3ce27_CommandTarget;

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

		private void BakeCommandBinding__4201c659f38294943adf4fd75ad8fff8_a06c834700c640a0891bd1e81ce3ce27(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4201c659f38294943adf4fd75ad8fff8_a06c834700c640a0891bd1e81ce3ce27(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4201c659f38294943adf4fd75ad8fff8_a06c834700c640a0891bd1e81ce3ce27(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4201c659f38294943adf4fd75ad8fff8_a06c834700c640a0891bd1e81ce3ce27(_4201c659f38294943adf4fd75ad8fff8_a06c834700c640a0891bd1e81ce3ce27 command)
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
