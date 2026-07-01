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
	public class CoherenceSync_1ccf9b50cda6be6458909551c52517aa : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _1ccf9b50cda6be6458909551c52517aa_713f2a2817fe40ec9688cf07cfeff25e_CommandTarget;

		private Enemy_TP_GateBoss _1ccf9b50cda6be6458909551c52517aa_b18aeef3e95748f8824baff12e77b2b6_CommandTarget;

		private Enemy_TP_GateBoss _1ccf9b50cda6be6458909551c52517aa_3bee27fffce44273a700b74a827b5ce2_CommandTarget;

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

		private void BakeCommandBinding__1ccf9b50cda6be6458909551c52517aa_713f2a2817fe40ec9688cf07cfeff25e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ccf9b50cda6be6458909551c52517aa_713f2a2817fe40ec9688cf07cfeff25e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ccf9b50cda6be6458909551c52517aa_713f2a2817fe40ec9688cf07cfeff25e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ccf9b50cda6be6458909551c52517aa_713f2a2817fe40ec9688cf07cfeff25e(_1ccf9b50cda6be6458909551c52517aa_713f2a2817fe40ec9688cf07cfeff25e command)
		{
		}

		private void BakeCommandBinding__1ccf9b50cda6be6458909551c52517aa_b18aeef3e95748f8824baff12e77b2b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ccf9b50cda6be6458909551c52517aa_b18aeef3e95748f8824baff12e77b2b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ccf9b50cda6be6458909551c52517aa_b18aeef3e95748f8824baff12e77b2b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ccf9b50cda6be6458909551c52517aa_b18aeef3e95748f8824baff12e77b2b6(_1ccf9b50cda6be6458909551c52517aa_b18aeef3e95748f8824baff12e77b2b6 command)
		{
		}

		private void BakeCommandBinding__1ccf9b50cda6be6458909551c52517aa_3bee27fffce44273a700b74a827b5ce2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ccf9b50cda6be6458909551c52517aa_3bee27fffce44273a700b74a827b5ce2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ccf9b50cda6be6458909551c52517aa_3bee27fffce44273a700b74a827b5ce2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ccf9b50cda6be6458909551c52517aa_3bee27fffce44273a700b74a827b5ce2(_1ccf9b50cda6be6458909551c52517aa_3bee27fffce44273a700b74a827b5ce2 command)
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
