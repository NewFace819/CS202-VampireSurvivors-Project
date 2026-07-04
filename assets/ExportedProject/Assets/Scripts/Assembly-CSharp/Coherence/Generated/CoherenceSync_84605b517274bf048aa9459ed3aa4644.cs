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
	public class CoherenceSync_84605b517274bf048aa9459ed3aa4644 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _84605b517274bf048aa9459ed3aa4644_ebc2a495641e4c3390fd7923ca18f6e5_CommandTarget;

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

		private void BakeCommandBinding__84605b517274bf048aa9459ed3aa4644_ebc2a495641e4c3390fd7923ca18f6e5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__84605b517274bf048aa9459ed3aa4644_ebc2a495641e4c3390fd7923ca18f6e5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__84605b517274bf048aa9459ed3aa4644_ebc2a495641e4c3390fd7923ca18f6e5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__84605b517274bf048aa9459ed3aa4644_ebc2a495641e4c3390fd7923ca18f6e5(_84605b517274bf048aa9459ed3aa4644_ebc2a495641e4c3390fd7923ca18f6e5 command)
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
