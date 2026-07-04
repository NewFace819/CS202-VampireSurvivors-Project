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
	public class CoherenceSync_a323748edc20858468d06cd02ed90273 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a323748edc20858468d06cd02ed90273_68d31167d1d9418f9170b696b4b3e6d3_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_1c3cfb5de12f46ac95bc03cb66e5ae4c_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_8ab786564d80433ab5fd17c01809d7e7_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_68c23fc1c87b4537a10a3689bc8eb12b_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_332a4cbabee34524bf9cb965a9161fb1_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_6e0de92fbfcc411da80215b0ee59d868_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_d4998d71ec5448358e6662b90a183745_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_b2639698fbbe4883b447037494989514_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_4466b797b3134715b403a1a39d9aa96a_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_595824b58da448a2ae26d19ff0f80bc7_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_5064c3c1123f492eba592cbca2429b4c_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_26b86e5c0b8c45e68a3016294e8c4d7f_CommandTarget;

		private CharacterController _a323748edc20858468d06cd02ed90273_a35ef8b73cfe4cc7aba15e1b983dea10_CommandTarget;

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

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_68d31167d1d9418f9170b696b4b3e6d3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_68d31167d1d9418f9170b696b4b3e6d3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_68d31167d1d9418f9170b696b4b3e6d3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_68d31167d1d9418f9170b696b4b3e6d3(_a323748edc20858468d06cd02ed90273_68d31167d1d9418f9170b696b4b3e6d3 command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_1c3cfb5de12f46ac95bc03cb66e5ae4c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_1c3cfb5de12f46ac95bc03cb66e5ae4c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_1c3cfb5de12f46ac95bc03cb66e5ae4c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_1c3cfb5de12f46ac95bc03cb66e5ae4c(_a323748edc20858468d06cd02ed90273_1c3cfb5de12f46ac95bc03cb66e5ae4c command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_8ab786564d80433ab5fd17c01809d7e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_8ab786564d80433ab5fd17c01809d7e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_8ab786564d80433ab5fd17c01809d7e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_8ab786564d80433ab5fd17c01809d7e7(_a323748edc20858468d06cd02ed90273_8ab786564d80433ab5fd17c01809d7e7 command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_68c23fc1c87b4537a10a3689bc8eb12b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_68c23fc1c87b4537a10a3689bc8eb12b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_68c23fc1c87b4537a10a3689bc8eb12b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_68c23fc1c87b4537a10a3689bc8eb12b(_a323748edc20858468d06cd02ed90273_68c23fc1c87b4537a10a3689bc8eb12b command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_332a4cbabee34524bf9cb965a9161fb1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_332a4cbabee34524bf9cb965a9161fb1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_332a4cbabee34524bf9cb965a9161fb1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_332a4cbabee34524bf9cb965a9161fb1(_a323748edc20858468d06cd02ed90273_332a4cbabee34524bf9cb965a9161fb1 command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_6e0de92fbfcc411da80215b0ee59d868(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_6e0de92fbfcc411da80215b0ee59d868(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_6e0de92fbfcc411da80215b0ee59d868(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_6e0de92fbfcc411da80215b0ee59d868(_a323748edc20858468d06cd02ed90273_6e0de92fbfcc411da80215b0ee59d868 command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_d4998d71ec5448358e6662b90a183745(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_d4998d71ec5448358e6662b90a183745(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_d4998d71ec5448358e6662b90a183745(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_d4998d71ec5448358e6662b90a183745(_a323748edc20858468d06cd02ed90273_d4998d71ec5448358e6662b90a183745 command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_b2639698fbbe4883b447037494989514(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_b2639698fbbe4883b447037494989514(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_b2639698fbbe4883b447037494989514(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_b2639698fbbe4883b447037494989514(_a323748edc20858468d06cd02ed90273_b2639698fbbe4883b447037494989514 command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_4466b797b3134715b403a1a39d9aa96a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_4466b797b3134715b403a1a39d9aa96a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_4466b797b3134715b403a1a39d9aa96a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_4466b797b3134715b403a1a39d9aa96a(_a323748edc20858468d06cd02ed90273_4466b797b3134715b403a1a39d9aa96a command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_595824b58da448a2ae26d19ff0f80bc7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_595824b58da448a2ae26d19ff0f80bc7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_595824b58da448a2ae26d19ff0f80bc7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_595824b58da448a2ae26d19ff0f80bc7(_a323748edc20858468d06cd02ed90273_595824b58da448a2ae26d19ff0f80bc7 command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_5064c3c1123f492eba592cbca2429b4c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_5064c3c1123f492eba592cbca2429b4c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_5064c3c1123f492eba592cbca2429b4c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_5064c3c1123f492eba592cbca2429b4c(_a323748edc20858468d06cd02ed90273_5064c3c1123f492eba592cbca2429b4c command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_26b86e5c0b8c45e68a3016294e8c4d7f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_26b86e5c0b8c45e68a3016294e8c4d7f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_26b86e5c0b8c45e68a3016294e8c4d7f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_26b86e5c0b8c45e68a3016294e8c4d7f(_a323748edc20858468d06cd02ed90273_26b86e5c0b8c45e68a3016294e8c4d7f command)
		{
		}

		private void BakeCommandBinding__a323748edc20858468d06cd02ed90273_a35ef8b73cfe4cc7aba15e1b983dea10(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a323748edc20858468d06cd02ed90273_a35ef8b73cfe4cc7aba15e1b983dea10(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a323748edc20858468d06cd02ed90273_a35ef8b73cfe4cc7aba15e1b983dea10(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a323748edc20858468d06cd02ed90273_a35ef8b73cfe4cc7aba15e1b983dea10(_a323748edc20858468d06cd02ed90273_a35ef8b73cfe4cc7aba15e1b983dea10 command)
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
