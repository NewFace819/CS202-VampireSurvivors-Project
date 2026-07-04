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
	public class CoherenceSync_04b804dae8c34c34db9c9b3aaabae938 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _04b804dae8c34c34db9c9b3aaabae938_ad5d86159f8e43caa6fc3e158aa373dc_CommandTarget;

		private Enemy_TP_GateBoss _04b804dae8c34c34db9c9b3aaabae938_828d00ca68a941bdad40af7d4cc535bb_CommandTarget;

		private Enemy_TP_GateBoss _04b804dae8c34c34db9c9b3aaabae938_fc0554d7c6ba4fec87f134d31364b79b_CommandTarget;

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

		private void BakeCommandBinding__04b804dae8c34c34db9c9b3aaabae938_ad5d86159f8e43caa6fc3e158aa373dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04b804dae8c34c34db9c9b3aaabae938_ad5d86159f8e43caa6fc3e158aa373dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04b804dae8c34c34db9c9b3aaabae938_ad5d86159f8e43caa6fc3e158aa373dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04b804dae8c34c34db9c9b3aaabae938_ad5d86159f8e43caa6fc3e158aa373dc(_04b804dae8c34c34db9c9b3aaabae938_ad5d86159f8e43caa6fc3e158aa373dc command)
		{
		}

		private void BakeCommandBinding__04b804dae8c34c34db9c9b3aaabae938_828d00ca68a941bdad40af7d4cc535bb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04b804dae8c34c34db9c9b3aaabae938_828d00ca68a941bdad40af7d4cc535bb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04b804dae8c34c34db9c9b3aaabae938_828d00ca68a941bdad40af7d4cc535bb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04b804dae8c34c34db9c9b3aaabae938_828d00ca68a941bdad40af7d4cc535bb(_04b804dae8c34c34db9c9b3aaabae938_828d00ca68a941bdad40af7d4cc535bb command)
		{
		}

		private void BakeCommandBinding__04b804dae8c34c34db9c9b3aaabae938_fc0554d7c6ba4fec87f134d31364b79b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04b804dae8c34c34db9c9b3aaabae938_fc0554d7c6ba4fec87f134d31364b79b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04b804dae8c34c34db9c9b3aaabae938_fc0554d7c6ba4fec87f134d31364b79b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04b804dae8c34c34db9c9b3aaabae938_fc0554d7c6ba4fec87f134d31364b79b(_04b804dae8c34c34db9c9b3aaabae938_fc0554d7c6ba4fec87f134d31364b79b command)
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
