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
	public class CoherenceSync_5bbfb8ed35f3b234082c40faf0685128 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _5bbfb8ed35f3b234082c40faf0685128_14212107831845cca70269f4f55d8e82_CommandTarget;

		private NetworkPickup _5bbfb8ed35f3b234082c40faf0685128_9093d09ede884ebeab1372a83866f27a_CommandTarget;

		private NetworkPickup _5bbfb8ed35f3b234082c40faf0685128_acff1f4f3f554118a764e11f8254ca50_CommandTarget;

		private NetworkPickup _5bbfb8ed35f3b234082c40faf0685128_d2c4a0f3b4254029b5387d2108284e04_CommandTarget;

		private NetworkPickup _5bbfb8ed35f3b234082c40faf0685128_3b6a7771714047b580406e8383993b09_CommandTarget;

		private NetworkPickup _5bbfb8ed35f3b234082c40faf0685128_7af8471d1e4543c48ef0137965122078_CommandTarget;

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

		private void BakeCommandBinding__5bbfb8ed35f3b234082c40faf0685128_14212107831845cca70269f4f55d8e82(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5bbfb8ed35f3b234082c40faf0685128_14212107831845cca70269f4f55d8e82(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5bbfb8ed35f3b234082c40faf0685128_14212107831845cca70269f4f55d8e82(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5bbfb8ed35f3b234082c40faf0685128_14212107831845cca70269f4f55d8e82(_5bbfb8ed35f3b234082c40faf0685128_14212107831845cca70269f4f55d8e82 command)
		{
		}

		private void BakeCommandBinding__5bbfb8ed35f3b234082c40faf0685128_9093d09ede884ebeab1372a83866f27a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5bbfb8ed35f3b234082c40faf0685128_9093d09ede884ebeab1372a83866f27a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5bbfb8ed35f3b234082c40faf0685128_9093d09ede884ebeab1372a83866f27a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5bbfb8ed35f3b234082c40faf0685128_9093d09ede884ebeab1372a83866f27a(_5bbfb8ed35f3b234082c40faf0685128_9093d09ede884ebeab1372a83866f27a command)
		{
		}

		private void BakeCommandBinding__5bbfb8ed35f3b234082c40faf0685128_acff1f4f3f554118a764e11f8254ca50(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5bbfb8ed35f3b234082c40faf0685128_acff1f4f3f554118a764e11f8254ca50(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5bbfb8ed35f3b234082c40faf0685128_acff1f4f3f554118a764e11f8254ca50(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5bbfb8ed35f3b234082c40faf0685128_acff1f4f3f554118a764e11f8254ca50(_5bbfb8ed35f3b234082c40faf0685128_acff1f4f3f554118a764e11f8254ca50 command)
		{
		}

		private void BakeCommandBinding__5bbfb8ed35f3b234082c40faf0685128_d2c4a0f3b4254029b5387d2108284e04(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5bbfb8ed35f3b234082c40faf0685128_d2c4a0f3b4254029b5387d2108284e04(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5bbfb8ed35f3b234082c40faf0685128_d2c4a0f3b4254029b5387d2108284e04(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5bbfb8ed35f3b234082c40faf0685128_d2c4a0f3b4254029b5387d2108284e04(_5bbfb8ed35f3b234082c40faf0685128_d2c4a0f3b4254029b5387d2108284e04 command)
		{
		}

		private void BakeCommandBinding__5bbfb8ed35f3b234082c40faf0685128_3b6a7771714047b580406e8383993b09(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5bbfb8ed35f3b234082c40faf0685128_3b6a7771714047b580406e8383993b09(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5bbfb8ed35f3b234082c40faf0685128_3b6a7771714047b580406e8383993b09(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5bbfb8ed35f3b234082c40faf0685128_3b6a7771714047b580406e8383993b09(_5bbfb8ed35f3b234082c40faf0685128_3b6a7771714047b580406e8383993b09 command)
		{
		}

		private void BakeCommandBinding__5bbfb8ed35f3b234082c40faf0685128_7af8471d1e4543c48ef0137965122078(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5bbfb8ed35f3b234082c40faf0685128_7af8471d1e4543c48ef0137965122078(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5bbfb8ed35f3b234082c40faf0685128_7af8471d1e4543c48ef0137965122078(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5bbfb8ed35f3b234082c40faf0685128_7af8471d1e4543c48ef0137965122078(_5bbfb8ed35f3b234082c40faf0685128_7af8471d1e4543c48ef0137965122078 command)
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
