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
	public class CoherenceSync_b79ab106a70059543a672326cdcc611b : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _b79ab106a70059543a672326cdcc611b_cc53a57ec8fd4876805e13a186ab9343_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_ebf1307d9eef4cc28682710d19b402c6_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_6bd438bb1d58436599fc59d2375f6c18_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_acbebad17d384439a854e4d603695b61_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_858d45abba4347efbb545e2387871f59_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_e6cf56bbb1d543939bf6216e71f7b892_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_11890f486e804ce9b82a114aa503dbc9_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_cee82a1da98d48b4b1ecaa65c12d9dee_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_f2864716a3274a4ba6023058c7ab5a03_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_ff41d63738dd49dbbddebac637a24093_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_9578438e41154a1484b4f9e5e7eadd99_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_f0621fc7be054a8fa876a7fd81cc9c6b_CommandTarget;

		private CharacterController _b79ab106a70059543a672326cdcc611b_e97db67f85654fb296177fa87d147a9c_CommandTarget;

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

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_cc53a57ec8fd4876805e13a186ab9343(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_cc53a57ec8fd4876805e13a186ab9343(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_cc53a57ec8fd4876805e13a186ab9343(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_cc53a57ec8fd4876805e13a186ab9343(_b79ab106a70059543a672326cdcc611b_cc53a57ec8fd4876805e13a186ab9343 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_ebf1307d9eef4cc28682710d19b402c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_ebf1307d9eef4cc28682710d19b402c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_ebf1307d9eef4cc28682710d19b402c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_ebf1307d9eef4cc28682710d19b402c6(_b79ab106a70059543a672326cdcc611b_ebf1307d9eef4cc28682710d19b402c6 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_6bd438bb1d58436599fc59d2375f6c18(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_6bd438bb1d58436599fc59d2375f6c18(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_6bd438bb1d58436599fc59d2375f6c18(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_6bd438bb1d58436599fc59d2375f6c18(_b79ab106a70059543a672326cdcc611b_6bd438bb1d58436599fc59d2375f6c18 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_acbebad17d384439a854e4d603695b61(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_acbebad17d384439a854e4d603695b61(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_acbebad17d384439a854e4d603695b61(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_acbebad17d384439a854e4d603695b61(_b79ab106a70059543a672326cdcc611b_acbebad17d384439a854e4d603695b61 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_858d45abba4347efbb545e2387871f59(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_858d45abba4347efbb545e2387871f59(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_858d45abba4347efbb545e2387871f59(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_858d45abba4347efbb545e2387871f59(_b79ab106a70059543a672326cdcc611b_858d45abba4347efbb545e2387871f59 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_e6cf56bbb1d543939bf6216e71f7b892(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_e6cf56bbb1d543939bf6216e71f7b892(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_e6cf56bbb1d543939bf6216e71f7b892(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_e6cf56bbb1d543939bf6216e71f7b892(_b79ab106a70059543a672326cdcc611b_e6cf56bbb1d543939bf6216e71f7b892 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_11890f486e804ce9b82a114aa503dbc9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_11890f486e804ce9b82a114aa503dbc9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_11890f486e804ce9b82a114aa503dbc9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_11890f486e804ce9b82a114aa503dbc9(_b79ab106a70059543a672326cdcc611b_11890f486e804ce9b82a114aa503dbc9 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_cee82a1da98d48b4b1ecaa65c12d9dee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_cee82a1da98d48b4b1ecaa65c12d9dee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_cee82a1da98d48b4b1ecaa65c12d9dee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_cee82a1da98d48b4b1ecaa65c12d9dee(_b79ab106a70059543a672326cdcc611b_cee82a1da98d48b4b1ecaa65c12d9dee command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_f2864716a3274a4ba6023058c7ab5a03(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_f2864716a3274a4ba6023058c7ab5a03(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_f2864716a3274a4ba6023058c7ab5a03(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_f2864716a3274a4ba6023058c7ab5a03(_b79ab106a70059543a672326cdcc611b_f2864716a3274a4ba6023058c7ab5a03 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_ff41d63738dd49dbbddebac637a24093(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_ff41d63738dd49dbbddebac637a24093(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_ff41d63738dd49dbbddebac637a24093(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_ff41d63738dd49dbbddebac637a24093(_b79ab106a70059543a672326cdcc611b_ff41d63738dd49dbbddebac637a24093 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_9578438e41154a1484b4f9e5e7eadd99(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_9578438e41154a1484b4f9e5e7eadd99(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_9578438e41154a1484b4f9e5e7eadd99(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_9578438e41154a1484b4f9e5e7eadd99(_b79ab106a70059543a672326cdcc611b_9578438e41154a1484b4f9e5e7eadd99 command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_f0621fc7be054a8fa876a7fd81cc9c6b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_f0621fc7be054a8fa876a7fd81cc9c6b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_f0621fc7be054a8fa876a7fd81cc9c6b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_f0621fc7be054a8fa876a7fd81cc9c6b(_b79ab106a70059543a672326cdcc611b_f0621fc7be054a8fa876a7fd81cc9c6b command)
		{
		}

		private void BakeCommandBinding__b79ab106a70059543a672326cdcc611b_e97db67f85654fb296177fa87d147a9c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b79ab106a70059543a672326cdcc611b_e97db67f85654fb296177fa87d147a9c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b79ab106a70059543a672326cdcc611b_e97db67f85654fb296177fa87d147a9c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b79ab106a70059543a672326cdcc611b_e97db67f85654fb296177fa87d147a9c(_b79ab106a70059543a672326cdcc611b_e97db67f85654fb296177fa87d147a9c command)
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
