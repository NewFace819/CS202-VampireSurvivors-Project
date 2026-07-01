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
	public class CoherenceSync_6e64fbd28ff97014c927fbde9490cb15 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _6e64fbd28ff97014c927fbde9490cb15_6eedde7cc3d04ca2b236770f46bc56f8_CommandTarget;

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

		private void BakeCommandBinding__6e64fbd28ff97014c927fbde9490cb15_6eedde7cc3d04ca2b236770f46bc56f8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6e64fbd28ff97014c927fbde9490cb15_6eedde7cc3d04ca2b236770f46bc56f8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6e64fbd28ff97014c927fbde9490cb15_6eedde7cc3d04ca2b236770f46bc56f8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6e64fbd28ff97014c927fbde9490cb15_6eedde7cc3d04ca2b236770f46bc56f8(_6e64fbd28ff97014c927fbde9490cb15_6eedde7cc3d04ca2b236770f46bc56f8 command)
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
