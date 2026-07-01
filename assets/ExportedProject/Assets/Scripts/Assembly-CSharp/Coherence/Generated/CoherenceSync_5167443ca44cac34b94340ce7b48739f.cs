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
	public class CoherenceSync_5167443ca44cac34b94340ce7b48739f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_47a98f9fd15949c0b5a302dd2cd49b24_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_6c9ba61043934e77b36326d34d1cf2a9_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_8854b7ee420c4dce9c64d7063d69b922_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_cebd9d3fc0574b66baa89d62852afc94_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_15233da1698c463384b8b826a9410ccc_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_153e8b4355d74e2692c5a2ad324becb2_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_a82f8446457444978a2a2672f3f0c9e0_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_2b021127272140e79e4a7ec85c1eb35e_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_8a15a0700be94c19bcc9c55fdb163980_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_701dde7357464fdea8e2bcebe1afdb84_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_8a9cbb486e58481bb45a4f732efc1d51_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_800587e0a9cc48829dced46dde297894_CommandTarget;

		private CharacterController _5167443ca44cac34b94340ce7b48739f_504ec08dd0f54d80af96a152ee229d6a_CommandTarget;

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

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_47a98f9fd15949c0b5a302dd2cd49b24(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_47a98f9fd15949c0b5a302dd2cd49b24(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_47a98f9fd15949c0b5a302dd2cd49b24(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_47a98f9fd15949c0b5a302dd2cd49b24(_5167443ca44cac34b94340ce7b48739f_47a98f9fd15949c0b5a302dd2cd49b24 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_6c9ba61043934e77b36326d34d1cf2a9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_6c9ba61043934e77b36326d34d1cf2a9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_6c9ba61043934e77b36326d34d1cf2a9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_6c9ba61043934e77b36326d34d1cf2a9(_5167443ca44cac34b94340ce7b48739f_6c9ba61043934e77b36326d34d1cf2a9 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_8854b7ee420c4dce9c64d7063d69b922(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_8854b7ee420c4dce9c64d7063d69b922(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_8854b7ee420c4dce9c64d7063d69b922(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_8854b7ee420c4dce9c64d7063d69b922(_5167443ca44cac34b94340ce7b48739f_8854b7ee420c4dce9c64d7063d69b922 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_cebd9d3fc0574b66baa89d62852afc94(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_cebd9d3fc0574b66baa89d62852afc94(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_cebd9d3fc0574b66baa89d62852afc94(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_cebd9d3fc0574b66baa89d62852afc94(_5167443ca44cac34b94340ce7b48739f_cebd9d3fc0574b66baa89d62852afc94 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_15233da1698c463384b8b826a9410ccc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_15233da1698c463384b8b826a9410ccc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_15233da1698c463384b8b826a9410ccc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_15233da1698c463384b8b826a9410ccc(_5167443ca44cac34b94340ce7b48739f_15233da1698c463384b8b826a9410ccc command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_153e8b4355d74e2692c5a2ad324becb2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_153e8b4355d74e2692c5a2ad324becb2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_153e8b4355d74e2692c5a2ad324becb2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_153e8b4355d74e2692c5a2ad324becb2(_5167443ca44cac34b94340ce7b48739f_153e8b4355d74e2692c5a2ad324becb2 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_a82f8446457444978a2a2672f3f0c9e0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_a82f8446457444978a2a2672f3f0c9e0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_a82f8446457444978a2a2672f3f0c9e0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_a82f8446457444978a2a2672f3f0c9e0(_5167443ca44cac34b94340ce7b48739f_a82f8446457444978a2a2672f3f0c9e0 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_2b021127272140e79e4a7ec85c1eb35e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_2b021127272140e79e4a7ec85c1eb35e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_2b021127272140e79e4a7ec85c1eb35e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_2b021127272140e79e4a7ec85c1eb35e(_5167443ca44cac34b94340ce7b48739f_2b021127272140e79e4a7ec85c1eb35e command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_8a15a0700be94c19bcc9c55fdb163980(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_8a15a0700be94c19bcc9c55fdb163980(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_8a15a0700be94c19bcc9c55fdb163980(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_8a15a0700be94c19bcc9c55fdb163980(_5167443ca44cac34b94340ce7b48739f_8a15a0700be94c19bcc9c55fdb163980 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_701dde7357464fdea8e2bcebe1afdb84(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_701dde7357464fdea8e2bcebe1afdb84(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_701dde7357464fdea8e2bcebe1afdb84(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_701dde7357464fdea8e2bcebe1afdb84(_5167443ca44cac34b94340ce7b48739f_701dde7357464fdea8e2bcebe1afdb84 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_8a9cbb486e58481bb45a4f732efc1d51(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_8a9cbb486e58481bb45a4f732efc1d51(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_8a9cbb486e58481bb45a4f732efc1d51(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_8a9cbb486e58481bb45a4f732efc1d51(_5167443ca44cac34b94340ce7b48739f_8a9cbb486e58481bb45a4f732efc1d51 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_800587e0a9cc48829dced46dde297894(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_800587e0a9cc48829dced46dde297894(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_800587e0a9cc48829dced46dde297894(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_800587e0a9cc48829dced46dde297894(_5167443ca44cac34b94340ce7b48739f_800587e0a9cc48829dced46dde297894 command)
		{
		}

		private void BakeCommandBinding__5167443ca44cac34b94340ce7b48739f_504ec08dd0f54d80af96a152ee229d6a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5167443ca44cac34b94340ce7b48739f_504ec08dd0f54d80af96a152ee229d6a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5167443ca44cac34b94340ce7b48739f_504ec08dd0f54d80af96a152ee229d6a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5167443ca44cac34b94340ce7b48739f_504ec08dd0f54d80af96a152ee229d6a(_5167443ca44cac34b94340ce7b48739f_504ec08dd0f54d80af96a152ee229d6a command)
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
