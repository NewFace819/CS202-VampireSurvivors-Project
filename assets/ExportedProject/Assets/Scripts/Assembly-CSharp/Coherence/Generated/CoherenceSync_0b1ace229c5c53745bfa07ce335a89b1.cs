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
	public class CoherenceSync_0b1ace229c5c53745bfa07ce335a89b1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_0e78be47e1844ae08012f10904feb870_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_f0b59fd1eca147008e162290d742822c_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_fc8180367d77424387d80129b07245fc_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_b1a6c3060c344d6a8eebf13b2eacc251_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_020e48d6d32c430b944389ee8f3cb1bd_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_8893649720c44bde8aec9f5c03bee29e_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_0ca210ca09a0481287343941ceb0c562_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_af202be2415e43999ca8837823904857_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_5d41d48a6e854a01ac1a0cddde2263e5_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_7dc9b6fbc74c4379bb1a29bad397fe1c_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_87e18b5fbd034dc097a1d3b4ff5de591_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_cfa6cdeb8db3478ba0d034daa9f68065_CommandTarget;

		private CharacterController _0b1ace229c5c53745bfa07ce335a89b1_13727c0edf25499780bc6bfe62195c4c_CommandTarget;

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

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_0e78be47e1844ae08012f10904feb870(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_0e78be47e1844ae08012f10904feb870(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_0e78be47e1844ae08012f10904feb870(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_0e78be47e1844ae08012f10904feb870(_0b1ace229c5c53745bfa07ce335a89b1_0e78be47e1844ae08012f10904feb870 command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_f0b59fd1eca147008e162290d742822c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_f0b59fd1eca147008e162290d742822c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_f0b59fd1eca147008e162290d742822c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_f0b59fd1eca147008e162290d742822c(_0b1ace229c5c53745bfa07ce335a89b1_f0b59fd1eca147008e162290d742822c command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_fc8180367d77424387d80129b07245fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_fc8180367d77424387d80129b07245fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_fc8180367d77424387d80129b07245fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_fc8180367d77424387d80129b07245fc(_0b1ace229c5c53745bfa07ce335a89b1_fc8180367d77424387d80129b07245fc command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_b1a6c3060c344d6a8eebf13b2eacc251(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_b1a6c3060c344d6a8eebf13b2eacc251(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_b1a6c3060c344d6a8eebf13b2eacc251(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_b1a6c3060c344d6a8eebf13b2eacc251(_0b1ace229c5c53745bfa07ce335a89b1_b1a6c3060c344d6a8eebf13b2eacc251 command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_020e48d6d32c430b944389ee8f3cb1bd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_020e48d6d32c430b944389ee8f3cb1bd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_020e48d6d32c430b944389ee8f3cb1bd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_020e48d6d32c430b944389ee8f3cb1bd(_0b1ace229c5c53745bfa07ce335a89b1_020e48d6d32c430b944389ee8f3cb1bd command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_8893649720c44bde8aec9f5c03bee29e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_8893649720c44bde8aec9f5c03bee29e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_8893649720c44bde8aec9f5c03bee29e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_8893649720c44bde8aec9f5c03bee29e(_0b1ace229c5c53745bfa07ce335a89b1_8893649720c44bde8aec9f5c03bee29e command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_0ca210ca09a0481287343941ceb0c562(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_0ca210ca09a0481287343941ceb0c562(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_0ca210ca09a0481287343941ceb0c562(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_0ca210ca09a0481287343941ceb0c562(_0b1ace229c5c53745bfa07ce335a89b1_0ca210ca09a0481287343941ceb0c562 command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_af202be2415e43999ca8837823904857(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_af202be2415e43999ca8837823904857(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_af202be2415e43999ca8837823904857(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_af202be2415e43999ca8837823904857(_0b1ace229c5c53745bfa07ce335a89b1_af202be2415e43999ca8837823904857 command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_5d41d48a6e854a01ac1a0cddde2263e5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_5d41d48a6e854a01ac1a0cddde2263e5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_5d41d48a6e854a01ac1a0cddde2263e5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_5d41d48a6e854a01ac1a0cddde2263e5(_0b1ace229c5c53745bfa07ce335a89b1_5d41d48a6e854a01ac1a0cddde2263e5 command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_7dc9b6fbc74c4379bb1a29bad397fe1c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_7dc9b6fbc74c4379bb1a29bad397fe1c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_7dc9b6fbc74c4379bb1a29bad397fe1c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_7dc9b6fbc74c4379bb1a29bad397fe1c(_0b1ace229c5c53745bfa07ce335a89b1_7dc9b6fbc74c4379bb1a29bad397fe1c command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_87e18b5fbd034dc097a1d3b4ff5de591(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_87e18b5fbd034dc097a1d3b4ff5de591(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_87e18b5fbd034dc097a1d3b4ff5de591(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_87e18b5fbd034dc097a1d3b4ff5de591(_0b1ace229c5c53745bfa07ce335a89b1_87e18b5fbd034dc097a1d3b4ff5de591 command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_cfa6cdeb8db3478ba0d034daa9f68065(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_cfa6cdeb8db3478ba0d034daa9f68065(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_cfa6cdeb8db3478ba0d034daa9f68065(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_cfa6cdeb8db3478ba0d034daa9f68065(_0b1ace229c5c53745bfa07ce335a89b1_cfa6cdeb8db3478ba0d034daa9f68065 command)
		{
		}

		private void BakeCommandBinding__0b1ace229c5c53745bfa07ce335a89b1_13727c0edf25499780bc6bfe62195c4c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b1ace229c5c53745bfa07ce335a89b1_13727c0edf25499780bc6bfe62195c4c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b1ace229c5c53745bfa07ce335a89b1_13727c0edf25499780bc6bfe62195c4c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b1ace229c5c53745bfa07ce335a89b1_13727c0edf25499780bc6bfe62195c4c(_0b1ace229c5c53745bfa07ce335a89b1_13727c0edf25499780bc6bfe62195c4c command)
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
