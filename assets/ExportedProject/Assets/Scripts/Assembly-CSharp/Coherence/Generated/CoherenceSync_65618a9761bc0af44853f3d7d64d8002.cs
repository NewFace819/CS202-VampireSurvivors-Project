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
	public class CoherenceSync_65618a9761bc0af44853f3d7d64d8002 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_d09410ac969748ca83e2f46d6c004980_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_78909f163cf34711bd2397228bad316f_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_473ebc0d14854ccd8d5b5b1a3ea3eb17_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_5a4a47bb37c94822a8e31d5aa172ac7b_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_c2882cf64a8c44e5b789baca122e5be3_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_3894ee8327c143e69613cf261377bd1b_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_8653343958c1491faf90e69a5bc4e9c4_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_49b65744f1f6493c8348ead098b1019c_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_7ff8897586e84b3ea7e1b6c63b1d016c_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_d521933eeaff440093cf1111bbdea159_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_aa82a9f08b2447d28a2c74617bc74f74_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_81cd77fd2fec46fb85d65e4c736c50ed_CommandTarget;

		private CharacterController _65618a9761bc0af44853f3d7d64d8002_f245ae2ea73c4d6b9e79db79c8fb9bca_CommandTarget;

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

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_d09410ac969748ca83e2f46d6c004980(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_d09410ac969748ca83e2f46d6c004980(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_d09410ac969748ca83e2f46d6c004980(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_d09410ac969748ca83e2f46d6c004980(_65618a9761bc0af44853f3d7d64d8002_d09410ac969748ca83e2f46d6c004980 command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_78909f163cf34711bd2397228bad316f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_78909f163cf34711bd2397228bad316f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_78909f163cf34711bd2397228bad316f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_78909f163cf34711bd2397228bad316f(_65618a9761bc0af44853f3d7d64d8002_78909f163cf34711bd2397228bad316f command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_473ebc0d14854ccd8d5b5b1a3ea3eb17(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_473ebc0d14854ccd8d5b5b1a3ea3eb17(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_473ebc0d14854ccd8d5b5b1a3ea3eb17(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_473ebc0d14854ccd8d5b5b1a3ea3eb17(_65618a9761bc0af44853f3d7d64d8002_473ebc0d14854ccd8d5b5b1a3ea3eb17 command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_5a4a47bb37c94822a8e31d5aa172ac7b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_5a4a47bb37c94822a8e31d5aa172ac7b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_5a4a47bb37c94822a8e31d5aa172ac7b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_5a4a47bb37c94822a8e31d5aa172ac7b(_65618a9761bc0af44853f3d7d64d8002_5a4a47bb37c94822a8e31d5aa172ac7b command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_c2882cf64a8c44e5b789baca122e5be3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_c2882cf64a8c44e5b789baca122e5be3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_c2882cf64a8c44e5b789baca122e5be3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_c2882cf64a8c44e5b789baca122e5be3(_65618a9761bc0af44853f3d7d64d8002_c2882cf64a8c44e5b789baca122e5be3 command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_3894ee8327c143e69613cf261377bd1b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_3894ee8327c143e69613cf261377bd1b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_3894ee8327c143e69613cf261377bd1b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_3894ee8327c143e69613cf261377bd1b(_65618a9761bc0af44853f3d7d64d8002_3894ee8327c143e69613cf261377bd1b command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_8653343958c1491faf90e69a5bc4e9c4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_8653343958c1491faf90e69a5bc4e9c4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_8653343958c1491faf90e69a5bc4e9c4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_8653343958c1491faf90e69a5bc4e9c4(_65618a9761bc0af44853f3d7d64d8002_8653343958c1491faf90e69a5bc4e9c4 command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_49b65744f1f6493c8348ead098b1019c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_49b65744f1f6493c8348ead098b1019c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_49b65744f1f6493c8348ead098b1019c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_49b65744f1f6493c8348ead098b1019c(_65618a9761bc0af44853f3d7d64d8002_49b65744f1f6493c8348ead098b1019c command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_7ff8897586e84b3ea7e1b6c63b1d016c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_7ff8897586e84b3ea7e1b6c63b1d016c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_7ff8897586e84b3ea7e1b6c63b1d016c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_7ff8897586e84b3ea7e1b6c63b1d016c(_65618a9761bc0af44853f3d7d64d8002_7ff8897586e84b3ea7e1b6c63b1d016c command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_d521933eeaff440093cf1111bbdea159(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_d521933eeaff440093cf1111bbdea159(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_d521933eeaff440093cf1111bbdea159(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_d521933eeaff440093cf1111bbdea159(_65618a9761bc0af44853f3d7d64d8002_d521933eeaff440093cf1111bbdea159 command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_aa82a9f08b2447d28a2c74617bc74f74(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_aa82a9f08b2447d28a2c74617bc74f74(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_aa82a9f08b2447d28a2c74617bc74f74(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_aa82a9f08b2447d28a2c74617bc74f74(_65618a9761bc0af44853f3d7d64d8002_aa82a9f08b2447d28a2c74617bc74f74 command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_81cd77fd2fec46fb85d65e4c736c50ed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_81cd77fd2fec46fb85d65e4c736c50ed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_81cd77fd2fec46fb85d65e4c736c50ed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_81cd77fd2fec46fb85d65e4c736c50ed(_65618a9761bc0af44853f3d7d64d8002_81cd77fd2fec46fb85d65e4c736c50ed command)
		{
		}

		private void BakeCommandBinding__65618a9761bc0af44853f3d7d64d8002_f245ae2ea73c4d6b9e79db79c8fb9bca(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__65618a9761bc0af44853f3d7d64d8002_f245ae2ea73c4d6b9e79db79c8fb9bca(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__65618a9761bc0af44853f3d7d64d8002_f245ae2ea73c4d6b9e79db79c8fb9bca(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__65618a9761bc0af44853f3d7d64d8002_f245ae2ea73c4d6b9e79db79c8fb9bca(_65618a9761bc0af44853f3d7d64d8002_f245ae2ea73c4d6b9e79db79c8fb9bca command)
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
