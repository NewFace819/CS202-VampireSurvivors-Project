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
	public class CoherenceSync_463be16195935a7499dc3815765a7ec0 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _463be16195935a7499dc3815765a7ec0_8c0ddc7b848a409d9c9efd47c639e30c_CommandTarget;

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

		private void BakeCommandBinding__463be16195935a7499dc3815765a7ec0_8c0ddc7b848a409d9c9efd47c639e30c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__463be16195935a7499dc3815765a7ec0_8c0ddc7b848a409d9c9efd47c639e30c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__463be16195935a7499dc3815765a7ec0_8c0ddc7b848a409d9c9efd47c639e30c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__463be16195935a7499dc3815765a7ec0_8c0ddc7b848a409d9c9efd47c639e30c(_463be16195935a7499dc3815765a7ec0_8c0ddc7b848a409d9c9efd47c639e30c command)
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
