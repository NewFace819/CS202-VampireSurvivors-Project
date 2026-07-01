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
	public class CoherenceSync_8115559d30515a446a3618f3e16e70d6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _8115559d30515a446a3618f3e16e70d6_bf28784fe254449a936bc2134add7e2c_CommandTarget;

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

		private void BakeCommandBinding__8115559d30515a446a3618f3e16e70d6_bf28784fe254449a936bc2134add7e2c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8115559d30515a446a3618f3e16e70d6_bf28784fe254449a936bc2134add7e2c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8115559d30515a446a3618f3e16e70d6_bf28784fe254449a936bc2134add7e2c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8115559d30515a446a3618f3e16e70d6_bf28784fe254449a936bc2134add7e2c(_8115559d30515a446a3618f3e16e70d6_bf28784fe254449a936bc2134add7e2c command)
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
