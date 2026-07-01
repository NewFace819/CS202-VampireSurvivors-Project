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
	public class CoherenceSync_935395f70f9bc7d4fa614948272047da : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _935395f70f9bc7d4fa614948272047da_a653a731c0224f08b2f93f927e76f547_CommandTarget;

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

		private void BakeCommandBinding__935395f70f9bc7d4fa614948272047da_a653a731c0224f08b2f93f927e76f547(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__935395f70f9bc7d4fa614948272047da_a653a731c0224f08b2f93f927e76f547(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__935395f70f9bc7d4fa614948272047da_a653a731c0224f08b2f93f927e76f547(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__935395f70f9bc7d4fa614948272047da_a653a731c0224f08b2f93f927e76f547(_935395f70f9bc7d4fa614948272047da_a653a731c0224f08b2f93f927e76f547 command)
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
