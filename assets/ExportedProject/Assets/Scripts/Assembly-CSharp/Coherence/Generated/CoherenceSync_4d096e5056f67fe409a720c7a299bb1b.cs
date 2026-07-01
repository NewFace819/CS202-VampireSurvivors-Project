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
	public class CoherenceSync_4d096e5056f67fe409a720c7a299bb1b : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _4d096e5056f67fe409a720c7a299bb1b_df5580177b7544f1a575d0e20e02a4e0_CommandTarget;

		private Enemy_TP_GateBoss _4d096e5056f67fe409a720c7a299bb1b_c18413967889477bb1e3deeeab97aaef_CommandTarget;

		private Enemy_TP_GateBoss _4d096e5056f67fe409a720c7a299bb1b_54819b1ec62a44a8a8421aba80ee7b82_CommandTarget;

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

		private void BakeCommandBinding__4d096e5056f67fe409a720c7a299bb1b_df5580177b7544f1a575d0e20e02a4e0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4d096e5056f67fe409a720c7a299bb1b_df5580177b7544f1a575d0e20e02a4e0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4d096e5056f67fe409a720c7a299bb1b_df5580177b7544f1a575d0e20e02a4e0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4d096e5056f67fe409a720c7a299bb1b_df5580177b7544f1a575d0e20e02a4e0(_4d096e5056f67fe409a720c7a299bb1b_df5580177b7544f1a575d0e20e02a4e0 command)
		{
		}

		private void BakeCommandBinding__4d096e5056f67fe409a720c7a299bb1b_c18413967889477bb1e3deeeab97aaef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4d096e5056f67fe409a720c7a299bb1b_c18413967889477bb1e3deeeab97aaef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4d096e5056f67fe409a720c7a299bb1b_c18413967889477bb1e3deeeab97aaef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4d096e5056f67fe409a720c7a299bb1b_c18413967889477bb1e3deeeab97aaef(_4d096e5056f67fe409a720c7a299bb1b_c18413967889477bb1e3deeeab97aaef command)
		{
		}

		private void BakeCommandBinding__4d096e5056f67fe409a720c7a299bb1b_54819b1ec62a44a8a8421aba80ee7b82(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4d096e5056f67fe409a720c7a299bb1b_54819b1ec62a44a8a8421aba80ee7b82(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4d096e5056f67fe409a720c7a299bb1b_54819b1ec62a44a8a8421aba80ee7b82(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4d096e5056f67fe409a720c7a299bb1b_54819b1ec62a44a8a8421aba80ee7b82(_4d096e5056f67fe409a720c7a299bb1b_54819b1ec62a44a8a8421aba80ee7b82 command)
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
