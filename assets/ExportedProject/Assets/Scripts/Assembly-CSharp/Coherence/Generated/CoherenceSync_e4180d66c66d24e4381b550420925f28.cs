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
	public class CoherenceSync_e4180d66c66d24e4381b550420925f28 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _e4180d66c66d24e4381b550420925f28_9dd8f99aca3b46f2a24fa35be7ccda92_CommandTarget;

		private Enemy_TP_GateBoss _e4180d66c66d24e4381b550420925f28_7e031d022d704366b97c9b5b807c85db_CommandTarget;

		private Enemy_TP_GateBoss _e4180d66c66d24e4381b550420925f28_8bf53ae770e044ceaae5d8a6dac0b97b_CommandTarget;

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

		private void BakeCommandBinding__e4180d66c66d24e4381b550420925f28_9dd8f99aca3b46f2a24fa35be7ccda92(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4180d66c66d24e4381b550420925f28_9dd8f99aca3b46f2a24fa35be7ccda92(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4180d66c66d24e4381b550420925f28_9dd8f99aca3b46f2a24fa35be7ccda92(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4180d66c66d24e4381b550420925f28_9dd8f99aca3b46f2a24fa35be7ccda92(_e4180d66c66d24e4381b550420925f28_9dd8f99aca3b46f2a24fa35be7ccda92 command)
		{
		}

		private void BakeCommandBinding__e4180d66c66d24e4381b550420925f28_7e031d022d704366b97c9b5b807c85db(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4180d66c66d24e4381b550420925f28_7e031d022d704366b97c9b5b807c85db(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4180d66c66d24e4381b550420925f28_7e031d022d704366b97c9b5b807c85db(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4180d66c66d24e4381b550420925f28_7e031d022d704366b97c9b5b807c85db(_e4180d66c66d24e4381b550420925f28_7e031d022d704366b97c9b5b807c85db command)
		{
		}

		private void BakeCommandBinding__e4180d66c66d24e4381b550420925f28_8bf53ae770e044ceaae5d8a6dac0b97b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4180d66c66d24e4381b550420925f28_8bf53ae770e044ceaae5d8a6dac0b97b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4180d66c66d24e4381b550420925f28_8bf53ae770e044ceaae5d8a6dac0b97b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4180d66c66d24e4381b550420925f28_8bf53ae770e044ceaae5d8a6dac0b97b(_e4180d66c66d24e4381b550420925f28_8bf53ae770e044ceaae5d8a6dac0b97b command)
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
