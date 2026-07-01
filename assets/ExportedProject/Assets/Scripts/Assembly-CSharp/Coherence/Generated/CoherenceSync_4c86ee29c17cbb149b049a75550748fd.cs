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
	public class CoherenceSync_4c86ee29c17cbb149b049a75550748fd : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _4c86ee29c17cbb149b049a75550748fd_4c9647b107b34ebbbb75148f161d8dbe_CommandTarget;

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

		private void BakeCommandBinding__4c86ee29c17cbb149b049a75550748fd_4c9647b107b34ebbbb75148f161d8dbe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c86ee29c17cbb149b049a75550748fd_4c9647b107b34ebbbb75148f161d8dbe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c86ee29c17cbb149b049a75550748fd_4c9647b107b34ebbbb75148f161d8dbe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c86ee29c17cbb149b049a75550748fd_4c9647b107b34ebbbb75148f161d8dbe(_4c86ee29c17cbb149b049a75550748fd_4c9647b107b34ebbbb75148f161d8dbe command)
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
