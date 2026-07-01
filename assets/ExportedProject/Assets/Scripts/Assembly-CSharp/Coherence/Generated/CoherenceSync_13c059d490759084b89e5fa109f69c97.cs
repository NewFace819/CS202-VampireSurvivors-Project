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
	public class CoherenceSync_13c059d490759084b89e5fa109f69c97 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _13c059d490759084b89e5fa109f69c97_5d873bb02aa5452880f6e1d399e80123_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_d9ee779089474fefa0719c898b2d4b3d_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_2ab338d05cc34320adb09fe1792d612c_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_9881486080924a07b1116d8cabf62eed_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_5e4ebd00807146a28f56cd1f523b46e6_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_62f21efb5036436f90d75537d40813e3_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_9c313f92142d4047828333820cc6901c_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_af8141d969ab4410ab426d35ecbb86fc_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_9fc1dfffcd894a49a02975176dead31e_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_4b90f60ca64540318a1df6d53efb1890_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_e5391f6ea01f426885d8e6429d204974_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_ace8b04983d943dbb0636507a9f0bd0d_CommandTarget;

		private CharacterController _13c059d490759084b89e5fa109f69c97_5eb7ffe4787e45c78ea3bfafbf15529a_CommandTarget;

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

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_5d873bb02aa5452880f6e1d399e80123(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_5d873bb02aa5452880f6e1d399e80123(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_5d873bb02aa5452880f6e1d399e80123(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_5d873bb02aa5452880f6e1d399e80123(_13c059d490759084b89e5fa109f69c97_5d873bb02aa5452880f6e1d399e80123 command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_d9ee779089474fefa0719c898b2d4b3d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_d9ee779089474fefa0719c898b2d4b3d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_d9ee779089474fefa0719c898b2d4b3d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_d9ee779089474fefa0719c898b2d4b3d(_13c059d490759084b89e5fa109f69c97_d9ee779089474fefa0719c898b2d4b3d command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_2ab338d05cc34320adb09fe1792d612c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_2ab338d05cc34320adb09fe1792d612c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_2ab338d05cc34320adb09fe1792d612c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_2ab338d05cc34320adb09fe1792d612c(_13c059d490759084b89e5fa109f69c97_2ab338d05cc34320adb09fe1792d612c command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_9881486080924a07b1116d8cabf62eed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_9881486080924a07b1116d8cabf62eed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_9881486080924a07b1116d8cabf62eed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_9881486080924a07b1116d8cabf62eed(_13c059d490759084b89e5fa109f69c97_9881486080924a07b1116d8cabf62eed command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_5e4ebd00807146a28f56cd1f523b46e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_5e4ebd00807146a28f56cd1f523b46e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_5e4ebd00807146a28f56cd1f523b46e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_5e4ebd00807146a28f56cd1f523b46e6(_13c059d490759084b89e5fa109f69c97_5e4ebd00807146a28f56cd1f523b46e6 command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_62f21efb5036436f90d75537d40813e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_62f21efb5036436f90d75537d40813e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_62f21efb5036436f90d75537d40813e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_62f21efb5036436f90d75537d40813e3(_13c059d490759084b89e5fa109f69c97_62f21efb5036436f90d75537d40813e3 command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_9c313f92142d4047828333820cc6901c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_9c313f92142d4047828333820cc6901c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_9c313f92142d4047828333820cc6901c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_9c313f92142d4047828333820cc6901c(_13c059d490759084b89e5fa109f69c97_9c313f92142d4047828333820cc6901c command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_af8141d969ab4410ab426d35ecbb86fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_af8141d969ab4410ab426d35ecbb86fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_af8141d969ab4410ab426d35ecbb86fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_af8141d969ab4410ab426d35ecbb86fc(_13c059d490759084b89e5fa109f69c97_af8141d969ab4410ab426d35ecbb86fc command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_9fc1dfffcd894a49a02975176dead31e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_9fc1dfffcd894a49a02975176dead31e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_9fc1dfffcd894a49a02975176dead31e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_9fc1dfffcd894a49a02975176dead31e(_13c059d490759084b89e5fa109f69c97_9fc1dfffcd894a49a02975176dead31e command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_4b90f60ca64540318a1df6d53efb1890(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_4b90f60ca64540318a1df6d53efb1890(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_4b90f60ca64540318a1df6d53efb1890(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_4b90f60ca64540318a1df6d53efb1890(_13c059d490759084b89e5fa109f69c97_4b90f60ca64540318a1df6d53efb1890 command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_e5391f6ea01f426885d8e6429d204974(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_e5391f6ea01f426885d8e6429d204974(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_e5391f6ea01f426885d8e6429d204974(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_e5391f6ea01f426885d8e6429d204974(_13c059d490759084b89e5fa109f69c97_e5391f6ea01f426885d8e6429d204974 command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_ace8b04983d943dbb0636507a9f0bd0d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_ace8b04983d943dbb0636507a9f0bd0d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_ace8b04983d943dbb0636507a9f0bd0d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_ace8b04983d943dbb0636507a9f0bd0d(_13c059d490759084b89e5fa109f69c97_ace8b04983d943dbb0636507a9f0bd0d command)
		{
		}

		private void BakeCommandBinding__13c059d490759084b89e5fa109f69c97_5eb7ffe4787e45c78ea3bfafbf15529a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__13c059d490759084b89e5fa109f69c97_5eb7ffe4787e45c78ea3bfafbf15529a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__13c059d490759084b89e5fa109f69c97_5eb7ffe4787e45c78ea3bfafbf15529a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__13c059d490759084b89e5fa109f69c97_5eb7ffe4787e45c78ea3bfafbf15529a(_13c059d490759084b89e5fa109f69c97_5eb7ffe4787e45c78ea3bfafbf15529a command)
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
