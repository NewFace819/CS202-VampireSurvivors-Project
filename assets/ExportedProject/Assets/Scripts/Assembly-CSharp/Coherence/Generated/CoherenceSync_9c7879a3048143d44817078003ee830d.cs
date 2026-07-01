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
	public class CoherenceSync_9c7879a3048143d44817078003ee830d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _9c7879a3048143d44817078003ee830d_201760a091464da0b81a2231855a008b_CommandTarget;

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

		private void BakeCommandBinding__9c7879a3048143d44817078003ee830d_201760a091464da0b81a2231855a008b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9c7879a3048143d44817078003ee830d_201760a091464da0b81a2231855a008b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9c7879a3048143d44817078003ee830d_201760a091464da0b81a2231855a008b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9c7879a3048143d44817078003ee830d_201760a091464da0b81a2231855a008b(_9c7879a3048143d44817078003ee830d_201760a091464da0b81a2231855a008b command)
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
