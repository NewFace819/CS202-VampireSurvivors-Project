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
	public class CoherenceSync_c7ebef2d63252f54a8c38b1176c3d54c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_016c0b93bd3b4e8287d6c6288ee043a9_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_2ca87394422f467a83683d4142c36594_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_ee185c6202344fec90d46be63ea1ef5e_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_7b3961a7d5094901ac9203c83dbf2f3c_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_2565746c187440b3baf63e9f819e0535_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_83846df4bdef48129fcdbd6c92d8f04c_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_3d151b45c23548f881f9e200875c9dc5_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_ba7493cc80b04b74b88d5e52965a32dd_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_35d994a66f49473cb983ac5858a3de85_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_ebd3ee563dfe43f0bd11933ff11e1178_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_c5d539c992164e21bb239ad3a982114b_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_216e93118bba485ab67e96534639a158_CommandTarget;

		private CharacterController _c7ebef2d63252f54a8c38b1176c3d54c_2b715e2a6f404ccbb51845345fb2275c_CommandTarget;

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

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_016c0b93bd3b4e8287d6c6288ee043a9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_016c0b93bd3b4e8287d6c6288ee043a9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_016c0b93bd3b4e8287d6c6288ee043a9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_016c0b93bd3b4e8287d6c6288ee043a9(_c7ebef2d63252f54a8c38b1176c3d54c_016c0b93bd3b4e8287d6c6288ee043a9 command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_2ca87394422f467a83683d4142c36594(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_2ca87394422f467a83683d4142c36594(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_2ca87394422f467a83683d4142c36594(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_2ca87394422f467a83683d4142c36594(_c7ebef2d63252f54a8c38b1176c3d54c_2ca87394422f467a83683d4142c36594 command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_ee185c6202344fec90d46be63ea1ef5e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_ee185c6202344fec90d46be63ea1ef5e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_ee185c6202344fec90d46be63ea1ef5e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_ee185c6202344fec90d46be63ea1ef5e(_c7ebef2d63252f54a8c38b1176c3d54c_ee185c6202344fec90d46be63ea1ef5e command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_7b3961a7d5094901ac9203c83dbf2f3c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_7b3961a7d5094901ac9203c83dbf2f3c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_7b3961a7d5094901ac9203c83dbf2f3c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_7b3961a7d5094901ac9203c83dbf2f3c(_c7ebef2d63252f54a8c38b1176c3d54c_7b3961a7d5094901ac9203c83dbf2f3c command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_2565746c187440b3baf63e9f819e0535(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_2565746c187440b3baf63e9f819e0535(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_2565746c187440b3baf63e9f819e0535(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_2565746c187440b3baf63e9f819e0535(_c7ebef2d63252f54a8c38b1176c3d54c_2565746c187440b3baf63e9f819e0535 command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_83846df4bdef48129fcdbd6c92d8f04c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_83846df4bdef48129fcdbd6c92d8f04c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_83846df4bdef48129fcdbd6c92d8f04c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_83846df4bdef48129fcdbd6c92d8f04c(_c7ebef2d63252f54a8c38b1176c3d54c_83846df4bdef48129fcdbd6c92d8f04c command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_3d151b45c23548f881f9e200875c9dc5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_3d151b45c23548f881f9e200875c9dc5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_3d151b45c23548f881f9e200875c9dc5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_3d151b45c23548f881f9e200875c9dc5(_c7ebef2d63252f54a8c38b1176c3d54c_3d151b45c23548f881f9e200875c9dc5 command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_ba7493cc80b04b74b88d5e52965a32dd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_ba7493cc80b04b74b88d5e52965a32dd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_ba7493cc80b04b74b88d5e52965a32dd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_ba7493cc80b04b74b88d5e52965a32dd(_c7ebef2d63252f54a8c38b1176c3d54c_ba7493cc80b04b74b88d5e52965a32dd command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_35d994a66f49473cb983ac5858a3de85(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_35d994a66f49473cb983ac5858a3de85(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_35d994a66f49473cb983ac5858a3de85(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_35d994a66f49473cb983ac5858a3de85(_c7ebef2d63252f54a8c38b1176c3d54c_35d994a66f49473cb983ac5858a3de85 command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_ebd3ee563dfe43f0bd11933ff11e1178(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_ebd3ee563dfe43f0bd11933ff11e1178(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_ebd3ee563dfe43f0bd11933ff11e1178(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_ebd3ee563dfe43f0bd11933ff11e1178(_c7ebef2d63252f54a8c38b1176c3d54c_ebd3ee563dfe43f0bd11933ff11e1178 command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_c5d539c992164e21bb239ad3a982114b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_c5d539c992164e21bb239ad3a982114b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_c5d539c992164e21bb239ad3a982114b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_c5d539c992164e21bb239ad3a982114b(_c7ebef2d63252f54a8c38b1176c3d54c_c5d539c992164e21bb239ad3a982114b command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_216e93118bba485ab67e96534639a158(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_216e93118bba485ab67e96534639a158(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_216e93118bba485ab67e96534639a158(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_216e93118bba485ab67e96534639a158(_c7ebef2d63252f54a8c38b1176c3d54c_216e93118bba485ab67e96534639a158 command)
		{
		}

		private void BakeCommandBinding__c7ebef2d63252f54a8c38b1176c3d54c_2b715e2a6f404ccbb51845345fb2275c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7ebef2d63252f54a8c38b1176c3d54c_2b715e2a6f404ccbb51845345fb2275c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7ebef2d63252f54a8c38b1176c3d54c_2b715e2a6f404ccbb51845345fb2275c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7ebef2d63252f54a8c38b1176c3d54c_2b715e2a6f404ccbb51845345fb2275c(_c7ebef2d63252f54a8c38b1176c3d54c_2b715e2a6f404ccbb51845345fb2275c command)
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
