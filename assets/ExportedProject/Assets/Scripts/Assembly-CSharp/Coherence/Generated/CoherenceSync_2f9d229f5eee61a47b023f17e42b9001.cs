using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_2f9d229f5eee61a47b023f17e42b9001 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _2f9d229f5eee61a47b023f17e42b9001_e79aad1be5c94985a79b79e4c31a6299_CommandTarget;

		private NetworkPickup _2f9d229f5eee61a47b023f17e42b9001_411dab49591c4a21ac025f75d2420cf2_CommandTarget;

		private NetworkPickup _2f9d229f5eee61a47b023f17e42b9001_7f96cf73af984f858a9a2e7de5802a26_CommandTarget;

		private NetworkPickup _2f9d229f5eee61a47b023f17e42b9001_65c8c166aa094086846a5aab75b34c65_CommandTarget;

		private NetworkPickup _2f9d229f5eee61a47b023f17e42b9001_fe4b4562dcf44445ac3a90d222a46d92_CommandTarget;

		private NetworkPickup _2f9d229f5eee61a47b023f17e42b9001_fb215dc9d11b4244891347c66e31e06b_CommandTarget;

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

		private void BakeCommandBinding__2f9d229f5eee61a47b023f17e42b9001_e79aad1be5c94985a79b79e4c31a6299(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f9d229f5eee61a47b023f17e42b9001_e79aad1be5c94985a79b79e4c31a6299(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f9d229f5eee61a47b023f17e42b9001_e79aad1be5c94985a79b79e4c31a6299(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f9d229f5eee61a47b023f17e42b9001_e79aad1be5c94985a79b79e4c31a6299(_2f9d229f5eee61a47b023f17e42b9001_e79aad1be5c94985a79b79e4c31a6299 command)
		{
		}

		private void BakeCommandBinding__2f9d229f5eee61a47b023f17e42b9001_411dab49591c4a21ac025f75d2420cf2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f9d229f5eee61a47b023f17e42b9001_411dab49591c4a21ac025f75d2420cf2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f9d229f5eee61a47b023f17e42b9001_411dab49591c4a21ac025f75d2420cf2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f9d229f5eee61a47b023f17e42b9001_411dab49591c4a21ac025f75d2420cf2(_2f9d229f5eee61a47b023f17e42b9001_411dab49591c4a21ac025f75d2420cf2 command)
		{
		}

		private void BakeCommandBinding__2f9d229f5eee61a47b023f17e42b9001_7f96cf73af984f858a9a2e7de5802a26(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f9d229f5eee61a47b023f17e42b9001_7f96cf73af984f858a9a2e7de5802a26(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f9d229f5eee61a47b023f17e42b9001_7f96cf73af984f858a9a2e7de5802a26(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f9d229f5eee61a47b023f17e42b9001_7f96cf73af984f858a9a2e7de5802a26(_2f9d229f5eee61a47b023f17e42b9001_7f96cf73af984f858a9a2e7de5802a26 command)
		{
		}

		private void BakeCommandBinding__2f9d229f5eee61a47b023f17e42b9001_65c8c166aa094086846a5aab75b34c65(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f9d229f5eee61a47b023f17e42b9001_65c8c166aa094086846a5aab75b34c65(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f9d229f5eee61a47b023f17e42b9001_65c8c166aa094086846a5aab75b34c65(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f9d229f5eee61a47b023f17e42b9001_65c8c166aa094086846a5aab75b34c65(_2f9d229f5eee61a47b023f17e42b9001_65c8c166aa094086846a5aab75b34c65 command)
		{
		}

		private void BakeCommandBinding__2f9d229f5eee61a47b023f17e42b9001_fe4b4562dcf44445ac3a90d222a46d92(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f9d229f5eee61a47b023f17e42b9001_fe4b4562dcf44445ac3a90d222a46d92(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f9d229f5eee61a47b023f17e42b9001_fe4b4562dcf44445ac3a90d222a46d92(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f9d229f5eee61a47b023f17e42b9001_fe4b4562dcf44445ac3a90d222a46d92(_2f9d229f5eee61a47b023f17e42b9001_fe4b4562dcf44445ac3a90d222a46d92 command)
		{
		}

		private void BakeCommandBinding__2f9d229f5eee61a47b023f17e42b9001_fb215dc9d11b4244891347c66e31e06b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2f9d229f5eee61a47b023f17e42b9001_fb215dc9d11b4244891347c66e31e06b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2f9d229f5eee61a47b023f17e42b9001_fb215dc9d11b4244891347c66e31e06b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2f9d229f5eee61a47b023f17e42b9001_fb215dc9d11b4244891347c66e31e06b(_2f9d229f5eee61a47b023f17e42b9001_fb215dc9d11b4244891347c66e31e06b command)
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
