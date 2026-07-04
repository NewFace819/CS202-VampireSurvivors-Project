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
	public class CoherenceSync_4d19d6a76ead5464e85fc9182c2b9614 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _4d19d6a76ead5464e85fc9182c2b9614_a512d39bd64d4b3fa79ba17f02473ec7_CommandTarget;

		private EnemyLightningOni _4d19d6a76ead5464e85fc9182c2b9614_c639956aeb48408f86cb5d62d247952e_CommandTarget;

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

		private void BakeCommandBinding__4d19d6a76ead5464e85fc9182c2b9614_a512d39bd64d4b3fa79ba17f02473ec7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4d19d6a76ead5464e85fc9182c2b9614_a512d39bd64d4b3fa79ba17f02473ec7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4d19d6a76ead5464e85fc9182c2b9614_a512d39bd64d4b3fa79ba17f02473ec7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4d19d6a76ead5464e85fc9182c2b9614_a512d39bd64d4b3fa79ba17f02473ec7(_4d19d6a76ead5464e85fc9182c2b9614_a512d39bd64d4b3fa79ba17f02473ec7 command)
		{
		}

		private void BakeCommandBinding__4d19d6a76ead5464e85fc9182c2b9614_c639956aeb48408f86cb5d62d247952e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4d19d6a76ead5464e85fc9182c2b9614_c639956aeb48408f86cb5d62d247952e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4d19d6a76ead5464e85fc9182c2b9614_c639956aeb48408f86cb5d62d247952e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4d19d6a76ead5464e85fc9182c2b9614_c639956aeb48408f86cb5d62d247952e(_4d19d6a76ead5464e85fc9182c2b9614_c639956aeb48408f86cb5d62d247952e command)
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
