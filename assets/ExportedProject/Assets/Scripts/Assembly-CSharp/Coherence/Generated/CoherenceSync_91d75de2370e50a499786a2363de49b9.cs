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
	public class CoherenceSync_91d75de2370e50a499786a2363de49b9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _91d75de2370e50a499786a2363de49b9_1a5ae91011b44ce58fbd7529a9694c70_CommandTarget;

		private EnemyBeelzebubSection _91d75de2370e50a499786a2363de49b9_86a9b99115cf4ff4bee340bb5d812cbd_CommandTarget;

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

		private void BakeCommandBinding__91d75de2370e50a499786a2363de49b9_1a5ae91011b44ce58fbd7529a9694c70(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__91d75de2370e50a499786a2363de49b9_1a5ae91011b44ce58fbd7529a9694c70(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__91d75de2370e50a499786a2363de49b9_1a5ae91011b44ce58fbd7529a9694c70(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__91d75de2370e50a499786a2363de49b9_1a5ae91011b44ce58fbd7529a9694c70(_91d75de2370e50a499786a2363de49b9_1a5ae91011b44ce58fbd7529a9694c70 command)
		{
		}

		private void BakeCommandBinding__91d75de2370e50a499786a2363de49b9_86a9b99115cf4ff4bee340bb5d812cbd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__91d75de2370e50a499786a2363de49b9_86a9b99115cf4ff4bee340bb5d812cbd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__91d75de2370e50a499786a2363de49b9_86a9b99115cf4ff4bee340bb5d812cbd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__91d75de2370e50a499786a2363de49b9_86a9b99115cf4ff4bee340bb5d812cbd(_91d75de2370e50a499786a2363de49b9_86a9b99115cf4ff4bee340bb5d812cbd command)
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
