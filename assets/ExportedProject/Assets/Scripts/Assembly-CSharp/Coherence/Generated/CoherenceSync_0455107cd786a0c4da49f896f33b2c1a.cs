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
	public class CoherenceSync_0455107cd786a0c4da49f896f33b2c1a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _0455107cd786a0c4da49f896f33b2c1a_27ba2c86cf0748e18bb247ddfa29e1a6_CommandTarget;

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

		private void BakeCommandBinding__0455107cd786a0c4da49f896f33b2c1a_27ba2c86cf0748e18bb247ddfa29e1a6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0455107cd786a0c4da49f896f33b2c1a_27ba2c86cf0748e18bb247ddfa29e1a6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0455107cd786a0c4da49f896f33b2c1a_27ba2c86cf0748e18bb247ddfa29e1a6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0455107cd786a0c4da49f896f33b2c1a_27ba2c86cf0748e18bb247ddfa29e1a6(_0455107cd786a0c4da49f896f33b2c1a_27ba2c86cf0748e18bb247ddfa29e1a6 command)
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
