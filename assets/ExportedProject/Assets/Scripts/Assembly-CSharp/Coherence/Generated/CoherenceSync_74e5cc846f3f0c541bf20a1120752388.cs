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
	public class CoherenceSync_74e5cc846f3f0c541bf20a1120752388 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _74e5cc846f3f0c541bf20a1120752388_0a1a5af1057146d19f22e630c9bcc245_CommandTarget;

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

		private void BakeCommandBinding__74e5cc846f3f0c541bf20a1120752388_0a1a5af1057146d19f22e630c9bcc245(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__74e5cc846f3f0c541bf20a1120752388_0a1a5af1057146d19f22e630c9bcc245(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__74e5cc846f3f0c541bf20a1120752388_0a1a5af1057146d19f22e630c9bcc245(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__74e5cc846f3f0c541bf20a1120752388_0a1a5af1057146d19f22e630c9bcc245(_74e5cc846f3f0c541bf20a1120752388_0a1a5af1057146d19f22e630c9bcc245 command)
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
