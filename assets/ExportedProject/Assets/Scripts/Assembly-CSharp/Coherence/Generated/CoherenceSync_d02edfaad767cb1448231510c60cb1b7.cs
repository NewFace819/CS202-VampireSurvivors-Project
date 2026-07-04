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
	public class CoherenceSync_d02edfaad767cb1448231510c60cb1b7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _d02edfaad767cb1448231510c60cb1b7_ed3f4eb9a95a4585b6227ec5a6f10c3f_CommandTarget;

		private Enemy_TP_GateBoss _d02edfaad767cb1448231510c60cb1b7_6aa1d455d9fb4bccb8857a4181432279_CommandTarget;

		private Enemy_TP_GateBoss _d02edfaad767cb1448231510c60cb1b7_fae54d20ac1b483da4823f3ee5e13b62_CommandTarget;

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

		private void BakeCommandBinding__d02edfaad767cb1448231510c60cb1b7_ed3f4eb9a95a4585b6227ec5a6f10c3f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d02edfaad767cb1448231510c60cb1b7_ed3f4eb9a95a4585b6227ec5a6f10c3f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d02edfaad767cb1448231510c60cb1b7_ed3f4eb9a95a4585b6227ec5a6f10c3f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d02edfaad767cb1448231510c60cb1b7_ed3f4eb9a95a4585b6227ec5a6f10c3f(_d02edfaad767cb1448231510c60cb1b7_ed3f4eb9a95a4585b6227ec5a6f10c3f command)
		{
		}

		private void BakeCommandBinding__d02edfaad767cb1448231510c60cb1b7_6aa1d455d9fb4bccb8857a4181432279(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d02edfaad767cb1448231510c60cb1b7_6aa1d455d9fb4bccb8857a4181432279(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d02edfaad767cb1448231510c60cb1b7_6aa1d455d9fb4bccb8857a4181432279(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d02edfaad767cb1448231510c60cb1b7_6aa1d455d9fb4bccb8857a4181432279(_d02edfaad767cb1448231510c60cb1b7_6aa1d455d9fb4bccb8857a4181432279 command)
		{
		}

		private void BakeCommandBinding__d02edfaad767cb1448231510c60cb1b7_fae54d20ac1b483da4823f3ee5e13b62(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d02edfaad767cb1448231510c60cb1b7_fae54d20ac1b483da4823f3ee5e13b62(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d02edfaad767cb1448231510c60cb1b7_fae54d20ac1b483da4823f3ee5e13b62(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d02edfaad767cb1448231510c60cb1b7_fae54d20ac1b483da4823f3ee5e13b62(_d02edfaad767cb1448231510c60cb1b7_fae54d20ac1b483da4823f3ee5e13b62 command)
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
