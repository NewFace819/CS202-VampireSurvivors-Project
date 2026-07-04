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
	public class CoherenceSync_179b6ea99704ced4280199f92a1d8de6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _179b6ea99704ced4280199f92a1d8de6_aa322efd75b040e0a117d9f893f3ebf3_CommandTarget;

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

		private void BakeCommandBinding__179b6ea99704ced4280199f92a1d8de6_aa322efd75b040e0a117d9f893f3ebf3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__179b6ea99704ced4280199f92a1d8de6_aa322efd75b040e0a117d9f893f3ebf3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__179b6ea99704ced4280199f92a1d8de6_aa322efd75b040e0a117d9f893f3ebf3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__179b6ea99704ced4280199f92a1d8de6_aa322efd75b040e0a117d9f893f3ebf3(_179b6ea99704ced4280199f92a1d8de6_aa322efd75b040e0a117d9f893f3ebf3 command)
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
