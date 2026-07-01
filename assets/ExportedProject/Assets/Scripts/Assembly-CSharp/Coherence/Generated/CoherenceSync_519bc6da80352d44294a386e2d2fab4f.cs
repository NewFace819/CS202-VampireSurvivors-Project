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
	public class CoherenceSync_519bc6da80352d44294a386e2d2fab4f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_c05e3fdfc4ee4007a0bd9a5f744eb89a_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_287fccb64e7a4511b8c0d468276703af_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_4920c192af3f421e89ffa87fab256502_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_5097d51dc4a849fd80c9b2c794bc756b_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_e1e8249dfa724e90b7a2839b5c5ce321_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_f1980b4c6a654ac3a51f3586c5477682_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_18ddbac467304d1fa03c08131c32a5bb_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_93f67c4eb0d8434bb18afd0b1a30fa92_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_0cf1bf47f5544429999125b88c527161_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_3806790f1a1149bcb4e7ea7d39220529_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_23d7b94e441f4dfd9866934955b29515_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_d8fa585e2ead463aa43c55b49620ede4_CommandTarget;

		private CharacterController _519bc6da80352d44294a386e2d2fab4f_e2a63e822f524855a1d72b85cd6568c0_CommandTarget;

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

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_c05e3fdfc4ee4007a0bd9a5f744eb89a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_c05e3fdfc4ee4007a0bd9a5f744eb89a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_c05e3fdfc4ee4007a0bd9a5f744eb89a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_c05e3fdfc4ee4007a0bd9a5f744eb89a(_519bc6da80352d44294a386e2d2fab4f_c05e3fdfc4ee4007a0bd9a5f744eb89a command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_287fccb64e7a4511b8c0d468276703af(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_287fccb64e7a4511b8c0d468276703af(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_287fccb64e7a4511b8c0d468276703af(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_287fccb64e7a4511b8c0d468276703af(_519bc6da80352d44294a386e2d2fab4f_287fccb64e7a4511b8c0d468276703af command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_4920c192af3f421e89ffa87fab256502(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_4920c192af3f421e89ffa87fab256502(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_4920c192af3f421e89ffa87fab256502(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_4920c192af3f421e89ffa87fab256502(_519bc6da80352d44294a386e2d2fab4f_4920c192af3f421e89ffa87fab256502 command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_5097d51dc4a849fd80c9b2c794bc756b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_5097d51dc4a849fd80c9b2c794bc756b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_5097d51dc4a849fd80c9b2c794bc756b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_5097d51dc4a849fd80c9b2c794bc756b(_519bc6da80352d44294a386e2d2fab4f_5097d51dc4a849fd80c9b2c794bc756b command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_e1e8249dfa724e90b7a2839b5c5ce321(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_e1e8249dfa724e90b7a2839b5c5ce321(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_e1e8249dfa724e90b7a2839b5c5ce321(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_e1e8249dfa724e90b7a2839b5c5ce321(_519bc6da80352d44294a386e2d2fab4f_e1e8249dfa724e90b7a2839b5c5ce321 command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_f1980b4c6a654ac3a51f3586c5477682(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_f1980b4c6a654ac3a51f3586c5477682(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_f1980b4c6a654ac3a51f3586c5477682(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_f1980b4c6a654ac3a51f3586c5477682(_519bc6da80352d44294a386e2d2fab4f_f1980b4c6a654ac3a51f3586c5477682 command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_18ddbac467304d1fa03c08131c32a5bb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_18ddbac467304d1fa03c08131c32a5bb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_18ddbac467304d1fa03c08131c32a5bb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_18ddbac467304d1fa03c08131c32a5bb(_519bc6da80352d44294a386e2d2fab4f_18ddbac467304d1fa03c08131c32a5bb command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_93f67c4eb0d8434bb18afd0b1a30fa92(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_93f67c4eb0d8434bb18afd0b1a30fa92(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_93f67c4eb0d8434bb18afd0b1a30fa92(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_93f67c4eb0d8434bb18afd0b1a30fa92(_519bc6da80352d44294a386e2d2fab4f_93f67c4eb0d8434bb18afd0b1a30fa92 command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_0cf1bf47f5544429999125b88c527161(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_0cf1bf47f5544429999125b88c527161(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_0cf1bf47f5544429999125b88c527161(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_0cf1bf47f5544429999125b88c527161(_519bc6da80352d44294a386e2d2fab4f_0cf1bf47f5544429999125b88c527161 command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_3806790f1a1149bcb4e7ea7d39220529(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_3806790f1a1149bcb4e7ea7d39220529(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_3806790f1a1149bcb4e7ea7d39220529(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_3806790f1a1149bcb4e7ea7d39220529(_519bc6da80352d44294a386e2d2fab4f_3806790f1a1149bcb4e7ea7d39220529 command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_23d7b94e441f4dfd9866934955b29515(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_23d7b94e441f4dfd9866934955b29515(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_23d7b94e441f4dfd9866934955b29515(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_23d7b94e441f4dfd9866934955b29515(_519bc6da80352d44294a386e2d2fab4f_23d7b94e441f4dfd9866934955b29515 command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_d8fa585e2ead463aa43c55b49620ede4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_d8fa585e2ead463aa43c55b49620ede4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_d8fa585e2ead463aa43c55b49620ede4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_d8fa585e2ead463aa43c55b49620ede4(_519bc6da80352d44294a386e2d2fab4f_d8fa585e2ead463aa43c55b49620ede4 command)
		{
		}

		private void BakeCommandBinding__519bc6da80352d44294a386e2d2fab4f_e2a63e822f524855a1d72b85cd6568c0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__519bc6da80352d44294a386e2d2fab4f_e2a63e822f524855a1d72b85cd6568c0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__519bc6da80352d44294a386e2d2fab4f_e2a63e822f524855a1d72b85cd6568c0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__519bc6da80352d44294a386e2d2fab4f_e2a63e822f524855a1d72b85cd6568c0(_519bc6da80352d44294a386e2d2fab4f_e2a63e822f524855a1d72b85cd6568c0 command)
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
