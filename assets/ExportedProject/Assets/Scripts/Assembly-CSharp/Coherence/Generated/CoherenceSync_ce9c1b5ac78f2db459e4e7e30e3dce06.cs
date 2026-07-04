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
	public class CoherenceSync_ce9c1b5ac78f2db459e4e7e30e3dce06 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_3559c57d9d2d4618a894042ce7adf6ea_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_b34f82345d59446192a0d4cca032346d_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_9d220cad712b4220bfffda9a7eaf8e21_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_ad9f3dcf2cce463ba35290e7531fb3c8_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_0118258b75794c639d295ed65cdfa7dc_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_e3183155d6c040f38ba7194338f714b7_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_1db04c605c154c2da02ae6ed39506844_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_5ecc3e33c4614e118b6aab7e6de4a009_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_ce189dbe2e124c87b9601f66b508a493_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_7623777cf7734a779e3599ead9f04804_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_e26ffbcd73ca4f62b0ab5d27c95c3b23_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_95eeae33316340a2a8498fab8bb8d308_CommandTarget;

		private CharacterController _ce9c1b5ac78f2db459e4e7e30e3dce06_953193a4a5a34444864a5ddecb9779a8_CommandTarget;

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

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_3559c57d9d2d4618a894042ce7adf6ea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_3559c57d9d2d4618a894042ce7adf6ea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_3559c57d9d2d4618a894042ce7adf6ea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_3559c57d9d2d4618a894042ce7adf6ea(_ce9c1b5ac78f2db459e4e7e30e3dce06_3559c57d9d2d4618a894042ce7adf6ea command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_b34f82345d59446192a0d4cca032346d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_b34f82345d59446192a0d4cca032346d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_b34f82345d59446192a0d4cca032346d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_b34f82345d59446192a0d4cca032346d(_ce9c1b5ac78f2db459e4e7e30e3dce06_b34f82345d59446192a0d4cca032346d command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_9d220cad712b4220bfffda9a7eaf8e21(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_9d220cad712b4220bfffda9a7eaf8e21(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_9d220cad712b4220bfffda9a7eaf8e21(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_9d220cad712b4220bfffda9a7eaf8e21(_ce9c1b5ac78f2db459e4e7e30e3dce06_9d220cad712b4220bfffda9a7eaf8e21 command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_ad9f3dcf2cce463ba35290e7531fb3c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_ad9f3dcf2cce463ba35290e7531fb3c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_ad9f3dcf2cce463ba35290e7531fb3c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_ad9f3dcf2cce463ba35290e7531fb3c8(_ce9c1b5ac78f2db459e4e7e30e3dce06_ad9f3dcf2cce463ba35290e7531fb3c8 command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_0118258b75794c639d295ed65cdfa7dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_0118258b75794c639d295ed65cdfa7dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_0118258b75794c639d295ed65cdfa7dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_0118258b75794c639d295ed65cdfa7dc(_ce9c1b5ac78f2db459e4e7e30e3dce06_0118258b75794c639d295ed65cdfa7dc command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_e3183155d6c040f38ba7194338f714b7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_e3183155d6c040f38ba7194338f714b7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_e3183155d6c040f38ba7194338f714b7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_e3183155d6c040f38ba7194338f714b7(_ce9c1b5ac78f2db459e4e7e30e3dce06_e3183155d6c040f38ba7194338f714b7 command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_1db04c605c154c2da02ae6ed39506844(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_1db04c605c154c2da02ae6ed39506844(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_1db04c605c154c2da02ae6ed39506844(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_1db04c605c154c2da02ae6ed39506844(_ce9c1b5ac78f2db459e4e7e30e3dce06_1db04c605c154c2da02ae6ed39506844 command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_5ecc3e33c4614e118b6aab7e6de4a009(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_5ecc3e33c4614e118b6aab7e6de4a009(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_5ecc3e33c4614e118b6aab7e6de4a009(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_5ecc3e33c4614e118b6aab7e6de4a009(_ce9c1b5ac78f2db459e4e7e30e3dce06_5ecc3e33c4614e118b6aab7e6de4a009 command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_ce189dbe2e124c87b9601f66b508a493(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_ce189dbe2e124c87b9601f66b508a493(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_ce189dbe2e124c87b9601f66b508a493(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_ce189dbe2e124c87b9601f66b508a493(_ce9c1b5ac78f2db459e4e7e30e3dce06_ce189dbe2e124c87b9601f66b508a493 command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_7623777cf7734a779e3599ead9f04804(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_7623777cf7734a779e3599ead9f04804(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_7623777cf7734a779e3599ead9f04804(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_7623777cf7734a779e3599ead9f04804(_ce9c1b5ac78f2db459e4e7e30e3dce06_7623777cf7734a779e3599ead9f04804 command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_e26ffbcd73ca4f62b0ab5d27c95c3b23(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_e26ffbcd73ca4f62b0ab5d27c95c3b23(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_e26ffbcd73ca4f62b0ab5d27c95c3b23(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_e26ffbcd73ca4f62b0ab5d27c95c3b23(_ce9c1b5ac78f2db459e4e7e30e3dce06_e26ffbcd73ca4f62b0ab5d27c95c3b23 command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_95eeae33316340a2a8498fab8bb8d308(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_95eeae33316340a2a8498fab8bb8d308(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_95eeae33316340a2a8498fab8bb8d308(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_95eeae33316340a2a8498fab8bb8d308(_ce9c1b5ac78f2db459e4e7e30e3dce06_95eeae33316340a2a8498fab8bb8d308 command)
		{
		}

		private void BakeCommandBinding__ce9c1b5ac78f2db459e4e7e30e3dce06_953193a4a5a34444864a5ddecb9779a8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_953193a4a5a34444864a5ddecb9779a8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_953193a4a5a34444864a5ddecb9779a8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce9c1b5ac78f2db459e4e7e30e3dce06_953193a4a5a34444864a5ddecb9779a8(_ce9c1b5ac78f2db459e4e7e30e3dce06_953193a4a5a34444864a5ddecb9779a8 command)
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
