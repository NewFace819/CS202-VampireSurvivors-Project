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
	public class CoherenceSync_3b27967017d8b0248ac7d8ac7e83e721 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _3b27967017d8b0248ac7d8ac7e83e721_d3c6f69d52c242a1aeaae5360f1b3582_CommandTarget;

		private EnemyBeelzebubBee _3b27967017d8b0248ac7d8ac7e83e721_0dd52434e9af432cb2b2ef9f8f14e294_CommandTarget;

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

		private void BakeCommandBinding__3b27967017d8b0248ac7d8ac7e83e721_d3c6f69d52c242a1aeaae5360f1b3582(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b27967017d8b0248ac7d8ac7e83e721_d3c6f69d52c242a1aeaae5360f1b3582(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b27967017d8b0248ac7d8ac7e83e721_d3c6f69d52c242a1aeaae5360f1b3582(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b27967017d8b0248ac7d8ac7e83e721_d3c6f69d52c242a1aeaae5360f1b3582(_3b27967017d8b0248ac7d8ac7e83e721_d3c6f69d52c242a1aeaae5360f1b3582 command)
		{
		}

		private void BakeCommandBinding__3b27967017d8b0248ac7d8ac7e83e721_0dd52434e9af432cb2b2ef9f8f14e294(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3b27967017d8b0248ac7d8ac7e83e721_0dd52434e9af432cb2b2ef9f8f14e294(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3b27967017d8b0248ac7d8ac7e83e721_0dd52434e9af432cb2b2ef9f8f14e294(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3b27967017d8b0248ac7d8ac7e83e721_0dd52434e9af432cb2b2ef9f8f14e294(_3b27967017d8b0248ac7d8ac7e83e721_0dd52434e9af432cb2b2ef9f8f14e294 command)
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
