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
	public class CoherenceSync_53a0a29141061454b98564e0ed7c60d1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _53a0a29141061454b98564e0ed7c60d1_0ce41a2f5d9e4006a89c27c97fe248a2_CommandTarget;

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

		private void BakeCommandBinding__53a0a29141061454b98564e0ed7c60d1_0ce41a2f5d9e4006a89c27c97fe248a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__53a0a29141061454b98564e0ed7c60d1_0ce41a2f5d9e4006a89c27c97fe248a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__53a0a29141061454b98564e0ed7c60d1_0ce41a2f5d9e4006a89c27c97fe248a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__53a0a29141061454b98564e0ed7c60d1_0ce41a2f5d9e4006a89c27c97fe248a2(_53a0a29141061454b98564e0ed7c60d1_0ce41a2f5d9e4006a89c27c97fe248a2 command)
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
