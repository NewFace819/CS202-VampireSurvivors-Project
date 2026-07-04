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
	public class CoherenceSync_40b53bce946834a41813aa21dfe4253d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_fee755a948214d32a3d66e9d7a1e1298_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_fc57298cb78c442ebc7754532c9352b4_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_d8476bf714ba4ca7828c231600d5e9bf_CommandTarget;

		private CharacterControllerMenya _40b53bce946834a41813aa21dfe4253d_c3f79f99a3ce47959be5387de18b74bc_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_9d4477522b55429cb4ad1b5c4a22c762_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_634e17f426364569b4d734511ad0b806_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_52515db54ca54f73ad6da6a51eaa0296_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_ab7a0f4bcbfb4ba891278ff22d7a726f_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_0aaa468f5d714192ac87429d8802eb76_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_e5c44efb7aa740e39db2d36c7e90cb84_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_17fd1b5b23ea44c7b47a29d88210a349_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_62d29f581f504595ac9b1ad387bff5da_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_138f0b0c98bb4cbe978fa55fc26f8095_CommandTarget;

		private CharacterController _40b53bce946834a41813aa21dfe4253d_59806c51a3b642b6bfe6c7b589104be1_CommandTarget;

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

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_fee755a948214d32a3d66e9d7a1e1298(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_fee755a948214d32a3d66e9d7a1e1298(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_fee755a948214d32a3d66e9d7a1e1298(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_fee755a948214d32a3d66e9d7a1e1298(_40b53bce946834a41813aa21dfe4253d_fee755a948214d32a3d66e9d7a1e1298 command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_fc57298cb78c442ebc7754532c9352b4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_fc57298cb78c442ebc7754532c9352b4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_fc57298cb78c442ebc7754532c9352b4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_fc57298cb78c442ebc7754532c9352b4(_40b53bce946834a41813aa21dfe4253d_fc57298cb78c442ebc7754532c9352b4 command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_d8476bf714ba4ca7828c231600d5e9bf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_d8476bf714ba4ca7828c231600d5e9bf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_d8476bf714ba4ca7828c231600d5e9bf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_d8476bf714ba4ca7828c231600d5e9bf(_40b53bce946834a41813aa21dfe4253d_d8476bf714ba4ca7828c231600d5e9bf command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_c3f79f99a3ce47959be5387de18b74bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_c3f79f99a3ce47959be5387de18b74bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_c3f79f99a3ce47959be5387de18b74bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_c3f79f99a3ce47959be5387de18b74bc(_40b53bce946834a41813aa21dfe4253d_c3f79f99a3ce47959be5387de18b74bc command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_9d4477522b55429cb4ad1b5c4a22c762(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_9d4477522b55429cb4ad1b5c4a22c762(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_9d4477522b55429cb4ad1b5c4a22c762(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_9d4477522b55429cb4ad1b5c4a22c762(_40b53bce946834a41813aa21dfe4253d_9d4477522b55429cb4ad1b5c4a22c762 command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_634e17f426364569b4d734511ad0b806(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_634e17f426364569b4d734511ad0b806(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_634e17f426364569b4d734511ad0b806(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_634e17f426364569b4d734511ad0b806(_40b53bce946834a41813aa21dfe4253d_634e17f426364569b4d734511ad0b806 command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_52515db54ca54f73ad6da6a51eaa0296(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_52515db54ca54f73ad6da6a51eaa0296(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_52515db54ca54f73ad6da6a51eaa0296(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_52515db54ca54f73ad6da6a51eaa0296(_40b53bce946834a41813aa21dfe4253d_52515db54ca54f73ad6da6a51eaa0296 command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_ab7a0f4bcbfb4ba891278ff22d7a726f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_ab7a0f4bcbfb4ba891278ff22d7a726f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_ab7a0f4bcbfb4ba891278ff22d7a726f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_ab7a0f4bcbfb4ba891278ff22d7a726f(_40b53bce946834a41813aa21dfe4253d_ab7a0f4bcbfb4ba891278ff22d7a726f command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_0aaa468f5d714192ac87429d8802eb76(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_0aaa468f5d714192ac87429d8802eb76(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_0aaa468f5d714192ac87429d8802eb76(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_0aaa468f5d714192ac87429d8802eb76(_40b53bce946834a41813aa21dfe4253d_0aaa468f5d714192ac87429d8802eb76 command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_e5c44efb7aa740e39db2d36c7e90cb84(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_e5c44efb7aa740e39db2d36c7e90cb84(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_e5c44efb7aa740e39db2d36c7e90cb84(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_e5c44efb7aa740e39db2d36c7e90cb84(_40b53bce946834a41813aa21dfe4253d_e5c44efb7aa740e39db2d36c7e90cb84 command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_17fd1b5b23ea44c7b47a29d88210a349(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_17fd1b5b23ea44c7b47a29d88210a349(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_17fd1b5b23ea44c7b47a29d88210a349(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_17fd1b5b23ea44c7b47a29d88210a349(_40b53bce946834a41813aa21dfe4253d_17fd1b5b23ea44c7b47a29d88210a349 command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_62d29f581f504595ac9b1ad387bff5da(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_62d29f581f504595ac9b1ad387bff5da(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_62d29f581f504595ac9b1ad387bff5da(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_62d29f581f504595ac9b1ad387bff5da(_40b53bce946834a41813aa21dfe4253d_62d29f581f504595ac9b1ad387bff5da command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_138f0b0c98bb4cbe978fa55fc26f8095(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_138f0b0c98bb4cbe978fa55fc26f8095(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_138f0b0c98bb4cbe978fa55fc26f8095(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_138f0b0c98bb4cbe978fa55fc26f8095(_40b53bce946834a41813aa21dfe4253d_138f0b0c98bb4cbe978fa55fc26f8095 command)
		{
		}

		private void BakeCommandBinding__40b53bce946834a41813aa21dfe4253d_59806c51a3b642b6bfe6c7b589104be1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__40b53bce946834a41813aa21dfe4253d_59806c51a3b642b6bfe6c7b589104be1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__40b53bce946834a41813aa21dfe4253d_59806c51a3b642b6bfe6c7b589104be1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__40b53bce946834a41813aa21dfe4253d_59806c51a3b642b6bfe6c7b589104be1(_40b53bce946834a41813aa21dfe4253d_59806c51a3b642b6bfe6c7b589104be1 command)
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
