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
	public class CoherenceSync_209bef20d4344ed41ab35db11629eab4 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _209bef20d4344ed41ab35db11629eab4_65873cb1650346dab6aa4be83a596e3f_CommandTarget;

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

		private void BakeCommandBinding__209bef20d4344ed41ab35db11629eab4_65873cb1650346dab6aa4be83a596e3f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__209bef20d4344ed41ab35db11629eab4_65873cb1650346dab6aa4be83a596e3f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__209bef20d4344ed41ab35db11629eab4_65873cb1650346dab6aa4be83a596e3f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__209bef20d4344ed41ab35db11629eab4_65873cb1650346dab6aa4be83a596e3f(_209bef20d4344ed41ab35db11629eab4_65873cb1650346dab6aa4be83a596e3f command)
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
