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
	public class CoherenceSync_e12f536fde7e5724e8c48096e0125fa5 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_685bd5bad4384c3f888c25175ce12a91_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_7e6fd786a8e04f8c9f054c4d55092f6e_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_8e020e1b6ae34c2da269607874413fe5_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_024e79fb4f0b4d7b89918a18e9956fa1_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_ab832c6755194d538cfedad889f30734_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_a8eee8b2ea024bdbb93279a3e4c37d40_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_17ec1a72f98c4cedacb86166c0a1e964_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_74dcb9d607d943319a31c58924916666_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_08ac2d9e1460472e8d74d58cd6bfbff8_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_487e756db93c40fb9cce1b7137ebfc75_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_e7232a31ede2419f890520ceaf3618d1_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_2e02a576d42a4384a0a093adff709fd2_CommandTarget;

		private CharacterController _e12f536fde7e5724e8c48096e0125fa5_b232550fbcec440983b0779347fd0134_CommandTarget;

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

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_685bd5bad4384c3f888c25175ce12a91(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_685bd5bad4384c3f888c25175ce12a91(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_685bd5bad4384c3f888c25175ce12a91(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_685bd5bad4384c3f888c25175ce12a91(_e12f536fde7e5724e8c48096e0125fa5_685bd5bad4384c3f888c25175ce12a91 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_7e6fd786a8e04f8c9f054c4d55092f6e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_7e6fd786a8e04f8c9f054c4d55092f6e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_7e6fd786a8e04f8c9f054c4d55092f6e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_7e6fd786a8e04f8c9f054c4d55092f6e(_e12f536fde7e5724e8c48096e0125fa5_7e6fd786a8e04f8c9f054c4d55092f6e command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_8e020e1b6ae34c2da269607874413fe5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_8e020e1b6ae34c2da269607874413fe5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_8e020e1b6ae34c2da269607874413fe5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_8e020e1b6ae34c2da269607874413fe5(_e12f536fde7e5724e8c48096e0125fa5_8e020e1b6ae34c2da269607874413fe5 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_024e79fb4f0b4d7b89918a18e9956fa1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_024e79fb4f0b4d7b89918a18e9956fa1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_024e79fb4f0b4d7b89918a18e9956fa1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_024e79fb4f0b4d7b89918a18e9956fa1(_e12f536fde7e5724e8c48096e0125fa5_024e79fb4f0b4d7b89918a18e9956fa1 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_ab832c6755194d538cfedad889f30734(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_ab832c6755194d538cfedad889f30734(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_ab832c6755194d538cfedad889f30734(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_ab832c6755194d538cfedad889f30734(_e12f536fde7e5724e8c48096e0125fa5_ab832c6755194d538cfedad889f30734 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_a8eee8b2ea024bdbb93279a3e4c37d40(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_a8eee8b2ea024bdbb93279a3e4c37d40(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_a8eee8b2ea024bdbb93279a3e4c37d40(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_a8eee8b2ea024bdbb93279a3e4c37d40(_e12f536fde7e5724e8c48096e0125fa5_a8eee8b2ea024bdbb93279a3e4c37d40 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_17ec1a72f98c4cedacb86166c0a1e964(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_17ec1a72f98c4cedacb86166c0a1e964(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_17ec1a72f98c4cedacb86166c0a1e964(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_17ec1a72f98c4cedacb86166c0a1e964(_e12f536fde7e5724e8c48096e0125fa5_17ec1a72f98c4cedacb86166c0a1e964 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_74dcb9d607d943319a31c58924916666(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_74dcb9d607d943319a31c58924916666(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_74dcb9d607d943319a31c58924916666(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_74dcb9d607d943319a31c58924916666(_e12f536fde7e5724e8c48096e0125fa5_74dcb9d607d943319a31c58924916666 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_08ac2d9e1460472e8d74d58cd6bfbff8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_08ac2d9e1460472e8d74d58cd6bfbff8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_08ac2d9e1460472e8d74d58cd6bfbff8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_08ac2d9e1460472e8d74d58cd6bfbff8(_e12f536fde7e5724e8c48096e0125fa5_08ac2d9e1460472e8d74d58cd6bfbff8 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_487e756db93c40fb9cce1b7137ebfc75(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_487e756db93c40fb9cce1b7137ebfc75(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_487e756db93c40fb9cce1b7137ebfc75(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_487e756db93c40fb9cce1b7137ebfc75(_e12f536fde7e5724e8c48096e0125fa5_487e756db93c40fb9cce1b7137ebfc75 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_e7232a31ede2419f890520ceaf3618d1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_e7232a31ede2419f890520ceaf3618d1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_e7232a31ede2419f890520ceaf3618d1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_e7232a31ede2419f890520ceaf3618d1(_e12f536fde7e5724e8c48096e0125fa5_e7232a31ede2419f890520ceaf3618d1 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_2e02a576d42a4384a0a093adff709fd2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_2e02a576d42a4384a0a093adff709fd2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_2e02a576d42a4384a0a093adff709fd2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_2e02a576d42a4384a0a093adff709fd2(_e12f536fde7e5724e8c48096e0125fa5_2e02a576d42a4384a0a093adff709fd2 command)
		{
		}

		private void BakeCommandBinding__e12f536fde7e5724e8c48096e0125fa5_b232550fbcec440983b0779347fd0134(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e12f536fde7e5724e8c48096e0125fa5_b232550fbcec440983b0779347fd0134(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e12f536fde7e5724e8c48096e0125fa5_b232550fbcec440983b0779347fd0134(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e12f536fde7e5724e8c48096e0125fa5_b232550fbcec440983b0779347fd0134(_e12f536fde7e5724e8c48096e0125fa5_b232550fbcec440983b0779347fd0134 command)
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
