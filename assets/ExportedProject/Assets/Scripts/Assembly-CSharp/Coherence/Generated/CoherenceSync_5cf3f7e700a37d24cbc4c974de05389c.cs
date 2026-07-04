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
	public class CoherenceSync_5cf3f7e700a37d24cbc4c974de05389c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_32c9c754f4744d9681e36269d3e2807f_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_c6ef842cbc0b428fbba5bd6e4164a762_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_83f35276cb9e4236adce33f4fa0f3405_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_097516e4627a4ab08b8671b6c6e0aaf1_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_9dd441b7a88c4f898af99a8f8e9f2fdd_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_3130dd798c9b4b40a819ffa15ea17ca1_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_3138db40d08a4e8f9a59a2ff70949a7e_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_2273f05d0aaa4294836fe9efa78825ce_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_e387bd838d7048dfb263789974321ca1_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_79a9de17e4a74a8ba2fb811a26ba9f74_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_11080562c8aa497596e3215bcf4b2047_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_cf6608d39ef3451381dbc91cad852031_CommandTarget;

		private CharacterController _5cf3f7e700a37d24cbc4c974de05389c_ba065966d71542689f4836ad591afe07_CommandTarget;

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

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_32c9c754f4744d9681e36269d3e2807f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_32c9c754f4744d9681e36269d3e2807f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_32c9c754f4744d9681e36269d3e2807f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_32c9c754f4744d9681e36269d3e2807f(_5cf3f7e700a37d24cbc4c974de05389c_32c9c754f4744d9681e36269d3e2807f command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_c6ef842cbc0b428fbba5bd6e4164a762(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_c6ef842cbc0b428fbba5bd6e4164a762(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_c6ef842cbc0b428fbba5bd6e4164a762(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_c6ef842cbc0b428fbba5bd6e4164a762(_5cf3f7e700a37d24cbc4c974de05389c_c6ef842cbc0b428fbba5bd6e4164a762 command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_83f35276cb9e4236adce33f4fa0f3405(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_83f35276cb9e4236adce33f4fa0f3405(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_83f35276cb9e4236adce33f4fa0f3405(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_83f35276cb9e4236adce33f4fa0f3405(_5cf3f7e700a37d24cbc4c974de05389c_83f35276cb9e4236adce33f4fa0f3405 command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_097516e4627a4ab08b8671b6c6e0aaf1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_097516e4627a4ab08b8671b6c6e0aaf1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_097516e4627a4ab08b8671b6c6e0aaf1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_097516e4627a4ab08b8671b6c6e0aaf1(_5cf3f7e700a37d24cbc4c974de05389c_097516e4627a4ab08b8671b6c6e0aaf1 command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_9dd441b7a88c4f898af99a8f8e9f2fdd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_9dd441b7a88c4f898af99a8f8e9f2fdd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_9dd441b7a88c4f898af99a8f8e9f2fdd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_9dd441b7a88c4f898af99a8f8e9f2fdd(_5cf3f7e700a37d24cbc4c974de05389c_9dd441b7a88c4f898af99a8f8e9f2fdd command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_3130dd798c9b4b40a819ffa15ea17ca1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_3130dd798c9b4b40a819ffa15ea17ca1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_3130dd798c9b4b40a819ffa15ea17ca1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_3130dd798c9b4b40a819ffa15ea17ca1(_5cf3f7e700a37d24cbc4c974de05389c_3130dd798c9b4b40a819ffa15ea17ca1 command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_3138db40d08a4e8f9a59a2ff70949a7e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_3138db40d08a4e8f9a59a2ff70949a7e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_3138db40d08a4e8f9a59a2ff70949a7e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_3138db40d08a4e8f9a59a2ff70949a7e(_5cf3f7e700a37d24cbc4c974de05389c_3138db40d08a4e8f9a59a2ff70949a7e command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_2273f05d0aaa4294836fe9efa78825ce(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_2273f05d0aaa4294836fe9efa78825ce(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_2273f05d0aaa4294836fe9efa78825ce(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_2273f05d0aaa4294836fe9efa78825ce(_5cf3f7e700a37d24cbc4c974de05389c_2273f05d0aaa4294836fe9efa78825ce command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_e387bd838d7048dfb263789974321ca1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_e387bd838d7048dfb263789974321ca1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_e387bd838d7048dfb263789974321ca1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_e387bd838d7048dfb263789974321ca1(_5cf3f7e700a37d24cbc4c974de05389c_e387bd838d7048dfb263789974321ca1 command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_79a9de17e4a74a8ba2fb811a26ba9f74(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_79a9de17e4a74a8ba2fb811a26ba9f74(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_79a9de17e4a74a8ba2fb811a26ba9f74(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_79a9de17e4a74a8ba2fb811a26ba9f74(_5cf3f7e700a37d24cbc4c974de05389c_79a9de17e4a74a8ba2fb811a26ba9f74 command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_11080562c8aa497596e3215bcf4b2047(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_11080562c8aa497596e3215bcf4b2047(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_11080562c8aa497596e3215bcf4b2047(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_11080562c8aa497596e3215bcf4b2047(_5cf3f7e700a37d24cbc4c974de05389c_11080562c8aa497596e3215bcf4b2047 command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_cf6608d39ef3451381dbc91cad852031(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_cf6608d39ef3451381dbc91cad852031(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_cf6608d39ef3451381dbc91cad852031(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_cf6608d39ef3451381dbc91cad852031(_5cf3f7e700a37d24cbc4c974de05389c_cf6608d39ef3451381dbc91cad852031 command)
		{
		}

		private void BakeCommandBinding__5cf3f7e700a37d24cbc4c974de05389c_ba065966d71542689f4836ad591afe07(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5cf3f7e700a37d24cbc4c974de05389c_ba065966d71542689f4836ad591afe07(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5cf3f7e700a37d24cbc4c974de05389c_ba065966d71542689f4836ad591afe07(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5cf3f7e700a37d24cbc4c974de05389c_ba065966d71542689f4836ad591afe07(_5cf3f7e700a37d24cbc4c974de05389c_ba065966d71542689f4836ad591afe07 command)
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
