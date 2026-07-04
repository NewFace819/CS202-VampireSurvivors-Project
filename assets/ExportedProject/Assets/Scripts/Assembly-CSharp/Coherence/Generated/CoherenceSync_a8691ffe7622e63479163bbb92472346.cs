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
	public class CoherenceSync_a8691ffe7622e63479163bbb92472346 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _a8691ffe7622e63479163bbb92472346_d232a9b6b36745ea929d407a24278b37_CommandTarget;

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

		private void BakeCommandBinding__a8691ffe7622e63479163bbb92472346_d232a9b6b36745ea929d407a24278b37(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a8691ffe7622e63479163bbb92472346_d232a9b6b36745ea929d407a24278b37(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a8691ffe7622e63479163bbb92472346_d232a9b6b36745ea929d407a24278b37(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a8691ffe7622e63479163bbb92472346_d232a9b6b36745ea929d407a24278b37(_a8691ffe7622e63479163bbb92472346_d232a9b6b36745ea929d407a24278b37 command)
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
