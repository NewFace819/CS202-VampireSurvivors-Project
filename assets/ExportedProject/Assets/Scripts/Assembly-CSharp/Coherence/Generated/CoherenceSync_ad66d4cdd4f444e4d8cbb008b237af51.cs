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
	public class CoherenceSync_ad66d4cdd4f444e4d8cbb008b237af51 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _ad66d4cdd4f444e4d8cbb008b237af51_5c5c33f78e7d4b6095a42e80829641a5_CommandTarget;

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

		private void BakeCommandBinding__ad66d4cdd4f444e4d8cbb008b237af51_5c5c33f78e7d4b6095a42e80829641a5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ad66d4cdd4f444e4d8cbb008b237af51_5c5c33f78e7d4b6095a42e80829641a5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ad66d4cdd4f444e4d8cbb008b237af51_5c5c33f78e7d4b6095a42e80829641a5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ad66d4cdd4f444e4d8cbb008b237af51_5c5c33f78e7d4b6095a42e80829641a5(_ad66d4cdd4f444e4d8cbb008b237af51_5c5c33f78e7d4b6095a42e80829641a5 command)
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
