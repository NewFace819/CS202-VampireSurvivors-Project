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
	public class CoherenceSync_ed0fabe719e53c6418985e6f56978572 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _ed0fabe719e53c6418985e6f56978572_39b7a32b6f72409bba6ad6a8a35e7d41_CommandTarget;

		private Enemy_TP_GateBoss _ed0fabe719e53c6418985e6f56978572_0dbedc2223cb43a7b45ccb3063ca87ae_CommandTarget;

		private Enemy_TP_GateBoss _ed0fabe719e53c6418985e6f56978572_ecb570c594604c97ae2b9acaf97fe493_CommandTarget;

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

		private void BakeCommandBinding__ed0fabe719e53c6418985e6f56978572_39b7a32b6f72409bba6ad6a8a35e7d41(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ed0fabe719e53c6418985e6f56978572_39b7a32b6f72409bba6ad6a8a35e7d41(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ed0fabe719e53c6418985e6f56978572_39b7a32b6f72409bba6ad6a8a35e7d41(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ed0fabe719e53c6418985e6f56978572_39b7a32b6f72409bba6ad6a8a35e7d41(_ed0fabe719e53c6418985e6f56978572_39b7a32b6f72409bba6ad6a8a35e7d41 command)
		{
		}

		private void BakeCommandBinding__ed0fabe719e53c6418985e6f56978572_0dbedc2223cb43a7b45ccb3063ca87ae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ed0fabe719e53c6418985e6f56978572_0dbedc2223cb43a7b45ccb3063ca87ae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ed0fabe719e53c6418985e6f56978572_0dbedc2223cb43a7b45ccb3063ca87ae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ed0fabe719e53c6418985e6f56978572_0dbedc2223cb43a7b45ccb3063ca87ae(_ed0fabe719e53c6418985e6f56978572_0dbedc2223cb43a7b45ccb3063ca87ae command)
		{
		}

		private void BakeCommandBinding__ed0fabe719e53c6418985e6f56978572_ecb570c594604c97ae2b9acaf97fe493(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ed0fabe719e53c6418985e6f56978572_ecb570c594604c97ae2b9acaf97fe493(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ed0fabe719e53c6418985e6f56978572_ecb570c594604c97ae2b9acaf97fe493(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ed0fabe719e53c6418985e6f56978572_ecb570c594604c97ae2b9acaf97fe493(_ed0fabe719e53c6418985e6f56978572_ecb570c594604c97ae2b9acaf97fe493 command)
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
