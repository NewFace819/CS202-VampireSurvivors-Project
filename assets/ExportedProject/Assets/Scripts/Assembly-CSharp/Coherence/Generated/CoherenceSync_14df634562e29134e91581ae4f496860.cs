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
	public class CoherenceSync_14df634562e29134e91581ae4f496860 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _14df634562e29134e91581ae4f496860_35c2163236644223ac5e99ee8679b97b_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_f4384d83bbbe44069d65a5a687bc6440_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_04e34eb299b54eeeb6e4e44a59ea787b_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_63c506c5925a4a6fa18b55de3449faa8_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_a89f41518eeb4138875469c6b83a1e44_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_86293026ca984626844df54f83f91df6_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_cf7c7ca18d3a421fb66636b5b03aa45a_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_dbc2f48ad6d0471bb385fb5a0481a513_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_f24d5a54f77a4a9794457199ec7dd253_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_ff0f150bc5a340049dbdd0521872d3d5_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_60a0e6040f8a4fb495f9ff48e791f7a8_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_1a0e2fad779a4fdd95ba8933d157de9a_CommandTarget;

		private CharacterController _14df634562e29134e91581ae4f496860_47af0742fae24cab9c82833b17ac62da_CommandTarget;

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

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_35c2163236644223ac5e99ee8679b97b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_35c2163236644223ac5e99ee8679b97b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_35c2163236644223ac5e99ee8679b97b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_35c2163236644223ac5e99ee8679b97b(_14df634562e29134e91581ae4f496860_35c2163236644223ac5e99ee8679b97b command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_f4384d83bbbe44069d65a5a687bc6440(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_f4384d83bbbe44069d65a5a687bc6440(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_f4384d83bbbe44069d65a5a687bc6440(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_f4384d83bbbe44069d65a5a687bc6440(_14df634562e29134e91581ae4f496860_f4384d83bbbe44069d65a5a687bc6440 command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_04e34eb299b54eeeb6e4e44a59ea787b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_04e34eb299b54eeeb6e4e44a59ea787b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_04e34eb299b54eeeb6e4e44a59ea787b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_04e34eb299b54eeeb6e4e44a59ea787b(_14df634562e29134e91581ae4f496860_04e34eb299b54eeeb6e4e44a59ea787b command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_63c506c5925a4a6fa18b55de3449faa8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_63c506c5925a4a6fa18b55de3449faa8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_63c506c5925a4a6fa18b55de3449faa8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_63c506c5925a4a6fa18b55de3449faa8(_14df634562e29134e91581ae4f496860_63c506c5925a4a6fa18b55de3449faa8 command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_a89f41518eeb4138875469c6b83a1e44(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_a89f41518eeb4138875469c6b83a1e44(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_a89f41518eeb4138875469c6b83a1e44(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_a89f41518eeb4138875469c6b83a1e44(_14df634562e29134e91581ae4f496860_a89f41518eeb4138875469c6b83a1e44 command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_86293026ca984626844df54f83f91df6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_86293026ca984626844df54f83f91df6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_86293026ca984626844df54f83f91df6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_86293026ca984626844df54f83f91df6(_14df634562e29134e91581ae4f496860_86293026ca984626844df54f83f91df6 command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_cf7c7ca18d3a421fb66636b5b03aa45a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_cf7c7ca18d3a421fb66636b5b03aa45a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_cf7c7ca18d3a421fb66636b5b03aa45a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_cf7c7ca18d3a421fb66636b5b03aa45a(_14df634562e29134e91581ae4f496860_cf7c7ca18d3a421fb66636b5b03aa45a command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_dbc2f48ad6d0471bb385fb5a0481a513(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_dbc2f48ad6d0471bb385fb5a0481a513(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_dbc2f48ad6d0471bb385fb5a0481a513(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_dbc2f48ad6d0471bb385fb5a0481a513(_14df634562e29134e91581ae4f496860_dbc2f48ad6d0471bb385fb5a0481a513 command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_f24d5a54f77a4a9794457199ec7dd253(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_f24d5a54f77a4a9794457199ec7dd253(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_f24d5a54f77a4a9794457199ec7dd253(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_f24d5a54f77a4a9794457199ec7dd253(_14df634562e29134e91581ae4f496860_f24d5a54f77a4a9794457199ec7dd253 command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_ff0f150bc5a340049dbdd0521872d3d5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_ff0f150bc5a340049dbdd0521872d3d5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_ff0f150bc5a340049dbdd0521872d3d5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_ff0f150bc5a340049dbdd0521872d3d5(_14df634562e29134e91581ae4f496860_ff0f150bc5a340049dbdd0521872d3d5 command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_60a0e6040f8a4fb495f9ff48e791f7a8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_60a0e6040f8a4fb495f9ff48e791f7a8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_60a0e6040f8a4fb495f9ff48e791f7a8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_60a0e6040f8a4fb495f9ff48e791f7a8(_14df634562e29134e91581ae4f496860_60a0e6040f8a4fb495f9ff48e791f7a8 command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_1a0e2fad779a4fdd95ba8933d157de9a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_1a0e2fad779a4fdd95ba8933d157de9a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_1a0e2fad779a4fdd95ba8933d157de9a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_1a0e2fad779a4fdd95ba8933d157de9a(_14df634562e29134e91581ae4f496860_1a0e2fad779a4fdd95ba8933d157de9a command)
		{
		}

		private void BakeCommandBinding__14df634562e29134e91581ae4f496860_47af0742fae24cab9c82833b17ac62da(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__14df634562e29134e91581ae4f496860_47af0742fae24cab9c82833b17ac62da(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__14df634562e29134e91581ae4f496860_47af0742fae24cab9c82833b17ac62da(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__14df634562e29134e91581ae4f496860_47af0742fae24cab9c82833b17ac62da(_14df634562e29134e91581ae4f496860_47af0742fae24cab9c82833b17ac62da command)
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
