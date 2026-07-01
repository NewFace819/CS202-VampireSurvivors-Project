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
	public class CoherenceSync_b69aa349718557648aaeeb4157595687 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _b69aa349718557648aaeeb4157595687_7c4c9c9c3c71400ca3cf935a07e55b2f_CommandTarget;

		private EnemyBigFuzz _b69aa349718557648aaeeb4157595687_bda765a6df3147d696789bdd43176b88_CommandTarget;

		private EnemyBigFuzz _b69aa349718557648aaeeb4157595687_74e9864e2d784348a8ea752fd8658179_CommandTarget;

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

		private void BakeCommandBinding__b69aa349718557648aaeeb4157595687_7c4c9c9c3c71400ca3cf935a07e55b2f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b69aa349718557648aaeeb4157595687_7c4c9c9c3c71400ca3cf935a07e55b2f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b69aa349718557648aaeeb4157595687_7c4c9c9c3c71400ca3cf935a07e55b2f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b69aa349718557648aaeeb4157595687_7c4c9c9c3c71400ca3cf935a07e55b2f(_b69aa349718557648aaeeb4157595687_7c4c9c9c3c71400ca3cf935a07e55b2f command)
		{
		}

		private void BakeCommandBinding__b69aa349718557648aaeeb4157595687_bda765a6df3147d696789bdd43176b88(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b69aa349718557648aaeeb4157595687_bda765a6df3147d696789bdd43176b88(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b69aa349718557648aaeeb4157595687_bda765a6df3147d696789bdd43176b88(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b69aa349718557648aaeeb4157595687_bda765a6df3147d696789bdd43176b88(_b69aa349718557648aaeeb4157595687_bda765a6df3147d696789bdd43176b88 command)
		{
		}

		private void BakeCommandBinding__b69aa349718557648aaeeb4157595687_74e9864e2d784348a8ea752fd8658179(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b69aa349718557648aaeeb4157595687_74e9864e2d784348a8ea752fd8658179(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b69aa349718557648aaeeb4157595687_74e9864e2d784348a8ea752fd8658179(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b69aa349718557648aaeeb4157595687_74e9864e2d784348a8ea752fd8658179(_b69aa349718557648aaeeb4157595687_74e9864e2d784348a8ea752fd8658179 command)
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
