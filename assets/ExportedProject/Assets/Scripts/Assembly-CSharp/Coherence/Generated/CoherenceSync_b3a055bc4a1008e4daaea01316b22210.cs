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
	public class CoherenceSync_b3a055bc4a1008e4daaea01316b22210 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_98365401591f4d0fa2b7f1694aa12462_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_5063b5433d354486b4437c49e026b708_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_8051a51ef09c4fefb78ed23f7bc94998_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_24a48339e7cb46ddb4a57da9c031d756_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_3f4de3c5e75a4ab2b8eadb8f081f88c7_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_9c620875949e42ffba7625e7ec6015d6_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_22a4a4eab1e64f2b8535161bbe44dbbb_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_8f3f50a2a2e34b088ad6fe13c56e90dc_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_40f005a860f34e8c942c638e2be12e23_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_3cb6005971184ad3984ad428d37a2ef8_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_3925cf2793494fa785d015ae5c4f12d3_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_82d982903883448f8da17d75236ae08e_CommandTarget;

		private CharacterController _b3a055bc4a1008e4daaea01316b22210_51887c22473f4318be6e9cc7fc15658a_CommandTarget;

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

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_98365401591f4d0fa2b7f1694aa12462(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_98365401591f4d0fa2b7f1694aa12462(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_98365401591f4d0fa2b7f1694aa12462(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_98365401591f4d0fa2b7f1694aa12462(_b3a055bc4a1008e4daaea01316b22210_98365401591f4d0fa2b7f1694aa12462 command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_5063b5433d354486b4437c49e026b708(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_5063b5433d354486b4437c49e026b708(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_5063b5433d354486b4437c49e026b708(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_5063b5433d354486b4437c49e026b708(_b3a055bc4a1008e4daaea01316b22210_5063b5433d354486b4437c49e026b708 command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_8051a51ef09c4fefb78ed23f7bc94998(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_8051a51ef09c4fefb78ed23f7bc94998(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_8051a51ef09c4fefb78ed23f7bc94998(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_8051a51ef09c4fefb78ed23f7bc94998(_b3a055bc4a1008e4daaea01316b22210_8051a51ef09c4fefb78ed23f7bc94998 command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_24a48339e7cb46ddb4a57da9c031d756(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_24a48339e7cb46ddb4a57da9c031d756(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_24a48339e7cb46ddb4a57da9c031d756(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_24a48339e7cb46ddb4a57da9c031d756(_b3a055bc4a1008e4daaea01316b22210_24a48339e7cb46ddb4a57da9c031d756 command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_3f4de3c5e75a4ab2b8eadb8f081f88c7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_3f4de3c5e75a4ab2b8eadb8f081f88c7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_3f4de3c5e75a4ab2b8eadb8f081f88c7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_3f4de3c5e75a4ab2b8eadb8f081f88c7(_b3a055bc4a1008e4daaea01316b22210_3f4de3c5e75a4ab2b8eadb8f081f88c7 command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_9c620875949e42ffba7625e7ec6015d6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_9c620875949e42ffba7625e7ec6015d6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_9c620875949e42ffba7625e7ec6015d6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_9c620875949e42ffba7625e7ec6015d6(_b3a055bc4a1008e4daaea01316b22210_9c620875949e42ffba7625e7ec6015d6 command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_22a4a4eab1e64f2b8535161bbe44dbbb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_22a4a4eab1e64f2b8535161bbe44dbbb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_22a4a4eab1e64f2b8535161bbe44dbbb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_22a4a4eab1e64f2b8535161bbe44dbbb(_b3a055bc4a1008e4daaea01316b22210_22a4a4eab1e64f2b8535161bbe44dbbb command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_8f3f50a2a2e34b088ad6fe13c56e90dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_8f3f50a2a2e34b088ad6fe13c56e90dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_8f3f50a2a2e34b088ad6fe13c56e90dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_8f3f50a2a2e34b088ad6fe13c56e90dc(_b3a055bc4a1008e4daaea01316b22210_8f3f50a2a2e34b088ad6fe13c56e90dc command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_40f005a860f34e8c942c638e2be12e23(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_40f005a860f34e8c942c638e2be12e23(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_40f005a860f34e8c942c638e2be12e23(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_40f005a860f34e8c942c638e2be12e23(_b3a055bc4a1008e4daaea01316b22210_40f005a860f34e8c942c638e2be12e23 command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_3cb6005971184ad3984ad428d37a2ef8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_3cb6005971184ad3984ad428d37a2ef8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_3cb6005971184ad3984ad428d37a2ef8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_3cb6005971184ad3984ad428d37a2ef8(_b3a055bc4a1008e4daaea01316b22210_3cb6005971184ad3984ad428d37a2ef8 command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_3925cf2793494fa785d015ae5c4f12d3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_3925cf2793494fa785d015ae5c4f12d3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_3925cf2793494fa785d015ae5c4f12d3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_3925cf2793494fa785d015ae5c4f12d3(_b3a055bc4a1008e4daaea01316b22210_3925cf2793494fa785d015ae5c4f12d3 command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_82d982903883448f8da17d75236ae08e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_82d982903883448f8da17d75236ae08e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_82d982903883448f8da17d75236ae08e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_82d982903883448f8da17d75236ae08e(_b3a055bc4a1008e4daaea01316b22210_82d982903883448f8da17d75236ae08e command)
		{
		}

		private void BakeCommandBinding__b3a055bc4a1008e4daaea01316b22210_51887c22473f4318be6e9cc7fc15658a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b3a055bc4a1008e4daaea01316b22210_51887c22473f4318be6e9cc7fc15658a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b3a055bc4a1008e4daaea01316b22210_51887c22473f4318be6e9cc7fc15658a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b3a055bc4a1008e4daaea01316b22210_51887c22473f4318be6e9cc7fc15658a(_b3a055bc4a1008e4daaea01316b22210_51887c22473f4318be6e9cc7fc15658a command)
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
