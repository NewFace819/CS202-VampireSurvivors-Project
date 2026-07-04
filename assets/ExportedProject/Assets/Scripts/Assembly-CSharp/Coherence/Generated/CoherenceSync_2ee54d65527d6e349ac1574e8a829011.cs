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
	public class CoherenceSync_2ee54d65527d6e349ac1574e8a829011 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_c12f6a2f71b844cf8276aaa03bdd6faf_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_45e6660cc8b149a89ddea408b4dfc109_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_04d8af173b624f4a96c8a1f997e3463a_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_d0b7496c2d60494688b4765478137521_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_1aacc238f3934fe0af468ef184506fc1_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_0d1b2dc103364d30a6c4e84aabb617b2_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_08424bd76fb44ec0b59bc9b83e3798dd_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_4f4944451c4b43498e853d01dad01913_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_c6140ca6668f4e63bc1f0b59ddf827a0_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_12e88be5332e48a6b6cd4af518626cc1_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_a2562d4da8bb4f1094ee1963a20e6b9d_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_37e2446b6aaa4d56b012e38abfae5277_CommandTarget;

		private CharacterController _2ee54d65527d6e349ac1574e8a829011_6b4e02670dd14f3f870ddfbd751afccd_CommandTarget;

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

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_c12f6a2f71b844cf8276aaa03bdd6faf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_c12f6a2f71b844cf8276aaa03bdd6faf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_c12f6a2f71b844cf8276aaa03bdd6faf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_c12f6a2f71b844cf8276aaa03bdd6faf(_2ee54d65527d6e349ac1574e8a829011_c12f6a2f71b844cf8276aaa03bdd6faf command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_45e6660cc8b149a89ddea408b4dfc109(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_45e6660cc8b149a89ddea408b4dfc109(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_45e6660cc8b149a89ddea408b4dfc109(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_45e6660cc8b149a89ddea408b4dfc109(_2ee54d65527d6e349ac1574e8a829011_45e6660cc8b149a89ddea408b4dfc109 command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_04d8af173b624f4a96c8a1f997e3463a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_04d8af173b624f4a96c8a1f997e3463a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_04d8af173b624f4a96c8a1f997e3463a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_04d8af173b624f4a96c8a1f997e3463a(_2ee54d65527d6e349ac1574e8a829011_04d8af173b624f4a96c8a1f997e3463a command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_d0b7496c2d60494688b4765478137521(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_d0b7496c2d60494688b4765478137521(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_d0b7496c2d60494688b4765478137521(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_d0b7496c2d60494688b4765478137521(_2ee54d65527d6e349ac1574e8a829011_d0b7496c2d60494688b4765478137521 command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_1aacc238f3934fe0af468ef184506fc1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_1aacc238f3934fe0af468ef184506fc1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_1aacc238f3934fe0af468ef184506fc1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_1aacc238f3934fe0af468ef184506fc1(_2ee54d65527d6e349ac1574e8a829011_1aacc238f3934fe0af468ef184506fc1 command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_0d1b2dc103364d30a6c4e84aabb617b2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_0d1b2dc103364d30a6c4e84aabb617b2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_0d1b2dc103364d30a6c4e84aabb617b2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_0d1b2dc103364d30a6c4e84aabb617b2(_2ee54d65527d6e349ac1574e8a829011_0d1b2dc103364d30a6c4e84aabb617b2 command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_08424bd76fb44ec0b59bc9b83e3798dd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_08424bd76fb44ec0b59bc9b83e3798dd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_08424bd76fb44ec0b59bc9b83e3798dd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_08424bd76fb44ec0b59bc9b83e3798dd(_2ee54d65527d6e349ac1574e8a829011_08424bd76fb44ec0b59bc9b83e3798dd command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_4f4944451c4b43498e853d01dad01913(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_4f4944451c4b43498e853d01dad01913(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_4f4944451c4b43498e853d01dad01913(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_4f4944451c4b43498e853d01dad01913(_2ee54d65527d6e349ac1574e8a829011_4f4944451c4b43498e853d01dad01913 command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_c6140ca6668f4e63bc1f0b59ddf827a0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_c6140ca6668f4e63bc1f0b59ddf827a0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_c6140ca6668f4e63bc1f0b59ddf827a0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_c6140ca6668f4e63bc1f0b59ddf827a0(_2ee54d65527d6e349ac1574e8a829011_c6140ca6668f4e63bc1f0b59ddf827a0 command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_12e88be5332e48a6b6cd4af518626cc1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_12e88be5332e48a6b6cd4af518626cc1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_12e88be5332e48a6b6cd4af518626cc1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_12e88be5332e48a6b6cd4af518626cc1(_2ee54d65527d6e349ac1574e8a829011_12e88be5332e48a6b6cd4af518626cc1 command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_a2562d4da8bb4f1094ee1963a20e6b9d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_a2562d4da8bb4f1094ee1963a20e6b9d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_a2562d4da8bb4f1094ee1963a20e6b9d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_a2562d4da8bb4f1094ee1963a20e6b9d(_2ee54d65527d6e349ac1574e8a829011_a2562d4da8bb4f1094ee1963a20e6b9d command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_37e2446b6aaa4d56b012e38abfae5277(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_37e2446b6aaa4d56b012e38abfae5277(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_37e2446b6aaa4d56b012e38abfae5277(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_37e2446b6aaa4d56b012e38abfae5277(_2ee54d65527d6e349ac1574e8a829011_37e2446b6aaa4d56b012e38abfae5277 command)
		{
		}

		private void BakeCommandBinding__2ee54d65527d6e349ac1574e8a829011_6b4e02670dd14f3f870ddfbd751afccd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2ee54d65527d6e349ac1574e8a829011_6b4e02670dd14f3f870ddfbd751afccd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2ee54d65527d6e349ac1574e8a829011_6b4e02670dd14f3f870ddfbd751afccd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2ee54d65527d6e349ac1574e8a829011_6b4e02670dd14f3f870ddfbd751afccd(_2ee54d65527d6e349ac1574e8a829011_6b4e02670dd14f3f870ddfbd751afccd command)
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
