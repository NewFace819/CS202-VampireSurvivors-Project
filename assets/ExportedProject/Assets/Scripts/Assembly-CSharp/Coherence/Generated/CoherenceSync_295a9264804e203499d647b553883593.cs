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
	public class CoherenceSync_295a9264804e203499d647b553883593 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _295a9264804e203499d647b553883593_ede16cb516864a0a9aea0abdc6f61522_CommandTarget;

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

		private void BakeCommandBinding__295a9264804e203499d647b553883593_ede16cb516864a0a9aea0abdc6f61522(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__295a9264804e203499d647b553883593_ede16cb516864a0a9aea0abdc6f61522(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__295a9264804e203499d647b553883593_ede16cb516864a0a9aea0abdc6f61522(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__295a9264804e203499d647b553883593_ede16cb516864a0a9aea0abdc6f61522(_295a9264804e203499d647b553883593_ede16cb516864a0a9aea0abdc6f61522 command)
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
