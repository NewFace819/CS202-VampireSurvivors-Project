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
	public class CoherenceSync_f0624f8cc4a16e24fa2b0e0db2a9b9ec : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_4f11ddf602314cf48a1fcf0448bc8394_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_1a9cb239805e495b9f101bf7bad778b5_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_d5af14fd72d84772be92ec41b599bf13_CommandTarget;

		private C1_Impostor _f0624f8cc4a16e24fa2b0e0db2a9b9ec_46ca1aa05393400fb2b8d045eae3ca5a_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_5ffa177e52464740805dc639152572ed_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_a513075c92764d338cdc7167cecfe45c_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_abaa896717b94a7fb805f848cba46c1e_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_7541c066c9614ac0980c359f13674378_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_30f759d502d7467bbe0d2d791858c078_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_0001fc3526bc49f5ab9c8965af543452_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_4ed0e7615f854cc78a8448c5323075aa_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_44444f4dee654066a3e8326fd1ba3382_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_edc7932449f8470c907dc0df6d16ded3_CommandTarget;

		private CharacterController _f0624f8cc4a16e24fa2b0e0db2a9b9ec_941d113658f44ff48d4abdc55041f328_CommandTarget;

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

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_4f11ddf602314cf48a1fcf0448bc8394(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_4f11ddf602314cf48a1fcf0448bc8394(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_4f11ddf602314cf48a1fcf0448bc8394(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_4f11ddf602314cf48a1fcf0448bc8394(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_4f11ddf602314cf48a1fcf0448bc8394 command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_1a9cb239805e495b9f101bf7bad778b5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_1a9cb239805e495b9f101bf7bad778b5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_1a9cb239805e495b9f101bf7bad778b5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_1a9cb239805e495b9f101bf7bad778b5(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_1a9cb239805e495b9f101bf7bad778b5 command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_d5af14fd72d84772be92ec41b599bf13(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_d5af14fd72d84772be92ec41b599bf13(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_d5af14fd72d84772be92ec41b599bf13(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_d5af14fd72d84772be92ec41b599bf13(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_d5af14fd72d84772be92ec41b599bf13 command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_46ca1aa05393400fb2b8d045eae3ca5a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_46ca1aa05393400fb2b8d045eae3ca5a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_46ca1aa05393400fb2b8d045eae3ca5a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_46ca1aa05393400fb2b8d045eae3ca5a(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_46ca1aa05393400fb2b8d045eae3ca5a command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_5ffa177e52464740805dc639152572ed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_5ffa177e52464740805dc639152572ed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_5ffa177e52464740805dc639152572ed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_5ffa177e52464740805dc639152572ed(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_5ffa177e52464740805dc639152572ed command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_a513075c92764d338cdc7167cecfe45c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_a513075c92764d338cdc7167cecfe45c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_a513075c92764d338cdc7167cecfe45c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_a513075c92764d338cdc7167cecfe45c(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_a513075c92764d338cdc7167cecfe45c command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_abaa896717b94a7fb805f848cba46c1e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_abaa896717b94a7fb805f848cba46c1e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_abaa896717b94a7fb805f848cba46c1e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_abaa896717b94a7fb805f848cba46c1e(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_abaa896717b94a7fb805f848cba46c1e command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_7541c066c9614ac0980c359f13674378(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_7541c066c9614ac0980c359f13674378(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_7541c066c9614ac0980c359f13674378(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_7541c066c9614ac0980c359f13674378(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_7541c066c9614ac0980c359f13674378 command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_30f759d502d7467bbe0d2d791858c078(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_30f759d502d7467bbe0d2d791858c078(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_30f759d502d7467bbe0d2d791858c078(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_30f759d502d7467bbe0d2d791858c078(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_30f759d502d7467bbe0d2d791858c078 command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_0001fc3526bc49f5ab9c8965af543452(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_0001fc3526bc49f5ab9c8965af543452(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_0001fc3526bc49f5ab9c8965af543452(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_0001fc3526bc49f5ab9c8965af543452(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_0001fc3526bc49f5ab9c8965af543452 command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_4ed0e7615f854cc78a8448c5323075aa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_4ed0e7615f854cc78a8448c5323075aa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_4ed0e7615f854cc78a8448c5323075aa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_4ed0e7615f854cc78a8448c5323075aa(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_4ed0e7615f854cc78a8448c5323075aa command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_44444f4dee654066a3e8326fd1ba3382(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_44444f4dee654066a3e8326fd1ba3382(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_44444f4dee654066a3e8326fd1ba3382(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_44444f4dee654066a3e8326fd1ba3382(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_44444f4dee654066a3e8326fd1ba3382 command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_edc7932449f8470c907dc0df6d16ded3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_edc7932449f8470c907dc0df6d16ded3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_edc7932449f8470c907dc0df6d16ded3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_edc7932449f8470c907dc0df6d16ded3(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_edc7932449f8470c907dc0df6d16ded3 command)
		{
		}

		private void BakeCommandBinding__f0624f8cc4a16e24fa2b0e0db2a9b9ec_941d113658f44ff48d4abdc55041f328(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_941d113658f44ff48d4abdc55041f328(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_941d113658f44ff48d4abdc55041f328(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f0624f8cc4a16e24fa2b0e0db2a9b9ec_941d113658f44ff48d4abdc55041f328(_f0624f8cc4a16e24fa2b0e0db2a9b9ec_941d113658f44ff48d4abdc55041f328 command)
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
