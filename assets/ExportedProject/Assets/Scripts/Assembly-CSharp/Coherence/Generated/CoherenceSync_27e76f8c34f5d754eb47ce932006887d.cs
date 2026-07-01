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
	public class CoherenceSync_27e76f8c34f5d754eb47ce932006887d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _27e76f8c34f5d754eb47ce932006887d_c72ad8818f5a4a8980e8246ede7b1c85_CommandTarget;

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

		private void BakeCommandBinding__27e76f8c34f5d754eb47ce932006887d_c72ad8818f5a4a8980e8246ede7b1c85(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27e76f8c34f5d754eb47ce932006887d_c72ad8818f5a4a8980e8246ede7b1c85(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27e76f8c34f5d754eb47ce932006887d_c72ad8818f5a4a8980e8246ede7b1c85(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27e76f8c34f5d754eb47ce932006887d_c72ad8818f5a4a8980e8246ede7b1c85(_27e76f8c34f5d754eb47ce932006887d_c72ad8818f5a4a8980e8246ede7b1c85 command)
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
