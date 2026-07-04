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
	public class CoherenceSync_a784ec07c4de9184f936bf561a2fda03 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_67ced92e6e6e4ec6adece66179147c4b_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_7aa6197d610a411e8481307c71549381_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_0d9631eb034b4e42ab7c8dcc9862b747_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_2061b4855b18426e9d2748d75e4fbff7_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_cf8fe067efad430aabb5da1081e0e1b5_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_3fbb5d3d6ed04407843d6d5d9130b871_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_0f2ae494f03a4d8c8672077d7a0b17c1_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_32650cde4f3c4a179d7a5fe3dca81016_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_a7768b8e88e249bf9d2152b4b72fb218_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_58d09e1452b74ba6bb28cc670a79c48e_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_1073af696f824a77999dc252e1ce9f8c_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_96e8772237e4456781723158c2d5f0b0_CommandTarget;

		private CharacterController _a784ec07c4de9184f936bf561a2fda03_e07801c2e9254012bf1189b2861bed94_CommandTarget;

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

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_67ced92e6e6e4ec6adece66179147c4b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_67ced92e6e6e4ec6adece66179147c4b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_67ced92e6e6e4ec6adece66179147c4b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_67ced92e6e6e4ec6adece66179147c4b(_a784ec07c4de9184f936bf561a2fda03_67ced92e6e6e4ec6adece66179147c4b command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_7aa6197d610a411e8481307c71549381(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_7aa6197d610a411e8481307c71549381(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_7aa6197d610a411e8481307c71549381(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_7aa6197d610a411e8481307c71549381(_a784ec07c4de9184f936bf561a2fda03_7aa6197d610a411e8481307c71549381 command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_0d9631eb034b4e42ab7c8dcc9862b747(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_0d9631eb034b4e42ab7c8dcc9862b747(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_0d9631eb034b4e42ab7c8dcc9862b747(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_0d9631eb034b4e42ab7c8dcc9862b747(_a784ec07c4de9184f936bf561a2fda03_0d9631eb034b4e42ab7c8dcc9862b747 command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_2061b4855b18426e9d2748d75e4fbff7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_2061b4855b18426e9d2748d75e4fbff7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_2061b4855b18426e9d2748d75e4fbff7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_2061b4855b18426e9d2748d75e4fbff7(_a784ec07c4de9184f936bf561a2fda03_2061b4855b18426e9d2748d75e4fbff7 command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_cf8fe067efad430aabb5da1081e0e1b5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_cf8fe067efad430aabb5da1081e0e1b5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_cf8fe067efad430aabb5da1081e0e1b5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_cf8fe067efad430aabb5da1081e0e1b5(_a784ec07c4de9184f936bf561a2fda03_cf8fe067efad430aabb5da1081e0e1b5 command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_3fbb5d3d6ed04407843d6d5d9130b871(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_3fbb5d3d6ed04407843d6d5d9130b871(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_3fbb5d3d6ed04407843d6d5d9130b871(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_3fbb5d3d6ed04407843d6d5d9130b871(_a784ec07c4de9184f936bf561a2fda03_3fbb5d3d6ed04407843d6d5d9130b871 command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_0f2ae494f03a4d8c8672077d7a0b17c1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_0f2ae494f03a4d8c8672077d7a0b17c1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_0f2ae494f03a4d8c8672077d7a0b17c1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_0f2ae494f03a4d8c8672077d7a0b17c1(_a784ec07c4de9184f936bf561a2fda03_0f2ae494f03a4d8c8672077d7a0b17c1 command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_32650cde4f3c4a179d7a5fe3dca81016(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_32650cde4f3c4a179d7a5fe3dca81016(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_32650cde4f3c4a179d7a5fe3dca81016(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_32650cde4f3c4a179d7a5fe3dca81016(_a784ec07c4de9184f936bf561a2fda03_32650cde4f3c4a179d7a5fe3dca81016 command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_a7768b8e88e249bf9d2152b4b72fb218(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_a7768b8e88e249bf9d2152b4b72fb218(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_a7768b8e88e249bf9d2152b4b72fb218(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_a7768b8e88e249bf9d2152b4b72fb218(_a784ec07c4de9184f936bf561a2fda03_a7768b8e88e249bf9d2152b4b72fb218 command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_58d09e1452b74ba6bb28cc670a79c48e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_58d09e1452b74ba6bb28cc670a79c48e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_58d09e1452b74ba6bb28cc670a79c48e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_58d09e1452b74ba6bb28cc670a79c48e(_a784ec07c4de9184f936bf561a2fda03_58d09e1452b74ba6bb28cc670a79c48e command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_1073af696f824a77999dc252e1ce9f8c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_1073af696f824a77999dc252e1ce9f8c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_1073af696f824a77999dc252e1ce9f8c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_1073af696f824a77999dc252e1ce9f8c(_a784ec07c4de9184f936bf561a2fda03_1073af696f824a77999dc252e1ce9f8c command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_96e8772237e4456781723158c2d5f0b0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_96e8772237e4456781723158c2d5f0b0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_96e8772237e4456781723158c2d5f0b0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_96e8772237e4456781723158c2d5f0b0(_a784ec07c4de9184f936bf561a2fda03_96e8772237e4456781723158c2d5f0b0 command)
		{
		}

		private void BakeCommandBinding__a784ec07c4de9184f936bf561a2fda03_e07801c2e9254012bf1189b2861bed94(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a784ec07c4de9184f936bf561a2fda03_e07801c2e9254012bf1189b2861bed94(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a784ec07c4de9184f936bf561a2fda03_e07801c2e9254012bf1189b2861bed94(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a784ec07c4de9184f936bf561a2fda03_e07801c2e9254012bf1189b2861bed94(_a784ec07c4de9184f936bf561a2fda03_e07801c2e9254012bf1189b2861bed94 command)
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
