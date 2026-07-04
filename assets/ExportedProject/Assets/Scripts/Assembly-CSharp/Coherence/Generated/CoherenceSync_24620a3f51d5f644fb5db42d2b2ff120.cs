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
	public class CoherenceSync_24620a3f51d5f644fb5db42d2b2ff120 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_83f706cd5a57454490ad15ff963ba0a5_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_e422aa494087449e96a9fb20cd5841e1_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_dd43e82b9d1d405f959aa85960e5a3c0_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_1717ac64263f4e3093eb3eb2a7dcbeba_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_478cec6719a942e889672b05bee3cf85_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_1b4f79e6d09b48f68778b8ddb022934b_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_4fedccc28f4246e789fb004c75e34229_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_761948d9311f458a99c749e590df3407_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_a162c9b5917a4702a95d9296b8889b93_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_89b38842477f45a0bf5dc3476e69be01_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_a116af99fa77497885f7fee1b45dc63a_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_b74b216825674f108e19c5a729adfaee_CommandTarget;

		private CharacterController _24620a3f51d5f644fb5db42d2b2ff120_a80ff9e27a614ebcbe6be63b57fd26d9_CommandTarget;

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

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_83f706cd5a57454490ad15ff963ba0a5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_83f706cd5a57454490ad15ff963ba0a5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_83f706cd5a57454490ad15ff963ba0a5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_83f706cd5a57454490ad15ff963ba0a5(_24620a3f51d5f644fb5db42d2b2ff120_83f706cd5a57454490ad15ff963ba0a5 command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_e422aa494087449e96a9fb20cd5841e1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_e422aa494087449e96a9fb20cd5841e1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_e422aa494087449e96a9fb20cd5841e1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_e422aa494087449e96a9fb20cd5841e1(_24620a3f51d5f644fb5db42d2b2ff120_e422aa494087449e96a9fb20cd5841e1 command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_dd43e82b9d1d405f959aa85960e5a3c0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_dd43e82b9d1d405f959aa85960e5a3c0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_dd43e82b9d1d405f959aa85960e5a3c0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_dd43e82b9d1d405f959aa85960e5a3c0(_24620a3f51d5f644fb5db42d2b2ff120_dd43e82b9d1d405f959aa85960e5a3c0 command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_1717ac64263f4e3093eb3eb2a7dcbeba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_1717ac64263f4e3093eb3eb2a7dcbeba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_1717ac64263f4e3093eb3eb2a7dcbeba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_1717ac64263f4e3093eb3eb2a7dcbeba(_24620a3f51d5f644fb5db42d2b2ff120_1717ac64263f4e3093eb3eb2a7dcbeba command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_478cec6719a942e889672b05bee3cf85(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_478cec6719a942e889672b05bee3cf85(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_478cec6719a942e889672b05bee3cf85(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_478cec6719a942e889672b05bee3cf85(_24620a3f51d5f644fb5db42d2b2ff120_478cec6719a942e889672b05bee3cf85 command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_1b4f79e6d09b48f68778b8ddb022934b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_1b4f79e6d09b48f68778b8ddb022934b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_1b4f79e6d09b48f68778b8ddb022934b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_1b4f79e6d09b48f68778b8ddb022934b(_24620a3f51d5f644fb5db42d2b2ff120_1b4f79e6d09b48f68778b8ddb022934b command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_4fedccc28f4246e789fb004c75e34229(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_4fedccc28f4246e789fb004c75e34229(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_4fedccc28f4246e789fb004c75e34229(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_4fedccc28f4246e789fb004c75e34229(_24620a3f51d5f644fb5db42d2b2ff120_4fedccc28f4246e789fb004c75e34229 command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_761948d9311f458a99c749e590df3407(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_761948d9311f458a99c749e590df3407(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_761948d9311f458a99c749e590df3407(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_761948d9311f458a99c749e590df3407(_24620a3f51d5f644fb5db42d2b2ff120_761948d9311f458a99c749e590df3407 command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_a162c9b5917a4702a95d9296b8889b93(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_a162c9b5917a4702a95d9296b8889b93(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_a162c9b5917a4702a95d9296b8889b93(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_a162c9b5917a4702a95d9296b8889b93(_24620a3f51d5f644fb5db42d2b2ff120_a162c9b5917a4702a95d9296b8889b93 command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_89b38842477f45a0bf5dc3476e69be01(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_89b38842477f45a0bf5dc3476e69be01(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_89b38842477f45a0bf5dc3476e69be01(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_89b38842477f45a0bf5dc3476e69be01(_24620a3f51d5f644fb5db42d2b2ff120_89b38842477f45a0bf5dc3476e69be01 command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_a116af99fa77497885f7fee1b45dc63a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_a116af99fa77497885f7fee1b45dc63a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_a116af99fa77497885f7fee1b45dc63a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_a116af99fa77497885f7fee1b45dc63a(_24620a3f51d5f644fb5db42d2b2ff120_a116af99fa77497885f7fee1b45dc63a command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_b74b216825674f108e19c5a729adfaee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_b74b216825674f108e19c5a729adfaee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_b74b216825674f108e19c5a729adfaee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_b74b216825674f108e19c5a729adfaee(_24620a3f51d5f644fb5db42d2b2ff120_b74b216825674f108e19c5a729adfaee command)
		{
		}

		private void BakeCommandBinding__24620a3f51d5f644fb5db42d2b2ff120_a80ff9e27a614ebcbe6be63b57fd26d9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__24620a3f51d5f644fb5db42d2b2ff120_a80ff9e27a614ebcbe6be63b57fd26d9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__24620a3f51d5f644fb5db42d2b2ff120_a80ff9e27a614ebcbe6be63b57fd26d9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__24620a3f51d5f644fb5db42d2b2ff120_a80ff9e27a614ebcbe6be63b57fd26d9(_24620a3f51d5f644fb5db42d2b2ff120_a80ff9e27a614ebcbe6be63b57fd26d9 command)
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
