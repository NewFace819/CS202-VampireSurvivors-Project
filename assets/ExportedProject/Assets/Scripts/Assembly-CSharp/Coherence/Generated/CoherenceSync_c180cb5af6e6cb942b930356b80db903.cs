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
	public class CoherenceSync_c180cb5af6e6cb942b930356b80db903 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_08fb3ce6a03b4a4e92127bf231d4076a_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_2486f334b6fe48b7bf81c087e5133865_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_bf54a9a7366f4f07a91a102fc54a2d99_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_4e6dafd89f1040b08e1f3e6ba4f76d47_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_60de2b152a9044d2bcff99ee69953f7f_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_294c9b9c386a47bd8fbfad7dd84f28f4_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_2b974c3778bd484e95b1b6eb4bd559af_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_f65dcf31efbe4c80aa677d63f574524a_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_69b45c8bfad34c629f6b992d9ebad96e_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_2b3afe509e3a4a21914bf3749a6edcc8_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_a31f4f36fdfb4b0f9ca915e8f1c10bc9_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_2f7a88a3d0224bb1b5e19b3c7e350f54_CommandTarget;

		private CharacterController _c180cb5af6e6cb942b930356b80db903_eb6ec4bd3fbc49de827b8566be67cd78_CommandTarget;

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

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_08fb3ce6a03b4a4e92127bf231d4076a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_08fb3ce6a03b4a4e92127bf231d4076a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_08fb3ce6a03b4a4e92127bf231d4076a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_08fb3ce6a03b4a4e92127bf231d4076a(_c180cb5af6e6cb942b930356b80db903_08fb3ce6a03b4a4e92127bf231d4076a command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_2486f334b6fe48b7bf81c087e5133865(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_2486f334b6fe48b7bf81c087e5133865(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_2486f334b6fe48b7bf81c087e5133865(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_2486f334b6fe48b7bf81c087e5133865(_c180cb5af6e6cb942b930356b80db903_2486f334b6fe48b7bf81c087e5133865 command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_bf54a9a7366f4f07a91a102fc54a2d99(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_bf54a9a7366f4f07a91a102fc54a2d99(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_bf54a9a7366f4f07a91a102fc54a2d99(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_bf54a9a7366f4f07a91a102fc54a2d99(_c180cb5af6e6cb942b930356b80db903_bf54a9a7366f4f07a91a102fc54a2d99 command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_4e6dafd89f1040b08e1f3e6ba4f76d47(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_4e6dafd89f1040b08e1f3e6ba4f76d47(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_4e6dafd89f1040b08e1f3e6ba4f76d47(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_4e6dafd89f1040b08e1f3e6ba4f76d47(_c180cb5af6e6cb942b930356b80db903_4e6dafd89f1040b08e1f3e6ba4f76d47 command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_60de2b152a9044d2bcff99ee69953f7f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_60de2b152a9044d2bcff99ee69953f7f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_60de2b152a9044d2bcff99ee69953f7f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_60de2b152a9044d2bcff99ee69953f7f(_c180cb5af6e6cb942b930356b80db903_60de2b152a9044d2bcff99ee69953f7f command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_294c9b9c386a47bd8fbfad7dd84f28f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_294c9b9c386a47bd8fbfad7dd84f28f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_294c9b9c386a47bd8fbfad7dd84f28f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_294c9b9c386a47bd8fbfad7dd84f28f4(_c180cb5af6e6cb942b930356b80db903_294c9b9c386a47bd8fbfad7dd84f28f4 command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_2b974c3778bd484e95b1b6eb4bd559af(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_2b974c3778bd484e95b1b6eb4bd559af(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_2b974c3778bd484e95b1b6eb4bd559af(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_2b974c3778bd484e95b1b6eb4bd559af(_c180cb5af6e6cb942b930356b80db903_2b974c3778bd484e95b1b6eb4bd559af command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_f65dcf31efbe4c80aa677d63f574524a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_f65dcf31efbe4c80aa677d63f574524a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_f65dcf31efbe4c80aa677d63f574524a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_f65dcf31efbe4c80aa677d63f574524a(_c180cb5af6e6cb942b930356b80db903_f65dcf31efbe4c80aa677d63f574524a command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_69b45c8bfad34c629f6b992d9ebad96e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_69b45c8bfad34c629f6b992d9ebad96e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_69b45c8bfad34c629f6b992d9ebad96e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_69b45c8bfad34c629f6b992d9ebad96e(_c180cb5af6e6cb942b930356b80db903_69b45c8bfad34c629f6b992d9ebad96e command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_2b3afe509e3a4a21914bf3749a6edcc8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_2b3afe509e3a4a21914bf3749a6edcc8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_2b3afe509e3a4a21914bf3749a6edcc8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_2b3afe509e3a4a21914bf3749a6edcc8(_c180cb5af6e6cb942b930356b80db903_2b3afe509e3a4a21914bf3749a6edcc8 command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_a31f4f36fdfb4b0f9ca915e8f1c10bc9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_a31f4f36fdfb4b0f9ca915e8f1c10bc9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_a31f4f36fdfb4b0f9ca915e8f1c10bc9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_a31f4f36fdfb4b0f9ca915e8f1c10bc9(_c180cb5af6e6cb942b930356b80db903_a31f4f36fdfb4b0f9ca915e8f1c10bc9 command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_2f7a88a3d0224bb1b5e19b3c7e350f54(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_2f7a88a3d0224bb1b5e19b3c7e350f54(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_2f7a88a3d0224bb1b5e19b3c7e350f54(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_2f7a88a3d0224bb1b5e19b3c7e350f54(_c180cb5af6e6cb942b930356b80db903_2f7a88a3d0224bb1b5e19b3c7e350f54 command)
		{
		}

		private void BakeCommandBinding__c180cb5af6e6cb942b930356b80db903_eb6ec4bd3fbc49de827b8566be67cd78(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c180cb5af6e6cb942b930356b80db903_eb6ec4bd3fbc49de827b8566be67cd78(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c180cb5af6e6cb942b930356b80db903_eb6ec4bd3fbc49de827b8566be67cd78(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c180cb5af6e6cb942b930356b80db903_eb6ec4bd3fbc49de827b8566be67cd78(_c180cb5af6e6cb942b930356b80db903_eb6ec4bd3fbc49de827b8566be67cd78 command)
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
