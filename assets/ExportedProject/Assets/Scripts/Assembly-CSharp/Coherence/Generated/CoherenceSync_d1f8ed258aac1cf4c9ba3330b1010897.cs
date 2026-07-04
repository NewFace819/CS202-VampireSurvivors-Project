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
	public class CoherenceSync_d1f8ed258aac1cf4c9ba3330b1010897 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _d1f8ed258aac1cf4c9ba3330b1010897_f724ed101cc440a49a694b0958d19505_CommandTarget;

		private NetworkPickup _d1f8ed258aac1cf4c9ba3330b1010897_d6eeac68332340b390e47b7f191b1ceb_CommandTarget;

		private NetworkPickup _d1f8ed258aac1cf4c9ba3330b1010897_0666055e0eb54cbcbe3d3134b2737359_CommandTarget;

		private NetworkPickup _d1f8ed258aac1cf4c9ba3330b1010897_3990d3ac045f467f9234d4b71ce9b679_CommandTarget;

		private NetworkPickup _d1f8ed258aac1cf4c9ba3330b1010897_a8e91bfec6be46f5bfbf4d523830ce20_CommandTarget;

		private NetworkPickup _d1f8ed258aac1cf4c9ba3330b1010897_8c7b9145cf5648238173a3afdc395405_CommandTarget;

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

		private void BakeCommandBinding__d1f8ed258aac1cf4c9ba3330b1010897_f724ed101cc440a49a694b0958d19505(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d1f8ed258aac1cf4c9ba3330b1010897_f724ed101cc440a49a694b0958d19505(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d1f8ed258aac1cf4c9ba3330b1010897_f724ed101cc440a49a694b0958d19505(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d1f8ed258aac1cf4c9ba3330b1010897_f724ed101cc440a49a694b0958d19505(_d1f8ed258aac1cf4c9ba3330b1010897_f724ed101cc440a49a694b0958d19505 command)
		{
		}

		private void BakeCommandBinding__d1f8ed258aac1cf4c9ba3330b1010897_d6eeac68332340b390e47b7f191b1ceb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d1f8ed258aac1cf4c9ba3330b1010897_d6eeac68332340b390e47b7f191b1ceb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d1f8ed258aac1cf4c9ba3330b1010897_d6eeac68332340b390e47b7f191b1ceb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d1f8ed258aac1cf4c9ba3330b1010897_d6eeac68332340b390e47b7f191b1ceb(_d1f8ed258aac1cf4c9ba3330b1010897_d6eeac68332340b390e47b7f191b1ceb command)
		{
		}

		private void BakeCommandBinding__d1f8ed258aac1cf4c9ba3330b1010897_0666055e0eb54cbcbe3d3134b2737359(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d1f8ed258aac1cf4c9ba3330b1010897_0666055e0eb54cbcbe3d3134b2737359(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d1f8ed258aac1cf4c9ba3330b1010897_0666055e0eb54cbcbe3d3134b2737359(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d1f8ed258aac1cf4c9ba3330b1010897_0666055e0eb54cbcbe3d3134b2737359(_d1f8ed258aac1cf4c9ba3330b1010897_0666055e0eb54cbcbe3d3134b2737359 command)
		{
		}

		private void BakeCommandBinding__d1f8ed258aac1cf4c9ba3330b1010897_3990d3ac045f467f9234d4b71ce9b679(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d1f8ed258aac1cf4c9ba3330b1010897_3990d3ac045f467f9234d4b71ce9b679(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d1f8ed258aac1cf4c9ba3330b1010897_3990d3ac045f467f9234d4b71ce9b679(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d1f8ed258aac1cf4c9ba3330b1010897_3990d3ac045f467f9234d4b71ce9b679(_d1f8ed258aac1cf4c9ba3330b1010897_3990d3ac045f467f9234d4b71ce9b679 command)
		{
		}

		private void BakeCommandBinding__d1f8ed258aac1cf4c9ba3330b1010897_a8e91bfec6be46f5bfbf4d523830ce20(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d1f8ed258aac1cf4c9ba3330b1010897_a8e91bfec6be46f5bfbf4d523830ce20(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d1f8ed258aac1cf4c9ba3330b1010897_a8e91bfec6be46f5bfbf4d523830ce20(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d1f8ed258aac1cf4c9ba3330b1010897_a8e91bfec6be46f5bfbf4d523830ce20(_d1f8ed258aac1cf4c9ba3330b1010897_a8e91bfec6be46f5bfbf4d523830ce20 command)
		{
		}

		private void BakeCommandBinding__d1f8ed258aac1cf4c9ba3330b1010897_8c7b9145cf5648238173a3afdc395405(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d1f8ed258aac1cf4c9ba3330b1010897_8c7b9145cf5648238173a3afdc395405(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d1f8ed258aac1cf4c9ba3330b1010897_8c7b9145cf5648238173a3afdc395405(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d1f8ed258aac1cf4c9ba3330b1010897_8c7b9145cf5648238173a3afdc395405(_d1f8ed258aac1cf4c9ba3330b1010897_8c7b9145cf5648238173a3afdc395405 command)
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
