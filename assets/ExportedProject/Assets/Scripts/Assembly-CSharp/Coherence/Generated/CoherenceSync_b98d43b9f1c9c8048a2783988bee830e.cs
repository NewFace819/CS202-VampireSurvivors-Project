using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_b98d43b9f1c9c8048a2783988bee830e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Destructible _b98d43b9f1c9c8048a2783988bee830e_4aaa14bd0efa472c97c2e3dd980a0abe_CommandTarget;

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

		private void BakeCommandBinding__b98d43b9f1c9c8048a2783988bee830e_4aaa14bd0efa472c97c2e3dd980a0abe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b98d43b9f1c9c8048a2783988bee830e_4aaa14bd0efa472c97c2e3dd980a0abe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b98d43b9f1c9c8048a2783988bee830e_4aaa14bd0efa472c97c2e3dd980a0abe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b98d43b9f1c9c8048a2783988bee830e_4aaa14bd0efa472c97c2e3dd980a0abe(_b98d43b9f1c9c8048a2783988bee830e_4aaa14bd0efa472c97c2e3dd980a0abe command)
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
