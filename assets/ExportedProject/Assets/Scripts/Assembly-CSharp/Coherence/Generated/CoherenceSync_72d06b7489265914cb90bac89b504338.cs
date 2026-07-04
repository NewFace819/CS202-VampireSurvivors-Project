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
	public class CoherenceSync_72d06b7489265914cb90bac89b504338 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _72d06b7489265914cb90bac89b504338_9896684da20843f9a3bcc5ed1c2a90c6_CommandTarget;

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

		private void BakeCommandBinding__72d06b7489265914cb90bac89b504338_9896684da20843f9a3bcc5ed1c2a90c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__72d06b7489265914cb90bac89b504338_9896684da20843f9a3bcc5ed1c2a90c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__72d06b7489265914cb90bac89b504338_9896684da20843f9a3bcc5ed1c2a90c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__72d06b7489265914cb90bac89b504338_9896684da20843f9a3bcc5ed1c2a90c6(_72d06b7489265914cb90bac89b504338_9896684da20843f9a3bcc5ed1c2a90c6 command)
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
