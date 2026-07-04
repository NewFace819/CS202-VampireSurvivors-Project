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
	public class CoherenceSync_833f6bdfadb9f3a4ea2dbf59c18f1c2e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_29647e7f20e6457988416929b25f0efc_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_091b97f16e26417680872a7fcce10c71_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_2fc63d97aead44aaab2804050be7b6b1_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_116815ed33574a12b443d8ff3cfaba09_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_08366ed10ad144249279240b2b96db14_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_0025840111de4a28ade29f986a71b09a_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_e008ae3867484eac9d60602ca74770b0_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_4a3a756686924ad59c5b3838c61b33cd_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_17a44fa88f3742688ec3018bc0a4411a_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_a1f9cefafee340d9816e728ff39e7753_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_149cc7b744174d7e8149741623e775f8_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_e2720c2b614446d5b5f98ca931c30acb_CommandTarget;

		private CharacterController _833f6bdfadb9f3a4ea2dbf59c18f1c2e_d573d356bccc42cba7b248d54b1f004d_CommandTarget;

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

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_29647e7f20e6457988416929b25f0efc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_29647e7f20e6457988416929b25f0efc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_29647e7f20e6457988416929b25f0efc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_29647e7f20e6457988416929b25f0efc(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_29647e7f20e6457988416929b25f0efc command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_091b97f16e26417680872a7fcce10c71(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_091b97f16e26417680872a7fcce10c71(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_091b97f16e26417680872a7fcce10c71(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_091b97f16e26417680872a7fcce10c71(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_091b97f16e26417680872a7fcce10c71 command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_2fc63d97aead44aaab2804050be7b6b1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_2fc63d97aead44aaab2804050be7b6b1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_2fc63d97aead44aaab2804050be7b6b1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_2fc63d97aead44aaab2804050be7b6b1(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_2fc63d97aead44aaab2804050be7b6b1 command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_116815ed33574a12b443d8ff3cfaba09(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_116815ed33574a12b443d8ff3cfaba09(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_116815ed33574a12b443d8ff3cfaba09(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_116815ed33574a12b443d8ff3cfaba09(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_116815ed33574a12b443d8ff3cfaba09 command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_08366ed10ad144249279240b2b96db14(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_08366ed10ad144249279240b2b96db14(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_08366ed10ad144249279240b2b96db14(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_08366ed10ad144249279240b2b96db14(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_08366ed10ad144249279240b2b96db14 command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_0025840111de4a28ade29f986a71b09a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_0025840111de4a28ade29f986a71b09a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_0025840111de4a28ade29f986a71b09a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_0025840111de4a28ade29f986a71b09a(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_0025840111de4a28ade29f986a71b09a command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_e008ae3867484eac9d60602ca74770b0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_e008ae3867484eac9d60602ca74770b0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_e008ae3867484eac9d60602ca74770b0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_e008ae3867484eac9d60602ca74770b0(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_e008ae3867484eac9d60602ca74770b0 command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_4a3a756686924ad59c5b3838c61b33cd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_4a3a756686924ad59c5b3838c61b33cd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_4a3a756686924ad59c5b3838c61b33cd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_4a3a756686924ad59c5b3838c61b33cd(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_4a3a756686924ad59c5b3838c61b33cd command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_17a44fa88f3742688ec3018bc0a4411a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_17a44fa88f3742688ec3018bc0a4411a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_17a44fa88f3742688ec3018bc0a4411a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_17a44fa88f3742688ec3018bc0a4411a(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_17a44fa88f3742688ec3018bc0a4411a command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_a1f9cefafee340d9816e728ff39e7753(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_a1f9cefafee340d9816e728ff39e7753(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_a1f9cefafee340d9816e728ff39e7753(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_a1f9cefafee340d9816e728ff39e7753(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_a1f9cefafee340d9816e728ff39e7753 command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_149cc7b744174d7e8149741623e775f8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_149cc7b744174d7e8149741623e775f8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_149cc7b744174d7e8149741623e775f8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_149cc7b744174d7e8149741623e775f8(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_149cc7b744174d7e8149741623e775f8 command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_e2720c2b614446d5b5f98ca931c30acb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_e2720c2b614446d5b5f98ca931c30acb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_e2720c2b614446d5b5f98ca931c30acb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_e2720c2b614446d5b5f98ca931c30acb(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_e2720c2b614446d5b5f98ca931c30acb command)
		{
		}

		private void BakeCommandBinding__833f6bdfadb9f3a4ea2dbf59c18f1c2e_d573d356bccc42cba7b248d54b1f004d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_d573d356bccc42cba7b248d54b1f004d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_d573d356bccc42cba7b248d54b1f004d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__833f6bdfadb9f3a4ea2dbf59c18f1c2e_d573d356bccc42cba7b248d54b1f004d(_833f6bdfadb9f3a4ea2dbf59c18f1c2e_d573d356bccc42cba7b248d54b1f004d command)
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
