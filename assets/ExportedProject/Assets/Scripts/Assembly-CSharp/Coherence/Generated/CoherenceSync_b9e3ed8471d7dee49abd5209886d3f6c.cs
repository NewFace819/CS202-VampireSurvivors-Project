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
	public class CoherenceSync_b9e3ed8471d7dee49abd5209886d3f6c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _b9e3ed8471d7dee49abd5209886d3f6c_c7be62f4d1324486a77c2f1851e926d6_CommandTarget;

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

		private void BakeCommandBinding__b9e3ed8471d7dee49abd5209886d3f6c_c7be62f4d1324486a77c2f1851e926d6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b9e3ed8471d7dee49abd5209886d3f6c_c7be62f4d1324486a77c2f1851e926d6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b9e3ed8471d7dee49abd5209886d3f6c_c7be62f4d1324486a77c2f1851e926d6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b9e3ed8471d7dee49abd5209886d3f6c_c7be62f4d1324486a77c2f1851e926d6(_b9e3ed8471d7dee49abd5209886d3f6c_c7be62f4d1324486a77c2f1851e926d6 command)
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
