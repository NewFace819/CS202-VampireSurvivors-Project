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
	public class CoherenceSync_87ae72cdba9ade446811d62dc7f908b0 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_dfb42454686e44c79f9abb4d9e9fce2b_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_906e6d531be842b99a2f9f0b40a157f1_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_6a17f1e866a544aebc69e92a90d2a75c_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_379a1eb909d341cea7caef6436980d0f_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_8eb9df216977447b8ce1614230d70a67_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_f35860692dd84316b0a921dea941b116_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_1b9b0b376cfc4811b96c7e504481c69c_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_40a0a5a6e2304393832fa2bf8cb45b1a_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_3e014b88ae3349f88db5dfddeb9cb094_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_3f51869d176e49a2a83dd3adcf83a2fa_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_5c5f6f0408c74ddfac02f6bd175f6111_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_20308457ee91475d9a21dd487edb359f_CommandTarget;

		private CharacterController _87ae72cdba9ade446811d62dc7f908b0_ac4395a5e193414a8f0526826d331569_CommandTarget;

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

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_dfb42454686e44c79f9abb4d9e9fce2b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_dfb42454686e44c79f9abb4d9e9fce2b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_dfb42454686e44c79f9abb4d9e9fce2b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_dfb42454686e44c79f9abb4d9e9fce2b(_87ae72cdba9ade446811d62dc7f908b0_dfb42454686e44c79f9abb4d9e9fce2b command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_906e6d531be842b99a2f9f0b40a157f1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_906e6d531be842b99a2f9f0b40a157f1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_906e6d531be842b99a2f9f0b40a157f1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_906e6d531be842b99a2f9f0b40a157f1(_87ae72cdba9ade446811d62dc7f908b0_906e6d531be842b99a2f9f0b40a157f1 command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_6a17f1e866a544aebc69e92a90d2a75c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_6a17f1e866a544aebc69e92a90d2a75c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_6a17f1e866a544aebc69e92a90d2a75c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_6a17f1e866a544aebc69e92a90d2a75c(_87ae72cdba9ade446811d62dc7f908b0_6a17f1e866a544aebc69e92a90d2a75c command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_379a1eb909d341cea7caef6436980d0f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_379a1eb909d341cea7caef6436980d0f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_379a1eb909d341cea7caef6436980d0f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_379a1eb909d341cea7caef6436980d0f(_87ae72cdba9ade446811d62dc7f908b0_379a1eb909d341cea7caef6436980d0f command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_8eb9df216977447b8ce1614230d70a67(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_8eb9df216977447b8ce1614230d70a67(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_8eb9df216977447b8ce1614230d70a67(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_8eb9df216977447b8ce1614230d70a67(_87ae72cdba9ade446811d62dc7f908b0_8eb9df216977447b8ce1614230d70a67 command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_f35860692dd84316b0a921dea941b116(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_f35860692dd84316b0a921dea941b116(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_f35860692dd84316b0a921dea941b116(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_f35860692dd84316b0a921dea941b116(_87ae72cdba9ade446811d62dc7f908b0_f35860692dd84316b0a921dea941b116 command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_1b9b0b376cfc4811b96c7e504481c69c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_1b9b0b376cfc4811b96c7e504481c69c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_1b9b0b376cfc4811b96c7e504481c69c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_1b9b0b376cfc4811b96c7e504481c69c(_87ae72cdba9ade446811d62dc7f908b0_1b9b0b376cfc4811b96c7e504481c69c command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_40a0a5a6e2304393832fa2bf8cb45b1a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_40a0a5a6e2304393832fa2bf8cb45b1a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_40a0a5a6e2304393832fa2bf8cb45b1a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_40a0a5a6e2304393832fa2bf8cb45b1a(_87ae72cdba9ade446811d62dc7f908b0_40a0a5a6e2304393832fa2bf8cb45b1a command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_3e014b88ae3349f88db5dfddeb9cb094(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_3e014b88ae3349f88db5dfddeb9cb094(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_3e014b88ae3349f88db5dfddeb9cb094(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_3e014b88ae3349f88db5dfddeb9cb094(_87ae72cdba9ade446811d62dc7f908b0_3e014b88ae3349f88db5dfddeb9cb094 command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_3f51869d176e49a2a83dd3adcf83a2fa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_3f51869d176e49a2a83dd3adcf83a2fa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_3f51869d176e49a2a83dd3adcf83a2fa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_3f51869d176e49a2a83dd3adcf83a2fa(_87ae72cdba9ade446811d62dc7f908b0_3f51869d176e49a2a83dd3adcf83a2fa command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_5c5f6f0408c74ddfac02f6bd175f6111(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_5c5f6f0408c74ddfac02f6bd175f6111(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_5c5f6f0408c74ddfac02f6bd175f6111(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_5c5f6f0408c74ddfac02f6bd175f6111(_87ae72cdba9ade446811d62dc7f908b0_5c5f6f0408c74ddfac02f6bd175f6111 command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_20308457ee91475d9a21dd487edb359f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_20308457ee91475d9a21dd487edb359f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_20308457ee91475d9a21dd487edb359f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_20308457ee91475d9a21dd487edb359f(_87ae72cdba9ade446811d62dc7f908b0_20308457ee91475d9a21dd487edb359f command)
		{
		}

		private void BakeCommandBinding__87ae72cdba9ade446811d62dc7f908b0_ac4395a5e193414a8f0526826d331569(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__87ae72cdba9ade446811d62dc7f908b0_ac4395a5e193414a8f0526826d331569(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__87ae72cdba9ade446811d62dc7f908b0_ac4395a5e193414a8f0526826d331569(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__87ae72cdba9ade446811d62dc7f908b0_ac4395a5e193414a8f0526826d331569(_87ae72cdba9ade446811d62dc7f908b0_ac4395a5e193414a8f0526826d331569 command)
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
