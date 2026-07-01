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
	public class CoherenceSync_faaf48c97104b4e4e833834bf5748abf : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _faaf48c97104b4e4e833834bf5748abf_dd80db354cda4ab9960c53e56aaa29d0_CommandTarget;

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

		private void BakeCommandBinding__faaf48c97104b4e4e833834bf5748abf_dd80db354cda4ab9960c53e56aaa29d0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__faaf48c97104b4e4e833834bf5748abf_dd80db354cda4ab9960c53e56aaa29d0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__faaf48c97104b4e4e833834bf5748abf_dd80db354cda4ab9960c53e56aaa29d0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__faaf48c97104b4e4e833834bf5748abf_dd80db354cda4ab9960c53e56aaa29d0(_faaf48c97104b4e4e833834bf5748abf_dd80db354cda4ab9960c53e56aaa29d0 command)
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
