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
	public class CoherenceSync_7152f042fbafc14468670f353ab59954 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _7152f042fbafc14468670f353ab59954_ee51f50dede846ba9f564d137ded0c94_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_6402bbdd893141f183239b87749d31a6_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_f00e67d058464f2087a56a1d08a91006_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_48d41a108c2f416db81914424524a3b6_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_d94d273172ae4f6a9b4fb48e45470582_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_2984cc70c1644edc8ee1cc4cafa50755_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_965a488dc0e14152b21888312765b063_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_6d7d0a53ee2e40ee9f03fc73050c6828_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_3bdd17a17f7d452cb385e9b9edc8ade2_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_1abf71f430164679bd5de6cfac872ffd_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_6e5117e5f6844e9cac8ed190d17b7ff8_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_d2ee24b305a44b81922e44b4d2b011eb_CommandTarget;

		private CharacterController _7152f042fbafc14468670f353ab59954_623e0099c647407b847a4a8d2b4d7296_CommandTarget;

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

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_ee51f50dede846ba9f564d137ded0c94(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_ee51f50dede846ba9f564d137ded0c94(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_ee51f50dede846ba9f564d137ded0c94(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_ee51f50dede846ba9f564d137ded0c94(_7152f042fbafc14468670f353ab59954_ee51f50dede846ba9f564d137ded0c94 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_6402bbdd893141f183239b87749d31a6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_6402bbdd893141f183239b87749d31a6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_6402bbdd893141f183239b87749d31a6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_6402bbdd893141f183239b87749d31a6(_7152f042fbafc14468670f353ab59954_6402bbdd893141f183239b87749d31a6 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_f00e67d058464f2087a56a1d08a91006(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_f00e67d058464f2087a56a1d08a91006(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_f00e67d058464f2087a56a1d08a91006(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_f00e67d058464f2087a56a1d08a91006(_7152f042fbafc14468670f353ab59954_f00e67d058464f2087a56a1d08a91006 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_48d41a108c2f416db81914424524a3b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_48d41a108c2f416db81914424524a3b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_48d41a108c2f416db81914424524a3b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_48d41a108c2f416db81914424524a3b6(_7152f042fbafc14468670f353ab59954_48d41a108c2f416db81914424524a3b6 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_d94d273172ae4f6a9b4fb48e45470582(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_d94d273172ae4f6a9b4fb48e45470582(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_d94d273172ae4f6a9b4fb48e45470582(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_d94d273172ae4f6a9b4fb48e45470582(_7152f042fbafc14468670f353ab59954_d94d273172ae4f6a9b4fb48e45470582 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_2984cc70c1644edc8ee1cc4cafa50755(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_2984cc70c1644edc8ee1cc4cafa50755(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_2984cc70c1644edc8ee1cc4cafa50755(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_2984cc70c1644edc8ee1cc4cafa50755(_7152f042fbafc14468670f353ab59954_2984cc70c1644edc8ee1cc4cafa50755 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_965a488dc0e14152b21888312765b063(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_965a488dc0e14152b21888312765b063(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_965a488dc0e14152b21888312765b063(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_965a488dc0e14152b21888312765b063(_7152f042fbafc14468670f353ab59954_965a488dc0e14152b21888312765b063 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_6d7d0a53ee2e40ee9f03fc73050c6828(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_6d7d0a53ee2e40ee9f03fc73050c6828(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_6d7d0a53ee2e40ee9f03fc73050c6828(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_6d7d0a53ee2e40ee9f03fc73050c6828(_7152f042fbafc14468670f353ab59954_6d7d0a53ee2e40ee9f03fc73050c6828 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_3bdd17a17f7d452cb385e9b9edc8ade2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_3bdd17a17f7d452cb385e9b9edc8ade2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_3bdd17a17f7d452cb385e9b9edc8ade2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_3bdd17a17f7d452cb385e9b9edc8ade2(_7152f042fbafc14468670f353ab59954_3bdd17a17f7d452cb385e9b9edc8ade2 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_1abf71f430164679bd5de6cfac872ffd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_1abf71f430164679bd5de6cfac872ffd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_1abf71f430164679bd5de6cfac872ffd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_1abf71f430164679bd5de6cfac872ffd(_7152f042fbafc14468670f353ab59954_1abf71f430164679bd5de6cfac872ffd command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_6e5117e5f6844e9cac8ed190d17b7ff8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_6e5117e5f6844e9cac8ed190d17b7ff8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_6e5117e5f6844e9cac8ed190d17b7ff8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_6e5117e5f6844e9cac8ed190d17b7ff8(_7152f042fbafc14468670f353ab59954_6e5117e5f6844e9cac8ed190d17b7ff8 command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_d2ee24b305a44b81922e44b4d2b011eb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_d2ee24b305a44b81922e44b4d2b011eb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_d2ee24b305a44b81922e44b4d2b011eb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_d2ee24b305a44b81922e44b4d2b011eb(_7152f042fbafc14468670f353ab59954_d2ee24b305a44b81922e44b4d2b011eb command)
		{
		}

		private void BakeCommandBinding__7152f042fbafc14468670f353ab59954_623e0099c647407b847a4a8d2b4d7296(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7152f042fbafc14468670f353ab59954_623e0099c647407b847a4a8d2b4d7296(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7152f042fbafc14468670f353ab59954_623e0099c647407b847a4a8d2b4d7296(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7152f042fbafc14468670f353ab59954_623e0099c647407b847a4a8d2b4d7296(_7152f042fbafc14468670f353ab59954_623e0099c647407b847a4a8d2b4d7296 command)
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
