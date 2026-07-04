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
	public class CoherenceSync_a86dbf590d04e0649bcc69d936d773b1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_fc8fc044edf648c6ad5dcbb31009f0e3_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_9950b326e9bc4e568e6431508a08dca8_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_ea316ce62568449a941e256a914c730b_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_b0e7a444d1a14ee48bec3e38925b2ad4_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_bac7d3c71f0446ba907ab5d0cd9300fb_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_a20f62cb3fc3407f9b9b05fa2a34f78c_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_0c0479f7665044d199b40ae3a8912873_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_8b5d21ba26c845caa661978f1db76bb3_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_d8546fa186114a1ba6d60353d1bce5ba_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_dd14ba1c486c4e56ac8471573d4c0503_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_1b5e411a81014797aca01a3fa338ee59_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_344dbfd538064d68ac1d443dda26c38d_CommandTarget;

		private CharacterController _a86dbf590d04e0649bcc69d936d773b1_a2ca93f6094a4be48788402a20b36521_CommandTarget;

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

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_fc8fc044edf648c6ad5dcbb31009f0e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_fc8fc044edf648c6ad5dcbb31009f0e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_fc8fc044edf648c6ad5dcbb31009f0e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_fc8fc044edf648c6ad5dcbb31009f0e3(_a86dbf590d04e0649bcc69d936d773b1_fc8fc044edf648c6ad5dcbb31009f0e3 command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_9950b326e9bc4e568e6431508a08dca8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_9950b326e9bc4e568e6431508a08dca8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_9950b326e9bc4e568e6431508a08dca8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_9950b326e9bc4e568e6431508a08dca8(_a86dbf590d04e0649bcc69d936d773b1_9950b326e9bc4e568e6431508a08dca8 command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_ea316ce62568449a941e256a914c730b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_ea316ce62568449a941e256a914c730b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_ea316ce62568449a941e256a914c730b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_ea316ce62568449a941e256a914c730b(_a86dbf590d04e0649bcc69d936d773b1_ea316ce62568449a941e256a914c730b command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_b0e7a444d1a14ee48bec3e38925b2ad4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_b0e7a444d1a14ee48bec3e38925b2ad4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_b0e7a444d1a14ee48bec3e38925b2ad4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_b0e7a444d1a14ee48bec3e38925b2ad4(_a86dbf590d04e0649bcc69d936d773b1_b0e7a444d1a14ee48bec3e38925b2ad4 command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_bac7d3c71f0446ba907ab5d0cd9300fb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_bac7d3c71f0446ba907ab5d0cd9300fb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_bac7d3c71f0446ba907ab5d0cd9300fb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_bac7d3c71f0446ba907ab5d0cd9300fb(_a86dbf590d04e0649bcc69d936d773b1_bac7d3c71f0446ba907ab5d0cd9300fb command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_a20f62cb3fc3407f9b9b05fa2a34f78c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_a20f62cb3fc3407f9b9b05fa2a34f78c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_a20f62cb3fc3407f9b9b05fa2a34f78c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_a20f62cb3fc3407f9b9b05fa2a34f78c(_a86dbf590d04e0649bcc69d936d773b1_a20f62cb3fc3407f9b9b05fa2a34f78c command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_0c0479f7665044d199b40ae3a8912873(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_0c0479f7665044d199b40ae3a8912873(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_0c0479f7665044d199b40ae3a8912873(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_0c0479f7665044d199b40ae3a8912873(_a86dbf590d04e0649bcc69d936d773b1_0c0479f7665044d199b40ae3a8912873 command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_8b5d21ba26c845caa661978f1db76bb3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_8b5d21ba26c845caa661978f1db76bb3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_8b5d21ba26c845caa661978f1db76bb3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_8b5d21ba26c845caa661978f1db76bb3(_a86dbf590d04e0649bcc69d936d773b1_8b5d21ba26c845caa661978f1db76bb3 command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_d8546fa186114a1ba6d60353d1bce5ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_d8546fa186114a1ba6d60353d1bce5ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_d8546fa186114a1ba6d60353d1bce5ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_d8546fa186114a1ba6d60353d1bce5ba(_a86dbf590d04e0649bcc69d936d773b1_d8546fa186114a1ba6d60353d1bce5ba command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_dd14ba1c486c4e56ac8471573d4c0503(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_dd14ba1c486c4e56ac8471573d4c0503(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_dd14ba1c486c4e56ac8471573d4c0503(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_dd14ba1c486c4e56ac8471573d4c0503(_a86dbf590d04e0649bcc69d936d773b1_dd14ba1c486c4e56ac8471573d4c0503 command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_1b5e411a81014797aca01a3fa338ee59(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_1b5e411a81014797aca01a3fa338ee59(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_1b5e411a81014797aca01a3fa338ee59(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_1b5e411a81014797aca01a3fa338ee59(_a86dbf590d04e0649bcc69d936d773b1_1b5e411a81014797aca01a3fa338ee59 command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_344dbfd538064d68ac1d443dda26c38d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_344dbfd538064d68ac1d443dda26c38d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_344dbfd538064d68ac1d443dda26c38d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_344dbfd538064d68ac1d443dda26c38d(_a86dbf590d04e0649bcc69d936d773b1_344dbfd538064d68ac1d443dda26c38d command)
		{
		}

		private void BakeCommandBinding__a86dbf590d04e0649bcc69d936d773b1_a2ca93f6094a4be48788402a20b36521(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a86dbf590d04e0649bcc69d936d773b1_a2ca93f6094a4be48788402a20b36521(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a86dbf590d04e0649bcc69d936d773b1_a2ca93f6094a4be48788402a20b36521(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a86dbf590d04e0649bcc69d936d773b1_a2ca93f6094a4be48788402a20b36521(_a86dbf590d04e0649bcc69d936d773b1_a2ca93f6094a4be48788402a20b36521 command)
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
