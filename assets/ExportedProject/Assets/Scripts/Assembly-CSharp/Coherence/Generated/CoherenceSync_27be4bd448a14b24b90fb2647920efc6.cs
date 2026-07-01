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
	public class CoherenceSync_27be4bd448a14b24b90fb2647920efc6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_a7e8335af4984978bb63e8a6d382bf64_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_e361ee20a8464d789864bb29f55b0f5a_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_3c727692d61e420688ba7d5e02982d42_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_b42ea9542b9547f2b5d33f96e86b8e84_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_ac1590a1c6fe44889f8a0193662b1783_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_1e3d9a14adde4638b961d8f609dd3a16_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_cd179c06e0e149acb89403b4177b02bf_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_b23394882ca54903b449d2d0190aac4f_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_024f491d894f43fab933cdabb86045e1_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_fbd345ea59724adabbf611c6d89f4de9_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_2fbbf7d8e5e240f8b70e654c08a777fd_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_e1ff1f9e91d04ac5a76fe7abdba9eae6_CommandTarget;

		private CharacterController _27be4bd448a14b24b90fb2647920efc6_97189a5dc0c24b9ab1a7f1e582b23fe1_CommandTarget;

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

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_a7e8335af4984978bb63e8a6d382bf64(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_a7e8335af4984978bb63e8a6d382bf64(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_a7e8335af4984978bb63e8a6d382bf64(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_a7e8335af4984978bb63e8a6d382bf64(_27be4bd448a14b24b90fb2647920efc6_a7e8335af4984978bb63e8a6d382bf64 command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_e361ee20a8464d789864bb29f55b0f5a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_e361ee20a8464d789864bb29f55b0f5a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_e361ee20a8464d789864bb29f55b0f5a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_e361ee20a8464d789864bb29f55b0f5a(_27be4bd448a14b24b90fb2647920efc6_e361ee20a8464d789864bb29f55b0f5a command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_3c727692d61e420688ba7d5e02982d42(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_3c727692d61e420688ba7d5e02982d42(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_3c727692d61e420688ba7d5e02982d42(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_3c727692d61e420688ba7d5e02982d42(_27be4bd448a14b24b90fb2647920efc6_3c727692d61e420688ba7d5e02982d42 command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_b42ea9542b9547f2b5d33f96e86b8e84(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_b42ea9542b9547f2b5d33f96e86b8e84(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_b42ea9542b9547f2b5d33f96e86b8e84(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_b42ea9542b9547f2b5d33f96e86b8e84(_27be4bd448a14b24b90fb2647920efc6_b42ea9542b9547f2b5d33f96e86b8e84 command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_ac1590a1c6fe44889f8a0193662b1783(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_ac1590a1c6fe44889f8a0193662b1783(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_ac1590a1c6fe44889f8a0193662b1783(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_ac1590a1c6fe44889f8a0193662b1783(_27be4bd448a14b24b90fb2647920efc6_ac1590a1c6fe44889f8a0193662b1783 command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_1e3d9a14adde4638b961d8f609dd3a16(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_1e3d9a14adde4638b961d8f609dd3a16(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_1e3d9a14adde4638b961d8f609dd3a16(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_1e3d9a14adde4638b961d8f609dd3a16(_27be4bd448a14b24b90fb2647920efc6_1e3d9a14adde4638b961d8f609dd3a16 command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_cd179c06e0e149acb89403b4177b02bf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_cd179c06e0e149acb89403b4177b02bf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_cd179c06e0e149acb89403b4177b02bf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_cd179c06e0e149acb89403b4177b02bf(_27be4bd448a14b24b90fb2647920efc6_cd179c06e0e149acb89403b4177b02bf command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_b23394882ca54903b449d2d0190aac4f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_b23394882ca54903b449d2d0190aac4f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_b23394882ca54903b449d2d0190aac4f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_b23394882ca54903b449d2d0190aac4f(_27be4bd448a14b24b90fb2647920efc6_b23394882ca54903b449d2d0190aac4f command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_024f491d894f43fab933cdabb86045e1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_024f491d894f43fab933cdabb86045e1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_024f491d894f43fab933cdabb86045e1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_024f491d894f43fab933cdabb86045e1(_27be4bd448a14b24b90fb2647920efc6_024f491d894f43fab933cdabb86045e1 command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_fbd345ea59724adabbf611c6d89f4de9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_fbd345ea59724adabbf611c6d89f4de9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_fbd345ea59724adabbf611c6d89f4de9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_fbd345ea59724adabbf611c6d89f4de9(_27be4bd448a14b24b90fb2647920efc6_fbd345ea59724adabbf611c6d89f4de9 command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_2fbbf7d8e5e240f8b70e654c08a777fd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_2fbbf7d8e5e240f8b70e654c08a777fd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_2fbbf7d8e5e240f8b70e654c08a777fd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_2fbbf7d8e5e240f8b70e654c08a777fd(_27be4bd448a14b24b90fb2647920efc6_2fbbf7d8e5e240f8b70e654c08a777fd command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_e1ff1f9e91d04ac5a76fe7abdba9eae6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_e1ff1f9e91d04ac5a76fe7abdba9eae6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_e1ff1f9e91d04ac5a76fe7abdba9eae6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_e1ff1f9e91d04ac5a76fe7abdba9eae6(_27be4bd448a14b24b90fb2647920efc6_e1ff1f9e91d04ac5a76fe7abdba9eae6 command)
		{
		}

		private void BakeCommandBinding__27be4bd448a14b24b90fb2647920efc6_97189a5dc0c24b9ab1a7f1e582b23fe1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27be4bd448a14b24b90fb2647920efc6_97189a5dc0c24b9ab1a7f1e582b23fe1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27be4bd448a14b24b90fb2647920efc6_97189a5dc0c24b9ab1a7f1e582b23fe1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27be4bd448a14b24b90fb2647920efc6_97189a5dc0c24b9ab1a7f1e582b23fe1(_27be4bd448a14b24b90fb2647920efc6_97189a5dc0c24b9ab1a7f1e582b23fe1 command)
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
