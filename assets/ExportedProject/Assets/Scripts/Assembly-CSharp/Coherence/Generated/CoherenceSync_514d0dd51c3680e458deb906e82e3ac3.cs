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
	public class CoherenceSync_514d0dd51c3680e458deb906e82e3ac3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_79cca134c97146119bb14bf6298012b4_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_ae0eb77eb4a14edd9ffdae1089f5521c_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_749081c2b7ae4df58104c5a0abd73a17_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_5533c5ad99aa4d119f438b37277fdd7c_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_a671c9d60274466fb9b45cb78e640db2_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_5c87f8c4de6940bb9f2f8951bde38e6a_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_e2fa9b1486624cd4b5ee1a00c0923a7c_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_911c98def84746648502f15284dad140_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_85cad728ffbc4962b2fa40da074f3ffa_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_64eab69c7b3a4abbb11dda771d2a1ea3_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_36ffcd2bd1814ab1aa9b0d11509279af_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_32fd4d9d35d74ddd815882c13655aab3_CommandTarget;

		private CharacterController _514d0dd51c3680e458deb906e82e3ac3_71a05f195eaa43cf83320bf1246780d4_CommandTarget;

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

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_79cca134c97146119bb14bf6298012b4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_79cca134c97146119bb14bf6298012b4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_79cca134c97146119bb14bf6298012b4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_79cca134c97146119bb14bf6298012b4(_514d0dd51c3680e458deb906e82e3ac3_79cca134c97146119bb14bf6298012b4 command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_ae0eb77eb4a14edd9ffdae1089f5521c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_ae0eb77eb4a14edd9ffdae1089f5521c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_ae0eb77eb4a14edd9ffdae1089f5521c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_ae0eb77eb4a14edd9ffdae1089f5521c(_514d0dd51c3680e458deb906e82e3ac3_ae0eb77eb4a14edd9ffdae1089f5521c command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_749081c2b7ae4df58104c5a0abd73a17(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_749081c2b7ae4df58104c5a0abd73a17(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_749081c2b7ae4df58104c5a0abd73a17(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_749081c2b7ae4df58104c5a0abd73a17(_514d0dd51c3680e458deb906e82e3ac3_749081c2b7ae4df58104c5a0abd73a17 command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_5533c5ad99aa4d119f438b37277fdd7c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_5533c5ad99aa4d119f438b37277fdd7c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_5533c5ad99aa4d119f438b37277fdd7c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_5533c5ad99aa4d119f438b37277fdd7c(_514d0dd51c3680e458deb906e82e3ac3_5533c5ad99aa4d119f438b37277fdd7c command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_a671c9d60274466fb9b45cb78e640db2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_a671c9d60274466fb9b45cb78e640db2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_a671c9d60274466fb9b45cb78e640db2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_a671c9d60274466fb9b45cb78e640db2(_514d0dd51c3680e458deb906e82e3ac3_a671c9d60274466fb9b45cb78e640db2 command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_5c87f8c4de6940bb9f2f8951bde38e6a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_5c87f8c4de6940bb9f2f8951bde38e6a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_5c87f8c4de6940bb9f2f8951bde38e6a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_5c87f8c4de6940bb9f2f8951bde38e6a(_514d0dd51c3680e458deb906e82e3ac3_5c87f8c4de6940bb9f2f8951bde38e6a command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_e2fa9b1486624cd4b5ee1a00c0923a7c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_e2fa9b1486624cd4b5ee1a00c0923a7c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_e2fa9b1486624cd4b5ee1a00c0923a7c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_e2fa9b1486624cd4b5ee1a00c0923a7c(_514d0dd51c3680e458deb906e82e3ac3_e2fa9b1486624cd4b5ee1a00c0923a7c command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_911c98def84746648502f15284dad140(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_911c98def84746648502f15284dad140(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_911c98def84746648502f15284dad140(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_911c98def84746648502f15284dad140(_514d0dd51c3680e458deb906e82e3ac3_911c98def84746648502f15284dad140 command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_85cad728ffbc4962b2fa40da074f3ffa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_85cad728ffbc4962b2fa40da074f3ffa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_85cad728ffbc4962b2fa40da074f3ffa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_85cad728ffbc4962b2fa40da074f3ffa(_514d0dd51c3680e458deb906e82e3ac3_85cad728ffbc4962b2fa40da074f3ffa command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_64eab69c7b3a4abbb11dda771d2a1ea3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_64eab69c7b3a4abbb11dda771d2a1ea3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_64eab69c7b3a4abbb11dda771d2a1ea3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_64eab69c7b3a4abbb11dda771d2a1ea3(_514d0dd51c3680e458deb906e82e3ac3_64eab69c7b3a4abbb11dda771d2a1ea3 command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_36ffcd2bd1814ab1aa9b0d11509279af(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_36ffcd2bd1814ab1aa9b0d11509279af(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_36ffcd2bd1814ab1aa9b0d11509279af(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_36ffcd2bd1814ab1aa9b0d11509279af(_514d0dd51c3680e458deb906e82e3ac3_36ffcd2bd1814ab1aa9b0d11509279af command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_32fd4d9d35d74ddd815882c13655aab3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_32fd4d9d35d74ddd815882c13655aab3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_32fd4d9d35d74ddd815882c13655aab3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_32fd4d9d35d74ddd815882c13655aab3(_514d0dd51c3680e458deb906e82e3ac3_32fd4d9d35d74ddd815882c13655aab3 command)
		{
		}

		private void BakeCommandBinding__514d0dd51c3680e458deb906e82e3ac3_71a05f195eaa43cf83320bf1246780d4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__514d0dd51c3680e458deb906e82e3ac3_71a05f195eaa43cf83320bf1246780d4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__514d0dd51c3680e458deb906e82e3ac3_71a05f195eaa43cf83320bf1246780d4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__514d0dd51c3680e458deb906e82e3ac3_71a05f195eaa43cf83320bf1246780d4(_514d0dd51c3680e458deb906e82e3ac3_71a05f195eaa43cf83320bf1246780d4 command)
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
