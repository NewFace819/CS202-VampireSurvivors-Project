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
	public class CoherenceSync_f5ea2098ba025134fbd33a39c72295c3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _f5ea2098ba025134fbd33a39c72295c3_9d2684b94ed842149be5ec49063063d2_CommandTarget;

		private NetworkPickup _f5ea2098ba025134fbd33a39c72295c3_0c8f834ff90a4df08e052e1f2e226baf_CommandTarget;

		private NetworkPickup _f5ea2098ba025134fbd33a39c72295c3_6ecee8f789d347cf9daa92a27d44f715_CommandTarget;

		private NetworkPickup _f5ea2098ba025134fbd33a39c72295c3_033eceacf92a40cb81adec14ee98eb95_CommandTarget;

		private NetworkPickup _f5ea2098ba025134fbd33a39c72295c3_27821575471c42d4bc4f7a8c8bd884e0_CommandTarget;

		private NetworkPickup _f5ea2098ba025134fbd33a39c72295c3_aca8934fb8a846bd910f62d06d3b219a_CommandTarget;

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

		private void BakeCommandBinding__f5ea2098ba025134fbd33a39c72295c3_9d2684b94ed842149be5ec49063063d2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5ea2098ba025134fbd33a39c72295c3_9d2684b94ed842149be5ec49063063d2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5ea2098ba025134fbd33a39c72295c3_9d2684b94ed842149be5ec49063063d2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5ea2098ba025134fbd33a39c72295c3_9d2684b94ed842149be5ec49063063d2(_f5ea2098ba025134fbd33a39c72295c3_9d2684b94ed842149be5ec49063063d2 command)
		{
		}

		private void BakeCommandBinding__f5ea2098ba025134fbd33a39c72295c3_0c8f834ff90a4df08e052e1f2e226baf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5ea2098ba025134fbd33a39c72295c3_0c8f834ff90a4df08e052e1f2e226baf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5ea2098ba025134fbd33a39c72295c3_0c8f834ff90a4df08e052e1f2e226baf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5ea2098ba025134fbd33a39c72295c3_0c8f834ff90a4df08e052e1f2e226baf(_f5ea2098ba025134fbd33a39c72295c3_0c8f834ff90a4df08e052e1f2e226baf command)
		{
		}

		private void BakeCommandBinding__f5ea2098ba025134fbd33a39c72295c3_6ecee8f789d347cf9daa92a27d44f715(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5ea2098ba025134fbd33a39c72295c3_6ecee8f789d347cf9daa92a27d44f715(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5ea2098ba025134fbd33a39c72295c3_6ecee8f789d347cf9daa92a27d44f715(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5ea2098ba025134fbd33a39c72295c3_6ecee8f789d347cf9daa92a27d44f715(_f5ea2098ba025134fbd33a39c72295c3_6ecee8f789d347cf9daa92a27d44f715 command)
		{
		}

		private void BakeCommandBinding__f5ea2098ba025134fbd33a39c72295c3_033eceacf92a40cb81adec14ee98eb95(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5ea2098ba025134fbd33a39c72295c3_033eceacf92a40cb81adec14ee98eb95(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5ea2098ba025134fbd33a39c72295c3_033eceacf92a40cb81adec14ee98eb95(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5ea2098ba025134fbd33a39c72295c3_033eceacf92a40cb81adec14ee98eb95(_f5ea2098ba025134fbd33a39c72295c3_033eceacf92a40cb81adec14ee98eb95 command)
		{
		}

		private void BakeCommandBinding__f5ea2098ba025134fbd33a39c72295c3_27821575471c42d4bc4f7a8c8bd884e0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5ea2098ba025134fbd33a39c72295c3_27821575471c42d4bc4f7a8c8bd884e0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5ea2098ba025134fbd33a39c72295c3_27821575471c42d4bc4f7a8c8bd884e0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5ea2098ba025134fbd33a39c72295c3_27821575471c42d4bc4f7a8c8bd884e0(_f5ea2098ba025134fbd33a39c72295c3_27821575471c42d4bc4f7a8c8bd884e0 command)
		{
		}

		private void BakeCommandBinding__f5ea2098ba025134fbd33a39c72295c3_aca8934fb8a846bd910f62d06d3b219a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f5ea2098ba025134fbd33a39c72295c3_aca8934fb8a846bd910f62d06d3b219a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f5ea2098ba025134fbd33a39c72295c3_aca8934fb8a846bd910f62d06d3b219a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f5ea2098ba025134fbd33a39c72295c3_aca8934fb8a846bd910f62d06d3b219a(_f5ea2098ba025134fbd33a39c72295c3_aca8934fb8a846bd910f62d06d3b219a command)
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
