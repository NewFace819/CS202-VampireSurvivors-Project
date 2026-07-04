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
	public class CoherenceSync_78efd33b5fb46114c89a47714eeaea17 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _78efd33b5fb46114c89a47714eeaea17_f4ae6ca39b324a6bb3424d6d70dcffef_CommandTarget;

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

		private void BakeCommandBinding__78efd33b5fb46114c89a47714eeaea17_f4ae6ca39b324a6bb3424d6d70dcffef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__78efd33b5fb46114c89a47714eeaea17_f4ae6ca39b324a6bb3424d6d70dcffef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__78efd33b5fb46114c89a47714eeaea17_f4ae6ca39b324a6bb3424d6d70dcffef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__78efd33b5fb46114c89a47714eeaea17_f4ae6ca39b324a6bb3424d6d70dcffef(_78efd33b5fb46114c89a47714eeaea17_f4ae6ca39b324a6bb3424d6d70dcffef command)
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
