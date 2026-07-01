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
	public class CoherenceSync_d33e9c4d59841ce4ea27dd6765b95e60 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _d33e9c4d59841ce4ea27dd6765b95e60_0856d21e15fd4b5b9c2aa7a6ce6c89d1_CommandTarget;

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

		private void BakeCommandBinding__d33e9c4d59841ce4ea27dd6765b95e60_0856d21e15fd4b5b9c2aa7a6ce6c89d1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d33e9c4d59841ce4ea27dd6765b95e60_0856d21e15fd4b5b9c2aa7a6ce6c89d1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d33e9c4d59841ce4ea27dd6765b95e60_0856d21e15fd4b5b9c2aa7a6ce6c89d1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d33e9c4d59841ce4ea27dd6765b95e60_0856d21e15fd4b5b9c2aa7a6ce6c89d1(_d33e9c4d59841ce4ea27dd6765b95e60_0856d21e15fd4b5b9c2aa7a6ce6c89d1 command)
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
