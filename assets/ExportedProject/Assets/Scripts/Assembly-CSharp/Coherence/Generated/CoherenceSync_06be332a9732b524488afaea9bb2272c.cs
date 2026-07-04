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
	public class CoherenceSync_06be332a9732b524488afaea9bb2272c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _06be332a9732b524488afaea9bb2272c_24db7f47ae244a42980de785363260c1_CommandTarget;

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

		private void BakeCommandBinding__06be332a9732b524488afaea9bb2272c_24db7f47ae244a42980de785363260c1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__06be332a9732b524488afaea9bb2272c_24db7f47ae244a42980de785363260c1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__06be332a9732b524488afaea9bb2272c_24db7f47ae244a42980de785363260c1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__06be332a9732b524488afaea9bb2272c_24db7f47ae244a42980de785363260c1(_06be332a9732b524488afaea9bb2272c_24db7f47ae244a42980de785363260c1 command)
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
