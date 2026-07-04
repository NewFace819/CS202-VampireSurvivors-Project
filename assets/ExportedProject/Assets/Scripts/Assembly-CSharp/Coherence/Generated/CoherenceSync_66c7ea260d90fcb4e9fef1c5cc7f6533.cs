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
using VampireSurvivors.Objects.Items;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_66c7ea260d90fcb4e9fef1c5cc7f6533 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _66c7ea260d90fcb4e9fef1c5cc7f6533_1fab1b4792474b579c5c9df92d4a7747_CommandTarget;

		private NetworkPickup _66c7ea260d90fcb4e9fef1c5cc7f6533_a2c91d12acb0413b80c7a8ac63106c00_CommandTarget;

		private NetworkPickup _66c7ea260d90fcb4e9fef1c5cc7f6533_20ed55436c394e8993538c1b6f0c32e4_CommandTarget;

		private NetworkPickup _66c7ea260d90fcb4e9fef1c5cc7f6533_3b87d1cd74f8440a9fe90a32a75e23d7_CommandTarget;

		private NetworkPickup _66c7ea260d90fcb4e9fef1c5cc7f6533_777509b2313444adb2e4e7741641402f_CommandTarget;

		private PickupCustomMerchant _66c7ea260d90fcb4e9fef1c5cc7f6533_abbd81973df049059feea419b224fe33_CommandTarget;

		private NetworkPickup _66c7ea260d90fcb4e9fef1c5cc7f6533_cc66361f27224d85ab71305619b5b258_CommandTarget;

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

		private void BakeCommandBinding__66c7ea260d90fcb4e9fef1c5cc7f6533_1fab1b4792474b579c5c9df92d4a7747(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_1fab1b4792474b579c5c9df92d4a7747(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_1fab1b4792474b579c5c9df92d4a7747(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_1fab1b4792474b579c5c9df92d4a7747(_66c7ea260d90fcb4e9fef1c5cc7f6533_1fab1b4792474b579c5c9df92d4a7747 command)
		{
		}

		private void BakeCommandBinding__66c7ea260d90fcb4e9fef1c5cc7f6533_a2c91d12acb0413b80c7a8ac63106c00(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_a2c91d12acb0413b80c7a8ac63106c00(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_a2c91d12acb0413b80c7a8ac63106c00(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_a2c91d12acb0413b80c7a8ac63106c00(_66c7ea260d90fcb4e9fef1c5cc7f6533_a2c91d12acb0413b80c7a8ac63106c00 command)
		{
		}

		private void BakeCommandBinding__66c7ea260d90fcb4e9fef1c5cc7f6533_20ed55436c394e8993538c1b6f0c32e4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_20ed55436c394e8993538c1b6f0c32e4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_20ed55436c394e8993538c1b6f0c32e4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_20ed55436c394e8993538c1b6f0c32e4(_66c7ea260d90fcb4e9fef1c5cc7f6533_20ed55436c394e8993538c1b6f0c32e4 command)
		{
		}

		private void BakeCommandBinding__66c7ea260d90fcb4e9fef1c5cc7f6533_3b87d1cd74f8440a9fe90a32a75e23d7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_3b87d1cd74f8440a9fe90a32a75e23d7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_3b87d1cd74f8440a9fe90a32a75e23d7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_3b87d1cd74f8440a9fe90a32a75e23d7(_66c7ea260d90fcb4e9fef1c5cc7f6533_3b87d1cd74f8440a9fe90a32a75e23d7 command)
		{
		}

		private void BakeCommandBinding__66c7ea260d90fcb4e9fef1c5cc7f6533_777509b2313444adb2e4e7741641402f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_777509b2313444adb2e4e7741641402f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_777509b2313444adb2e4e7741641402f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_777509b2313444adb2e4e7741641402f(_66c7ea260d90fcb4e9fef1c5cc7f6533_777509b2313444adb2e4e7741641402f command)
		{
		}

		private void BakeCommandBinding__66c7ea260d90fcb4e9fef1c5cc7f6533_abbd81973df049059feea419b224fe33(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_abbd81973df049059feea419b224fe33(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_abbd81973df049059feea419b224fe33(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_abbd81973df049059feea419b224fe33(_66c7ea260d90fcb4e9fef1c5cc7f6533_abbd81973df049059feea419b224fe33 command)
		{
		}

		private void BakeCommandBinding__66c7ea260d90fcb4e9fef1c5cc7f6533_cc66361f27224d85ab71305619b5b258(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_cc66361f27224d85ab71305619b5b258(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_cc66361f27224d85ab71305619b5b258(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66c7ea260d90fcb4e9fef1c5cc7f6533_cc66361f27224d85ab71305619b5b258(_66c7ea260d90fcb4e9fef1c5cc7f6533_cc66361f27224d85ab71305619b5b258 command)
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
