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
	public class CoherenceSync_99d0edd9d18b4434ab5457ddca681615 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _99d0edd9d18b4434ab5457ddca681615_1fa6fa66c2da4c98b088542c2ef956a0_CommandTarget;

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

		private void BakeCommandBinding__99d0edd9d18b4434ab5457ddca681615_1fa6fa66c2da4c98b088542c2ef956a0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__99d0edd9d18b4434ab5457ddca681615_1fa6fa66c2da4c98b088542c2ef956a0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__99d0edd9d18b4434ab5457ddca681615_1fa6fa66c2da4c98b088542c2ef956a0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__99d0edd9d18b4434ab5457ddca681615_1fa6fa66c2da4c98b088542c2ef956a0(_99d0edd9d18b4434ab5457ddca681615_1fa6fa66c2da4c98b088542c2ef956a0 command)
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
