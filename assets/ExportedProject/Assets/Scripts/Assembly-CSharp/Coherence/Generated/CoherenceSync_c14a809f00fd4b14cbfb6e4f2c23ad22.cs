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
	public class CoherenceSync_c14a809f00fd4b14cbfb6e4f2c23ad22 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_5c2bca59054a4549bfe06bd1fc295fdf_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_27523352e57c44e78e6bdaa65d1bcb19_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_9f55e5b96e764f41b1a020f815ac7636_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_37dd58b163a74d17a01b9b08fa3f0d23_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_590eb70b1fd4411e9d3709d05d75016d_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_d329812182ce47b780d5ff0d8c1b21f0_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_ea26990876024b9192128914d645f9fc_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_d762aa26baac4533b38007491d36f13f_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_04d8b287a67e4b37b7b76aff4a3943ed_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_be3ee1f492fa4eb386ff7ef0c3d360cb_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_cfd2376d81134aed9a228cca7e630117_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_8dc8a198c374487d809524f688d94295_CommandTarget;

		private CharacterController _c14a809f00fd4b14cbfb6e4f2c23ad22_1fcd564dfaa948d2b68207fab4632d2c_CommandTarget;

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

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_5c2bca59054a4549bfe06bd1fc295fdf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_5c2bca59054a4549bfe06bd1fc295fdf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_5c2bca59054a4549bfe06bd1fc295fdf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_5c2bca59054a4549bfe06bd1fc295fdf(_c14a809f00fd4b14cbfb6e4f2c23ad22_5c2bca59054a4549bfe06bd1fc295fdf command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_27523352e57c44e78e6bdaa65d1bcb19(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_27523352e57c44e78e6bdaa65d1bcb19(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_27523352e57c44e78e6bdaa65d1bcb19(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_27523352e57c44e78e6bdaa65d1bcb19(_c14a809f00fd4b14cbfb6e4f2c23ad22_27523352e57c44e78e6bdaa65d1bcb19 command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_9f55e5b96e764f41b1a020f815ac7636(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_9f55e5b96e764f41b1a020f815ac7636(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_9f55e5b96e764f41b1a020f815ac7636(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_9f55e5b96e764f41b1a020f815ac7636(_c14a809f00fd4b14cbfb6e4f2c23ad22_9f55e5b96e764f41b1a020f815ac7636 command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_37dd58b163a74d17a01b9b08fa3f0d23(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_37dd58b163a74d17a01b9b08fa3f0d23(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_37dd58b163a74d17a01b9b08fa3f0d23(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_37dd58b163a74d17a01b9b08fa3f0d23(_c14a809f00fd4b14cbfb6e4f2c23ad22_37dd58b163a74d17a01b9b08fa3f0d23 command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_590eb70b1fd4411e9d3709d05d75016d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_590eb70b1fd4411e9d3709d05d75016d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_590eb70b1fd4411e9d3709d05d75016d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_590eb70b1fd4411e9d3709d05d75016d(_c14a809f00fd4b14cbfb6e4f2c23ad22_590eb70b1fd4411e9d3709d05d75016d command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_d329812182ce47b780d5ff0d8c1b21f0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_d329812182ce47b780d5ff0d8c1b21f0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_d329812182ce47b780d5ff0d8c1b21f0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_d329812182ce47b780d5ff0d8c1b21f0(_c14a809f00fd4b14cbfb6e4f2c23ad22_d329812182ce47b780d5ff0d8c1b21f0 command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_ea26990876024b9192128914d645f9fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_ea26990876024b9192128914d645f9fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_ea26990876024b9192128914d645f9fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_ea26990876024b9192128914d645f9fc(_c14a809f00fd4b14cbfb6e4f2c23ad22_ea26990876024b9192128914d645f9fc command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_d762aa26baac4533b38007491d36f13f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_d762aa26baac4533b38007491d36f13f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_d762aa26baac4533b38007491d36f13f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_d762aa26baac4533b38007491d36f13f(_c14a809f00fd4b14cbfb6e4f2c23ad22_d762aa26baac4533b38007491d36f13f command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_04d8b287a67e4b37b7b76aff4a3943ed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_04d8b287a67e4b37b7b76aff4a3943ed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_04d8b287a67e4b37b7b76aff4a3943ed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_04d8b287a67e4b37b7b76aff4a3943ed(_c14a809f00fd4b14cbfb6e4f2c23ad22_04d8b287a67e4b37b7b76aff4a3943ed command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_be3ee1f492fa4eb386ff7ef0c3d360cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_be3ee1f492fa4eb386ff7ef0c3d360cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_be3ee1f492fa4eb386ff7ef0c3d360cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_be3ee1f492fa4eb386ff7ef0c3d360cb(_c14a809f00fd4b14cbfb6e4f2c23ad22_be3ee1f492fa4eb386ff7ef0c3d360cb command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_cfd2376d81134aed9a228cca7e630117(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_cfd2376d81134aed9a228cca7e630117(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_cfd2376d81134aed9a228cca7e630117(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_cfd2376d81134aed9a228cca7e630117(_c14a809f00fd4b14cbfb6e4f2c23ad22_cfd2376d81134aed9a228cca7e630117 command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_8dc8a198c374487d809524f688d94295(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_8dc8a198c374487d809524f688d94295(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_8dc8a198c374487d809524f688d94295(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_8dc8a198c374487d809524f688d94295(_c14a809f00fd4b14cbfb6e4f2c23ad22_8dc8a198c374487d809524f688d94295 command)
		{
		}

		private void BakeCommandBinding__c14a809f00fd4b14cbfb6e4f2c23ad22_1fcd564dfaa948d2b68207fab4632d2c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_1fcd564dfaa948d2b68207fab4632d2c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_1fcd564dfaa948d2b68207fab4632d2c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c14a809f00fd4b14cbfb6e4f2c23ad22_1fcd564dfaa948d2b68207fab4632d2c(_c14a809f00fd4b14cbfb6e4f2c23ad22_1fcd564dfaa948d2b68207fab4632d2c command)
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
