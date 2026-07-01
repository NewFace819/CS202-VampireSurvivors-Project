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
	public class CoherenceSync_e3686734998044f449e933734bd8ee0c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _e3686734998044f449e933734bd8ee0c_a2f70dc672324281a8d42a3ab0bc6d93_CommandTarget;

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

		private void BakeCommandBinding__e3686734998044f449e933734bd8ee0c_a2f70dc672324281a8d42a3ab0bc6d93(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3686734998044f449e933734bd8ee0c_a2f70dc672324281a8d42a3ab0bc6d93(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3686734998044f449e933734bd8ee0c_a2f70dc672324281a8d42a3ab0bc6d93(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3686734998044f449e933734bd8ee0c_a2f70dc672324281a8d42a3ab0bc6d93(_e3686734998044f449e933734bd8ee0c_a2f70dc672324281a8d42a3ab0bc6d93 command)
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
