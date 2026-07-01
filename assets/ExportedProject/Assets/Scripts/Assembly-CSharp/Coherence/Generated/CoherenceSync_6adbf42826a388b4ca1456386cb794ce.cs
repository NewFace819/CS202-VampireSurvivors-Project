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
	public class CoherenceSync_6adbf42826a388b4ca1456386cb794ce : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _6adbf42826a388b4ca1456386cb794ce_49d83b2110724b1da8f0c7c15e53f8c2_CommandTarget;

		private NetworkPickup _6adbf42826a388b4ca1456386cb794ce_7e9415f1c3df4ba69b2a8139c7ea3634_CommandTarget;

		private NetworkPickup _6adbf42826a388b4ca1456386cb794ce_f6abded9b1e44b0b9a2b7620756df706_CommandTarget;

		private NetworkPickup _6adbf42826a388b4ca1456386cb794ce_3370b15f451b41588d2c628fde0354fa_CommandTarget;

		private NetworkPickup _6adbf42826a388b4ca1456386cb794ce_ef181382c3e74e48adef805d47a50238_CommandTarget;

		private PickupCustomMerchant _6adbf42826a388b4ca1456386cb794ce_103de8dcdd1c467bb9e6b78007f7422e_CommandTarget;

		private NetworkPickup _6adbf42826a388b4ca1456386cb794ce_7acf62ddc38c46ab9b4eda43de30e345_CommandTarget;

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

		private void BakeCommandBinding__6adbf42826a388b4ca1456386cb794ce_49d83b2110724b1da8f0c7c15e53f8c2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6adbf42826a388b4ca1456386cb794ce_49d83b2110724b1da8f0c7c15e53f8c2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6adbf42826a388b4ca1456386cb794ce_49d83b2110724b1da8f0c7c15e53f8c2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6adbf42826a388b4ca1456386cb794ce_49d83b2110724b1da8f0c7c15e53f8c2(_6adbf42826a388b4ca1456386cb794ce_49d83b2110724b1da8f0c7c15e53f8c2 command)
		{
		}

		private void BakeCommandBinding__6adbf42826a388b4ca1456386cb794ce_7e9415f1c3df4ba69b2a8139c7ea3634(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6adbf42826a388b4ca1456386cb794ce_7e9415f1c3df4ba69b2a8139c7ea3634(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6adbf42826a388b4ca1456386cb794ce_7e9415f1c3df4ba69b2a8139c7ea3634(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6adbf42826a388b4ca1456386cb794ce_7e9415f1c3df4ba69b2a8139c7ea3634(_6adbf42826a388b4ca1456386cb794ce_7e9415f1c3df4ba69b2a8139c7ea3634 command)
		{
		}

		private void BakeCommandBinding__6adbf42826a388b4ca1456386cb794ce_f6abded9b1e44b0b9a2b7620756df706(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6adbf42826a388b4ca1456386cb794ce_f6abded9b1e44b0b9a2b7620756df706(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6adbf42826a388b4ca1456386cb794ce_f6abded9b1e44b0b9a2b7620756df706(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6adbf42826a388b4ca1456386cb794ce_f6abded9b1e44b0b9a2b7620756df706(_6adbf42826a388b4ca1456386cb794ce_f6abded9b1e44b0b9a2b7620756df706 command)
		{
		}

		private void BakeCommandBinding__6adbf42826a388b4ca1456386cb794ce_3370b15f451b41588d2c628fde0354fa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6adbf42826a388b4ca1456386cb794ce_3370b15f451b41588d2c628fde0354fa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6adbf42826a388b4ca1456386cb794ce_3370b15f451b41588d2c628fde0354fa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6adbf42826a388b4ca1456386cb794ce_3370b15f451b41588d2c628fde0354fa(_6adbf42826a388b4ca1456386cb794ce_3370b15f451b41588d2c628fde0354fa command)
		{
		}

		private void BakeCommandBinding__6adbf42826a388b4ca1456386cb794ce_ef181382c3e74e48adef805d47a50238(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6adbf42826a388b4ca1456386cb794ce_ef181382c3e74e48adef805d47a50238(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6adbf42826a388b4ca1456386cb794ce_ef181382c3e74e48adef805d47a50238(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6adbf42826a388b4ca1456386cb794ce_ef181382c3e74e48adef805d47a50238(_6adbf42826a388b4ca1456386cb794ce_ef181382c3e74e48adef805d47a50238 command)
		{
		}

		private void BakeCommandBinding__6adbf42826a388b4ca1456386cb794ce_103de8dcdd1c467bb9e6b78007f7422e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6adbf42826a388b4ca1456386cb794ce_103de8dcdd1c467bb9e6b78007f7422e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6adbf42826a388b4ca1456386cb794ce_103de8dcdd1c467bb9e6b78007f7422e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6adbf42826a388b4ca1456386cb794ce_103de8dcdd1c467bb9e6b78007f7422e(_6adbf42826a388b4ca1456386cb794ce_103de8dcdd1c467bb9e6b78007f7422e command)
		{
		}

		private void BakeCommandBinding__6adbf42826a388b4ca1456386cb794ce_7acf62ddc38c46ab9b4eda43de30e345(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6adbf42826a388b4ca1456386cb794ce_7acf62ddc38c46ab9b4eda43de30e345(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6adbf42826a388b4ca1456386cb794ce_7acf62ddc38c46ab9b4eda43de30e345(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6adbf42826a388b4ca1456386cb794ce_7acf62ddc38c46ab9b4eda43de30e345(_6adbf42826a388b4ca1456386cb794ce_7acf62ddc38c46ab9b4eda43de30e345 command)
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
