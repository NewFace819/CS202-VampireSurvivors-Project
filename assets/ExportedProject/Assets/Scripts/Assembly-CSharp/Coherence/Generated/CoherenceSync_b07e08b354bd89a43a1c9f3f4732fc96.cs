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
	public class CoherenceSync_b07e08b354bd89a43a1c9f3f4732fc96 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_60a50e473a8844e0a151fc93e2e19f57_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_b831db6463934622b692a09ea170405b_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_7fa4251cde4541f3ab4de7dcf74e30bc_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_8a535b5bba2b4e23915b5389036af1ea_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_0c7129be8bbd4d779093c0927f38e43d_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_fc4b69dff0d94dea93ca17ab085534ce_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_6d8015d51b08410d89417a8646ede9b8_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_baa33573d4d44ef28e64684026e12dec_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_e9f6b06b352c4d32a840150b035578bd_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_fde40902ae394c22b87b8ce55c468bad_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_d8a211a547244290b55a96295c9cdb67_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_806a3fdb6ee64a3c934ec09f05e6a2e3_CommandTarget;

		private CharacterController _b07e08b354bd89a43a1c9f3f4732fc96_aa0185e1e2234f03ae4687535f0e4871_CommandTarget;

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

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_60a50e473a8844e0a151fc93e2e19f57(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_60a50e473a8844e0a151fc93e2e19f57(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_60a50e473a8844e0a151fc93e2e19f57(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_60a50e473a8844e0a151fc93e2e19f57(_b07e08b354bd89a43a1c9f3f4732fc96_60a50e473a8844e0a151fc93e2e19f57 command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_b831db6463934622b692a09ea170405b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_b831db6463934622b692a09ea170405b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_b831db6463934622b692a09ea170405b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_b831db6463934622b692a09ea170405b(_b07e08b354bd89a43a1c9f3f4732fc96_b831db6463934622b692a09ea170405b command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_7fa4251cde4541f3ab4de7dcf74e30bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_7fa4251cde4541f3ab4de7dcf74e30bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_7fa4251cde4541f3ab4de7dcf74e30bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_7fa4251cde4541f3ab4de7dcf74e30bc(_b07e08b354bd89a43a1c9f3f4732fc96_7fa4251cde4541f3ab4de7dcf74e30bc command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_8a535b5bba2b4e23915b5389036af1ea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_8a535b5bba2b4e23915b5389036af1ea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_8a535b5bba2b4e23915b5389036af1ea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_8a535b5bba2b4e23915b5389036af1ea(_b07e08b354bd89a43a1c9f3f4732fc96_8a535b5bba2b4e23915b5389036af1ea command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_0c7129be8bbd4d779093c0927f38e43d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_0c7129be8bbd4d779093c0927f38e43d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_0c7129be8bbd4d779093c0927f38e43d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_0c7129be8bbd4d779093c0927f38e43d(_b07e08b354bd89a43a1c9f3f4732fc96_0c7129be8bbd4d779093c0927f38e43d command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_fc4b69dff0d94dea93ca17ab085534ce(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_fc4b69dff0d94dea93ca17ab085534ce(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_fc4b69dff0d94dea93ca17ab085534ce(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_fc4b69dff0d94dea93ca17ab085534ce(_b07e08b354bd89a43a1c9f3f4732fc96_fc4b69dff0d94dea93ca17ab085534ce command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_6d8015d51b08410d89417a8646ede9b8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_6d8015d51b08410d89417a8646ede9b8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_6d8015d51b08410d89417a8646ede9b8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_6d8015d51b08410d89417a8646ede9b8(_b07e08b354bd89a43a1c9f3f4732fc96_6d8015d51b08410d89417a8646ede9b8 command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_baa33573d4d44ef28e64684026e12dec(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_baa33573d4d44ef28e64684026e12dec(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_baa33573d4d44ef28e64684026e12dec(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_baa33573d4d44ef28e64684026e12dec(_b07e08b354bd89a43a1c9f3f4732fc96_baa33573d4d44ef28e64684026e12dec command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_e9f6b06b352c4d32a840150b035578bd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_e9f6b06b352c4d32a840150b035578bd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_e9f6b06b352c4d32a840150b035578bd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_e9f6b06b352c4d32a840150b035578bd(_b07e08b354bd89a43a1c9f3f4732fc96_e9f6b06b352c4d32a840150b035578bd command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_fde40902ae394c22b87b8ce55c468bad(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_fde40902ae394c22b87b8ce55c468bad(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_fde40902ae394c22b87b8ce55c468bad(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_fde40902ae394c22b87b8ce55c468bad(_b07e08b354bd89a43a1c9f3f4732fc96_fde40902ae394c22b87b8ce55c468bad command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_d8a211a547244290b55a96295c9cdb67(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_d8a211a547244290b55a96295c9cdb67(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_d8a211a547244290b55a96295c9cdb67(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_d8a211a547244290b55a96295c9cdb67(_b07e08b354bd89a43a1c9f3f4732fc96_d8a211a547244290b55a96295c9cdb67 command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_806a3fdb6ee64a3c934ec09f05e6a2e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_806a3fdb6ee64a3c934ec09f05e6a2e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_806a3fdb6ee64a3c934ec09f05e6a2e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_806a3fdb6ee64a3c934ec09f05e6a2e3(_b07e08b354bd89a43a1c9f3f4732fc96_806a3fdb6ee64a3c934ec09f05e6a2e3 command)
		{
		}

		private void BakeCommandBinding__b07e08b354bd89a43a1c9f3f4732fc96_aa0185e1e2234f03ae4687535f0e4871(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b07e08b354bd89a43a1c9f3f4732fc96_aa0185e1e2234f03ae4687535f0e4871(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b07e08b354bd89a43a1c9f3f4732fc96_aa0185e1e2234f03ae4687535f0e4871(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b07e08b354bd89a43a1c9f3f4732fc96_aa0185e1e2234f03ae4687535f0e4871(_b07e08b354bd89a43a1c9f3f4732fc96_aa0185e1e2234f03ae4687535f0e4871 command)
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
