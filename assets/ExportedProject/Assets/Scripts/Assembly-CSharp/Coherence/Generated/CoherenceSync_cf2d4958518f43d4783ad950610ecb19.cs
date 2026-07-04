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
	public class CoherenceSync_cf2d4958518f43d4783ad950610ecb19 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_b1229811ecd149bfb7bc011f003b206e_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_095940342fa94baab1e248c566ac307b_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_059b8c7791eb4a5cb8fdebdc1b400e36_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_7bb49503bde64c33bf267b4155959156_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_dc7045beb3f84a70b2beb410fc30f750_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_b101f5a5a6cd44319ce1c4e166393bf6_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_02dcb9827cd74e849a99c9347fe52d0d_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_67dc2e5948164add9fb9ac56c41cf0ec_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_7b54ca650418428da34abdc3651f9a42_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_42f5506b62e0496b95d609eab99285f1_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_ba5bfb4308244aaa839bd9391d69b577_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_ac4906f1bcee443b91a72c3945a4ef0c_CommandTarget;

		private CharacterController _cf2d4958518f43d4783ad950610ecb19_b945281f31f34b98907585c151edd9de_CommandTarget;

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

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_b1229811ecd149bfb7bc011f003b206e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_b1229811ecd149bfb7bc011f003b206e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_b1229811ecd149bfb7bc011f003b206e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_b1229811ecd149bfb7bc011f003b206e(_cf2d4958518f43d4783ad950610ecb19_b1229811ecd149bfb7bc011f003b206e command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_095940342fa94baab1e248c566ac307b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_095940342fa94baab1e248c566ac307b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_095940342fa94baab1e248c566ac307b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_095940342fa94baab1e248c566ac307b(_cf2d4958518f43d4783ad950610ecb19_095940342fa94baab1e248c566ac307b command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_059b8c7791eb4a5cb8fdebdc1b400e36(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_059b8c7791eb4a5cb8fdebdc1b400e36(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_059b8c7791eb4a5cb8fdebdc1b400e36(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_059b8c7791eb4a5cb8fdebdc1b400e36(_cf2d4958518f43d4783ad950610ecb19_059b8c7791eb4a5cb8fdebdc1b400e36 command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_7bb49503bde64c33bf267b4155959156(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_7bb49503bde64c33bf267b4155959156(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_7bb49503bde64c33bf267b4155959156(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_7bb49503bde64c33bf267b4155959156(_cf2d4958518f43d4783ad950610ecb19_7bb49503bde64c33bf267b4155959156 command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_dc7045beb3f84a70b2beb410fc30f750(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_dc7045beb3f84a70b2beb410fc30f750(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_dc7045beb3f84a70b2beb410fc30f750(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_dc7045beb3f84a70b2beb410fc30f750(_cf2d4958518f43d4783ad950610ecb19_dc7045beb3f84a70b2beb410fc30f750 command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_b101f5a5a6cd44319ce1c4e166393bf6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_b101f5a5a6cd44319ce1c4e166393bf6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_b101f5a5a6cd44319ce1c4e166393bf6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_b101f5a5a6cd44319ce1c4e166393bf6(_cf2d4958518f43d4783ad950610ecb19_b101f5a5a6cd44319ce1c4e166393bf6 command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_02dcb9827cd74e849a99c9347fe52d0d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_02dcb9827cd74e849a99c9347fe52d0d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_02dcb9827cd74e849a99c9347fe52d0d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_02dcb9827cd74e849a99c9347fe52d0d(_cf2d4958518f43d4783ad950610ecb19_02dcb9827cd74e849a99c9347fe52d0d command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_67dc2e5948164add9fb9ac56c41cf0ec(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_67dc2e5948164add9fb9ac56c41cf0ec(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_67dc2e5948164add9fb9ac56c41cf0ec(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_67dc2e5948164add9fb9ac56c41cf0ec(_cf2d4958518f43d4783ad950610ecb19_67dc2e5948164add9fb9ac56c41cf0ec command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_7b54ca650418428da34abdc3651f9a42(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_7b54ca650418428da34abdc3651f9a42(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_7b54ca650418428da34abdc3651f9a42(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_7b54ca650418428da34abdc3651f9a42(_cf2d4958518f43d4783ad950610ecb19_7b54ca650418428da34abdc3651f9a42 command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_42f5506b62e0496b95d609eab99285f1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_42f5506b62e0496b95d609eab99285f1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_42f5506b62e0496b95d609eab99285f1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_42f5506b62e0496b95d609eab99285f1(_cf2d4958518f43d4783ad950610ecb19_42f5506b62e0496b95d609eab99285f1 command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_ba5bfb4308244aaa839bd9391d69b577(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_ba5bfb4308244aaa839bd9391d69b577(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_ba5bfb4308244aaa839bd9391d69b577(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_ba5bfb4308244aaa839bd9391d69b577(_cf2d4958518f43d4783ad950610ecb19_ba5bfb4308244aaa839bd9391d69b577 command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_ac4906f1bcee443b91a72c3945a4ef0c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_ac4906f1bcee443b91a72c3945a4ef0c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_ac4906f1bcee443b91a72c3945a4ef0c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_ac4906f1bcee443b91a72c3945a4ef0c(_cf2d4958518f43d4783ad950610ecb19_ac4906f1bcee443b91a72c3945a4ef0c command)
		{
		}

		private void BakeCommandBinding__cf2d4958518f43d4783ad950610ecb19_b945281f31f34b98907585c151edd9de(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cf2d4958518f43d4783ad950610ecb19_b945281f31f34b98907585c151edd9de(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cf2d4958518f43d4783ad950610ecb19_b945281f31f34b98907585c151edd9de(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cf2d4958518f43d4783ad950610ecb19_b945281f31f34b98907585c151edd9de(_cf2d4958518f43d4783ad950610ecb19_b945281f31f34b98907585c151edd9de command)
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
