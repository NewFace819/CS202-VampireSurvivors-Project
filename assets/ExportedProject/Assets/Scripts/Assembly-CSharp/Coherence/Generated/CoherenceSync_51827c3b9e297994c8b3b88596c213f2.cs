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
	public class CoherenceSync_51827c3b9e297994c8b3b88596c213f2 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _51827c3b9e297994c8b3b88596c213f2_09af7408276c4a23b90b50ceb9f09928_CommandTarget;

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

		private void BakeCommandBinding__51827c3b9e297994c8b3b88596c213f2_09af7408276c4a23b90b50ceb9f09928(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51827c3b9e297994c8b3b88596c213f2_09af7408276c4a23b90b50ceb9f09928(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51827c3b9e297994c8b3b88596c213f2_09af7408276c4a23b90b50ceb9f09928(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51827c3b9e297994c8b3b88596c213f2_09af7408276c4a23b90b50ceb9f09928(_51827c3b9e297994c8b3b88596c213f2_09af7408276c4a23b90b50ceb9f09928 command)
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
