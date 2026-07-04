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
	public class CoherenceSync_7f11d9d5827fa65409eac7e9081f4255 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _7f11d9d5827fa65409eac7e9081f4255_4e2dba6a50eb4f3fbabc0c58f7229011_CommandTarget;

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

		private void BakeCommandBinding__7f11d9d5827fa65409eac7e9081f4255_4e2dba6a50eb4f3fbabc0c58f7229011(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7f11d9d5827fa65409eac7e9081f4255_4e2dba6a50eb4f3fbabc0c58f7229011(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7f11d9d5827fa65409eac7e9081f4255_4e2dba6a50eb4f3fbabc0c58f7229011(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7f11d9d5827fa65409eac7e9081f4255_4e2dba6a50eb4f3fbabc0c58f7229011(_7f11d9d5827fa65409eac7e9081f4255_4e2dba6a50eb4f3fbabc0c58f7229011 command)
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
