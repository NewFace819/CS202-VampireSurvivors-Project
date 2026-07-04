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
	public class CoherenceSync_accfc10a1b64d6143ab379fe62c0c946 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _accfc10a1b64d6143ab379fe62c0c946_b16c0ddc8c97415ea24877602765c252_CommandTarget;

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

		private void BakeCommandBinding__accfc10a1b64d6143ab379fe62c0c946_b16c0ddc8c97415ea24877602765c252(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__accfc10a1b64d6143ab379fe62c0c946_b16c0ddc8c97415ea24877602765c252(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__accfc10a1b64d6143ab379fe62c0c946_b16c0ddc8c97415ea24877602765c252(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__accfc10a1b64d6143ab379fe62c0c946_b16c0ddc8c97415ea24877602765c252(_accfc10a1b64d6143ab379fe62c0c946_b16c0ddc8c97415ea24877602765c252 command)
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
