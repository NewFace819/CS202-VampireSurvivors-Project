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
	public class CoherenceSync_e42f8c8f410e5894d8aeae0740cfeae4 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _e42f8c8f410e5894d8aeae0740cfeae4_f218c82760f041a0a86116378babf469_CommandTarget;

		private Enemy_TP_GateBoss _e42f8c8f410e5894d8aeae0740cfeae4_0474dcf7f88e49c2958a31ebf512a968_CommandTarget;

		private Enemy_TP_GateBoss _e42f8c8f410e5894d8aeae0740cfeae4_1da6105220a8436598442ed9f682b215_CommandTarget;

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

		private void BakeCommandBinding__e42f8c8f410e5894d8aeae0740cfeae4_f218c82760f041a0a86116378babf469(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e42f8c8f410e5894d8aeae0740cfeae4_f218c82760f041a0a86116378babf469(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e42f8c8f410e5894d8aeae0740cfeae4_f218c82760f041a0a86116378babf469(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e42f8c8f410e5894d8aeae0740cfeae4_f218c82760f041a0a86116378babf469(_e42f8c8f410e5894d8aeae0740cfeae4_f218c82760f041a0a86116378babf469 command)
		{
		}

		private void BakeCommandBinding__e42f8c8f410e5894d8aeae0740cfeae4_0474dcf7f88e49c2958a31ebf512a968(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e42f8c8f410e5894d8aeae0740cfeae4_0474dcf7f88e49c2958a31ebf512a968(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e42f8c8f410e5894d8aeae0740cfeae4_0474dcf7f88e49c2958a31ebf512a968(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e42f8c8f410e5894d8aeae0740cfeae4_0474dcf7f88e49c2958a31ebf512a968(_e42f8c8f410e5894d8aeae0740cfeae4_0474dcf7f88e49c2958a31ebf512a968 command)
		{
		}

		private void BakeCommandBinding__e42f8c8f410e5894d8aeae0740cfeae4_1da6105220a8436598442ed9f682b215(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e42f8c8f410e5894d8aeae0740cfeae4_1da6105220a8436598442ed9f682b215(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e42f8c8f410e5894d8aeae0740cfeae4_1da6105220a8436598442ed9f682b215(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e42f8c8f410e5894d8aeae0740cfeae4_1da6105220a8436598442ed9f682b215(_e42f8c8f410e5894d8aeae0740cfeae4_1da6105220a8436598442ed9f682b215 command)
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
