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
	public class CoherenceSync_93ed3567057e7b84e9083504ebf79a8c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_ffe69554e5fc48ac9afe87e5372b7e92_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_acbeab690f0643dfa7b558cecd8a4ede_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_e154cad59d8b427d8511ddc8d452793a_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_885fac09343748da93ee8c22c9f8cbb1_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_17fc78d41a7e410e83f4dd1c4edfbcb5_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_e9b3bd70563d4ea781e5e5ab882f6455_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_f97329c8228240e6a07ee1c4899f2b17_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_237a5175d09d4143acfcce1597571fe8_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_f63bae4fb7a14b4f9e38ea2da5d4c658_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_2da3d71c8d9e47e1b37c45554e136831_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_cea7e0a602ec47f385cd4c8244f10616_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_fc5bf0ffeced46538508731be9a0c6be_CommandTarget;

		private CharacterController _93ed3567057e7b84e9083504ebf79a8c_35b40473d27e4c03ae0667ae4d224bd4_CommandTarget;

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

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_ffe69554e5fc48ac9afe87e5372b7e92(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_ffe69554e5fc48ac9afe87e5372b7e92(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_ffe69554e5fc48ac9afe87e5372b7e92(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_ffe69554e5fc48ac9afe87e5372b7e92(_93ed3567057e7b84e9083504ebf79a8c_ffe69554e5fc48ac9afe87e5372b7e92 command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_acbeab690f0643dfa7b558cecd8a4ede(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_acbeab690f0643dfa7b558cecd8a4ede(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_acbeab690f0643dfa7b558cecd8a4ede(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_acbeab690f0643dfa7b558cecd8a4ede(_93ed3567057e7b84e9083504ebf79a8c_acbeab690f0643dfa7b558cecd8a4ede command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_e154cad59d8b427d8511ddc8d452793a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_e154cad59d8b427d8511ddc8d452793a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_e154cad59d8b427d8511ddc8d452793a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_e154cad59d8b427d8511ddc8d452793a(_93ed3567057e7b84e9083504ebf79a8c_e154cad59d8b427d8511ddc8d452793a command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_885fac09343748da93ee8c22c9f8cbb1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_885fac09343748da93ee8c22c9f8cbb1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_885fac09343748da93ee8c22c9f8cbb1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_885fac09343748da93ee8c22c9f8cbb1(_93ed3567057e7b84e9083504ebf79a8c_885fac09343748da93ee8c22c9f8cbb1 command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_17fc78d41a7e410e83f4dd1c4edfbcb5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_17fc78d41a7e410e83f4dd1c4edfbcb5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_17fc78d41a7e410e83f4dd1c4edfbcb5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_17fc78d41a7e410e83f4dd1c4edfbcb5(_93ed3567057e7b84e9083504ebf79a8c_17fc78d41a7e410e83f4dd1c4edfbcb5 command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_e9b3bd70563d4ea781e5e5ab882f6455(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_e9b3bd70563d4ea781e5e5ab882f6455(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_e9b3bd70563d4ea781e5e5ab882f6455(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_e9b3bd70563d4ea781e5e5ab882f6455(_93ed3567057e7b84e9083504ebf79a8c_e9b3bd70563d4ea781e5e5ab882f6455 command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_f97329c8228240e6a07ee1c4899f2b17(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_f97329c8228240e6a07ee1c4899f2b17(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_f97329c8228240e6a07ee1c4899f2b17(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_f97329c8228240e6a07ee1c4899f2b17(_93ed3567057e7b84e9083504ebf79a8c_f97329c8228240e6a07ee1c4899f2b17 command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_237a5175d09d4143acfcce1597571fe8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_237a5175d09d4143acfcce1597571fe8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_237a5175d09d4143acfcce1597571fe8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_237a5175d09d4143acfcce1597571fe8(_93ed3567057e7b84e9083504ebf79a8c_237a5175d09d4143acfcce1597571fe8 command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_f63bae4fb7a14b4f9e38ea2da5d4c658(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_f63bae4fb7a14b4f9e38ea2da5d4c658(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_f63bae4fb7a14b4f9e38ea2da5d4c658(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_f63bae4fb7a14b4f9e38ea2da5d4c658(_93ed3567057e7b84e9083504ebf79a8c_f63bae4fb7a14b4f9e38ea2da5d4c658 command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_2da3d71c8d9e47e1b37c45554e136831(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_2da3d71c8d9e47e1b37c45554e136831(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_2da3d71c8d9e47e1b37c45554e136831(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_2da3d71c8d9e47e1b37c45554e136831(_93ed3567057e7b84e9083504ebf79a8c_2da3d71c8d9e47e1b37c45554e136831 command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_cea7e0a602ec47f385cd4c8244f10616(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_cea7e0a602ec47f385cd4c8244f10616(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_cea7e0a602ec47f385cd4c8244f10616(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_cea7e0a602ec47f385cd4c8244f10616(_93ed3567057e7b84e9083504ebf79a8c_cea7e0a602ec47f385cd4c8244f10616 command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_fc5bf0ffeced46538508731be9a0c6be(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_fc5bf0ffeced46538508731be9a0c6be(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_fc5bf0ffeced46538508731be9a0c6be(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_fc5bf0ffeced46538508731be9a0c6be(_93ed3567057e7b84e9083504ebf79a8c_fc5bf0ffeced46538508731be9a0c6be command)
		{
		}

		private void BakeCommandBinding__93ed3567057e7b84e9083504ebf79a8c_35b40473d27e4c03ae0667ae4d224bd4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__93ed3567057e7b84e9083504ebf79a8c_35b40473d27e4c03ae0667ae4d224bd4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__93ed3567057e7b84e9083504ebf79a8c_35b40473d27e4c03ae0667ae4d224bd4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__93ed3567057e7b84e9083504ebf79a8c_35b40473d27e4c03ae0667ae4d224bd4(_93ed3567057e7b84e9083504ebf79a8c_35b40473d27e4c03ae0667ae4d224bd4 command)
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
