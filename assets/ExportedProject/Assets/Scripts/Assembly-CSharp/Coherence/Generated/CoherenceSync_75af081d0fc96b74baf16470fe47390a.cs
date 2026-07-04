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
	public class CoherenceSync_75af081d0fc96b74baf16470fe47390a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_5a3b6545611f42f5ae09afd89ee16f74_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_c51d0696635b410a9a1d105077905bbf_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_1d4b9c773f324331bbca0645a4e25291_CommandTarget;

		private CharacterControllerSheMoonIta _75af081d0fc96b74baf16470fe47390a_487a2283fd044bfd90dfeecf12945b00_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_26c08936c42447c8aa5d60c386739769_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_64b60eef76604477a7297b5d67da449c_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_8ba094caeeb547ffb25b98a0cf532496_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_4c57eab113c5467ea342fdb8b60e1b3c_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_37192051dfe240d880e2b950492dfe39_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_8d650629691c4090be427a30bf215386_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_4d15318d3a494555a064a4ce473359e6_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_b0addca2ccd248d4ae5b1031f0c32313_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_22f27e66c8a641ed8d6d0396ef285cb5_CommandTarget;

		private CharacterController _75af081d0fc96b74baf16470fe47390a_405636a3da7246f3b40a7f60720cd2c4_CommandTarget;

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

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_5a3b6545611f42f5ae09afd89ee16f74(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_5a3b6545611f42f5ae09afd89ee16f74(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_5a3b6545611f42f5ae09afd89ee16f74(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_5a3b6545611f42f5ae09afd89ee16f74(_75af081d0fc96b74baf16470fe47390a_5a3b6545611f42f5ae09afd89ee16f74 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_c51d0696635b410a9a1d105077905bbf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_c51d0696635b410a9a1d105077905bbf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_c51d0696635b410a9a1d105077905bbf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_c51d0696635b410a9a1d105077905bbf(_75af081d0fc96b74baf16470fe47390a_c51d0696635b410a9a1d105077905bbf command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_1d4b9c773f324331bbca0645a4e25291(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_1d4b9c773f324331bbca0645a4e25291(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_1d4b9c773f324331bbca0645a4e25291(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_1d4b9c773f324331bbca0645a4e25291(_75af081d0fc96b74baf16470fe47390a_1d4b9c773f324331bbca0645a4e25291 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_487a2283fd044bfd90dfeecf12945b00(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_487a2283fd044bfd90dfeecf12945b00(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_487a2283fd044bfd90dfeecf12945b00(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_487a2283fd044bfd90dfeecf12945b00(_75af081d0fc96b74baf16470fe47390a_487a2283fd044bfd90dfeecf12945b00 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_26c08936c42447c8aa5d60c386739769(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_26c08936c42447c8aa5d60c386739769(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_26c08936c42447c8aa5d60c386739769(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_26c08936c42447c8aa5d60c386739769(_75af081d0fc96b74baf16470fe47390a_26c08936c42447c8aa5d60c386739769 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_64b60eef76604477a7297b5d67da449c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_64b60eef76604477a7297b5d67da449c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_64b60eef76604477a7297b5d67da449c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_64b60eef76604477a7297b5d67da449c(_75af081d0fc96b74baf16470fe47390a_64b60eef76604477a7297b5d67da449c command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_8ba094caeeb547ffb25b98a0cf532496(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_8ba094caeeb547ffb25b98a0cf532496(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_8ba094caeeb547ffb25b98a0cf532496(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_8ba094caeeb547ffb25b98a0cf532496(_75af081d0fc96b74baf16470fe47390a_8ba094caeeb547ffb25b98a0cf532496 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_4c57eab113c5467ea342fdb8b60e1b3c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_4c57eab113c5467ea342fdb8b60e1b3c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_4c57eab113c5467ea342fdb8b60e1b3c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_4c57eab113c5467ea342fdb8b60e1b3c(_75af081d0fc96b74baf16470fe47390a_4c57eab113c5467ea342fdb8b60e1b3c command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_37192051dfe240d880e2b950492dfe39(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_37192051dfe240d880e2b950492dfe39(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_37192051dfe240d880e2b950492dfe39(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_37192051dfe240d880e2b950492dfe39(_75af081d0fc96b74baf16470fe47390a_37192051dfe240d880e2b950492dfe39 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_8d650629691c4090be427a30bf215386(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_8d650629691c4090be427a30bf215386(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_8d650629691c4090be427a30bf215386(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_8d650629691c4090be427a30bf215386(_75af081d0fc96b74baf16470fe47390a_8d650629691c4090be427a30bf215386 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_4d15318d3a494555a064a4ce473359e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_4d15318d3a494555a064a4ce473359e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_4d15318d3a494555a064a4ce473359e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_4d15318d3a494555a064a4ce473359e6(_75af081d0fc96b74baf16470fe47390a_4d15318d3a494555a064a4ce473359e6 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_b0addca2ccd248d4ae5b1031f0c32313(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_b0addca2ccd248d4ae5b1031f0c32313(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_b0addca2ccd248d4ae5b1031f0c32313(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_b0addca2ccd248d4ae5b1031f0c32313(_75af081d0fc96b74baf16470fe47390a_b0addca2ccd248d4ae5b1031f0c32313 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_22f27e66c8a641ed8d6d0396ef285cb5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_22f27e66c8a641ed8d6d0396ef285cb5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_22f27e66c8a641ed8d6d0396ef285cb5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_22f27e66c8a641ed8d6d0396ef285cb5(_75af081d0fc96b74baf16470fe47390a_22f27e66c8a641ed8d6d0396ef285cb5 command)
		{
		}

		private void BakeCommandBinding__75af081d0fc96b74baf16470fe47390a_405636a3da7246f3b40a7f60720cd2c4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75af081d0fc96b74baf16470fe47390a_405636a3da7246f3b40a7f60720cd2c4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75af081d0fc96b74baf16470fe47390a_405636a3da7246f3b40a7f60720cd2c4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75af081d0fc96b74baf16470fe47390a_405636a3da7246f3b40a7f60720cd2c4(_75af081d0fc96b74baf16470fe47390a_405636a3da7246f3b40a7f60720cd2c4 command)
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
