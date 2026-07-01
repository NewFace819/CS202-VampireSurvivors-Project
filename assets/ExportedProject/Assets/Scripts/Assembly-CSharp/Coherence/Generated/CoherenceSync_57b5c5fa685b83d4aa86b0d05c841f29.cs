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
using VampireSurvivors.Objects.Characters.Enemies;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_57b5c5fa685b83d4aa86b0d05c841f29 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _57b5c5fa685b83d4aa86b0d05c841f29_d0f7895ecd1e42fabfc9128a5241476a_CommandTarget;

		private Enemy_TP_GateBoss _57b5c5fa685b83d4aa86b0d05c841f29_be0160ac93e04681b0ec6fca4186c3f1_CommandTarget;

		private Enemy_TP_GateBoss _57b5c5fa685b83d4aa86b0d05c841f29_de507ee6475b405d9bc823028cd13d28_CommandTarget;

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

		private void BakeCommandBinding__57b5c5fa685b83d4aa86b0d05c841f29_d0f7895ecd1e42fabfc9128a5241476a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__57b5c5fa685b83d4aa86b0d05c841f29_d0f7895ecd1e42fabfc9128a5241476a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__57b5c5fa685b83d4aa86b0d05c841f29_d0f7895ecd1e42fabfc9128a5241476a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__57b5c5fa685b83d4aa86b0d05c841f29_d0f7895ecd1e42fabfc9128a5241476a(_57b5c5fa685b83d4aa86b0d05c841f29_d0f7895ecd1e42fabfc9128a5241476a command)
		{
		}

		private void BakeCommandBinding__57b5c5fa685b83d4aa86b0d05c841f29_be0160ac93e04681b0ec6fca4186c3f1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__57b5c5fa685b83d4aa86b0d05c841f29_be0160ac93e04681b0ec6fca4186c3f1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__57b5c5fa685b83d4aa86b0d05c841f29_be0160ac93e04681b0ec6fca4186c3f1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__57b5c5fa685b83d4aa86b0d05c841f29_be0160ac93e04681b0ec6fca4186c3f1(_57b5c5fa685b83d4aa86b0d05c841f29_be0160ac93e04681b0ec6fca4186c3f1 command)
		{
		}

		private void BakeCommandBinding__57b5c5fa685b83d4aa86b0d05c841f29_de507ee6475b405d9bc823028cd13d28(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__57b5c5fa685b83d4aa86b0d05c841f29_de507ee6475b405d9bc823028cd13d28(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__57b5c5fa685b83d4aa86b0d05c841f29_de507ee6475b405d9bc823028cd13d28(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__57b5c5fa685b83d4aa86b0d05c841f29_de507ee6475b405d9bc823028cd13d28(_57b5c5fa685b83d4aa86b0d05c841f29_de507ee6475b405d9bc823028cd13d28 command)
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
