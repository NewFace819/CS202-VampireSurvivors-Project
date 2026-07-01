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
	public class CoherenceSync_8f69b5b90f9820c48b20d38d4878a1f0 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _8f69b5b90f9820c48b20d38d4878a1f0_085741c3d1e043f3a511a6b4502f3c86_CommandTarget;

		private Enemy_TP_GateBoss _8f69b5b90f9820c48b20d38d4878a1f0_26aa3cfae835415d84107af813928533_CommandTarget;

		private Enemy_TP_GateBoss _8f69b5b90f9820c48b20d38d4878a1f0_a5857239d2154827b584e3a4dab8a042_CommandTarget;

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

		private void BakeCommandBinding__8f69b5b90f9820c48b20d38d4878a1f0_085741c3d1e043f3a511a6b4502f3c86(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f69b5b90f9820c48b20d38d4878a1f0_085741c3d1e043f3a511a6b4502f3c86(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f69b5b90f9820c48b20d38d4878a1f0_085741c3d1e043f3a511a6b4502f3c86(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f69b5b90f9820c48b20d38d4878a1f0_085741c3d1e043f3a511a6b4502f3c86(_8f69b5b90f9820c48b20d38d4878a1f0_085741c3d1e043f3a511a6b4502f3c86 command)
		{
		}

		private void BakeCommandBinding__8f69b5b90f9820c48b20d38d4878a1f0_26aa3cfae835415d84107af813928533(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f69b5b90f9820c48b20d38d4878a1f0_26aa3cfae835415d84107af813928533(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f69b5b90f9820c48b20d38d4878a1f0_26aa3cfae835415d84107af813928533(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f69b5b90f9820c48b20d38d4878a1f0_26aa3cfae835415d84107af813928533(_8f69b5b90f9820c48b20d38d4878a1f0_26aa3cfae835415d84107af813928533 command)
		{
		}

		private void BakeCommandBinding__8f69b5b90f9820c48b20d38d4878a1f0_a5857239d2154827b584e3a4dab8a042(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8f69b5b90f9820c48b20d38d4878a1f0_a5857239d2154827b584e3a4dab8a042(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8f69b5b90f9820c48b20d38d4878a1f0_a5857239d2154827b584e3a4dab8a042(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8f69b5b90f9820c48b20d38d4878a1f0_a5857239d2154827b584e3a4dab8a042(_8f69b5b90f9820c48b20d38d4878a1f0_a5857239d2154827b584e3a4dab8a042 command)
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
