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
	public class CoherenceSync_adf15ca35ddd8ec4da348afaf9db339e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_c3403b7fe5594f479033764ada739dd4_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_753fd01e6c8c45ed9335e070a713ef6a_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_d5a235ab0388466ba5c088ab68d2baca_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_1fe52106dc6c4969aee546043eb327cb_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_357cadbbc18d41548dee84008f249b3a_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_7e794b2ff98f44d0a0bce2da2b4cb3b7_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_18ba5b1ceac24c34b153c9d394946145_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_a340524c1c454d7f92b795e3e835ba7b_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_c51d5d727772444f830299f4abcca985_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_1a3b1e4c1f0f49f88ac7d4506bb84282_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_1677aed6df6847d9a1b7a23d07ec64ac_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_7d5c4f58b3414912b64681d8ea3d01f5_CommandTarget;

		private CharacterController _adf15ca35ddd8ec4da348afaf9db339e_6c83c081b82249778411f9a6551bb2db_CommandTarget;

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

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_c3403b7fe5594f479033764ada739dd4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_c3403b7fe5594f479033764ada739dd4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_c3403b7fe5594f479033764ada739dd4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_c3403b7fe5594f479033764ada739dd4(_adf15ca35ddd8ec4da348afaf9db339e_c3403b7fe5594f479033764ada739dd4 command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_753fd01e6c8c45ed9335e070a713ef6a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_753fd01e6c8c45ed9335e070a713ef6a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_753fd01e6c8c45ed9335e070a713ef6a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_753fd01e6c8c45ed9335e070a713ef6a(_adf15ca35ddd8ec4da348afaf9db339e_753fd01e6c8c45ed9335e070a713ef6a command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_d5a235ab0388466ba5c088ab68d2baca(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_d5a235ab0388466ba5c088ab68d2baca(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_d5a235ab0388466ba5c088ab68d2baca(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_d5a235ab0388466ba5c088ab68d2baca(_adf15ca35ddd8ec4da348afaf9db339e_d5a235ab0388466ba5c088ab68d2baca command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_1fe52106dc6c4969aee546043eb327cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_1fe52106dc6c4969aee546043eb327cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_1fe52106dc6c4969aee546043eb327cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_1fe52106dc6c4969aee546043eb327cb(_adf15ca35ddd8ec4da348afaf9db339e_1fe52106dc6c4969aee546043eb327cb command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_357cadbbc18d41548dee84008f249b3a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_357cadbbc18d41548dee84008f249b3a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_357cadbbc18d41548dee84008f249b3a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_357cadbbc18d41548dee84008f249b3a(_adf15ca35ddd8ec4da348afaf9db339e_357cadbbc18d41548dee84008f249b3a command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_7e794b2ff98f44d0a0bce2da2b4cb3b7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_7e794b2ff98f44d0a0bce2da2b4cb3b7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_7e794b2ff98f44d0a0bce2da2b4cb3b7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_7e794b2ff98f44d0a0bce2da2b4cb3b7(_adf15ca35ddd8ec4da348afaf9db339e_7e794b2ff98f44d0a0bce2da2b4cb3b7 command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_18ba5b1ceac24c34b153c9d394946145(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_18ba5b1ceac24c34b153c9d394946145(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_18ba5b1ceac24c34b153c9d394946145(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_18ba5b1ceac24c34b153c9d394946145(_adf15ca35ddd8ec4da348afaf9db339e_18ba5b1ceac24c34b153c9d394946145 command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_a340524c1c454d7f92b795e3e835ba7b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_a340524c1c454d7f92b795e3e835ba7b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_a340524c1c454d7f92b795e3e835ba7b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_a340524c1c454d7f92b795e3e835ba7b(_adf15ca35ddd8ec4da348afaf9db339e_a340524c1c454d7f92b795e3e835ba7b command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_c51d5d727772444f830299f4abcca985(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_c51d5d727772444f830299f4abcca985(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_c51d5d727772444f830299f4abcca985(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_c51d5d727772444f830299f4abcca985(_adf15ca35ddd8ec4da348afaf9db339e_c51d5d727772444f830299f4abcca985 command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_1a3b1e4c1f0f49f88ac7d4506bb84282(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_1a3b1e4c1f0f49f88ac7d4506bb84282(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_1a3b1e4c1f0f49f88ac7d4506bb84282(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_1a3b1e4c1f0f49f88ac7d4506bb84282(_adf15ca35ddd8ec4da348afaf9db339e_1a3b1e4c1f0f49f88ac7d4506bb84282 command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_1677aed6df6847d9a1b7a23d07ec64ac(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_1677aed6df6847d9a1b7a23d07ec64ac(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_1677aed6df6847d9a1b7a23d07ec64ac(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_1677aed6df6847d9a1b7a23d07ec64ac(_adf15ca35ddd8ec4da348afaf9db339e_1677aed6df6847d9a1b7a23d07ec64ac command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_7d5c4f58b3414912b64681d8ea3d01f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_7d5c4f58b3414912b64681d8ea3d01f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_7d5c4f58b3414912b64681d8ea3d01f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_7d5c4f58b3414912b64681d8ea3d01f5(_adf15ca35ddd8ec4da348afaf9db339e_7d5c4f58b3414912b64681d8ea3d01f5 command)
		{
		}

		private void BakeCommandBinding__adf15ca35ddd8ec4da348afaf9db339e_6c83c081b82249778411f9a6551bb2db(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__adf15ca35ddd8ec4da348afaf9db339e_6c83c081b82249778411f9a6551bb2db(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__adf15ca35ddd8ec4da348afaf9db339e_6c83c081b82249778411f9a6551bb2db(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__adf15ca35ddd8ec4da348afaf9db339e_6c83c081b82249778411f9a6551bb2db(_adf15ca35ddd8ec4da348afaf9db339e_6c83c081b82249778411f9a6551bb2db command)
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
