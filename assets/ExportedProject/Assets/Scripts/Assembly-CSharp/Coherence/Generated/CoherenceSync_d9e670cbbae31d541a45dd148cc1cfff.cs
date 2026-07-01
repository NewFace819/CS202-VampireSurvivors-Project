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
	public class CoherenceSync_d9e670cbbae31d541a45dd148cc1cfff : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_a6a2f86a69784a50a37d898f4e2210b8_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_e019b924a6c3435298b3e0c1e816f481_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_704528bf9cda402ca60dee67185b1390_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_1ca94e1d8e214fd688e8cd8eb4adf4ba_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_4de3218e4ab549828e8b1e9c1be6390b_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_64f8359de5c747859c196a8b71bb6946_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_b975a6856bbd42f6af8ec0384756e498_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_6b585caccb85405bae85984ec076667f_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_7dfa8f575d9442908a41a4946f0e882d_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_e592da964ce6417699c5fb6f72541e26_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_12db496e63234da994713b7084026a51_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_9d92a9ee867343df83778786dce468f7_CommandTarget;

		private CharacterController _d9e670cbbae31d541a45dd148cc1cfff_11acc1b8ca83471d9ea9c3e00d278e41_CommandTarget;

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

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_a6a2f86a69784a50a37d898f4e2210b8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_a6a2f86a69784a50a37d898f4e2210b8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_a6a2f86a69784a50a37d898f4e2210b8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_a6a2f86a69784a50a37d898f4e2210b8(_d9e670cbbae31d541a45dd148cc1cfff_a6a2f86a69784a50a37d898f4e2210b8 command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_e019b924a6c3435298b3e0c1e816f481(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_e019b924a6c3435298b3e0c1e816f481(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_e019b924a6c3435298b3e0c1e816f481(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_e019b924a6c3435298b3e0c1e816f481(_d9e670cbbae31d541a45dd148cc1cfff_e019b924a6c3435298b3e0c1e816f481 command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_704528bf9cda402ca60dee67185b1390(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_704528bf9cda402ca60dee67185b1390(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_704528bf9cda402ca60dee67185b1390(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_704528bf9cda402ca60dee67185b1390(_d9e670cbbae31d541a45dd148cc1cfff_704528bf9cda402ca60dee67185b1390 command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_1ca94e1d8e214fd688e8cd8eb4adf4ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_1ca94e1d8e214fd688e8cd8eb4adf4ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_1ca94e1d8e214fd688e8cd8eb4adf4ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_1ca94e1d8e214fd688e8cd8eb4adf4ba(_d9e670cbbae31d541a45dd148cc1cfff_1ca94e1d8e214fd688e8cd8eb4adf4ba command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_4de3218e4ab549828e8b1e9c1be6390b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_4de3218e4ab549828e8b1e9c1be6390b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_4de3218e4ab549828e8b1e9c1be6390b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_4de3218e4ab549828e8b1e9c1be6390b(_d9e670cbbae31d541a45dd148cc1cfff_4de3218e4ab549828e8b1e9c1be6390b command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_64f8359de5c747859c196a8b71bb6946(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_64f8359de5c747859c196a8b71bb6946(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_64f8359de5c747859c196a8b71bb6946(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_64f8359de5c747859c196a8b71bb6946(_d9e670cbbae31d541a45dd148cc1cfff_64f8359de5c747859c196a8b71bb6946 command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_b975a6856bbd42f6af8ec0384756e498(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_b975a6856bbd42f6af8ec0384756e498(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_b975a6856bbd42f6af8ec0384756e498(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_b975a6856bbd42f6af8ec0384756e498(_d9e670cbbae31d541a45dd148cc1cfff_b975a6856bbd42f6af8ec0384756e498 command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_6b585caccb85405bae85984ec076667f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_6b585caccb85405bae85984ec076667f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_6b585caccb85405bae85984ec076667f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_6b585caccb85405bae85984ec076667f(_d9e670cbbae31d541a45dd148cc1cfff_6b585caccb85405bae85984ec076667f command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_7dfa8f575d9442908a41a4946f0e882d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_7dfa8f575d9442908a41a4946f0e882d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_7dfa8f575d9442908a41a4946f0e882d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_7dfa8f575d9442908a41a4946f0e882d(_d9e670cbbae31d541a45dd148cc1cfff_7dfa8f575d9442908a41a4946f0e882d command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_e592da964ce6417699c5fb6f72541e26(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_e592da964ce6417699c5fb6f72541e26(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_e592da964ce6417699c5fb6f72541e26(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_e592da964ce6417699c5fb6f72541e26(_d9e670cbbae31d541a45dd148cc1cfff_e592da964ce6417699c5fb6f72541e26 command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_12db496e63234da994713b7084026a51(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_12db496e63234da994713b7084026a51(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_12db496e63234da994713b7084026a51(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_12db496e63234da994713b7084026a51(_d9e670cbbae31d541a45dd148cc1cfff_12db496e63234da994713b7084026a51 command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_9d92a9ee867343df83778786dce468f7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_9d92a9ee867343df83778786dce468f7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_9d92a9ee867343df83778786dce468f7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_9d92a9ee867343df83778786dce468f7(_d9e670cbbae31d541a45dd148cc1cfff_9d92a9ee867343df83778786dce468f7 command)
		{
		}

		private void BakeCommandBinding__d9e670cbbae31d541a45dd148cc1cfff_11acc1b8ca83471d9ea9c3e00d278e41(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9e670cbbae31d541a45dd148cc1cfff_11acc1b8ca83471d9ea9c3e00d278e41(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9e670cbbae31d541a45dd148cc1cfff_11acc1b8ca83471d9ea9c3e00d278e41(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9e670cbbae31d541a45dd148cc1cfff_11acc1b8ca83471d9ea9c3e00d278e41(_d9e670cbbae31d541a45dd148cc1cfff_11acc1b8ca83471d9ea9c3e00d278e41 command)
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
