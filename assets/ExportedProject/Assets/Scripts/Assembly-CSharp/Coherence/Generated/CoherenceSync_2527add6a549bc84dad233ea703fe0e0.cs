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
	public class CoherenceSync_2527add6a549bc84dad233ea703fe0e0 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _2527add6a549bc84dad233ea703fe0e0_d810612336714a8980f21b4a7973e9f3_CommandTarget;

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

		private void BakeCommandBinding__2527add6a549bc84dad233ea703fe0e0_d810612336714a8980f21b4a7973e9f3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2527add6a549bc84dad233ea703fe0e0_d810612336714a8980f21b4a7973e9f3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2527add6a549bc84dad233ea703fe0e0_d810612336714a8980f21b4a7973e9f3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2527add6a549bc84dad233ea703fe0e0_d810612336714a8980f21b4a7973e9f3(_2527add6a549bc84dad233ea703fe0e0_d810612336714a8980f21b4a7973e9f3 command)
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
