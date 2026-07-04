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
	public class CoherenceSync_b3f6245be165a5240a5be041a1585971 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _b3f6245be165a5240a5be041a1585971_dc1b8d5c76a54a7c98e22c005de23cf8_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_8fbb134eaa9448d0b0676c6b881c31b3_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_228b9c4409c342b89252f75737fe4fc7_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_7b1157d6776944848bd447b4ca87e0ca_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_0b6e1380a95d42b08c1cf24976b37d5c_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_98df07d6714943f3a8d5f095e89a1c0e_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_84e5466f272942558565fc46df996609_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_349e7e1f6ce54425b183031da5d7924d_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_eb0c5e86e0b746c3b9735edb3b3731bd_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_266274fc27094acc8bc150f9d8783ff8_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_29942ba679484e2ea4736ea9e8e36c64_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_3bb50e6d30bb406498c57bc7a33c54ba_CommandTarget;

		private CharacterController _b3f6245be165a5240a5be041a1585971_3cd14cc2d27642be86fefc10a89a94d0_CommandTarget;

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

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_dc1b8d5c76a54a7c98e22c005de23cf8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_dc1b8d5c76a54a7c98e22c005de23cf8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_dc1b8d5c76a54a7c98e22c005de23cf8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_dc1b8d5c76a54a7c98e22c005de23cf8(_b3f6245be165a5240a5be041a1585971_dc1b8d5c76a54a7c98e22c005de23cf8 command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_8fbb134eaa9448d0b0676c6b881c31b3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_8fbb134eaa9448d0b0676c6b881c31b3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_8fbb134eaa9448d0b0676c6b881c31b3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_8fbb134eaa9448d0b0676c6b881c31b3(_b3f6245be165a5240a5be041a1585971_8fbb134eaa9448d0b0676c6b881c31b3 command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_228b9c4409c342b89252f75737fe4fc7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_228b9c4409c342b89252f75737fe4fc7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_228b9c4409c342b89252f75737fe4fc7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_228b9c4409c342b89252f75737fe4fc7(_b3f6245be165a5240a5be041a1585971_228b9c4409c342b89252f75737fe4fc7 command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_7b1157d6776944848bd447b4ca87e0ca(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_7b1157d6776944848bd447b4ca87e0ca(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_7b1157d6776944848bd447b4ca87e0ca(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_7b1157d6776944848bd447b4ca87e0ca(_b3f6245be165a5240a5be041a1585971_7b1157d6776944848bd447b4ca87e0ca command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_0b6e1380a95d42b08c1cf24976b37d5c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_0b6e1380a95d42b08c1cf24976b37d5c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_0b6e1380a95d42b08c1cf24976b37d5c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_0b6e1380a95d42b08c1cf24976b37d5c(_b3f6245be165a5240a5be041a1585971_0b6e1380a95d42b08c1cf24976b37d5c command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_98df07d6714943f3a8d5f095e89a1c0e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_98df07d6714943f3a8d5f095e89a1c0e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_98df07d6714943f3a8d5f095e89a1c0e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_98df07d6714943f3a8d5f095e89a1c0e(_b3f6245be165a5240a5be041a1585971_98df07d6714943f3a8d5f095e89a1c0e command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_84e5466f272942558565fc46df996609(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_84e5466f272942558565fc46df996609(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_84e5466f272942558565fc46df996609(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_84e5466f272942558565fc46df996609(_b3f6245be165a5240a5be041a1585971_84e5466f272942558565fc46df996609 command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_349e7e1f6ce54425b183031da5d7924d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_349e7e1f6ce54425b183031da5d7924d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_349e7e1f6ce54425b183031da5d7924d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_349e7e1f6ce54425b183031da5d7924d(_b3f6245be165a5240a5be041a1585971_349e7e1f6ce54425b183031da5d7924d command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_eb0c5e86e0b746c3b9735edb3b3731bd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_eb0c5e86e0b746c3b9735edb3b3731bd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_eb0c5e86e0b746c3b9735edb3b3731bd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_eb0c5e86e0b746c3b9735edb3b3731bd(_b3f6245be165a5240a5be041a1585971_eb0c5e86e0b746c3b9735edb3b3731bd command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_266274fc27094acc8bc150f9d8783ff8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_266274fc27094acc8bc150f9d8783ff8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_266274fc27094acc8bc150f9d8783ff8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_266274fc27094acc8bc150f9d8783ff8(_b3f6245be165a5240a5be041a1585971_266274fc27094acc8bc150f9d8783ff8 command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_29942ba679484e2ea4736ea9e8e36c64(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_29942ba679484e2ea4736ea9e8e36c64(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_29942ba679484e2ea4736ea9e8e36c64(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_29942ba679484e2ea4736ea9e8e36c64(_b3f6245be165a5240a5be041a1585971_29942ba679484e2ea4736ea9e8e36c64 command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_3bb50e6d30bb406498c57bc7a33c54ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_3bb50e6d30bb406498c57bc7a33c54ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_3bb50e6d30bb406498c57bc7a33c54ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_3bb50e6d30bb406498c57bc7a33c54ba(_b3f6245be165a5240a5be041a1585971_3bb50e6d30bb406498c57bc7a33c54ba command)
		{
		}

		private void BakeCommandBinding__b3f6245be165a5240a5be041a1585971_3cd14cc2d27642be86fefc10a89a94d0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3f6245be165a5240a5be041a1585971_3cd14cc2d27642be86fefc10a89a94d0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3f6245be165a5240a5be041a1585971_3cd14cc2d27642be86fefc10a89a94d0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3f6245be165a5240a5be041a1585971_3cd14cc2d27642be86fefc10a89a94d0(_b3f6245be165a5240a5be041a1585971_3cd14cc2d27642be86fefc10a89a94d0 command)
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
