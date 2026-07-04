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
	public class CoherenceSync_ee1b1e31b3031ba44a3b2c6d948a324d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _ee1b1e31b3031ba44a3b2c6d948a324d_875af5d819fc43478e5a38a654bc6c60_CommandTarget;

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

		private void BakeCommandBinding__ee1b1e31b3031ba44a3b2c6d948a324d_875af5d819fc43478e5a38a654bc6c60(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ee1b1e31b3031ba44a3b2c6d948a324d_875af5d819fc43478e5a38a654bc6c60(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ee1b1e31b3031ba44a3b2c6d948a324d_875af5d819fc43478e5a38a654bc6c60(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ee1b1e31b3031ba44a3b2c6d948a324d_875af5d819fc43478e5a38a654bc6c60(_ee1b1e31b3031ba44a3b2c6d948a324d_875af5d819fc43478e5a38a654bc6c60 command)
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
