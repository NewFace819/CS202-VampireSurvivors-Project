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
	public class CoherenceSync_4ad61933cff6c344b947676756feb8fa : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_a0eaaf23a4b34c7dbfdbb31bd6d18215_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_a2e90c80f86d452aacc804615d848fc8_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_fccaa1524c214156b9926ed0e0b37958_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_dcf4ce63aa9f4cce80460b9ce89d0929_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_d52af2792d6a46eeb26deaf5e2eefea8_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_fac8eab8ddee40db9d45079a70d9b594_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_80619e04cb76405cb1456e211f8aab67_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_393cc9e9495b443c998d0a99c686a6a2_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_a0e81fc9a19544d3a6e9eb940a6fb433_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_76757bc6278e4a1f933ee0ea9b90fc3f_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_d35d63b4afa44970aa90061a5caa4633_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_6f38b30d03d340c6ab6f89ce36d1a5a0_CommandTarget;

		private CharacterController _4ad61933cff6c344b947676756feb8fa_b12f8c0b4f524823a4f2c06e60bb97d3_CommandTarget;

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

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_a0eaaf23a4b34c7dbfdbb31bd6d18215(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_a0eaaf23a4b34c7dbfdbb31bd6d18215(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_a0eaaf23a4b34c7dbfdbb31bd6d18215(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_a0eaaf23a4b34c7dbfdbb31bd6d18215(_4ad61933cff6c344b947676756feb8fa_a0eaaf23a4b34c7dbfdbb31bd6d18215 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_a2e90c80f86d452aacc804615d848fc8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_a2e90c80f86d452aacc804615d848fc8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_a2e90c80f86d452aacc804615d848fc8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_a2e90c80f86d452aacc804615d848fc8(_4ad61933cff6c344b947676756feb8fa_a2e90c80f86d452aacc804615d848fc8 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_fccaa1524c214156b9926ed0e0b37958(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_fccaa1524c214156b9926ed0e0b37958(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_fccaa1524c214156b9926ed0e0b37958(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_fccaa1524c214156b9926ed0e0b37958(_4ad61933cff6c344b947676756feb8fa_fccaa1524c214156b9926ed0e0b37958 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_dcf4ce63aa9f4cce80460b9ce89d0929(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_dcf4ce63aa9f4cce80460b9ce89d0929(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_dcf4ce63aa9f4cce80460b9ce89d0929(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_dcf4ce63aa9f4cce80460b9ce89d0929(_4ad61933cff6c344b947676756feb8fa_dcf4ce63aa9f4cce80460b9ce89d0929 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_d52af2792d6a46eeb26deaf5e2eefea8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_d52af2792d6a46eeb26deaf5e2eefea8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_d52af2792d6a46eeb26deaf5e2eefea8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_d52af2792d6a46eeb26deaf5e2eefea8(_4ad61933cff6c344b947676756feb8fa_d52af2792d6a46eeb26deaf5e2eefea8 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_fac8eab8ddee40db9d45079a70d9b594(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_fac8eab8ddee40db9d45079a70d9b594(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_fac8eab8ddee40db9d45079a70d9b594(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_fac8eab8ddee40db9d45079a70d9b594(_4ad61933cff6c344b947676756feb8fa_fac8eab8ddee40db9d45079a70d9b594 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_80619e04cb76405cb1456e211f8aab67(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_80619e04cb76405cb1456e211f8aab67(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_80619e04cb76405cb1456e211f8aab67(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_80619e04cb76405cb1456e211f8aab67(_4ad61933cff6c344b947676756feb8fa_80619e04cb76405cb1456e211f8aab67 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_393cc9e9495b443c998d0a99c686a6a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_393cc9e9495b443c998d0a99c686a6a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_393cc9e9495b443c998d0a99c686a6a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_393cc9e9495b443c998d0a99c686a6a2(_4ad61933cff6c344b947676756feb8fa_393cc9e9495b443c998d0a99c686a6a2 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_a0e81fc9a19544d3a6e9eb940a6fb433(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_a0e81fc9a19544d3a6e9eb940a6fb433(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_a0e81fc9a19544d3a6e9eb940a6fb433(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_a0e81fc9a19544d3a6e9eb940a6fb433(_4ad61933cff6c344b947676756feb8fa_a0e81fc9a19544d3a6e9eb940a6fb433 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_76757bc6278e4a1f933ee0ea9b90fc3f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_76757bc6278e4a1f933ee0ea9b90fc3f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_76757bc6278e4a1f933ee0ea9b90fc3f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_76757bc6278e4a1f933ee0ea9b90fc3f(_4ad61933cff6c344b947676756feb8fa_76757bc6278e4a1f933ee0ea9b90fc3f command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_d35d63b4afa44970aa90061a5caa4633(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_d35d63b4afa44970aa90061a5caa4633(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_d35d63b4afa44970aa90061a5caa4633(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_d35d63b4afa44970aa90061a5caa4633(_4ad61933cff6c344b947676756feb8fa_d35d63b4afa44970aa90061a5caa4633 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_6f38b30d03d340c6ab6f89ce36d1a5a0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_6f38b30d03d340c6ab6f89ce36d1a5a0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_6f38b30d03d340c6ab6f89ce36d1a5a0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_6f38b30d03d340c6ab6f89ce36d1a5a0(_4ad61933cff6c344b947676756feb8fa_6f38b30d03d340c6ab6f89ce36d1a5a0 command)
		{
		}

		private void BakeCommandBinding__4ad61933cff6c344b947676756feb8fa_b12f8c0b4f524823a4f2c06e60bb97d3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4ad61933cff6c344b947676756feb8fa_b12f8c0b4f524823a4f2c06e60bb97d3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4ad61933cff6c344b947676756feb8fa_b12f8c0b4f524823a4f2c06e60bb97d3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4ad61933cff6c344b947676756feb8fa_b12f8c0b4f524823a4f2c06e60bb97d3(_4ad61933cff6c344b947676756feb8fa_b12f8c0b4f524823a4f2c06e60bb97d3 command)
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
