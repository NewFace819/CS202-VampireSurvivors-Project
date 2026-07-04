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
	public class CoherenceSync_58b3437face625e4fb85a0088b0770b3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _58b3437face625e4fb85a0088b0770b3_37cab170d7454073ba4e8d9ebf82f4fa_CommandTarget;

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

		private void BakeCommandBinding__58b3437face625e4fb85a0088b0770b3_37cab170d7454073ba4e8d9ebf82f4fa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__58b3437face625e4fb85a0088b0770b3_37cab170d7454073ba4e8d9ebf82f4fa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__58b3437face625e4fb85a0088b0770b3_37cab170d7454073ba4e8d9ebf82f4fa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__58b3437face625e4fb85a0088b0770b3_37cab170d7454073ba4e8d9ebf82f4fa(_58b3437face625e4fb85a0088b0770b3_37cab170d7454073ba4e8d9ebf82f4fa command)
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
