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
	public class CoherenceSync_5e3e58d5412a64640aa3c145df0b642b : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_86cba6821d4846fb806b416449113068_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_8367261b886c4598b32bd1ab18340632_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_d7525228543245aabe214200528ef824_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_c334c6ee718b4318b3994d1f73bdc88b_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_818cf9a542d04bb9842fc6170b26cf10_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_753eac8703814fe699bc694c4e653179_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_ebf42ad759b547ddb220b6d64b0d0e5c_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_b0d713b362d844718aeaff4aacbe7999_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_e63aa63296b44e01af55c2e1c7e4c376_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_68e9cc32ba5242ae9562783f73616b3d_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_58bc34cbb0764bae89d3ed812bd582de_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_f6f476627957475da1c16726f70c30e6_CommandTarget;

		private CharacterController _5e3e58d5412a64640aa3c145df0b642b_6218d227e00e4e77a9c1f5eecb535601_CommandTarget;

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

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_86cba6821d4846fb806b416449113068(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_86cba6821d4846fb806b416449113068(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_86cba6821d4846fb806b416449113068(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_86cba6821d4846fb806b416449113068(_5e3e58d5412a64640aa3c145df0b642b_86cba6821d4846fb806b416449113068 command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_8367261b886c4598b32bd1ab18340632(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_8367261b886c4598b32bd1ab18340632(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_8367261b886c4598b32bd1ab18340632(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_8367261b886c4598b32bd1ab18340632(_5e3e58d5412a64640aa3c145df0b642b_8367261b886c4598b32bd1ab18340632 command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_d7525228543245aabe214200528ef824(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_d7525228543245aabe214200528ef824(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_d7525228543245aabe214200528ef824(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_d7525228543245aabe214200528ef824(_5e3e58d5412a64640aa3c145df0b642b_d7525228543245aabe214200528ef824 command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_c334c6ee718b4318b3994d1f73bdc88b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_c334c6ee718b4318b3994d1f73bdc88b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_c334c6ee718b4318b3994d1f73bdc88b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_c334c6ee718b4318b3994d1f73bdc88b(_5e3e58d5412a64640aa3c145df0b642b_c334c6ee718b4318b3994d1f73bdc88b command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_818cf9a542d04bb9842fc6170b26cf10(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_818cf9a542d04bb9842fc6170b26cf10(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_818cf9a542d04bb9842fc6170b26cf10(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_818cf9a542d04bb9842fc6170b26cf10(_5e3e58d5412a64640aa3c145df0b642b_818cf9a542d04bb9842fc6170b26cf10 command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_753eac8703814fe699bc694c4e653179(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_753eac8703814fe699bc694c4e653179(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_753eac8703814fe699bc694c4e653179(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_753eac8703814fe699bc694c4e653179(_5e3e58d5412a64640aa3c145df0b642b_753eac8703814fe699bc694c4e653179 command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_ebf42ad759b547ddb220b6d64b0d0e5c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_ebf42ad759b547ddb220b6d64b0d0e5c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_ebf42ad759b547ddb220b6d64b0d0e5c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_ebf42ad759b547ddb220b6d64b0d0e5c(_5e3e58d5412a64640aa3c145df0b642b_ebf42ad759b547ddb220b6d64b0d0e5c command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_b0d713b362d844718aeaff4aacbe7999(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_b0d713b362d844718aeaff4aacbe7999(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_b0d713b362d844718aeaff4aacbe7999(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_b0d713b362d844718aeaff4aacbe7999(_5e3e58d5412a64640aa3c145df0b642b_b0d713b362d844718aeaff4aacbe7999 command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_e63aa63296b44e01af55c2e1c7e4c376(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_e63aa63296b44e01af55c2e1c7e4c376(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_e63aa63296b44e01af55c2e1c7e4c376(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_e63aa63296b44e01af55c2e1c7e4c376(_5e3e58d5412a64640aa3c145df0b642b_e63aa63296b44e01af55c2e1c7e4c376 command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_68e9cc32ba5242ae9562783f73616b3d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_68e9cc32ba5242ae9562783f73616b3d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_68e9cc32ba5242ae9562783f73616b3d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_68e9cc32ba5242ae9562783f73616b3d(_5e3e58d5412a64640aa3c145df0b642b_68e9cc32ba5242ae9562783f73616b3d command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_58bc34cbb0764bae89d3ed812bd582de(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_58bc34cbb0764bae89d3ed812bd582de(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_58bc34cbb0764bae89d3ed812bd582de(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_58bc34cbb0764bae89d3ed812bd582de(_5e3e58d5412a64640aa3c145df0b642b_58bc34cbb0764bae89d3ed812bd582de command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_f6f476627957475da1c16726f70c30e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_f6f476627957475da1c16726f70c30e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_f6f476627957475da1c16726f70c30e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_f6f476627957475da1c16726f70c30e6(_5e3e58d5412a64640aa3c145df0b642b_f6f476627957475da1c16726f70c30e6 command)
		{
		}

		private void BakeCommandBinding__5e3e58d5412a64640aa3c145df0b642b_6218d227e00e4e77a9c1f5eecb535601(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5e3e58d5412a64640aa3c145df0b642b_6218d227e00e4e77a9c1f5eecb535601(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5e3e58d5412a64640aa3c145df0b642b_6218d227e00e4e77a9c1f5eecb535601(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5e3e58d5412a64640aa3c145df0b642b_6218d227e00e4e77a9c1f5eecb535601(_5e3e58d5412a64640aa3c145df0b642b_6218d227e00e4e77a9c1f5eecb535601 command)
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
