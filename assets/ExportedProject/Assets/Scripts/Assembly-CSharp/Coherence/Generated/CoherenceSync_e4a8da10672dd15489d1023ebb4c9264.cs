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
	public class CoherenceSync_e4a8da10672dd15489d1023ebb4c9264 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _e4a8da10672dd15489d1023ebb4c9264_48c15124e0304816959fd67bc6b7a25f_CommandTarget;

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

		private void BakeCommandBinding__e4a8da10672dd15489d1023ebb4c9264_48c15124e0304816959fd67bc6b7a25f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4a8da10672dd15489d1023ebb4c9264_48c15124e0304816959fd67bc6b7a25f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4a8da10672dd15489d1023ebb4c9264_48c15124e0304816959fd67bc6b7a25f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4a8da10672dd15489d1023ebb4c9264_48c15124e0304816959fd67bc6b7a25f(_e4a8da10672dd15489d1023ebb4c9264_48c15124e0304816959fd67bc6b7a25f command)
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
