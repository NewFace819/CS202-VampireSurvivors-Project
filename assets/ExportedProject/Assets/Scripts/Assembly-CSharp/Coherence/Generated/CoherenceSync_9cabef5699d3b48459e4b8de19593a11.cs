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
	public class CoherenceSync_9cabef5699d3b48459e4b8de19593a11 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _9cabef5699d3b48459e4b8de19593a11_c5a6f04dfc5a44e0bd7baa01688f9bda_CommandTarget;

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

		private void BakeCommandBinding__9cabef5699d3b48459e4b8de19593a11_c5a6f04dfc5a44e0bd7baa01688f9bda(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9cabef5699d3b48459e4b8de19593a11_c5a6f04dfc5a44e0bd7baa01688f9bda(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9cabef5699d3b48459e4b8de19593a11_c5a6f04dfc5a44e0bd7baa01688f9bda(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9cabef5699d3b48459e4b8de19593a11_c5a6f04dfc5a44e0bd7baa01688f9bda(_9cabef5699d3b48459e4b8de19593a11_c5a6f04dfc5a44e0bd7baa01688f9bda command)
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
