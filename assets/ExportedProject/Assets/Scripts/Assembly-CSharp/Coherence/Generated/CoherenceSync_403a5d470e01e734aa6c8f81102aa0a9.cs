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
	public class CoherenceSync_403a5d470e01e734aa6c8f81102aa0a9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _403a5d470e01e734aa6c8f81102aa0a9_f91106856a774a94b252a57fcf175634_CommandTarget;

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

		private void BakeCommandBinding__403a5d470e01e734aa6c8f81102aa0a9_f91106856a774a94b252a57fcf175634(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__403a5d470e01e734aa6c8f81102aa0a9_f91106856a774a94b252a57fcf175634(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__403a5d470e01e734aa6c8f81102aa0a9_f91106856a774a94b252a57fcf175634(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__403a5d470e01e734aa6c8f81102aa0a9_f91106856a774a94b252a57fcf175634(_403a5d470e01e734aa6c8f81102aa0a9_f91106856a774a94b252a57fcf175634 command)
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
