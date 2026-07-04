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
	public class CoherenceSync_0f68dfea29cf1bb459cbacb0caa9505a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_163626410c7743e4b59be81b6ea4fa46_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_59abf94d0cbe4d23a02e4cbf17c0ef9a_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_d906227592284bfca68cdff2c591589a_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_1dded4b514bb470baf11d0b9dcfecf9b_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_8796dd30c1694723b3a1bb37015ceb19_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_5353ce55aa5c4f44a7d16c089244e19b_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_db374d7bb4f649ecac5bcd06a33e41f1_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_8cf97c7c7cb24027b0a31c89d7e5c69c_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_aca0c0f4c93a499ca88e837273453c95_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_fe54fc1599cd4ef89abbb11b31234ad0_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_8bdc9b91169243b5ac547d41cbcd95a7_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_b0db72cdc1e445fb92ce7486569f9327_CommandTarget;

		private CharacterController _0f68dfea29cf1bb459cbacb0caa9505a_a29cf13db0c14d46ad301c02b8f5a404_CommandTarget;

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

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_163626410c7743e4b59be81b6ea4fa46(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_163626410c7743e4b59be81b6ea4fa46(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_163626410c7743e4b59be81b6ea4fa46(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_163626410c7743e4b59be81b6ea4fa46(_0f68dfea29cf1bb459cbacb0caa9505a_163626410c7743e4b59be81b6ea4fa46 command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_59abf94d0cbe4d23a02e4cbf17c0ef9a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_59abf94d0cbe4d23a02e4cbf17c0ef9a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_59abf94d0cbe4d23a02e4cbf17c0ef9a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_59abf94d0cbe4d23a02e4cbf17c0ef9a(_0f68dfea29cf1bb459cbacb0caa9505a_59abf94d0cbe4d23a02e4cbf17c0ef9a command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_d906227592284bfca68cdff2c591589a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_d906227592284bfca68cdff2c591589a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_d906227592284bfca68cdff2c591589a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_d906227592284bfca68cdff2c591589a(_0f68dfea29cf1bb459cbacb0caa9505a_d906227592284bfca68cdff2c591589a command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_1dded4b514bb470baf11d0b9dcfecf9b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_1dded4b514bb470baf11d0b9dcfecf9b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_1dded4b514bb470baf11d0b9dcfecf9b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_1dded4b514bb470baf11d0b9dcfecf9b(_0f68dfea29cf1bb459cbacb0caa9505a_1dded4b514bb470baf11d0b9dcfecf9b command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_8796dd30c1694723b3a1bb37015ceb19(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_8796dd30c1694723b3a1bb37015ceb19(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_8796dd30c1694723b3a1bb37015ceb19(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_8796dd30c1694723b3a1bb37015ceb19(_0f68dfea29cf1bb459cbacb0caa9505a_8796dd30c1694723b3a1bb37015ceb19 command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_5353ce55aa5c4f44a7d16c089244e19b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_5353ce55aa5c4f44a7d16c089244e19b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_5353ce55aa5c4f44a7d16c089244e19b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_5353ce55aa5c4f44a7d16c089244e19b(_0f68dfea29cf1bb459cbacb0caa9505a_5353ce55aa5c4f44a7d16c089244e19b command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_db374d7bb4f649ecac5bcd06a33e41f1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_db374d7bb4f649ecac5bcd06a33e41f1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_db374d7bb4f649ecac5bcd06a33e41f1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_db374d7bb4f649ecac5bcd06a33e41f1(_0f68dfea29cf1bb459cbacb0caa9505a_db374d7bb4f649ecac5bcd06a33e41f1 command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_8cf97c7c7cb24027b0a31c89d7e5c69c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_8cf97c7c7cb24027b0a31c89d7e5c69c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_8cf97c7c7cb24027b0a31c89d7e5c69c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_8cf97c7c7cb24027b0a31c89d7e5c69c(_0f68dfea29cf1bb459cbacb0caa9505a_8cf97c7c7cb24027b0a31c89d7e5c69c command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_aca0c0f4c93a499ca88e837273453c95(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_aca0c0f4c93a499ca88e837273453c95(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_aca0c0f4c93a499ca88e837273453c95(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_aca0c0f4c93a499ca88e837273453c95(_0f68dfea29cf1bb459cbacb0caa9505a_aca0c0f4c93a499ca88e837273453c95 command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_fe54fc1599cd4ef89abbb11b31234ad0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_fe54fc1599cd4ef89abbb11b31234ad0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_fe54fc1599cd4ef89abbb11b31234ad0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_fe54fc1599cd4ef89abbb11b31234ad0(_0f68dfea29cf1bb459cbacb0caa9505a_fe54fc1599cd4ef89abbb11b31234ad0 command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_8bdc9b91169243b5ac547d41cbcd95a7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_8bdc9b91169243b5ac547d41cbcd95a7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_8bdc9b91169243b5ac547d41cbcd95a7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_8bdc9b91169243b5ac547d41cbcd95a7(_0f68dfea29cf1bb459cbacb0caa9505a_8bdc9b91169243b5ac547d41cbcd95a7 command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_b0db72cdc1e445fb92ce7486569f9327(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_b0db72cdc1e445fb92ce7486569f9327(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_b0db72cdc1e445fb92ce7486569f9327(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_b0db72cdc1e445fb92ce7486569f9327(_0f68dfea29cf1bb459cbacb0caa9505a_b0db72cdc1e445fb92ce7486569f9327 command)
		{
		}

		private void BakeCommandBinding__0f68dfea29cf1bb459cbacb0caa9505a_a29cf13db0c14d46ad301c02b8f5a404(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0f68dfea29cf1bb459cbacb0caa9505a_a29cf13db0c14d46ad301c02b8f5a404(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0f68dfea29cf1bb459cbacb0caa9505a_a29cf13db0c14d46ad301c02b8f5a404(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0f68dfea29cf1bb459cbacb0caa9505a_a29cf13db0c14d46ad301c02b8f5a404(_0f68dfea29cf1bb459cbacb0caa9505a_a29cf13db0c14d46ad301c02b8f5a404 command)
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
