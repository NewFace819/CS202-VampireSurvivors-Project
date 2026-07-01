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
	public class CoherenceSync_77a0b9d7d1693e348b23742e9af9fa50 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_6aec4fdc0df642fbb7341513c78cd950_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_ebeea2341cc24a8f99008fcca06e0603_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_c7034707667a4e2386646b2e770eab16_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_b2413512a4f74ffbb091a18043a5f999_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_21159f5c043e4be7a79f5872f6f08af3_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_5e0c76ef1cb34f379b52b1c7809e6ae7_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_439467ea1d0544ea9d5d004141b44096_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_7347bf5f8349493da0c431fe62ac9d8d_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_acbf127eaa38492580f3353e37436952_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_c4143e3544d7474390bc01389b7cddc8_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_fa5f9d6c59a948e48caa09db271be362_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_90921fa1b7a646ff893e4ea801c3f195_CommandTarget;

		private CharacterController _77a0b9d7d1693e348b23742e9af9fa50_fcc425ae5d8f46e680c1f71dc63ed315_CommandTarget;

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

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_6aec4fdc0df642fbb7341513c78cd950(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_6aec4fdc0df642fbb7341513c78cd950(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_6aec4fdc0df642fbb7341513c78cd950(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_6aec4fdc0df642fbb7341513c78cd950(_77a0b9d7d1693e348b23742e9af9fa50_6aec4fdc0df642fbb7341513c78cd950 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_ebeea2341cc24a8f99008fcca06e0603(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_ebeea2341cc24a8f99008fcca06e0603(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_ebeea2341cc24a8f99008fcca06e0603(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_ebeea2341cc24a8f99008fcca06e0603(_77a0b9d7d1693e348b23742e9af9fa50_ebeea2341cc24a8f99008fcca06e0603 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_c7034707667a4e2386646b2e770eab16(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_c7034707667a4e2386646b2e770eab16(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_c7034707667a4e2386646b2e770eab16(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_c7034707667a4e2386646b2e770eab16(_77a0b9d7d1693e348b23742e9af9fa50_c7034707667a4e2386646b2e770eab16 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_b2413512a4f74ffbb091a18043a5f999(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_b2413512a4f74ffbb091a18043a5f999(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_b2413512a4f74ffbb091a18043a5f999(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_b2413512a4f74ffbb091a18043a5f999(_77a0b9d7d1693e348b23742e9af9fa50_b2413512a4f74ffbb091a18043a5f999 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_21159f5c043e4be7a79f5872f6f08af3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_21159f5c043e4be7a79f5872f6f08af3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_21159f5c043e4be7a79f5872f6f08af3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_21159f5c043e4be7a79f5872f6f08af3(_77a0b9d7d1693e348b23742e9af9fa50_21159f5c043e4be7a79f5872f6f08af3 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_5e0c76ef1cb34f379b52b1c7809e6ae7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_5e0c76ef1cb34f379b52b1c7809e6ae7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_5e0c76ef1cb34f379b52b1c7809e6ae7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_5e0c76ef1cb34f379b52b1c7809e6ae7(_77a0b9d7d1693e348b23742e9af9fa50_5e0c76ef1cb34f379b52b1c7809e6ae7 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_439467ea1d0544ea9d5d004141b44096(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_439467ea1d0544ea9d5d004141b44096(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_439467ea1d0544ea9d5d004141b44096(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_439467ea1d0544ea9d5d004141b44096(_77a0b9d7d1693e348b23742e9af9fa50_439467ea1d0544ea9d5d004141b44096 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_7347bf5f8349493da0c431fe62ac9d8d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_7347bf5f8349493da0c431fe62ac9d8d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_7347bf5f8349493da0c431fe62ac9d8d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_7347bf5f8349493da0c431fe62ac9d8d(_77a0b9d7d1693e348b23742e9af9fa50_7347bf5f8349493da0c431fe62ac9d8d command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_acbf127eaa38492580f3353e37436952(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_acbf127eaa38492580f3353e37436952(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_acbf127eaa38492580f3353e37436952(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_acbf127eaa38492580f3353e37436952(_77a0b9d7d1693e348b23742e9af9fa50_acbf127eaa38492580f3353e37436952 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_c4143e3544d7474390bc01389b7cddc8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_c4143e3544d7474390bc01389b7cddc8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_c4143e3544d7474390bc01389b7cddc8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_c4143e3544d7474390bc01389b7cddc8(_77a0b9d7d1693e348b23742e9af9fa50_c4143e3544d7474390bc01389b7cddc8 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_fa5f9d6c59a948e48caa09db271be362(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_fa5f9d6c59a948e48caa09db271be362(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_fa5f9d6c59a948e48caa09db271be362(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_fa5f9d6c59a948e48caa09db271be362(_77a0b9d7d1693e348b23742e9af9fa50_fa5f9d6c59a948e48caa09db271be362 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_90921fa1b7a646ff893e4ea801c3f195(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_90921fa1b7a646ff893e4ea801c3f195(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_90921fa1b7a646ff893e4ea801c3f195(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_90921fa1b7a646ff893e4ea801c3f195(_77a0b9d7d1693e348b23742e9af9fa50_90921fa1b7a646ff893e4ea801c3f195 command)
		{
		}

		private void BakeCommandBinding__77a0b9d7d1693e348b23742e9af9fa50_fcc425ae5d8f46e680c1f71dc63ed315(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__77a0b9d7d1693e348b23742e9af9fa50_fcc425ae5d8f46e680c1f71dc63ed315(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__77a0b9d7d1693e348b23742e9af9fa50_fcc425ae5d8f46e680c1f71dc63ed315(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__77a0b9d7d1693e348b23742e9af9fa50_fcc425ae5d8f46e680c1f71dc63ed315(_77a0b9d7d1693e348b23742e9af9fa50_fcc425ae5d8f46e680c1f71dc63ed315 command)
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
