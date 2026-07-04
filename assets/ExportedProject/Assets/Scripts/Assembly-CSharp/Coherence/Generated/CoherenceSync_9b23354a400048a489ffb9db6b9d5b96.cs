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
	public class CoherenceSync_9b23354a400048a489ffb9db6b9d5b96 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _9b23354a400048a489ffb9db6b9d5b96_cb625513ed184c589a854ca36f53e47b_CommandTarget;

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

		private void BakeCommandBinding__9b23354a400048a489ffb9db6b9d5b96_cb625513ed184c589a854ca36f53e47b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9b23354a400048a489ffb9db6b9d5b96_cb625513ed184c589a854ca36f53e47b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9b23354a400048a489ffb9db6b9d5b96_cb625513ed184c589a854ca36f53e47b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9b23354a400048a489ffb9db6b9d5b96_cb625513ed184c589a854ca36f53e47b(_9b23354a400048a489ffb9db6b9d5b96_cb625513ed184c589a854ca36f53e47b command)
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
