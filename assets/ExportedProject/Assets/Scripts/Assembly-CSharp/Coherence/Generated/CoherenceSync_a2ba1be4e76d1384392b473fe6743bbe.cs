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
	public class CoherenceSync_a2ba1be4e76d1384392b473fe6743bbe : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _a2ba1be4e76d1384392b473fe6743bbe_09fbf8280af94ade8dd4bdc519f64d0b_CommandTarget;

		private TP_ADV_BOSS_PhantomBat _a2ba1be4e76d1384392b473fe6743bbe_8d2bdad93304437f9f5d95bad30b156b_CommandTarget;

		private TP_ADV_BOSS_PhantomBat _a2ba1be4e76d1384392b473fe6743bbe_f40d2a9368a54df0a7abab03865cf27b_CommandTarget;

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

		private void BakeCommandBinding__a2ba1be4e76d1384392b473fe6743bbe_09fbf8280af94ade8dd4bdc519f64d0b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2ba1be4e76d1384392b473fe6743bbe_09fbf8280af94ade8dd4bdc519f64d0b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2ba1be4e76d1384392b473fe6743bbe_09fbf8280af94ade8dd4bdc519f64d0b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2ba1be4e76d1384392b473fe6743bbe_09fbf8280af94ade8dd4bdc519f64d0b(_a2ba1be4e76d1384392b473fe6743bbe_09fbf8280af94ade8dd4bdc519f64d0b command)
		{
		}

		private void BakeCommandBinding__a2ba1be4e76d1384392b473fe6743bbe_8d2bdad93304437f9f5d95bad30b156b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2ba1be4e76d1384392b473fe6743bbe_8d2bdad93304437f9f5d95bad30b156b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2ba1be4e76d1384392b473fe6743bbe_8d2bdad93304437f9f5d95bad30b156b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2ba1be4e76d1384392b473fe6743bbe_8d2bdad93304437f9f5d95bad30b156b(_a2ba1be4e76d1384392b473fe6743bbe_8d2bdad93304437f9f5d95bad30b156b command)
		{
		}

		private void BakeCommandBinding__a2ba1be4e76d1384392b473fe6743bbe_f40d2a9368a54df0a7abab03865cf27b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a2ba1be4e76d1384392b473fe6743bbe_f40d2a9368a54df0a7abab03865cf27b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a2ba1be4e76d1384392b473fe6743bbe_f40d2a9368a54df0a7abab03865cf27b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a2ba1be4e76d1384392b473fe6743bbe_f40d2a9368a54df0a7abab03865cf27b(_a2ba1be4e76d1384392b473fe6743bbe_f40d2a9368a54df0a7abab03865cf27b command)
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
