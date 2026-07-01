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
	public class CoherenceSync_6571407d772bb034f93ea48f397b9a71 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _6571407d772bb034f93ea48f397b9a71_b7204e36772f4330a83d47a00e674c0d_CommandTarget;

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

		private void BakeCommandBinding__6571407d772bb034f93ea48f397b9a71_b7204e36772f4330a83d47a00e674c0d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6571407d772bb034f93ea48f397b9a71_b7204e36772f4330a83d47a00e674c0d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6571407d772bb034f93ea48f397b9a71_b7204e36772f4330a83d47a00e674c0d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6571407d772bb034f93ea48f397b9a71_b7204e36772f4330a83d47a00e674c0d(_6571407d772bb034f93ea48f397b9a71_b7204e36772f4330a83d47a00e674c0d command)
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
