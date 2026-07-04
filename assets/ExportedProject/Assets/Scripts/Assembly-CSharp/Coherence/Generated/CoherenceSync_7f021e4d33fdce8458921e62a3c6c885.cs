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
	public class CoherenceSync_7f021e4d33fdce8458921e62a3c6c885 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _7f021e4d33fdce8458921e62a3c6c885_89b1b3eab037492b85dbf3442d2d0879_CommandTarget;

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

		private void BakeCommandBinding__7f021e4d33fdce8458921e62a3c6c885_89b1b3eab037492b85dbf3442d2d0879(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7f021e4d33fdce8458921e62a3c6c885_89b1b3eab037492b85dbf3442d2d0879(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7f021e4d33fdce8458921e62a3c6c885_89b1b3eab037492b85dbf3442d2d0879(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7f021e4d33fdce8458921e62a3c6c885_89b1b3eab037492b85dbf3442d2d0879(_7f021e4d33fdce8458921e62a3c6c885_89b1b3eab037492b85dbf3442d2d0879 command)
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
