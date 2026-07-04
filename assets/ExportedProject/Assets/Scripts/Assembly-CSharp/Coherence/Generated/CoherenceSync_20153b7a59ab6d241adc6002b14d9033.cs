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
using VampireSurvivors.Objects.Characters.Enemies;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_20153b7a59ab6d241adc6002b14d9033 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _20153b7a59ab6d241adc6002b14d9033_ede9b277b72a428b9b93a839fcea7a0a_CommandTarget;

		private EnemyMazerellaDancer _20153b7a59ab6d241adc6002b14d9033_becd45b2ed304c1cb733bdd706c9d698_CommandTarget;

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

		private void BakeCommandBinding__20153b7a59ab6d241adc6002b14d9033_ede9b277b72a428b9b93a839fcea7a0a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20153b7a59ab6d241adc6002b14d9033_ede9b277b72a428b9b93a839fcea7a0a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20153b7a59ab6d241adc6002b14d9033_ede9b277b72a428b9b93a839fcea7a0a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20153b7a59ab6d241adc6002b14d9033_ede9b277b72a428b9b93a839fcea7a0a(_20153b7a59ab6d241adc6002b14d9033_ede9b277b72a428b9b93a839fcea7a0a command)
		{
		}

		private void BakeCommandBinding__20153b7a59ab6d241adc6002b14d9033_becd45b2ed304c1cb733bdd706c9d698(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20153b7a59ab6d241adc6002b14d9033_becd45b2ed304c1cb733bdd706c9d698(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20153b7a59ab6d241adc6002b14d9033_becd45b2ed304c1cb733bdd706c9d698(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20153b7a59ab6d241adc6002b14d9033_becd45b2ed304c1cb733bdd706c9d698(_20153b7a59ab6d241adc6002b14d9033_becd45b2ed304c1cb733bdd706c9d698 command)
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
