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
	public class CoherenceSync_054a82ab272ffe941a63a33199a34280 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _054a82ab272ffe941a63a33199a34280_a6abbe1bee4f43a4b0fb48136038e51b_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_a39702deaae54d0fa210533982a80a78_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_9a76d303c84a425890bd6a91f1df7e01_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_d25b83c0c5f945d48173f2a6827d55f9_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_1ba259f1e73046899091d1a5c4c55ef9_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_4b4bbdb42b804fdcacb332737e7805e1_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_4a64f9e276f8481e82ed90ff835a4a5a_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_adc7a74e6b78437f9395960065888991_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_1c40bf642a784df48149691da203bb2a_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_2f81e1e88f5543e3b0b4b0467a96dde3_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_17cee6080e904bbeb4db15f7f4adc5f5_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_dd8f6704eb6244fc93d546c473324373_CommandTarget;

		private CharacterController _054a82ab272ffe941a63a33199a34280_c46ed422d70148bea95dcebb1926a0f5_CommandTarget;

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

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_a6abbe1bee4f43a4b0fb48136038e51b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_a6abbe1bee4f43a4b0fb48136038e51b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_a6abbe1bee4f43a4b0fb48136038e51b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_a6abbe1bee4f43a4b0fb48136038e51b(_054a82ab272ffe941a63a33199a34280_a6abbe1bee4f43a4b0fb48136038e51b command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_a39702deaae54d0fa210533982a80a78(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_a39702deaae54d0fa210533982a80a78(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_a39702deaae54d0fa210533982a80a78(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_a39702deaae54d0fa210533982a80a78(_054a82ab272ffe941a63a33199a34280_a39702deaae54d0fa210533982a80a78 command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_9a76d303c84a425890bd6a91f1df7e01(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_9a76d303c84a425890bd6a91f1df7e01(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_9a76d303c84a425890bd6a91f1df7e01(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_9a76d303c84a425890bd6a91f1df7e01(_054a82ab272ffe941a63a33199a34280_9a76d303c84a425890bd6a91f1df7e01 command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_d25b83c0c5f945d48173f2a6827d55f9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_d25b83c0c5f945d48173f2a6827d55f9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_d25b83c0c5f945d48173f2a6827d55f9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_d25b83c0c5f945d48173f2a6827d55f9(_054a82ab272ffe941a63a33199a34280_d25b83c0c5f945d48173f2a6827d55f9 command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_1ba259f1e73046899091d1a5c4c55ef9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_1ba259f1e73046899091d1a5c4c55ef9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_1ba259f1e73046899091d1a5c4c55ef9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_1ba259f1e73046899091d1a5c4c55ef9(_054a82ab272ffe941a63a33199a34280_1ba259f1e73046899091d1a5c4c55ef9 command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_4b4bbdb42b804fdcacb332737e7805e1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_4b4bbdb42b804fdcacb332737e7805e1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_4b4bbdb42b804fdcacb332737e7805e1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_4b4bbdb42b804fdcacb332737e7805e1(_054a82ab272ffe941a63a33199a34280_4b4bbdb42b804fdcacb332737e7805e1 command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_4a64f9e276f8481e82ed90ff835a4a5a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_4a64f9e276f8481e82ed90ff835a4a5a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_4a64f9e276f8481e82ed90ff835a4a5a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_4a64f9e276f8481e82ed90ff835a4a5a(_054a82ab272ffe941a63a33199a34280_4a64f9e276f8481e82ed90ff835a4a5a command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_adc7a74e6b78437f9395960065888991(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_adc7a74e6b78437f9395960065888991(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_adc7a74e6b78437f9395960065888991(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_adc7a74e6b78437f9395960065888991(_054a82ab272ffe941a63a33199a34280_adc7a74e6b78437f9395960065888991 command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_1c40bf642a784df48149691da203bb2a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_1c40bf642a784df48149691da203bb2a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_1c40bf642a784df48149691da203bb2a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_1c40bf642a784df48149691da203bb2a(_054a82ab272ffe941a63a33199a34280_1c40bf642a784df48149691da203bb2a command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_2f81e1e88f5543e3b0b4b0467a96dde3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_2f81e1e88f5543e3b0b4b0467a96dde3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_2f81e1e88f5543e3b0b4b0467a96dde3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_2f81e1e88f5543e3b0b4b0467a96dde3(_054a82ab272ffe941a63a33199a34280_2f81e1e88f5543e3b0b4b0467a96dde3 command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_17cee6080e904bbeb4db15f7f4adc5f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_17cee6080e904bbeb4db15f7f4adc5f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_17cee6080e904bbeb4db15f7f4adc5f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_17cee6080e904bbeb4db15f7f4adc5f5(_054a82ab272ffe941a63a33199a34280_17cee6080e904bbeb4db15f7f4adc5f5 command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_dd8f6704eb6244fc93d546c473324373(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_dd8f6704eb6244fc93d546c473324373(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_dd8f6704eb6244fc93d546c473324373(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_dd8f6704eb6244fc93d546c473324373(_054a82ab272ffe941a63a33199a34280_dd8f6704eb6244fc93d546c473324373 command)
		{
		}

		private void BakeCommandBinding__054a82ab272ffe941a63a33199a34280_c46ed422d70148bea95dcebb1926a0f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__054a82ab272ffe941a63a33199a34280_c46ed422d70148bea95dcebb1926a0f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__054a82ab272ffe941a63a33199a34280_c46ed422d70148bea95dcebb1926a0f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__054a82ab272ffe941a63a33199a34280_c46ed422d70148bea95dcebb1926a0f5(_054a82ab272ffe941a63a33199a34280_c46ed422d70148bea95dcebb1926a0f5 command)
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
