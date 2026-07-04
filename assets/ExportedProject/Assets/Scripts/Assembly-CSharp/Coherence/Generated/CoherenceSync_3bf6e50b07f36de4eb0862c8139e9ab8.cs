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
	public class CoherenceSync_3bf6e50b07f36de4eb0862c8139e9ab8 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_42df829af2804ca9944049a3d0284f3e_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_8346654686f1474bbb34f555a6f17ecc_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_b7d6a8605c714c7e9f4c11ad065dcfe1_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_ff0fea750a534aae9b8ad8e239ef94e3_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_04282655f27f4fb48a126caeda45f0d1_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_578364e1968d49b394b7e8860b6d2382_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_a04c0c94508b497abbf648f0b754083a_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_88b31f15078f44f89a93a7063a059d2d_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_ed80280322b2443fb8565e7005df8289_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_09ca4e2c6a0c42d8b4fa6653a45f488d_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_4617fefe6dde4d5ca3a138324db80d0c_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_6b68584963f74c57999cb89df9b2a822_CommandTarget;

		private CharacterController _3bf6e50b07f36de4eb0862c8139e9ab8_f452a7b17b7544c79f81974769e54d7f_CommandTarget;

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

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_42df829af2804ca9944049a3d0284f3e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_42df829af2804ca9944049a3d0284f3e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_42df829af2804ca9944049a3d0284f3e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_42df829af2804ca9944049a3d0284f3e(_3bf6e50b07f36de4eb0862c8139e9ab8_42df829af2804ca9944049a3d0284f3e command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_8346654686f1474bbb34f555a6f17ecc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_8346654686f1474bbb34f555a6f17ecc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_8346654686f1474bbb34f555a6f17ecc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_8346654686f1474bbb34f555a6f17ecc(_3bf6e50b07f36de4eb0862c8139e9ab8_8346654686f1474bbb34f555a6f17ecc command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_b7d6a8605c714c7e9f4c11ad065dcfe1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_b7d6a8605c714c7e9f4c11ad065dcfe1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_b7d6a8605c714c7e9f4c11ad065dcfe1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_b7d6a8605c714c7e9f4c11ad065dcfe1(_3bf6e50b07f36de4eb0862c8139e9ab8_b7d6a8605c714c7e9f4c11ad065dcfe1 command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_ff0fea750a534aae9b8ad8e239ef94e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_ff0fea750a534aae9b8ad8e239ef94e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_ff0fea750a534aae9b8ad8e239ef94e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_ff0fea750a534aae9b8ad8e239ef94e3(_3bf6e50b07f36de4eb0862c8139e9ab8_ff0fea750a534aae9b8ad8e239ef94e3 command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_04282655f27f4fb48a126caeda45f0d1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_04282655f27f4fb48a126caeda45f0d1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_04282655f27f4fb48a126caeda45f0d1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_04282655f27f4fb48a126caeda45f0d1(_3bf6e50b07f36de4eb0862c8139e9ab8_04282655f27f4fb48a126caeda45f0d1 command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_578364e1968d49b394b7e8860b6d2382(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_578364e1968d49b394b7e8860b6d2382(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_578364e1968d49b394b7e8860b6d2382(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_578364e1968d49b394b7e8860b6d2382(_3bf6e50b07f36de4eb0862c8139e9ab8_578364e1968d49b394b7e8860b6d2382 command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_a04c0c94508b497abbf648f0b754083a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_a04c0c94508b497abbf648f0b754083a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_a04c0c94508b497abbf648f0b754083a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_a04c0c94508b497abbf648f0b754083a(_3bf6e50b07f36de4eb0862c8139e9ab8_a04c0c94508b497abbf648f0b754083a command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_88b31f15078f44f89a93a7063a059d2d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_88b31f15078f44f89a93a7063a059d2d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_88b31f15078f44f89a93a7063a059d2d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_88b31f15078f44f89a93a7063a059d2d(_3bf6e50b07f36de4eb0862c8139e9ab8_88b31f15078f44f89a93a7063a059d2d command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_ed80280322b2443fb8565e7005df8289(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_ed80280322b2443fb8565e7005df8289(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_ed80280322b2443fb8565e7005df8289(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_ed80280322b2443fb8565e7005df8289(_3bf6e50b07f36de4eb0862c8139e9ab8_ed80280322b2443fb8565e7005df8289 command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_09ca4e2c6a0c42d8b4fa6653a45f488d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_09ca4e2c6a0c42d8b4fa6653a45f488d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_09ca4e2c6a0c42d8b4fa6653a45f488d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_09ca4e2c6a0c42d8b4fa6653a45f488d(_3bf6e50b07f36de4eb0862c8139e9ab8_09ca4e2c6a0c42d8b4fa6653a45f488d command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_4617fefe6dde4d5ca3a138324db80d0c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_4617fefe6dde4d5ca3a138324db80d0c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_4617fefe6dde4d5ca3a138324db80d0c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_4617fefe6dde4d5ca3a138324db80d0c(_3bf6e50b07f36de4eb0862c8139e9ab8_4617fefe6dde4d5ca3a138324db80d0c command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_6b68584963f74c57999cb89df9b2a822(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_6b68584963f74c57999cb89df9b2a822(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_6b68584963f74c57999cb89df9b2a822(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_6b68584963f74c57999cb89df9b2a822(_3bf6e50b07f36de4eb0862c8139e9ab8_6b68584963f74c57999cb89df9b2a822 command)
		{
		}

		private void BakeCommandBinding__3bf6e50b07f36de4eb0862c8139e9ab8_f452a7b17b7544c79f81974769e54d7f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3bf6e50b07f36de4eb0862c8139e9ab8_f452a7b17b7544c79f81974769e54d7f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3bf6e50b07f36de4eb0862c8139e9ab8_f452a7b17b7544c79f81974769e54d7f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3bf6e50b07f36de4eb0862c8139e9ab8_f452a7b17b7544c79f81974769e54d7f(_3bf6e50b07f36de4eb0862c8139e9ab8_f452a7b17b7544c79f81974769e54d7f command)
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
