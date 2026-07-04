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
	public class CoherenceSync_96928f9678c3c4d499d936f24357008f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _96928f9678c3c4d499d936f24357008f_2a46a2778ae54c7d8230a21eb72e7926_CommandTarget;

		private Enemy_TP_GateBoss _96928f9678c3c4d499d936f24357008f_23d729a6844a442b89e4634ffd18872f_CommandTarget;

		private Enemy_TP_GateBoss _96928f9678c3c4d499d936f24357008f_1f77773ef7d14302aa68056b2d041ae7_CommandTarget;

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

		private void BakeCommandBinding__96928f9678c3c4d499d936f24357008f_2a46a2778ae54c7d8230a21eb72e7926(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__96928f9678c3c4d499d936f24357008f_2a46a2778ae54c7d8230a21eb72e7926(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__96928f9678c3c4d499d936f24357008f_2a46a2778ae54c7d8230a21eb72e7926(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__96928f9678c3c4d499d936f24357008f_2a46a2778ae54c7d8230a21eb72e7926(_96928f9678c3c4d499d936f24357008f_2a46a2778ae54c7d8230a21eb72e7926 command)
		{
		}

		private void BakeCommandBinding__96928f9678c3c4d499d936f24357008f_23d729a6844a442b89e4634ffd18872f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__96928f9678c3c4d499d936f24357008f_23d729a6844a442b89e4634ffd18872f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__96928f9678c3c4d499d936f24357008f_23d729a6844a442b89e4634ffd18872f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__96928f9678c3c4d499d936f24357008f_23d729a6844a442b89e4634ffd18872f(_96928f9678c3c4d499d936f24357008f_23d729a6844a442b89e4634ffd18872f command)
		{
		}

		private void BakeCommandBinding__96928f9678c3c4d499d936f24357008f_1f77773ef7d14302aa68056b2d041ae7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__96928f9678c3c4d499d936f24357008f_1f77773ef7d14302aa68056b2d041ae7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__96928f9678c3c4d499d936f24357008f_1f77773ef7d14302aa68056b2d041ae7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__96928f9678c3c4d499d936f24357008f_1f77773ef7d14302aa68056b2d041ae7(_96928f9678c3c4d499d936f24357008f_1f77773ef7d14302aa68056b2d041ae7 command)
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
