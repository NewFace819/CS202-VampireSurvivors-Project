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
	public class CoherenceSync_af86be262b5c0bb4684f6625caea1d92 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_9b401fce60ff473da7e15578bb63ec31_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_b16c54cd247e4c7793041871b4b6b074_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_e9096d9ce5654d89b96c61d3ae676c56_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_0acdce8ff25e4cf1bd1c55405f334458_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_0885e99c4e1c404b9af2564c520a60da_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_52fae90dfffb4b41abe3db32a1d59ee8_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_e706f7b4e7594a2e8b4364e79ffee454_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_d688278d556a4b8999d400e2ee2a311b_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_de77d401d2e94f0f9b2e7876583a8771_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_c44d177f20274e5fba2f5a3e6fe13d31_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_9b3720932dab4dd48886a9bf92b227b9_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_6bd9f11ac5644f03ba25903ced31f83c_CommandTarget;

		private CharacterController _af86be262b5c0bb4684f6625caea1d92_20ab5a2405ec4d3486e62b1132de8b14_CommandTarget;

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

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_9b401fce60ff473da7e15578bb63ec31(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_9b401fce60ff473da7e15578bb63ec31(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_9b401fce60ff473da7e15578bb63ec31(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_9b401fce60ff473da7e15578bb63ec31(_af86be262b5c0bb4684f6625caea1d92_9b401fce60ff473da7e15578bb63ec31 command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_b16c54cd247e4c7793041871b4b6b074(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_b16c54cd247e4c7793041871b4b6b074(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_b16c54cd247e4c7793041871b4b6b074(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_b16c54cd247e4c7793041871b4b6b074(_af86be262b5c0bb4684f6625caea1d92_b16c54cd247e4c7793041871b4b6b074 command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_e9096d9ce5654d89b96c61d3ae676c56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_e9096d9ce5654d89b96c61d3ae676c56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_e9096d9ce5654d89b96c61d3ae676c56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_e9096d9ce5654d89b96c61d3ae676c56(_af86be262b5c0bb4684f6625caea1d92_e9096d9ce5654d89b96c61d3ae676c56 command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_0acdce8ff25e4cf1bd1c55405f334458(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_0acdce8ff25e4cf1bd1c55405f334458(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_0acdce8ff25e4cf1bd1c55405f334458(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_0acdce8ff25e4cf1bd1c55405f334458(_af86be262b5c0bb4684f6625caea1d92_0acdce8ff25e4cf1bd1c55405f334458 command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_0885e99c4e1c404b9af2564c520a60da(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_0885e99c4e1c404b9af2564c520a60da(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_0885e99c4e1c404b9af2564c520a60da(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_0885e99c4e1c404b9af2564c520a60da(_af86be262b5c0bb4684f6625caea1d92_0885e99c4e1c404b9af2564c520a60da command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_52fae90dfffb4b41abe3db32a1d59ee8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_52fae90dfffb4b41abe3db32a1d59ee8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_52fae90dfffb4b41abe3db32a1d59ee8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_52fae90dfffb4b41abe3db32a1d59ee8(_af86be262b5c0bb4684f6625caea1d92_52fae90dfffb4b41abe3db32a1d59ee8 command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_e706f7b4e7594a2e8b4364e79ffee454(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_e706f7b4e7594a2e8b4364e79ffee454(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_e706f7b4e7594a2e8b4364e79ffee454(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_e706f7b4e7594a2e8b4364e79ffee454(_af86be262b5c0bb4684f6625caea1d92_e706f7b4e7594a2e8b4364e79ffee454 command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_d688278d556a4b8999d400e2ee2a311b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_d688278d556a4b8999d400e2ee2a311b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_d688278d556a4b8999d400e2ee2a311b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_d688278d556a4b8999d400e2ee2a311b(_af86be262b5c0bb4684f6625caea1d92_d688278d556a4b8999d400e2ee2a311b command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_de77d401d2e94f0f9b2e7876583a8771(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_de77d401d2e94f0f9b2e7876583a8771(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_de77d401d2e94f0f9b2e7876583a8771(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_de77d401d2e94f0f9b2e7876583a8771(_af86be262b5c0bb4684f6625caea1d92_de77d401d2e94f0f9b2e7876583a8771 command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_c44d177f20274e5fba2f5a3e6fe13d31(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_c44d177f20274e5fba2f5a3e6fe13d31(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_c44d177f20274e5fba2f5a3e6fe13d31(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_c44d177f20274e5fba2f5a3e6fe13d31(_af86be262b5c0bb4684f6625caea1d92_c44d177f20274e5fba2f5a3e6fe13d31 command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_9b3720932dab4dd48886a9bf92b227b9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_9b3720932dab4dd48886a9bf92b227b9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_9b3720932dab4dd48886a9bf92b227b9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_9b3720932dab4dd48886a9bf92b227b9(_af86be262b5c0bb4684f6625caea1d92_9b3720932dab4dd48886a9bf92b227b9 command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_6bd9f11ac5644f03ba25903ced31f83c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_6bd9f11ac5644f03ba25903ced31f83c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_6bd9f11ac5644f03ba25903ced31f83c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_6bd9f11ac5644f03ba25903ced31f83c(_af86be262b5c0bb4684f6625caea1d92_6bd9f11ac5644f03ba25903ced31f83c command)
		{
		}

		private void BakeCommandBinding__af86be262b5c0bb4684f6625caea1d92_20ab5a2405ec4d3486e62b1132de8b14(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af86be262b5c0bb4684f6625caea1d92_20ab5a2405ec4d3486e62b1132de8b14(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af86be262b5c0bb4684f6625caea1d92_20ab5a2405ec4d3486e62b1132de8b14(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af86be262b5c0bb4684f6625caea1d92_20ab5a2405ec4d3486e62b1132de8b14(_af86be262b5c0bb4684f6625caea1d92_20ab5a2405ec4d3486e62b1132de8b14 command)
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
