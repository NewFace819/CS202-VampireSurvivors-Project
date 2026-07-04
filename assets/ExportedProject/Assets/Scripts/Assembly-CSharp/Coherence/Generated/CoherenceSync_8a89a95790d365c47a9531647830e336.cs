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
	public class CoherenceSync_8a89a95790d365c47a9531647830e336 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _8a89a95790d365c47a9531647830e336_c9f74bf4293146ae8fe4223183976cc3_CommandTarget;

		private NetworkPickup _8a89a95790d365c47a9531647830e336_879e49b0fa574eb78cf79e680ee70f24_CommandTarget;

		private PickupMerchant _8a89a95790d365c47a9531647830e336_f438df3496f14255918063eee2718667_CommandTarget;

		private PickupMerchant _8a89a95790d365c47a9531647830e336_46bcca00cc944f5aac527bc1a2ba6394_CommandTarget;

		private NetworkPickup _8a89a95790d365c47a9531647830e336_127e28f9465b4c94ae1f10019d7b4e20_CommandTarget;

		private NetworkPickup _8a89a95790d365c47a9531647830e336_c1422abbf0f54bd1a6f511da7033202a_CommandTarget;

		private NetworkPickup _8a89a95790d365c47a9531647830e336_1520271637a34d16bdff4f9b937944d2_CommandTarget;

		private NetworkPickup _8a89a95790d365c47a9531647830e336_ac9b8d4a584544c897d78e7204fbbdb3_CommandTarget;

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

		private void BakeCommandBinding__8a89a95790d365c47a9531647830e336_c9f74bf4293146ae8fe4223183976cc3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8a89a95790d365c47a9531647830e336_c9f74bf4293146ae8fe4223183976cc3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8a89a95790d365c47a9531647830e336_c9f74bf4293146ae8fe4223183976cc3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8a89a95790d365c47a9531647830e336_c9f74bf4293146ae8fe4223183976cc3(_8a89a95790d365c47a9531647830e336_c9f74bf4293146ae8fe4223183976cc3 command)
		{
		}

		private void BakeCommandBinding__8a89a95790d365c47a9531647830e336_879e49b0fa574eb78cf79e680ee70f24(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8a89a95790d365c47a9531647830e336_879e49b0fa574eb78cf79e680ee70f24(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8a89a95790d365c47a9531647830e336_879e49b0fa574eb78cf79e680ee70f24(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8a89a95790d365c47a9531647830e336_879e49b0fa574eb78cf79e680ee70f24(_8a89a95790d365c47a9531647830e336_879e49b0fa574eb78cf79e680ee70f24 command)
		{
		}

		private void BakeCommandBinding__8a89a95790d365c47a9531647830e336_f438df3496f14255918063eee2718667(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8a89a95790d365c47a9531647830e336_f438df3496f14255918063eee2718667(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8a89a95790d365c47a9531647830e336_f438df3496f14255918063eee2718667(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8a89a95790d365c47a9531647830e336_f438df3496f14255918063eee2718667(_8a89a95790d365c47a9531647830e336_f438df3496f14255918063eee2718667 command)
		{
		}

		private void BakeCommandBinding__8a89a95790d365c47a9531647830e336_46bcca00cc944f5aac527bc1a2ba6394(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8a89a95790d365c47a9531647830e336_46bcca00cc944f5aac527bc1a2ba6394(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8a89a95790d365c47a9531647830e336_46bcca00cc944f5aac527bc1a2ba6394(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8a89a95790d365c47a9531647830e336_46bcca00cc944f5aac527bc1a2ba6394(_8a89a95790d365c47a9531647830e336_46bcca00cc944f5aac527bc1a2ba6394 command)
		{
		}

		private void BakeCommandBinding__8a89a95790d365c47a9531647830e336_127e28f9465b4c94ae1f10019d7b4e20(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8a89a95790d365c47a9531647830e336_127e28f9465b4c94ae1f10019d7b4e20(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8a89a95790d365c47a9531647830e336_127e28f9465b4c94ae1f10019d7b4e20(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8a89a95790d365c47a9531647830e336_127e28f9465b4c94ae1f10019d7b4e20(_8a89a95790d365c47a9531647830e336_127e28f9465b4c94ae1f10019d7b4e20 command)
		{
		}

		private void BakeCommandBinding__8a89a95790d365c47a9531647830e336_c1422abbf0f54bd1a6f511da7033202a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8a89a95790d365c47a9531647830e336_c1422abbf0f54bd1a6f511da7033202a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8a89a95790d365c47a9531647830e336_c1422abbf0f54bd1a6f511da7033202a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8a89a95790d365c47a9531647830e336_c1422abbf0f54bd1a6f511da7033202a(_8a89a95790d365c47a9531647830e336_c1422abbf0f54bd1a6f511da7033202a command)
		{
		}

		private void BakeCommandBinding__8a89a95790d365c47a9531647830e336_1520271637a34d16bdff4f9b937944d2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8a89a95790d365c47a9531647830e336_1520271637a34d16bdff4f9b937944d2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8a89a95790d365c47a9531647830e336_1520271637a34d16bdff4f9b937944d2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8a89a95790d365c47a9531647830e336_1520271637a34d16bdff4f9b937944d2(_8a89a95790d365c47a9531647830e336_1520271637a34d16bdff4f9b937944d2 command)
		{
		}

		private void BakeCommandBinding__8a89a95790d365c47a9531647830e336_ac9b8d4a584544c897d78e7204fbbdb3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8a89a95790d365c47a9531647830e336_ac9b8d4a584544c897d78e7204fbbdb3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8a89a95790d365c47a9531647830e336_ac9b8d4a584544c897d78e7204fbbdb3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8a89a95790d365c47a9531647830e336_ac9b8d4a584544c897d78e7204fbbdb3(_8a89a95790d365c47a9531647830e336_ac9b8d4a584544c897d78e7204fbbdb3 command)
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
