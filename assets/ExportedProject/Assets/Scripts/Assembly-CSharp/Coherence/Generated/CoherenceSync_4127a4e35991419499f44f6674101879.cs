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

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_4127a4e35991419499f44f6674101879 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _4127a4e35991419499f44f6674101879_d2b27e9c639c44fc866e8eff68f616de_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_ec56faacf9414b6ea07289e9302170fb_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_186ee8d8763b46b8a20aadeee9757b89_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_467e3983ce984c3ebc6784e7c3037d53_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_cac5b225be9449b4a16221b540bf5d90_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_ab40c43ecae943b59c0cf0e3b26e3ff4_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_fe6b5b65f868453ca2e66ba481dd0816_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_4f802d27de984c909fc19dd1a9d414a2_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_ddb6b283cd244e738018a1e5ac114e6e_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_3a587bdc940241ad9f2f29205becfbc7_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_2749a00b23524188891a5c679834576b_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_432c8b6884da4fcb91859cafe07d29dc_CommandTarget;

		private CharacterController _4127a4e35991419499f44f6674101879_d1a2f266415f4e5fbd342cea4f509f9b_CommandTarget;

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

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_d2b27e9c639c44fc866e8eff68f616de(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_d2b27e9c639c44fc866e8eff68f616de(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_d2b27e9c639c44fc866e8eff68f616de(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_d2b27e9c639c44fc866e8eff68f616de(_4127a4e35991419499f44f6674101879_d2b27e9c639c44fc866e8eff68f616de command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_ec56faacf9414b6ea07289e9302170fb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_ec56faacf9414b6ea07289e9302170fb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_ec56faacf9414b6ea07289e9302170fb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_ec56faacf9414b6ea07289e9302170fb(_4127a4e35991419499f44f6674101879_ec56faacf9414b6ea07289e9302170fb command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_186ee8d8763b46b8a20aadeee9757b89(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_186ee8d8763b46b8a20aadeee9757b89(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_186ee8d8763b46b8a20aadeee9757b89(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_186ee8d8763b46b8a20aadeee9757b89(_4127a4e35991419499f44f6674101879_186ee8d8763b46b8a20aadeee9757b89 command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_467e3983ce984c3ebc6784e7c3037d53(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_467e3983ce984c3ebc6784e7c3037d53(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_467e3983ce984c3ebc6784e7c3037d53(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_467e3983ce984c3ebc6784e7c3037d53(_4127a4e35991419499f44f6674101879_467e3983ce984c3ebc6784e7c3037d53 command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_cac5b225be9449b4a16221b540bf5d90(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_cac5b225be9449b4a16221b540bf5d90(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_cac5b225be9449b4a16221b540bf5d90(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_cac5b225be9449b4a16221b540bf5d90(_4127a4e35991419499f44f6674101879_cac5b225be9449b4a16221b540bf5d90 command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_ab40c43ecae943b59c0cf0e3b26e3ff4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_ab40c43ecae943b59c0cf0e3b26e3ff4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_ab40c43ecae943b59c0cf0e3b26e3ff4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_ab40c43ecae943b59c0cf0e3b26e3ff4(_4127a4e35991419499f44f6674101879_ab40c43ecae943b59c0cf0e3b26e3ff4 command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_fe6b5b65f868453ca2e66ba481dd0816(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_fe6b5b65f868453ca2e66ba481dd0816(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_fe6b5b65f868453ca2e66ba481dd0816(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_fe6b5b65f868453ca2e66ba481dd0816(_4127a4e35991419499f44f6674101879_fe6b5b65f868453ca2e66ba481dd0816 command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_4f802d27de984c909fc19dd1a9d414a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_4f802d27de984c909fc19dd1a9d414a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_4f802d27de984c909fc19dd1a9d414a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_4f802d27de984c909fc19dd1a9d414a2(_4127a4e35991419499f44f6674101879_4f802d27de984c909fc19dd1a9d414a2 command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_ddb6b283cd244e738018a1e5ac114e6e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_ddb6b283cd244e738018a1e5ac114e6e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_ddb6b283cd244e738018a1e5ac114e6e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_ddb6b283cd244e738018a1e5ac114e6e(_4127a4e35991419499f44f6674101879_ddb6b283cd244e738018a1e5ac114e6e command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_3a587bdc940241ad9f2f29205becfbc7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_3a587bdc940241ad9f2f29205becfbc7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_3a587bdc940241ad9f2f29205becfbc7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_3a587bdc940241ad9f2f29205becfbc7(_4127a4e35991419499f44f6674101879_3a587bdc940241ad9f2f29205becfbc7 command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_2749a00b23524188891a5c679834576b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_2749a00b23524188891a5c679834576b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_2749a00b23524188891a5c679834576b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_2749a00b23524188891a5c679834576b(_4127a4e35991419499f44f6674101879_2749a00b23524188891a5c679834576b command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_432c8b6884da4fcb91859cafe07d29dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_432c8b6884da4fcb91859cafe07d29dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_432c8b6884da4fcb91859cafe07d29dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_432c8b6884da4fcb91859cafe07d29dc(_4127a4e35991419499f44f6674101879_432c8b6884da4fcb91859cafe07d29dc command)
		{
		}

		private void BakeCommandBinding__4127a4e35991419499f44f6674101879_d1a2f266415f4e5fbd342cea4f509f9b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4127a4e35991419499f44f6674101879_d1a2f266415f4e5fbd342cea4f509f9b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4127a4e35991419499f44f6674101879_d1a2f266415f4e5fbd342cea4f509f9b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4127a4e35991419499f44f6674101879_d1a2f266415f4e5fbd342cea4f509f9b(_4127a4e35991419499f44f6674101879_d1a2f266415f4e5fbd342cea4f509f9b command)
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
