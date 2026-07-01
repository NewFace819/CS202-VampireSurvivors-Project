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
	public class CoherenceSync_ad7c79efbf88f1a44a06057a58171177 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _ad7c79efbf88f1a44a06057a58171177_b8edf7331bcf4fd2998b88a4b009d01d_CommandTarget;

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

		private void BakeCommandBinding__ad7c79efbf88f1a44a06057a58171177_b8edf7331bcf4fd2998b88a4b009d01d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ad7c79efbf88f1a44a06057a58171177_b8edf7331bcf4fd2998b88a4b009d01d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ad7c79efbf88f1a44a06057a58171177_b8edf7331bcf4fd2998b88a4b009d01d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ad7c79efbf88f1a44a06057a58171177_b8edf7331bcf4fd2998b88a4b009d01d(_ad7c79efbf88f1a44a06057a58171177_b8edf7331bcf4fd2998b88a4b009d01d command)
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
