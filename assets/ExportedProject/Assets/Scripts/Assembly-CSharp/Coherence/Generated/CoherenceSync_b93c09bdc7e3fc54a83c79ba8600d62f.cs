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
	public class CoherenceSync_b93c09bdc7e3fc54a83c79ba8600d62f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _b93c09bdc7e3fc54a83c79ba8600d62f_9194024d5ecd40fc80f127beecaaa942_CommandTarget;

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

		private void BakeCommandBinding__b93c09bdc7e3fc54a83c79ba8600d62f_9194024d5ecd40fc80f127beecaaa942(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b93c09bdc7e3fc54a83c79ba8600d62f_9194024d5ecd40fc80f127beecaaa942(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b93c09bdc7e3fc54a83c79ba8600d62f_9194024d5ecd40fc80f127beecaaa942(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b93c09bdc7e3fc54a83c79ba8600d62f_9194024d5ecd40fc80f127beecaaa942(_b93c09bdc7e3fc54a83c79ba8600d62f_9194024d5ecd40fc80f127beecaaa942 command)
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
