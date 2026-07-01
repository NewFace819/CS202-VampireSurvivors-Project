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
	public class CoherenceSync_43720b23d7ee7d949b96a75b5c26fb9b : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_7064387dc4f049ecba5acec7b39c2d53_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_2e04a05e7f74496e957631263e871611_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_55d40cf4693d4cf7b52a6aadc0a1fe2e_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_3efbf084bc86470e81bcafb7a47466f0_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_77efef4419b447068676bfb4c3c65562_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_9c6f027d234645a582cdfed6e224f54c_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_415e2857a7be45ffbf4ddde1dde4d49b_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_73d2de8c70dd4b28b5393088299e4f9b_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_6cdc1f17c10443478bdcc4bb336aeb6b_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_8062db20953247f6a9d793257b75ec41_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_bb4c428bccb14b9bb29a21b0a44b3b0f_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_655423c09e7448b1a77159f904d895f5_CommandTarget;

		private CharacterController _43720b23d7ee7d949b96a75b5c26fb9b_ca70dc5c67464fdd9859360fd366d62f_CommandTarget;

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

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_7064387dc4f049ecba5acec7b39c2d53(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_7064387dc4f049ecba5acec7b39c2d53(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_7064387dc4f049ecba5acec7b39c2d53(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_7064387dc4f049ecba5acec7b39c2d53(_43720b23d7ee7d949b96a75b5c26fb9b_7064387dc4f049ecba5acec7b39c2d53 command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_2e04a05e7f74496e957631263e871611(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_2e04a05e7f74496e957631263e871611(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_2e04a05e7f74496e957631263e871611(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_2e04a05e7f74496e957631263e871611(_43720b23d7ee7d949b96a75b5c26fb9b_2e04a05e7f74496e957631263e871611 command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_55d40cf4693d4cf7b52a6aadc0a1fe2e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_55d40cf4693d4cf7b52a6aadc0a1fe2e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_55d40cf4693d4cf7b52a6aadc0a1fe2e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_55d40cf4693d4cf7b52a6aadc0a1fe2e(_43720b23d7ee7d949b96a75b5c26fb9b_55d40cf4693d4cf7b52a6aadc0a1fe2e command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_3efbf084bc86470e81bcafb7a47466f0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_3efbf084bc86470e81bcafb7a47466f0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_3efbf084bc86470e81bcafb7a47466f0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_3efbf084bc86470e81bcafb7a47466f0(_43720b23d7ee7d949b96a75b5c26fb9b_3efbf084bc86470e81bcafb7a47466f0 command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_77efef4419b447068676bfb4c3c65562(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_77efef4419b447068676bfb4c3c65562(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_77efef4419b447068676bfb4c3c65562(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_77efef4419b447068676bfb4c3c65562(_43720b23d7ee7d949b96a75b5c26fb9b_77efef4419b447068676bfb4c3c65562 command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_9c6f027d234645a582cdfed6e224f54c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_9c6f027d234645a582cdfed6e224f54c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_9c6f027d234645a582cdfed6e224f54c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_9c6f027d234645a582cdfed6e224f54c(_43720b23d7ee7d949b96a75b5c26fb9b_9c6f027d234645a582cdfed6e224f54c command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_415e2857a7be45ffbf4ddde1dde4d49b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_415e2857a7be45ffbf4ddde1dde4d49b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_415e2857a7be45ffbf4ddde1dde4d49b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_415e2857a7be45ffbf4ddde1dde4d49b(_43720b23d7ee7d949b96a75b5c26fb9b_415e2857a7be45ffbf4ddde1dde4d49b command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_73d2de8c70dd4b28b5393088299e4f9b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_73d2de8c70dd4b28b5393088299e4f9b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_73d2de8c70dd4b28b5393088299e4f9b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_73d2de8c70dd4b28b5393088299e4f9b(_43720b23d7ee7d949b96a75b5c26fb9b_73d2de8c70dd4b28b5393088299e4f9b command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_6cdc1f17c10443478bdcc4bb336aeb6b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_6cdc1f17c10443478bdcc4bb336aeb6b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_6cdc1f17c10443478bdcc4bb336aeb6b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_6cdc1f17c10443478bdcc4bb336aeb6b(_43720b23d7ee7d949b96a75b5c26fb9b_6cdc1f17c10443478bdcc4bb336aeb6b command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_8062db20953247f6a9d793257b75ec41(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_8062db20953247f6a9d793257b75ec41(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_8062db20953247f6a9d793257b75ec41(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_8062db20953247f6a9d793257b75ec41(_43720b23d7ee7d949b96a75b5c26fb9b_8062db20953247f6a9d793257b75ec41 command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_bb4c428bccb14b9bb29a21b0a44b3b0f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_bb4c428bccb14b9bb29a21b0a44b3b0f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_bb4c428bccb14b9bb29a21b0a44b3b0f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_bb4c428bccb14b9bb29a21b0a44b3b0f(_43720b23d7ee7d949b96a75b5c26fb9b_bb4c428bccb14b9bb29a21b0a44b3b0f command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_655423c09e7448b1a77159f904d895f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_655423c09e7448b1a77159f904d895f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_655423c09e7448b1a77159f904d895f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_655423c09e7448b1a77159f904d895f5(_43720b23d7ee7d949b96a75b5c26fb9b_655423c09e7448b1a77159f904d895f5 command)
		{
		}

		private void BakeCommandBinding__43720b23d7ee7d949b96a75b5c26fb9b_ca70dc5c67464fdd9859360fd366d62f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__43720b23d7ee7d949b96a75b5c26fb9b_ca70dc5c67464fdd9859360fd366d62f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__43720b23d7ee7d949b96a75b5c26fb9b_ca70dc5c67464fdd9859360fd366d62f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__43720b23d7ee7d949b96a75b5c26fb9b_ca70dc5c67464fdd9859360fd366d62f(_43720b23d7ee7d949b96a75b5c26fb9b_ca70dc5c67464fdd9859360fd366d62f command)
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
