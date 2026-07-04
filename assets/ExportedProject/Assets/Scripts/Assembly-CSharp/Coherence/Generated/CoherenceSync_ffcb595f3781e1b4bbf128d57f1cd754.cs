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
	public class CoherenceSync_ffcb595f3781e1b4bbf128d57f1cd754 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_0946dde1c0614c0e9876e9956ee19b05_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_67999914ab5e4c1a93b6ac26259402ee_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_b134b75bf4e44bccaf45d3f528241cf9_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_24cad352a6d2475983709eb4211d056f_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_ba74d21395c74d1f97c777c7c0d203ba_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_4d519c0d1038496ca049e8fa464b01c0_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_fce0a9c821584811adbbdff11f88711f_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_de3762df720743a19c0bda21c5b6f037_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_aa8e22ffb0ba4a93b2772cd089dd185d_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_ca7cc6bef32a4ac98a3dc6855a96f22c_CommandTarget;

		private TP_Nathan_Character _ffcb595f3781e1b4bbf128d57f1cd754_b52ea18f558b475d9ca1dd96297b002d_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_f204acd7744947b38e6b6935ddefed36_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_32ba07b7d4ae488bbea7efd35fa5bcf0_CommandTarget;

		private CharacterController _ffcb595f3781e1b4bbf128d57f1cd754_1e6078ccf12e4472aac9c6aadb6a5b37_CommandTarget;

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

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_0946dde1c0614c0e9876e9956ee19b05(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_0946dde1c0614c0e9876e9956ee19b05(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_0946dde1c0614c0e9876e9956ee19b05(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_0946dde1c0614c0e9876e9956ee19b05(_ffcb595f3781e1b4bbf128d57f1cd754_0946dde1c0614c0e9876e9956ee19b05 command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_67999914ab5e4c1a93b6ac26259402ee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_67999914ab5e4c1a93b6ac26259402ee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_67999914ab5e4c1a93b6ac26259402ee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_67999914ab5e4c1a93b6ac26259402ee(_ffcb595f3781e1b4bbf128d57f1cd754_67999914ab5e4c1a93b6ac26259402ee command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_b134b75bf4e44bccaf45d3f528241cf9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_b134b75bf4e44bccaf45d3f528241cf9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_b134b75bf4e44bccaf45d3f528241cf9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_b134b75bf4e44bccaf45d3f528241cf9(_ffcb595f3781e1b4bbf128d57f1cd754_b134b75bf4e44bccaf45d3f528241cf9 command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_24cad352a6d2475983709eb4211d056f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_24cad352a6d2475983709eb4211d056f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_24cad352a6d2475983709eb4211d056f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_24cad352a6d2475983709eb4211d056f(_ffcb595f3781e1b4bbf128d57f1cd754_24cad352a6d2475983709eb4211d056f command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_ba74d21395c74d1f97c777c7c0d203ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_ba74d21395c74d1f97c777c7c0d203ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_ba74d21395c74d1f97c777c7c0d203ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_ba74d21395c74d1f97c777c7c0d203ba(_ffcb595f3781e1b4bbf128d57f1cd754_ba74d21395c74d1f97c777c7c0d203ba command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_4d519c0d1038496ca049e8fa464b01c0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_4d519c0d1038496ca049e8fa464b01c0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_4d519c0d1038496ca049e8fa464b01c0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_4d519c0d1038496ca049e8fa464b01c0(_ffcb595f3781e1b4bbf128d57f1cd754_4d519c0d1038496ca049e8fa464b01c0 command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_fce0a9c821584811adbbdff11f88711f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_fce0a9c821584811adbbdff11f88711f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_fce0a9c821584811adbbdff11f88711f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_fce0a9c821584811adbbdff11f88711f(_ffcb595f3781e1b4bbf128d57f1cd754_fce0a9c821584811adbbdff11f88711f command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_de3762df720743a19c0bda21c5b6f037(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_de3762df720743a19c0bda21c5b6f037(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_de3762df720743a19c0bda21c5b6f037(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_de3762df720743a19c0bda21c5b6f037(_ffcb595f3781e1b4bbf128d57f1cd754_de3762df720743a19c0bda21c5b6f037 command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_aa8e22ffb0ba4a93b2772cd089dd185d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_aa8e22ffb0ba4a93b2772cd089dd185d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_aa8e22ffb0ba4a93b2772cd089dd185d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_aa8e22ffb0ba4a93b2772cd089dd185d(_ffcb595f3781e1b4bbf128d57f1cd754_aa8e22ffb0ba4a93b2772cd089dd185d command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_ca7cc6bef32a4ac98a3dc6855a96f22c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_ca7cc6bef32a4ac98a3dc6855a96f22c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_ca7cc6bef32a4ac98a3dc6855a96f22c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_ca7cc6bef32a4ac98a3dc6855a96f22c(_ffcb595f3781e1b4bbf128d57f1cd754_ca7cc6bef32a4ac98a3dc6855a96f22c command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_b52ea18f558b475d9ca1dd96297b002d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_b52ea18f558b475d9ca1dd96297b002d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_b52ea18f558b475d9ca1dd96297b002d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_b52ea18f558b475d9ca1dd96297b002d(_ffcb595f3781e1b4bbf128d57f1cd754_b52ea18f558b475d9ca1dd96297b002d command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_f204acd7744947b38e6b6935ddefed36(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_f204acd7744947b38e6b6935ddefed36(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_f204acd7744947b38e6b6935ddefed36(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_f204acd7744947b38e6b6935ddefed36(_ffcb595f3781e1b4bbf128d57f1cd754_f204acd7744947b38e6b6935ddefed36 command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_32ba07b7d4ae488bbea7efd35fa5bcf0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_32ba07b7d4ae488bbea7efd35fa5bcf0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_32ba07b7d4ae488bbea7efd35fa5bcf0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_32ba07b7d4ae488bbea7efd35fa5bcf0(_ffcb595f3781e1b4bbf128d57f1cd754_32ba07b7d4ae488bbea7efd35fa5bcf0 command)
		{
		}

		private void BakeCommandBinding__ffcb595f3781e1b4bbf128d57f1cd754_1e6078ccf12e4472aac9c6aadb6a5b37(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffcb595f3781e1b4bbf128d57f1cd754_1e6078ccf12e4472aac9c6aadb6a5b37(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffcb595f3781e1b4bbf128d57f1cd754_1e6078ccf12e4472aac9c6aadb6a5b37(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffcb595f3781e1b4bbf128d57f1cd754_1e6078ccf12e4472aac9c6aadb6a5b37(_ffcb595f3781e1b4bbf128d57f1cd754_1e6078ccf12e4472aac9c6aadb6a5b37 command)
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
