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
	public class CoherenceSync_a62718d837244d54080833528373ede9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _a62718d837244d54080833528373ede9_2080d0ac9b784d16a83bd51bc0e4c866_CommandTarget;

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

		private void BakeCommandBinding__a62718d837244d54080833528373ede9_2080d0ac9b784d16a83bd51bc0e4c866(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a62718d837244d54080833528373ede9_2080d0ac9b784d16a83bd51bc0e4c866(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a62718d837244d54080833528373ede9_2080d0ac9b784d16a83bd51bc0e4c866(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a62718d837244d54080833528373ede9_2080d0ac9b784d16a83bd51bc0e4c866(_a62718d837244d54080833528373ede9_2080d0ac9b784d16a83bd51bc0e4c866 command)
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
