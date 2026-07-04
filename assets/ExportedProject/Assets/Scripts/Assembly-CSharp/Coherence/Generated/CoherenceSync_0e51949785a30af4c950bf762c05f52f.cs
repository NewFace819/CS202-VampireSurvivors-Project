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
	public class CoherenceSync_0e51949785a30af4c950bf762c05f52f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Destructible _0e51949785a30af4c950bf762c05f52f_02cc23e970ed4bf0bb927fad47dff92d_CommandTarget;

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

		private void BakeCommandBinding__0e51949785a30af4c950bf762c05f52f_02cc23e970ed4bf0bb927fad47dff92d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0e51949785a30af4c950bf762c05f52f_02cc23e970ed4bf0bb927fad47dff92d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0e51949785a30af4c950bf762c05f52f_02cc23e970ed4bf0bb927fad47dff92d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0e51949785a30af4c950bf762c05f52f_02cc23e970ed4bf0bb927fad47dff92d(_0e51949785a30af4c950bf762c05f52f_02cc23e970ed4bf0bb927fad47dff92d command)
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
