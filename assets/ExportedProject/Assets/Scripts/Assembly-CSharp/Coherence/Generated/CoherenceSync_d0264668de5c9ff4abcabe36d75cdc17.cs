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
	public class CoherenceSync_d0264668de5c9ff4abcabe36d75cdc17 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_47268d31c1e247ca91ae0e81772563a5_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_b8affdf974c148b0befefb76e58f9651_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_60dc54dd210a47a88f87d6e67e519de7_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_ea890d62ba244ea8a30649ada6777642_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_f56c98ecadc744eab2a1c8d38a55ec4b_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_7ccf8c37d6ee4f9091024ee482eeabbf_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_152dc653a4ea4c2c817178521cdf6757_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_91970b7b8a81438f91f09022274a43d6_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_25b9072849ae49b0a2fed766565f5066_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_c911d83726b44d08bb0148340926c5ab_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_ab2d8943b8d54df1adc1bbccdf3f6499_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_7559e63e414843e483c64fb83d82174d_CommandTarget;

		private CharacterController _d0264668de5c9ff4abcabe36d75cdc17_6ca9439e64c649b68051f30349c583c7_CommandTarget;

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

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_47268d31c1e247ca91ae0e81772563a5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_47268d31c1e247ca91ae0e81772563a5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_47268d31c1e247ca91ae0e81772563a5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_47268d31c1e247ca91ae0e81772563a5(_d0264668de5c9ff4abcabe36d75cdc17_47268d31c1e247ca91ae0e81772563a5 command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_b8affdf974c148b0befefb76e58f9651(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_b8affdf974c148b0befefb76e58f9651(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_b8affdf974c148b0befefb76e58f9651(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_b8affdf974c148b0befefb76e58f9651(_d0264668de5c9ff4abcabe36d75cdc17_b8affdf974c148b0befefb76e58f9651 command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_60dc54dd210a47a88f87d6e67e519de7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_60dc54dd210a47a88f87d6e67e519de7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_60dc54dd210a47a88f87d6e67e519de7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_60dc54dd210a47a88f87d6e67e519de7(_d0264668de5c9ff4abcabe36d75cdc17_60dc54dd210a47a88f87d6e67e519de7 command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_ea890d62ba244ea8a30649ada6777642(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_ea890d62ba244ea8a30649ada6777642(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_ea890d62ba244ea8a30649ada6777642(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_ea890d62ba244ea8a30649ada6777642(_d0264668de5c9ff4abcabe36d75cdc17_ea890d62ba244ea8a30649ada6777642 command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_f56c98ecadc744eab2a1c8d38a55ec4b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_f56c98ecadc744eab2a1c8d38a55ec4b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_f56c98ecadc744eab2a1c8d38a55ec4b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_f56c98ecadc744eab2a1c8d38a55ec4b(_d0264668de5c9ff4abcabe36d75cdc17_f56c98ecadc744eab2a1c8d38a55ec4b command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_7ccf8c37d6ee4f9091024ee482eeabbf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_7ccf8c37d6ee4f9091024ee482eeabbf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_7ccf8c37d6ee4f9091024ee482eeabbf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_7ccf8c37d6ee4f9091024ee482eeabbf(_d0264668de5c9ff4abcabe36d75cdc17_7ccf8c37d6ee4f9091024ee482eeabbf command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_152dc653a4ea4c2c817178521cdf6757(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_152dc653a4ea4c2c817178521cdf6757(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_152dc653a4ea4c2c817178521cdf6757(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_152dc653a4ea4c2c817178521cdf6757(_d0264668de5c9ff4abcabe36d75cdc17_152dc653a4ea4c2c817178521cdf6757 command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_91970b7b8a81438f91f09022274a43d6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_91970b7b8a81438f91f09022274a43d6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_91970b7b8a81438f91f09022274a43d6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_91970b7b8a81438f91f09022274a43d6(_d0264668de5c9ff4abcabe36d75cdc17_91970b7b8a81438f91f09022274a43d6 command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_25b9072849ae49b0a2fed766565f5066(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_25b9072849ae49b0a2fed766565f5066(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_25b9072849ae49b0a2fed766565f5066(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_25b9072849ae49b0a2fed766565f5066(_d0264668de5c9ff4abcabe36d75cdc17_25b9072849ae49b0a2fed766565f5066 command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_c911d83726b44d08bb0148340926c5ab(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_c911d83726b44d08bb0148340926c5ab(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_c911d83726b44d08bb0148340926c5ab(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_c911d83726b44d08bb0148340926c5ab(_d0264668de5c9ff4abcabe36d75cdc17_c911d83726b44d08bb0148340926c5ab command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_ab2d8943b8d54df1adc1bbccdf3f6499(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_ab2d8943b8d54df1adc1bbccdf3f6499(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_ab2d8943b8d54df1adc1bbccdf3f6499(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_ab2d8943b8d54df1adc1bbccdf3f6499(_d0264668de5c9ff4abcabe36d75cdc17_ab2d8943b8d54df1adc1bbccdf3f6499 command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_7559e63e414843e483c64fb83d82174d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_7559e63e414843e483c64fb83d82174d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_7559e63e414843e483c64fb83d82174d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_7559e63e414843e483c64fb83d82174d(_d0264668de5c9ff4abcabe36d75cdc17_7559e63e414843e483c64fb83d82174d command)
		{
		}

		private void BakeCommandBinding__d0264668de5c9ff4abcabe36d75cdc17_6ca9439e64c649b68051f30349c583c7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d0264668de5c9ff4abcabe36d75cdc17_6ca9439e64c649b68051f30349c583c7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d0264668de5c9ff4abcabe36d75cdc17_6ca9439e64c649b68051f30349c583c7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d0264668de5c9ff4abcabe36d75cdc17_6ca9439e64c649b68051f30349c583c7(_d0264668de5c9ff4abcabe36d75cdc17_6ca9439e64c649b68051f30349c583c7 command)
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
