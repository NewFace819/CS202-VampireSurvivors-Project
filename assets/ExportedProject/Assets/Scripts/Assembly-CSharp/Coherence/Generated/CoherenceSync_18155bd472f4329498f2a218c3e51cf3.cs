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
	public class CoherenceSync_18155bd472f4329498f2a218c3e51cf3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _18155bd472f4329498f2a218c3e51cf3_194bd269ee0049cdb8efe7c348df7f6a_CommandTarget;

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

		private void BakeCommandBinding__18155bd472f4329498f2a218c3e51cf3_194bd269ee0049cdb8efe7c348df7f6a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__18155bd472f4329498f2a218c3e51cf3_194bd269ee0049cdb8efe7c348df7f6a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__18155bd472f4329498f2a218c3e51cf3_194bd269ee0049cdb8efe7c348df7f6a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__18155bd472f4329498f2a218c3e51cf3_194bd269ee0049cdb8efe7c348df7f6a(_18155bd472f4329498f2a218c3e51cf3_194bd269ee0049cdb8efe7c348df7f6a command)
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
