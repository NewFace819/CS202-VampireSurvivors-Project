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
	public class CoherenceSync_18f4f7361a86e0945ad53b26e17c318f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Destructible _18f4f7361a86e0945ad53b26e17c318f_975956c191884e3c9d14c9a9d30c4473_CommandTarget;

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

		private void BakeCommandBinding__18f4f7361a86e0945ad53b26e17c318f_975956c191884e3c9d14c9a9d30c4473(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__18f4f7361a86e0945ad53b26e17c318f_975956c191884e3c9d14c9a9d30c4473(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__18f4f7361a86e0945ad53b26e17c318f_975956c191884e3c9d14c9a9d30c4473(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__18f4f7361a86e0945ad53b26e17c318f_975956c191884e3c9d14c9a9d30c4473(_18f4f7361a86e0945ad53b26e17c318f_975956c191884e3c9d14c9a9d30c4473 command)
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
