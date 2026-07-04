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
	public class CoherenceSync_288fba59c5ac81a4082f8a8ff001b3b2 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _288fba59c5ac81a4082f8a8ff001b3b2_53c421cde77f47e69cfa42863da44921_CommandTarget;

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

		private void BakeCommandBinding__288fba59c5ac81a4082f8a8ff001b3b2_53c421cde77f47e69cfa42863da44921(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__288fba59c5ac81a4082f8a8ff001b3b2_53c421cde77f47e69cfa42863da44921(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__288fba59c5ac81a4082f8a8ff001b3b2_53c421cde77f47e69cfa42863da44921(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__288fba59c5ac81a4082f8a8ff001b3b2_53c421cde77f47e69cfa42863da44921(_288fba59c5ac81a4082f8a8ff001b3b2_53c421cde77f47e69cfa42863da44921 command)
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
