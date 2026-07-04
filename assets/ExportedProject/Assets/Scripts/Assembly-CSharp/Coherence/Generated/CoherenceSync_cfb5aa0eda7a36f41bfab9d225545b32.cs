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
	public class CoherenceSync_cfb5aa0eda7a36f41bfab9d225545b32 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_7e8651eb102b4877a256ce3452e31252_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_ac5da870a8e446c194d5d3c406f05e6f_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_2922dc75bec9452aac845c6bf0951f0a_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_9231bc8e0878443298e09979a0366e85_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_0ce966c88f3744aa92335612a98c7634_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_d9d9603820e745fca8d51270f55b3ca5_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_ccbcb24b7fec4fc68dfb596c5f541269_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_9ce749d25ec94d88994e76ce5df5e86b_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_5bd8d2e9dba741288f840fbf215e326a_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_5a088d6971e64d02a9a46bd1e03ca582_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_2fb22079d32e47ddb32f623cb80c76f2_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_a2656f7927444891b5e6206e2358591d_CommandTarget;

		private CharacterController _cfb5aa0eda7a36f41bfab9d225545b32_1ce8718696ac4304856ab0ebb4a445af_CommandTarget;

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

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_7e8651eb102b4877a256ce3452e31252(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_7e8651eb102b4877a256ce3452e31252(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_7e8651eb102b4877a256ce3452e31252(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_7e8651eb102b4877a256ce3452e31252(_cfb5aa0eda7a36f41bfab9d225545b32_7e8651eb102b4877a256ce3452e31252 command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_ac5da870a8e446c194d5d3c406f05e6f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_ac5da870a8e446c194d5d3c406f05e6f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_ac5da870a8e446c194d5d3c406f05e6f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_ac5da870a8e446c194d5d3c406f05e6f(_cfb5aa0eda7a36f41bfab9d225545b32_ac5da870a8e446c194d5d3c406f05e6f command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_2922dc75bec9452aac845c6bf0951f0a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_2922dc75bec9452aac845c6bf0951f0a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_2922dc75bec9452aac845c6bf0951f0a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_2922dc75bec9452aac845c6bf0951f0a(_cfb5aa0eda7a36f41bfab9d225545b32_2922dc75bec9452aac845c6bf0951f0a command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_9231bc8e0878443298e09979a0366e85(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_9231bc8e0878443298e09979a0366e85(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_9231bc8e0878443298e09979a0366e85(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_9231bc8e0878443298e09979a0366e85(_cfb5aa0eda7a36f41bfab9d225545b32_9231bc8e0878443298e09979a0366e85 command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_0ce966c88f3744aa92335612a98c7634(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_0ce966c88f3744aa92335612a98c7634(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_0ce966c88f3744aa92335612a98c7634(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_0ce966c88f3744aa92335612a98c7634(_cfb5aa0eda7a36f41bfab9d225545b32_0ce966c88f3744aa92335612a98c7634 command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_d9d9603820e745fca8d51270f55b3ca5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_d9d9603820e745fca8d51270f55b3ca5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_d9d9603820e745fca8d51270f55b3ca5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_d9d9603820e745fca8d51270f55b3ca5(_cfb5aa0eda7a36f41bfab9d225545b32_d9d9603820e745fca8d51270f55b3ca5 command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_ccbcb24b7fec4fc68dfb596c5f541269(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_ccbcb24b7fec4fc68dfb596c5f541269(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_ccbcb24b7fec4fc68dfb596c5f541269(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_ccbcb24b7fec4fc68dfb596c5f541269(_cfb5aa0eda7a36f41bfab9d225545b32_ccbcb24b7fec4fc68dfb596c5f541269 command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_9ce749d25ec94d88994e76ce5df5e86b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_9ce749d25ec94d88994e76ce5df5e86b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_9ce749d25ec94d88994e76ce5df5e86b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_9ce749d25ec94d88994e76ce5df5e86b(_cfb5aa0eda7a36f41bfab9d225545b32_9ce749d25ec94d88994e76ce5df5e86b command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_5bd8d2e9dba741288f840fbf215e326a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_5bd8d2e9dba741288f840fbf215e326a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_5bd8d2e9dba741288f840fbf215e326a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_5bd8d2e9dba741288f840fbf215e326a(_cfb5aa0eda7a36f41bfab9d225545b32_5bd8d2e9dba741288f840fbf215e326a command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_5a088d6971e64d02a9a46bd1e03ca582(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_5a088d6971e64d02a9a46bd1e03ca582(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_5a088d6971e64d02a9a46bd1e03ca582(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_5a088d6971e64d02a9a46bd1e03ca582(_cfb5aa0eda7a36f41bfab9d225545b32_5a088d6971e64d02a9a46bd1e03ca582 command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_2fb22079d32e47ddb32f623cb80c76f2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_2fb22079d32e47ddb32f623cb80c76f2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_2fb22079d32e47ddb32f623cb80c76f2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_2fb22079d32e47ddb32f623cb80c76f2(_cfb5aa0eda7a36f41bfab9d225545b32_2fb22079d32e47ddb32f623cb80c76f2 command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_a2656f7927444891b5e6206e2358591d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_a2656f7927444891b5e6206e2358591d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_a2656f7927444891b5e6206e2358591d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_a2656f7927444891b5e6206e2358591d(_cfb5aa0eda7a36f41bfab9d225545b32_a2656f7927444891b5e6206e2358591d command)
		{
		}

		private void BakeCommandBinding__cfb5aa0eda7a36f41bfab9d225545b32_1ce8718696ac4304856ab0ebb4a445af(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cfb5aa0eda7a36f41bfab9d225545b32_1ce8718696ac4304856ab0ebb4a445af(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cfb5aa0eda7a36f41bfab9d225545b32_1ce8718696ac4304856ab0ebb4a445af(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cfb5aa0eda7a36f41bfab9d225545b32_1ce8718696ac4304856ab0ebb4a445af(_cfb5aa0eda7a36f41bfab9d225545b32_1ce8718696ac4304856ab0ebb4a445af command)
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
