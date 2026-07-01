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
	public class CoherenceSync_2c13491b2d6028e46a679ce5367328fc : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Destructible _2c13491b2d6028e46a679ce5367328fc_da7ad677657a413792d0451fe043cbd6_CommandTarget;

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

		private void BakeCommandBinding__2c13491b2d6028e46a679ce5367328fc_da7ad677657a413792d0451fe043cbd6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2c13491b2d6028e46a679ce5367328fc_da7ad677657a413792d0451fe043cbd6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2c13491b2d6028e46a679ce5367328fc_da7ad677657a413792d0451fe043cbd6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2c13491b2d6028e46a679ce5367328fc_da7ad677657a413792d0451fe043cbd6(_2c13491b2d6028e46a679ce5367328fc_da7ad677657a413792d0451fe043cbd6 command)
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
