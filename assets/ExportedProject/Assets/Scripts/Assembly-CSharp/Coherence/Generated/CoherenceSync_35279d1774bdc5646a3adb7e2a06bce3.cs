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
	public class CoherenceSync_35279d1774bdc5646a3adb7e2a06bce3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _35279d1774bdc5646a3adb7e2a06bce3_b0409a2489d84fc1aee5a30a277cf7cb_CommandTarget;

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

		private void BakeCommandBinding__35279d1774bdc5646a3adb7e2a06bce3_b0409a2489d84fc1aee5a30a277cf7cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__35279d1774bdc5646a3adb7e2a06bce3_b0409a2489d84fc1aee5a30a277cf7cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__35279d1774bdc5646a3adb7e2a06bce3_b0409a2489d84fc1aee5a30a277cf7cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__35279d1774bdc5646a3adb7e2a06bce3_b0409a2489d84fc1aee5a30a277cf7cb(_35279d1774bdc5646a3adb7e2a06bce3_b0409a2489d84fc1aee5a30a277cf7cb command)
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
