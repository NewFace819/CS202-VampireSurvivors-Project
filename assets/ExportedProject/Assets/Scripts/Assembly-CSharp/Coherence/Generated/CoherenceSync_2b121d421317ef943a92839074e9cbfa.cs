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
	public class CoherenceSync_2b121d421317ef943a92839074e9cbfa : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_5c7c2f6b48e8418c89c0bad8f2ee6966_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_8c7005f219194de39dde1fbbe3b61943_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_29a234558e8f4371a0fb4f4b84e6e5fe_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_ea2751e8386b48cea06073dda8745a9f_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_4b8eaea6efca4ac1ad8cf04ff54fd244_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_80a3487f81d94cb4a958a793f5d101d8_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_826455b05e6b4e409bb7e1cf199e35f5_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_aab5b56b98724d69a0d404ef694f8a7b_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_5228bd51b7954603a627b065463bcb75_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_d23c48739d094fae8cc7fe6808f19cf3_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_982f2016de4f4285ad7afee1ca4e42e3_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_8170ba4028e1431db52dea073c247835_CommandTarget;

		private CharacterController _2b121d421317ef943a92839074e9cbfa_8ae007520c544207aef26b1cbbd8ef07_CommandTarget;

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

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_5c7c2f6b48e8418c89c0bad8f2ee6966(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_5c7c2f6b48e8418c89c0bad8f2ee6966(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_5c7c2f6b48e8418c89c0bad8f2ee6966(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_5c7c2f6b48e8418c89c0bad8f2ee6966(_2b121d421317ef943a92839074e9cbfa_5c7c2f6b48e8418c89c0bad8f2ee6966 command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_8c7005f219194de39dde1fbbe3b61943(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_8c7005f219194de39dde1fbbe3b61943(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_8c7005f219194de39dde1fbbe3b61943(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_8c7005f219194de39dde1fbbe3b61943(_2b121d421317ef943a92839074e9cbfa_8c7005f219194de39dde1fbbe3b61943 command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_29a234558e8f4371a0fb4f4b84e6e5fe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_29a234558e8f4371a0fb4f4b84e6e5fe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_29a234558e8f4371a0fb4f4b84e6e5fe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_29a234558e8f4371a0fb4f4b84e6e5fe(_2b121d421317ef943a92839074e9cbfa_29a234558e8f4371a0fb4f4b84e6e5fe command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_ea2751e8386b48cea06073dda8745a9f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_ea2751e8386b48cea06073dda8745a9f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_ea2751e8386b48cea06073dda8745a9f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_ea2751e8386b48cea06073dda8745a9f(_2b121d421317ef943a92839074e9cbfa_ea2751e8386b48cea06073dda8745a9f command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_4b8eaea6efca4ac1ad8cf04ff54fd244(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_4b8eaea6efca4ac1ad8cf04ff54fd244(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_4b8eaea6efca4ac1ad8cf04ff54fd244(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_4b8eaea6efca4ac1ad8cf04ff54fd244(_2b121d421317ef943a92839074e9cbfa_4b8eaea6efca4ac1ad8cf04ff54fd244 command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_80a3487f81d94cb4a958a793f5d101d8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_80a3487f81d94cb4a958a793f5d101d8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_80a3487f81d94cb4a958a793f5d101d8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_80a3487f81d94cb4a958a793f5d101d8(_2b121d421317ef943a92839074e9cbfa_80a3487f81d94cb4a958a793f5d101d8 command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_826455b05e6b4e409bb7e1cf199e35f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_826455b05e6b4e409bb7e1cf199e35f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_826455b05e6b4e409bb7e1cf199e35f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_826455b05e6b4e409bb7e1cf199e35f5(_2b121d421317ef943a92839074e9cbfa_826455b05e6b4e409bb7e1cf199e35f5 command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_aab5b56b98724d69a0d404ef694f8a7b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_aab5b56b98724d69a0d404ef694f8a7b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_aab5b56b98724d69a0d404ef694f8a7b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_aab5b56b98724d69a0d404ef694f8a7b(_2b121d421317ef943a92839074e9cbfa_aab5b56b98724d69a0d404ef694f8a7b command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_5228bd51b7954603a627b065463bcb75(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_5228bd51b7954603a627b065463bcb75(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_5228bd51b7954603a627b065463bcb75(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_5228bd51b7954603a627b065463bcb75(_2b121d421317ef943a92839074e9cbfa_5228bd51b7954603a627b065463bcb75 command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_d23c48739d094fae8cc7fe6808f19cf3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_d23c48739d094fae8cc7fe6808f19cf3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_d23c48739d094fae8cc7fe6808f19cf3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_d23c48739d094fae8cc7fe6808f19cf3(_2b121d421317ef943a92839074e9cbfa_d23c48739d094fae8cc7fe6808f19cf3 command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_982f2016de4f4285ad7afee1ca4e42e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_982f2016de4f4285ad7afee1ca4e42e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_982f2016de4f4285ad7afee1ca4e42e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_982f2016de4f4285ad7afee1ca4e42e3(_2b121d421317ef943a92839074e9cbfa_982f2016de4f4285ad7afee1ca4e42e3 command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_8170ba4028e1431db52dea073c247835(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_8170ba4028e1431db52dea073c247835(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_8170ba4028e1431db52dea073c247835(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_8170ba4028e1431db52dea073c247835(_2b121d421317ef943a92839074e9cbfa_8170ba4028e1431db52dea073c247835 command)
		{
		}

		private void BakeCommandBinding__2b121d421317ef943a92839074e9cbfa_8ae007520c544207aef26b1cbbd8ef07(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2b121d421317ef943a92839074e9cbfa_8ae007520c544207aef26b1cbbd8ef07(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2b121d421317ef943a92839074e9cbfa_8ae007520c544207aef26b1cbbd8ef07(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2b121d421317ef943a92839074e9cbfa_8ae007520c544207aef26b1cbbd8ef07(_2b121d421317ef943a92839074e9cbfa_8ae007520c544207aef26b1cbbd8ef07 command)
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
