using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_5b900653e6a79844493c74a950c3376f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _5b900653e6a79844493c74a950c3376f_d7ebbd5925dc4068996f2ad40efb764a_CommandTarget;

		private NetworkPickup _5b900653e6a79844493c74a950c3376f_22915a3808cc48c39f5df2ea163a1966_CommandTarget;

		private NetworkPickup _5b900653e6a79844493c74a950c3376f_45d93f2bb4b84a5fb25dc53456d76a86_CommandTarget;

		private NetworkPickup _5b900653e6a79844493c74a950c3376f_f064e4028c7d4356ac95782a7a159e2c_CommandTarget;

		private NetworkPickup _5b900653e6a79844493c74a950c3376f_a835a1e3921a4054be640ecb406ff3ba_CommandTarget;

		private NetworkPickup _5b900653e6a79844493c74a950c3376f_4a3a901830874bee9680a7d16705388b_CommandTarget;

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

		private void BakeCommandBinding__5b900653e6a79844493c74a950c3376f_d7ebbd5925dc4068996f2ad40efb764a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5b900653e6a79844493c74a950c3376f_d7ebbd5925dc4068996f2ad40efb764a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5b900653e6a79844493c74a950c3376f_d7ebbd5925dc4068996f2ad40efb764a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5b900653e6a79844493c74a950c3376f_d7ebbd5925dc4068996f2ad40efb764a(_5b900653e6a79844493c74a950c3376f_d7ebbd5925dc4068996f2ad40efb764a command)
		{
		}

		private void BakeCommandBinding__5b900653e6a79844493c74a950c3376f_22915a3808cc48c39f5df2ea163a1966(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5b900653e6a79844493c74a950c3376f_22915a3808cc48c39f5df2ea163a1966(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5b900653e6a79844493c74a950c3376f_22915a3808cc48c39f5df2ea163a1966(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5b900653e6a79844493c74a950c3376f_22915a3808cc48c39f5df2ea163a1966(_5b900653e6a79844493c74a950c3376f_22915a3808cc48c39f5df2ea163a1966 command)
		{
		}

		private void BakeCommandBinding__5b900653e6a79844493c74a950c3376f_45d93f2bb4b84a5fb25dc53456d76a86(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5b900653e6a79844493c74a950c3376f_45d93f2bb4b84a5fb25dc53456d76a86(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5b900653e6a79844493c74a950c3376f_45d93f2bb4b84a5fb25dc53456d76a86(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5b900653e6a79844493c74a950c3376f_45d93f2bb4b84a5fb25dc53456d76a86(_5b900653e6a79844493c74a950c3376f_45d93f2bb4b84a5fb25dc53456d76a86 command)
		{
		}

		private void BakeCommandBinding__5b900653e6a79844493c74a950c3376f_f064e4028c7d4356ac95782a7a159e2c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5b900653e6a79844493c74a950c3376f_f064e4028c7d4356ac95782a7a159e2c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5b900653e6a79844493c74a950c3376f_f064e4028c7d4356ac95782a7a159e2c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5b900653e6a79844493c74a950c3376f_f064e4028c7d4356ac95782a7a159e2c(_5b900653e6a79844493c74a950c3376f_f064e4028c7d4356ac95782a7a159e2c command)
		{
		}

		private void BakeCommandBinding__5b900653e6a79844493c74a950c3376f_a835a1e3921a4054be640ecb406ff3ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5b900653e6a79844493c74a950c3376f_a835a1e3921a4054be640ecb406ff3ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5b900653e6a79844493c74a950c3376f_a835a1e3921a4054be640ecb406ff3ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5b900653e6a79844493c74a950c3376f_a835a1e3921a4054be640ecb406ff3ba(_5b900653e6a79844493c74a950c3376f_a835a1e3921a4054be640ecb406ff3ba command)
		{
		}

		private void BakeCommandBinding__5b900653e6a79844493c74a950c3376f_4a3a901830874bee9680a7d16705388b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5b900653e6a79844493c74a950c3376f_4a3a901830874bee9680a7d16705388b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5b900653e6a79844493c74a950c3376f_4a3a901830874bee9680a7d16705388b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5b900653e6a79844493c74a950c3376f_4a3a901830874bee9680a7d16705388b(_5b900653e6a79844493c74a950c3376f_4a3a901830874bee9680a7d16705388b command)
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
