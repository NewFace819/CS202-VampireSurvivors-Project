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
	public class CoherenceSync_4f7a63aad47b0714a995316c8db68d7e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_3f725629d2024f7f8c025ba067fd3c5d_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_143d9eb11c474be692cff028b63b88b5_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_6ff67b4dca1b4ee49ccad54d79578324_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_2da9498ff88c4776b0c974d26d43af73_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_57a3013c59e445ceb9f844d3409b8217_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_bb8063690c22454488381515012a9d41_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_512bf9cfe1c44301911cef5879a7f01f_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_19c9236d6a1147bd9838a941b7793340_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_aea3f5a1e0c244e9988475d59ca62bb2_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_c8d8441506e44614aaad90cc1d32fc29_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_202bbb73b00a49cb8195662f63b09db2_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_92ee65bad43c46de90d185675f7bd7ef_CommandTarget;

		private CharacterController _4f7a63aad47b0714a995316c8db68d7e_c8df1137525e43b59929eb87986ea02f_CommandTarget;

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

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_3f725629d2024f7f8c025ba067fd3c5d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_3f725629d2024f7f8c025ba067fd3c5d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_3f725629d2024f7f8c025ba067fd3c5d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_3f725629d2024f7f8c025ba067fd3c5d(_4f7a63aad47b0714a995316c8db68d7e_3f725629d2024f7f8c025ba067fd3c5d command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_143d9eb11c474be692cff028b63b88b5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_143d9eb11c474be692cff028b63b88b5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_143d9eb11c474be692cff028b63b88b5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_143d9eb11c474be692cff028b63b88b5(_4f7a63aad47b0714a995316c8db68d7e_143d9eb11c474be692cff028b63b88b5 command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_6ff67b4dca1b4ee49ccad54d79578324(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_6ff67b4dca1b4ee49ccad54d79578324(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_6ff67b4dca1b4ee49ccad54d79578324(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_6ff67b4dca1b4ee49ccad54d79578324(_4f7a63aad47b0714a995316c8db68d7e_6ff67b4dca1b4ee49ccad54d79578324 command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_2da9498ff88c4776b0c974d26d43af73(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_2da9498ff88c4776b0c974d26d43af73(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_2da9498ff88c4776b0c974d26d43af73(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_2da9498ff88c4776b0c974d26d43af73(_4f7a63aad47b0714a995316c8db68d7e_2da9498ff88c4776b0c974d26d43af73 command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_57a3013c59e445ceb9f844d3409b8217(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_57a3013c59e445ceb9f844d3409b8217(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_57a3013c59e445ceb9f844d3409b8217(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_57a3013c59e445ceb9f844d3409b8217(_4f7a63aad47b0714a995316c8db68d7e_57a3013c59e445ceb9f844d3409b8217 command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_bb8063690c22454488381515012a9d41(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_bb8063690c22454488381515012a9d41(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_bb8063690c22454488381515012a9d41(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_bb8063690c22454488381515012a9d41(_4f7a63aad47b0714a995316c8db68d7e_bb8063690c22454488381515012a9d41 command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_512bf9cfe1c44301911cef5879a7f01f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_512bf9cfe1c44301911cef5879a7f01f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_512bf9cfe1c44301911cef5879a7f01f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_512bf9cfe1c44301911cef5879a7f01f(_4f7a63aad47b0714a995316c8db68d7e_512bf9cfe1c44301911cef5879a7f01f command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_19c9236d6a1147bd9838a941b7793340(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_19c9236d6a1147bd9838a941b7793340(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_19c9236d6a1147bd9838a941b7793340(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_19c9236d6a1147bd9838a941b7793340(_4f7a63aad47b0714a995316c8db68d7e_19c9236d6a1147bd9838a941b7793340 command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_aea3f5a1e0c244e9988475d59ca62bb2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_aea3f5a1e0c244e9988475d59ca62bb2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_aea3f5a1e0c244e9988475d59ca62bb2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_aea3f5a1e0c244e9988475d59ca62bb2(_4f7a63aad47b0714a995316c8db68d7e_aea3f5a1e0c244e9988475d59ca62bb2 command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_c8d8441506e44614aaad90cc1d32fc29(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_c8d8441506e44614aaad90cc1d32fc29(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_c8d8441506e44614aaad90cc1d32fc29(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_c8d8441506e44614aaad90cc1d32fc29(_4f7a63aad47b0714a995316c8db68d7e_c8d8441506e44614aaad90cc1d32fc29 command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_202bbb73b00a49cb8195662f63b09db2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_202bbb73b00a49cb8195662f63b09db2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_202bbb73b00a49cb8195662f63b09db2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_202bbb73b00a49cb8195662f63b09db2(_4f7a63aad47b0714a995316c8db68d7e_202bbb73b00a49cb8195662f63b09db2 command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_92ee65bad43c46de90d185675f7bd7ef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_92ee65bad43c46de90d185675f7bd7ef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_92ee65bad43c46de90d185675f7bd7ef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_92ee65bad43c46de90d185675f7bd7ef(_4f7a63aad47b0714a995316c8db68d7e_92ee65bad43c46de90d185675f7bd7ef command)
		{
		}

		private void BakeCommandBinding__4f7a63aad47b0714a995316c8db68d7e_c8df1137525e43b59929eb87986ea02f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4f7a63aad47b0714a995316c8db68d7e_c8df1137525e43b59929eb87986ea02f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4f7a63aad47b0714a995316c8db68d7e_c8df1137525e43b59929eb87986ea02f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4f7a63aad47b0714a995316c8db68d7e_c8df1137525e43b59929eb87986ea02f(_4f7a63aad47b0714a995316c8db68d7e_c8df1137525e43b59929eb87986ea02f command)
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
