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
	public class CoherenceSync_73d58e274d4daef4fa290799ed1a03f7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_a2b42efd20dd437695fc547f077b9828_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_b5222f86a5a04d20921347245f0c1a84_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_55db74b3ed344130877b4e2962893013_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_c4d67aa96f2a48dba9303039e096eb52_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_39580edfafb248c89a0606e87b72bde3_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_538f7e4d50434be6958ea1a6dbc67468_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_c329bcbf50e84d28b019a1c428895de8_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_e7fa505c8ea14147a831c384c9141dfc_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_7c138d9887874c5eb249647ac475659f_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_3b3bc6d4bcad4e08ba0eb6c8cf26da2e_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_407bd08dac4d44d69cfa70e394950124_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_ac7f88d6a5dd4f6491e62bd48dd0101c_CommandTarget;

		private CharacterController _73d58e274d4daef4fa290799ed1a03f7_85eefd1bb32c40c88ebc52f250d5f504_CommandTarget;

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

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_a2b42efd20dd437695fc547f077b9828(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_a2b42efd20dd437695fc547f077b9828(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_a2b42efd20dd437695fc547f077b9828(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_a2b42efd20dd437695fc547f077b9828(_73d58e274d4daef4fa290799ed1a03f7_a2b42efd20dd437695fc547f077b9828 command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_b5222f86a5a04d20921347245f0c1a84(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_b5222f86a5a04d20921347245f0c1a84(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_b5222f86a5a04d20921347245f0c1a84(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_b5222f86a5a04d20921347245f0c1a84(_73d58e274d4daef4fa290799ed1a03f7_b5222f86a5a04d20921347245f0c1a84 command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_55db74b3ed344130877b4e2962893013(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_55db74b3ed344130877b4e2962893013(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_55db74b3ed344130877b4e2962893013(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_55db74b3ed344130877b4e2962893013(_73d58e274d4daef4fa290799ed1a03f7_55db74b3ed344130877b4e2962893013 command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_c4d67aa96f2a48dba9303039e096eb52(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_c4d67aa96f2a48dba9303039e096eb52(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_c4d67aa96f2a48dba9303039e096eb52(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_c4d67aa96f2a48dba9303039e096eb52(_73d58e274d4daef4fa290799ed1a03f7_c4d67aa96f2a48dba9303039e096eb52 command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_39580edfafb248c89a0606e87b72bde3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_39580edfafb248c89a0606e87b72bde3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_39580edfafb248c89a0606e87b72bde3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_39580edfafb248c89a0606e87b72bde3(_73d58e274d4daef4fa290799ed1a03f7_39580edfafb248c89a0606e87b72bde3 command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_538f7e4d50434be6958ea1a6dbc67468(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_538f7e4d50434be6958ea1a6dbc67468(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_538f7e4d50434be6958ea1a6dbc67468(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_538f7e4d50434be6958ea1a6dbc67468(_73d58e274d4daef4fa290799ed1a03f7_538f7e4d50434be6958ea1a6dbc67468 command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_c329bcbf50e84d28b019a1c428895de8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_c329bcbf50e84d28b019a1c428895de8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_c329bcbf50e84d28b019a1c428895de8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_c329bcbf50e84d28b019a1c428895de8(_73d58e274d4daef4fa290799ed1a03f7_c329bcbf50e84d28b019a1c428895de8 command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_e7fa505c8ea14147a831c384c9141dfc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_e7fa505c8ea14147a831c384c9141dfc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_e7fa505c8ea14147a831c384c9141dfc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_e7fa505c8ea14147a831c384c9141dfc(_73d58e274d4daef4fa290799ed1a03f7_e7fa505c8ea14147a831c384c9141dfc command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_7c138d9887874c5eb249647ac475659f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_7c138d9887874c5eb249647ac475659f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_7c138d9887874c5eb249647ac475659f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_7c138d9887874c5eb249647ac475659f(_73d58e274d4daef4fa290799ed1a03f7_7c138d9887874c5eb249647ac475659f command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_3b3bc6d4bcad4e08ba0eb6c8cf26da2e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_3b3bc6d4bcad4e08ba0eb6c8cf26da2e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_3b3bc6d4bcad4e08ba0eb6c8cf26da2e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_3b3bc6d4bcad4e08ba0eb6c8cf26da2e(_73d58e274d4daef4fa290799ed1a03f7_3b3bc6d4bcad4e08ba0eb6c8cf26da2e command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_407bd08dac4d44d69cfa70e394950124(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_407bd08dac4d44d69cfa70e394950124(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_407bd08dac4d44d69cfa70e394950124(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_407bd08dac4d44d69cfa70e394950124(_73d58e274d4daef4fa290799ed1a03f7_407bd08dac4d44d69cfa70e394950124 command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_ac7f88d6a5dd4f6491e62bd48dd0101c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_ac7f88d6a5dd4f6491e62bd48dd0101c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_ac7f88d6a5dd4f6491e62bd48dd0101c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_ac7f88d6a5dd4f6491e62bd48dd0101c(_73d58e274d4daef4fa290799ed1a03f7_ac7f88d6a5dd4f6491e62bd48dd0101c command)
		{
		}

		private void BakeCommandBinding__73d58e274d4daef4fa290799ed1a03f7_85eefd1bb32c40c88ebc52f250d5f504(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73d58e274d4daef4fa290799ed1a03f7_85eefd1bb32c40c88ebc52f250d5f504(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73d58e274d4daef4fa290799ed1a03f7_85eefd1bb32c40c88ebc52f250d5f504(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73d58e274d4daef4fa290799ed1a03f7_85eefd1bb32c40c88ebc52f250d5f504(_73d58e274d4daef4fa290799ed1a03f7_85eefd1bb32c40c88ebc52f250d5f504 command)
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
