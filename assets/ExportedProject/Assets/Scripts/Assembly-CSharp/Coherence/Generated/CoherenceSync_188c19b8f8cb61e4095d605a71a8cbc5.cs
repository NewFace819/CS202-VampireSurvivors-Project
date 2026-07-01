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
	public class CoherenceSync_188c19b8f8cb61e4095d605a71a8cbc5 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _188c19b8f8cb61e4095d605a71a8cbc5_6d98a7a4e0544c478e5b1a1ad387d836_CommandTarget;

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

		private void BakeCommandBinding__188c19b8f8cb61e4095d605a71a8cbc5_6d98a7a4e0544c478e5b1a1ad387d836(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__188c19b8f8cb61e4095d605a71a8cbc5_6d98a7a4e0544c478e5b1a1ad387d836(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__188c19b8f8cb61e4095d605a71a8cbc5_6d98a7a4e0544c478e5b1a1ad387d836(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__188c19b8f8cb61e4095d605a71a8cbc5_6d98a7a4e0544c478e5b1a1ad387d836(_188c19b8f8cb61e4095d605a71a8cbc5_6d98a7a4e0544c478e5b1a1ad387d836 command)
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
