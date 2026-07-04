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
	public class CoherenceSync_5c095ac93bd37d94cbe03b9339204127 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_0995e11a97f3499295bb606df1dc5a18_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_a32f1ccc423f4c8e82a837e4d539cb42_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_4dc121654056438a950b9f9098d50846_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_2b399bd6f60f43c99fd4b1a05a3c95f7_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_ba643ffe6b054769b5caa7d0566b3a2b_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_eedaa89af3d0475982478ce7fb571d65_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_f43cf1522201423b8448128d7b1bf256_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_683d807d460e478fabb807ace55fadfc_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_3508e93c563d49a7a7223e4f760d7c2a_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_e8346ad63dce42ce92f5ad1a51e64664_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_ba059fc792a84bcc88318eb98fc95d5a_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_6b62104b5d204943b035adc8cbe45061_CommandTarget;

		private CharacterController _5c095ac93bd37d94cbe03b9339204127_cfecac196e41441f9f65d212adafe15f_CommandTarget;

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

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_0995e11a97f3499295bb606df1dc5a18(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_0995e11a97f3499295bb606df1dc5a18(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_0995e11a97f3499295bb606df1dc5a18(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_0995e11a97f3499295bb606df1dc5a18(_5c095ac93bd37d94cbe03b9339204127_0995e11a97f3499295bb606df1dc5a18 command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_a32f1ccc423f4c8e82a837e4d539cb42(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_a32f1ccc423f4c8e82a837e4d539cb42(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_a32f1ccc423f4c8e82a837e4d539cb42(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_a32f1ccc423f4c8e82a837e4d539cb42(_5c095ac93bd37d94cbe03b9339204127_a32f1ccc423f4c8e82a837e4d539cb42 command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_4dc121654056438a950b9f9098d50846(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_4dc121654056438a950b9f9098d50846(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_4dc121654056438a950b9f9098d50846(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_4dc121654056438a950b9f9098d50846(_5c095ac93bd37d94cbe03b9339204127_4dc121654056438a950b9f9098d50846 command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_2b399bd6f60f43c99fd4b1a05a3c95f7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_2b399bd6f60f43c99fd4b1a05a3c95f7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_2b399bd6f60f43c99fd4b1a05a3c95f7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_2b399bd6f60f43c99fd4b1a05a3c95f7(_5c095ac93bd37d94cbe03b9339204127_2b399bd6f60f43c99fd4b1a05a3c95f7 command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_ba643ffe6b054769b5caa7d0566b3a2b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_ba643ffe6b054769b5caa7d0566b3a2b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_ba643ffe6b054769b5caa7d0566b3a2b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_ba643ffe6b054769b5caa7d0566b3a2b(_5c095ac93bd37d94cbe03b9339204127_ba643ffe6b054769b5caa7d0566b3a2b command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_eedaa89af3d0475982478ce7fb571d65(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_eedaa89af3d0475982478ce7fb571d65(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_eedaa89af3d0475982478ce7fb571d65(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_eedaa89af3d0475982478ce7fb571d65(_5c095ac93bd37d94cbe03b9339204127_eedaa89af3d0475982478ce7fb571d65 command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_f43cf1522201423b8448128d7b1bf256(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_f43cf1522201423b8448128d7b1bf256(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_f43cf1522201423b8448128d7b1bf256(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_f43cf1522201423b8448128d7b1bf256(_5c095ac93bd37d94cbe03b9339204127_f43cf1522201423b8448128d7b1bf256 command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_683d807d460e478fabb807ace55fadfc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_683d807d460e478fabb807ace55fadfc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_683d807d460e478fabb807ace55fadfc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_683d807d460e478fabb807ace55fadfc(_5c095ac93bd37d94cbe03b9339204127_683d807d460e478fabb807ace55fadfc command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_3508e93c563d49a7a7223e4f760d7c2a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_3508e93c563d49a7a7223e4f760d7c2a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_3508e93c563d49a7a7223e4f760d7c2a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_3508e93c563d49a7a7223e4f760d7c2a(_5c095ac93bd37d94cbe03b9339204127_3508e93c563d49a7a7223e4f760d7c2a command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_e8346ad63dce42ce92f5ad1a51e64664(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_e8346ad63dce42ce92f5ad1a51e64664(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_e8346ad63dce42ce92f5ad1a51e64664(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_e8346ad63dce42ce92f5ad1a51e64664(_5c095ac93bd37d94cbe03b9339204127_e8346ad63dce42ce92f5ad1a51e64664 command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_ba059fc792a84bcc88318eb98fc95d5a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_ba059fc792a84bcc88318eb98fc95d5a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_ba059fc792a84bcc88318eb98fc95d5a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_ba059fc792a84bcc88318eb98fc95d5a(_5c095ac93bd37d94cbe03b9339204127_ba059fc792a84bcc88318eb98fc95d5a command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_6b62104b5d204943b035adc8cbe45061(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_6b62104b5d204943b035adc8cbe45061(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_6b62104b5d204943b035adc8cbe45061(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_6b62104b5d204943b035adc8cbe45061(_5c095ac93bd37d94cbe03b9339204127_6b62104b5d204943b035adc8cbe45061 command)
		{
		}

		private void BakeCommandBinding__5c095ac93bd37d94cbe03b9339204127_cfecac196e41441f9f65d212adafe15f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__5c095ac93bd37d94cbe03b9339204127_cfecac196e41441f9f65d212adafe15f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__5c095ac93bd37d94cbe03b9339204127_cfecac196e41441f9f65d212adafe15f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__5c095ac93bd37d94cbe03b9339204127_cfecac196e41441f9f65d212adafe15f(_5c095ac93bd37d94cbe03b9339204127_cfecac196e41441f9f65d212adafe15f command)
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
