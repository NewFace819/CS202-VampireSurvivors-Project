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
	public class CoherenceSync_d73b61ec684a9174c836f2c561879448 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Destructible _d73b61ec684a9174c836f2c561879448_c0ed1d48b5e8417eacd730551db97f0a_CommandTarget;

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

		private void BakeCommandBinding__d73b61ec684a9174c836f2c561879448_c0ed1d48b5e8417eacd730551db97f0a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d73b61ec684a9174c836f2c561879448_c0ed1d48b5e8417eacd730551db97f0a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d73b61ec684a9174c836f2c561879448_c0ed1d48b5e8417eacd730551db97f0a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d73b61ec684a9174c836f2c561879448_c0ed1d48b5e8417eacd730551db97f0a(_d73b61ec684a9174c836f2c561879448_c0ed1d48b5e8417eacd730551db97f0a command)
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
