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
	public class CoherenceSync_ad5e5782efbaa164da06c48abc22c918 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _ad5e5782efbaa164da06c48abc22c918_8c311f5f8cb5415e87c8829243ba2d21_CommandTarget;

		private Enemy_TP_GateBoss _ad5e5782efbaa164da06c48abc22c918_df7fb3bb9b8e4b84885da0ba4807a85a_CommandTarget;

		private Enemy_TP_GateBoss _ad5e5782efbaa164da06c48abc22c918_5e6dc5849dfb4b148b57f326d1d2bb6a_CommandTarget;

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

		private void BakeCommandBinding__ad5e5782efbaa164da06c48abc22c918_8c311f5f8cb5415e87c8829243ba2d21(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ad5e5782efbaa164da06c48abc22c918_8c311f5f8cb5415e87c8829243ba2d21(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ad5e5782efbaa164da06c48abc22c918_8c311f5f8cb5415e87c8829243ba2d21(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ad5e5782efbaa164da06c48abc22c918_8c311f5f8cb5415e87c8829243ba2d21(_ad5e5782efbaa164da06c48abc22c918_8c311f5f8cb5415e87c8829243ba2d21 command)
		{
		}

		private void BakeCommandBinding__ad5e5782efbaa164da06c48abc22c918_df7fb3bb9b8e4b84885da0ba4807a85a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ad5e5782efbaa164da06c48abc22c918_df7fb3bb9b8e4b84885da0ba4807a85a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ad5e5782efbaa164da06c48abc22c918_df7fb3bb9b8e4b84885da0ba4807a85a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ad5e5782efbaa164da06c48abc22c918_df7fb3bb9b8e4b84885da0ba4807a85a(_ad5e5782efbaa164da06c48abc22c918_df7fb3bb9b8e4b84885da0ba4807a85a command)
		{
		}

		private void BakeCommandBinding__ad5e5782efbaa164da06c48abc22c918_5e6dc5849dfb4b148b57f326d1d2bb6a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ad5e5782efbaa164da06c48abc22c918_5e6dc5849dfb4b148b57f326d1d2bb6a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ad5e5782efbaa164da06c48abc22c918_5e6dc5849dfb4b148b57f326d1d2bb6a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ad5e5782efbaa164da06c48abc22c918_5e6dc5849dfb4b148b57f326d1d2bb6a(_ad5e5782efbaa164da06c48abc22c918_5e6dc5849dfb4b148b57f326d1d2bb6a command)
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
