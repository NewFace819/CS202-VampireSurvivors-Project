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
	public class CoherenceSync_a7cc6877fef3a7c4587e32c53120be11 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _a7cc6877fef3a7c4587e32c53120be11_bb6ccc191cff49b6a361510e016b6112_CommandTarget;

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

		private void BakeCommandBinding__a7cc6877fef3a7c4587e32c53120be11_bb6ccc191cff49b6a361510e016b6112(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a7cc6877fef3a7c4587e32c53120be11_bb6ccc191cff49b6a361510e016b6112(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a7cc6877fef3a7c4587e32c53120be11_bb6ccc191cff49b6a361510e016b6112(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a7cc6877fef3a7c4587e32c53120be11_bb6ccc191cff49b6a361510e016b6112(_a7cc6877fef3a7c4587e32c53120be11_bb6ccc191cff49b6a361510e016b6112 command)
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
