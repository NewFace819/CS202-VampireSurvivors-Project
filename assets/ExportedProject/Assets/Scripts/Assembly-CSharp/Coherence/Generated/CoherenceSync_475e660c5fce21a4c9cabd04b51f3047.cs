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
	public class CoherenceSync_475e660c5fce21a4c9cabd04b51f3047 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _475e660c5fce21a4c9cabd04b51f3047_0f26b328ff684c4ebdbce60552dcd7d9_CommandTarget;

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

		private void BakeCommandBinding__475e660c5fce21a4c9cabd04b51f3047_0f26b328ff684c4ebdbce60552dcd7d9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__475e660c5fce21a4c9cabd04b51f3047_0f26b328ff684c4ebdbce60552dcd7d9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__475e660c5fce21a4c9cabd04b51f3047_0f26b328ff684c4ebdbce60552dcd7d9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__475e660c5fce21a4c9cabd04b51f3047_0f26b328ff684c4ebdbce60552dcd7d9(_475e660c5fce21a4c9cabd04b51f3047_0f26b328ff684c4ebdbce60552dcd7d9 command)
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
