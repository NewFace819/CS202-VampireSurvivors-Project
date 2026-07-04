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
	public class CoherenceSync_a42f156792f891e4186ebc6d96ec8f5f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_5872a128a9b44d7d90fe6b8f0c48d8c4_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_69fea2cb1a884218b0218761a548e2d7_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_f7186061b5b94edb95df26e01a7f65c4_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_2102c44d929f4c9f8a2a031986bfc7b8_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_eaf86bedad404de583db7c0c8dcd784a_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_f9601f45b956409daf9cf41d59942a8f_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_ec720cce671e4848a39276a35371ee5f_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_14478094af324913a148e8636dc132d9_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_f9363ea5c9554e04aa6ebf0edcc1d9f5_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_b711932ca90246e6bfc1a1f0bdc4f662_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_07758bcdbb8141ed8eb78b5a8004850d_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_0d3b87adbecb4c1b85a756751e924d9e_CommandTarget;

		private CharacterController _a42f156792f891e4186ebc6d96ec8f5f_8451895b38b744cb9d139914279f3c4d_CommandTarget;

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

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_5872a128a9b44d7d90fe6b8f0c48d8c4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_5872a128a9b44d7d90fe6b8f0c48d8c4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_5872a128a9b44d7d90fe6b8f0c48d8c4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_5872a128a9b44d7d90fe6b8f0c48d8c4(_a42f156792f891e4186ebc6d96ec8f5f_5872a128a9b44d7d90fe6b8f0c48d8c4 command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_69fea2cb1a884218b0218761a548e2d7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_69fea2cb1a884218b0218761a548e2d7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_69fea2cb1a884218b0218761a548e2d7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_69fea2cb1a884218b0218761a548e2d7(_a42f156792f891e4186ebc6d96ec8f5f_69fea2cb1a884218b0218761a548e2d7 command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_f7186061b5b94edb95df26e01a7f65c4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_f7186061b5b94edb95df26e01a7f65c4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_f7186061b5b94edb95df26e01a7f65c4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_f7186061b5b94edb95df26e01a7f65c4(_a42f156792f891e4186ebc6d96ec8f5f_f7186061b5b94edb95df26e01a7f65c4 command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_2102c44d929f4c9f8a2a031986bfc7b8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_2102c44d929f4c9f8a2a031986bfc7b8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_2102c44d929f4c9f8a2a031986bfc7b8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_2102c44d929f4c9f8a2a031986bfc7b8(_a42f156792f891e4186ebc6d96ec8f5f_2102c44d929f4c9f8a2a031986bfc7b8 command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_eaf86bedad404de583db7c0c8dcd784a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_eaf86bedad404de583db7c0c8dcd784a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_eaf86bedad404de583db7c0c8dcd784a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_eaf86bedad404de583db7c0c8dcd784a(_a42f156792f891e4186ebc6d96ec8f5f_eaf86bedad404de583db7c0c8dcd784a command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_f9601f45b956409daf9cf41d59942a8f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_f9601f45b956409daf9cf41d59942a8f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_f9601f45b956409daf9cf41d59942a8f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_f9601f45b956409daf9cf41d59942a8f(_a42f156792f891e4186ebc6d96ec8f5f_f9601f45b956409daf9cf41d59942a8f command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_ec720cce671e4848a39276a35371ee5f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_ec720cce671e4848a39276a35371ee5f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_ec720cce671e4848a39276a35371ee5f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_ec720cce671e4848a39276a35371ee5f(_a42f156792f891e4186ebc6d96ec8f5f_ec720cce671e4848a39276a35371ee5f command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_14478094af324913a148e8636dc132d9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_14478094af324913a148e8636dc132d9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_14478094af324913a148e8636dc132d9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_14478094af324913a148e8636dc132d9(_a42f156792f891e4186ebc6d96ec8f5f_14478094af324913a148e8636dc132d9 command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_f9363ea5c9554e04aa6ebf0edcc1d9f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_f9363ea5c9554e04aa6ebf0edcc1d9f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_f9363ea5c9554e04aa6ebf0edcc1d9f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_f9363ea5c9554e04aa6ebf0edcc1d9f5(_a42f156792f891e4186ebc6d96ec8f5f_f9363ea5c9554e04aa6ebf0edcc1d9f5 command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_b711932ca90246e6bfc1a1f0bdc4f662(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_b711932ca90246e6bfc1a1f0bdc4f662(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_b711932ca90246e6bfc1a1f0bdc4f662(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_b711932ca90246e6bfc1a1f0bdc4f662(_a42f156792f891e4186ebc6d96ec8f5f_b711932ca90246e6bfc1a1f0bdc4f662 command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_07758bcdbb8141ed8eb78b5a8004850d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_07758bcdbb8141ed8eb78b5a8004850d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_07758bcdbb8141ed8eb78b5a8004850d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_07758bcdbb8141ed8eb78b5a8004850d(_a42f156792f891e4186ebc6d96ec8f5f_07758bcdbb8141ed8eb78b5a8004850d command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_0d3b87adbecb4c1b85a756751e924d9e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_0d3b87adbecb4c1b85a756751e924d9e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_0d3b87adbecb4c1b85a756751e924d9e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_0d3b87adbecb4c1b85a756751e924d9e(_a42f156792f891e4186ebc6d96ec8f5f_0d3b87adbecb4c1b85a756751e924d9e command)
		{
		}

		private void BakeCommandBinding__a42f156792f891e4186ebc6d96ec8f5f_8451895b38b744cb9d139914279f3c4d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a42f156792f891e4186ebc6d96ec8f5f_8451895b38b744cb9d139914279f3c4d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a42f156792f891e4186ebc6d96ec8f5f_8451895b38b744cb9d139914279f3c4d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a42f156792f891e4186ebc6d96ec8f5f_8451895b38b744cb9d139914279f3c4d(_a42f156792f891e4186ebc6d96ec8f5f_8451895b38b744cb9d139914279f3c4d command)
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
