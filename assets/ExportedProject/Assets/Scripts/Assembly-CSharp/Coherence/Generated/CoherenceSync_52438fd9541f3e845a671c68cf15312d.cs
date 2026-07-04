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
	public class CoherenceSync_52438fd9541f3e845a671c68cf15312d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _52438fd9541f3e845a671c68cf15312d_7527b5f49a724b2f810749cbac3f62f0_CommandTarget;

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

		private void BakeCommandBinding__52438fd9541f3e845a671c68cf15312d_7527b5f49a724b2f810749cbac3f62f0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52438fd9541f3e845a671c68cf15312d_7527b5f49a724b2f810749cbac3f62f0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52438fd9541f3e845a671c68cf15312d_7527b5f49a724b2f810749cbac3f62f0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52438fd9541f3e845a671c68cf15312d_7527b5f49a724b2f810749cbac3f62f0(_52438fd9541f3e845a671c68cf15312d_7527b5f49a724b2f810749cbac3f62f0 command)
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
