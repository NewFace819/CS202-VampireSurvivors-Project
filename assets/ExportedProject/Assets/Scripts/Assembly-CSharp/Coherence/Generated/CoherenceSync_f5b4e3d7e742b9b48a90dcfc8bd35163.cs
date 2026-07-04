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
	public class CoherenceSync_f5b4e3d7e742b9b48a90dcfc8bd35163 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _f5b4e3d7e742b9b48a90dcfc8bd35163_5ff80c212abb4843a814a6bfa337e790_CommandTarget;

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

		private void BakeCommandBinding__f5b4e3d7e742b9b48a90dcfc8bd35163_5ff80c212abb4843a814a6bfa337e790(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5b4e3d7e742b9b48a90dcfc8bd35163_5ff80c212abb4843a814a6bfa337e790(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5b4e3d7e742b9b48a90dcfc8bd35163_5ff80c212abb4843a814a6bfa337e790(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5b4e3d7e742b9b48a90dcfc8bd35163_5ff80c212abb4843a814a6bfa337e790(_f5b4e3d7e742b9b48a90dcfc8bd35163_5ff80c212abb4843a814a6bfa337e790 command)
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
