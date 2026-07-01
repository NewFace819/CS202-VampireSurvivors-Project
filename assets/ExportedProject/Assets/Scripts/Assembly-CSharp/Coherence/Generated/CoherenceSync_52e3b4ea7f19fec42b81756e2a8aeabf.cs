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
	public class CoherenceSync_52e3b4ea7f19fec42b81756e2a8aeabf : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_6ebdcb45df9f46ba968088a7c047f67c_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_f981ef65069747c6a05e8facb191a74a_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_8c1dea6af9be4cea89ff0889f7347274_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_3055acbb3013488e9d6c63029ecb4047_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_0b6333192a4141198228849d38bc44ae_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_3ee62010426f48188e82400523a3691a_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_44a048ca23a24abb8c92c903d9650b56_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_7c72c75a1fd9464c99aceb0a937f8e5e_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_ca439224b0b24fa5809e6af5ae24eb79_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_9a677a2a70b946c5b0fd1edc8b0ba528_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_6a222e89e8c64ee080e809a9877d2dd7_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_803f45d4327f48808c828dcd9f1ca6c8_CommandTarget;

		private CharacterController _52e3b4ea7f19fec42b81756e2a8aeabf_871625a6571b47bcad0c989911cc0c84_CommandTarget;

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

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_6ebdcb45df9f46ba968088a7c047f67c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_6ebdcb45df9f46ba968088a7c047f67c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_6ebdcb45df9f46ba968088a7c047f67c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_6ebdcb45df9f46ba968088a7c047f67c(_52e3b4ea7f19fec42b81756e2a8aeabf_6ebdcb45df9f46ba968088a7c047f67c command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_f981ef65069747c6a05e8facb191a74a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_f981ef65069747c6a05e8facb191a74a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_f981ef65069747c6a05e8facb191a74a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_f981ef65069747c6a05e8facb191a74a(_52e3b4ea7f19fec42b81756e2a8aeabf_f981ef65069747c6a05e8facb191a74a command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_8c1dea6af9be4cea89ff0889f7347274(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_8c1dea6af9be4cea89ff0889f7347274(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_8c1dea6af9be4cea89ff0889f7347274(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_8c1dea6af9be4cea89ff0889f7347274(_52e3b4ea7f19fec42b81756e2a8aeabf_8c1dea6af9be4cea89ff0889f7347274 command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_3055acbb3013488e9d6c63029ecb4047(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_3055acbb3013488e9d6c63029ecb4047(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_3055acbb3013488e9d6c63029ecb4047(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_3055acbb3013488e9d6c63029ecb4047(_52e3b4ea7f19fec42b81756e2a8aeabf_3055acbb3013488e9d6c63029ecb4047 command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_0b6333192a4141198228849d38bc44ae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_0b6333192a4141198228849d38bc44ae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_0b6333192a4141198228849d38bc44ae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_0b6333192a4141198228849d38bc44ae(_52e3b4ea7f19fec42b81756e2a8aeabf_0b6333192a4141198228849d38bc44ae command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_3ee62010426f48188e82400523a3691a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_3ee62010426f48188e82400523a3691a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_3ee62010426f48188e82400523a3691a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_3ee62010426f48188e82400523a3691a(_52e3b4ea7f19fec42b81756e2a8aeabf_3ee62010426f48188e82400523a3691a command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_44a048ca23a24abb8c92c903d9650b56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_44a048ca23a24abb8c92c903d9650b56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_44a048ca23a24abb8c92c903d9650b56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_44a048ca23a24abb8c92c903d9650b56(_52e3b4ea7f19fec42b81756e2a8aeabf_44a048ca23a24abb8c92c903d9650b56 command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_7c72c75a1fd9464c99aceb0a937f8e5e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_7c72c75a1fd9464c99aceb0a937f8e5e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_7c72c75a1fd9464c99aceb0a937f8e5e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_7c72c75a1fd9464c99aceb0a937f8e5e(_52e3b4ea7f19fec42b81756e2a8aeabf_7c72c75a1fd9464c99aceb0a937f8e5e command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_ca439224b0b24fa5809e6af5ae24eb79(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_ca439224b0b24fa5809e6af5ae24eb79(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_ca439224b0b24fa5809e6af5ae24eb79(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_ca439224b0b24fa5809e6af5ae24eb79(_52e3b4ea7f19fec42b81756e2a8aeabf_ca439224b0b24fa5809e6af5ae24eb79 command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_9a677a2a70b946c5b0fd1edc8b0ba528(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_9a677a2a70b946c5b0fd1edc8b0ba528(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_9a677a2a70b946c5b0fd1edc8b0ba528(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_9a677a2a70b946c5b0fd1edc8b0ba528(_52e3b4ea7f19fec42b81756e2a8aeabf_9a677a2a70b946c5b0fd1edc8b0ba528 command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_6a222e89e8c64ee080e809a9877d2dd7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_6a222e89e8c64ee080e809a9877d2dd7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_6a222e89e8c64ee080e809a9877d2dd7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_6a222e89e8c64ee080e809a9877d2dd7(_52e3b4ea7f19fec42b81756e2a8aeabf_6a222e89e8c64ee080e809a9877d2dd7 command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_803f45d4327f48808c828dcd9f1ca6c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_803f45d4327f48808c828dcd9f1ca6c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_803f45d4327f48808c828dcd9f1ca6c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_803f45d4327f48808c828dcd9f1ca6c8(_52e3b4ea7f19fec42b81756e2a8aeabf_803f45d4327f48808c828dcd9f1ca6c8 command)
		{
		}

		private void BakeCommandBinding__52e3b4ea7f19fec42b81756e2a8aeabf_871625a6571b47bcad0c989911cc0c84(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__52e3b4ea7f19fec42b81756e2a8aeabf_871625a6571b47bcad0c989911cc0c84(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__52e3b4ea7f19fec42b81756e2a8aeabf_871625a6571b47bcad0c989911cc0c84(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__52e3b4ea7f19fec42b81756e2a8aeabf_871625a6571b47bcad0c989911cc0c84(_52e3b4ea7f19fec42b81756e2a8aeabf_871625a6571b47bcad0c989911cc0c84 command)
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
