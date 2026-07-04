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
	public class CoherenceSync_51689b3267e6c0d459907e8aeca19cdd : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_e523c57d72be448c84d80623a5d8c6f3_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_5e90f9fd11fd4f32aeb745c5b4078a72_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_b1a0b55e771441db8e71d4aecdb24670_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_4235d49a2a9c4f98bd03ad63b7a1b6e5_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_5e8c283e04df495e9d63d781593b0079_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_562be0fff1a145f180fb3f7937802cdb_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_ced95f2da96b4d279f11a395e567b003_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_775f1cc61dcd4eb1bf72c2a513f0513f_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_6203b9ce82db411e95c81add07e2eea5_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_a5ba0d9d19674cb4bfc21e2a7d39cf9f_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_ffa661f45c1a414d9e2ce886aabff431_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_5182885022fb46dbb661a94d06ea4efb_CommandTarget;

		private CharacterController _51689b3267e6c0d459907e8aeca19cdd_34c49a2510624327b411e4b93106559c_CommandTarget;

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

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_e523c57d72be448c84d80623a5d8c6f3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_e523c57d72be448c84d80623a5d8c6f3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_e523c57d72be448c84d80623a5d8c6f3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_e523c57d72be448c84d80623a5d8c6f3(_51689b3267e6c0d459907e8aeca19cdd_e523c57d72be448c84d80623a5d8c6f3 command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_5e90f9fd11fd4f32aeb745c5b4078a72(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_5e90f9fd11fd4f32aeb745c5b4078a72(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_5e90f9fd11fd4f32aeb745c5b4078a72(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_5e90f9fd11fd4f32aeb745c5b4078a72(_51689b3267e6c0d459907e8aeca19cdd_5e90f9fd11fd4f32aeb745c5b4078a72 command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_b1a0b55e771441db8e71d4aecdb24670(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_b1a0b55e771441db8e71d4aecdb24670(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_b1a0b55e771441db8e71d4aecdb24670(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_b1a0b55e771441db8e71d4aecdb24670(_51689b3267e6c0d459907e8aeca19cdd_b1a0b55e771441db8e71d4aecdb24670 command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_4235d49a2a9c4f98bd03ad63b7a1b6e5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_4235d49a2a9c4f98bd03ad63b7a1b6e5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_4235d49a2a9c4f98bd03ad63b7a1b6e5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_4235d49a2a9c4f98bd03ad63b7a1b6e5(_51689b3267e6c0d459907e8aeca19cdd_4235d49a2a9c4f98bd03ad63b7a1b6e5 command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_5e8c283e04df495e9d63d781593b0079(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_5e8c283e04df495e9d63d781593b0079(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_5e8c283e04df495e9d63d781593b0079(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_5e8c283e04df495e9d63d781593b0079(_51689b3267e6c0d459907e8aeca19cdd_5e8c283e04df495e9d63d781593b0079 command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_562be0fff1a145f180fb3f7937802cdb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_562be0fff1a145f180fb3f7937802cdb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_562be0fff1a145f180fb3f7937802cdb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_562be0fff1a145f180fb3f7937802cdb(_51689b3267e6c0d459907e8aeca19cdd_562be0fff1a145f180fb3f7937802cdb command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_ced95f2da96b4d279f11a395e567b003(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_ced95f2da96b4d279f11a395e567b003(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_ced95f2da96b4d279f11a395e567b003(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_ced95f2da96b4d279f11a395e567b003(_51689b3267e6c0d459907e8aeca19cdd_ced95f2da96b4d279f11a395e567b003 command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_775f1cc61dcd4eb1bf72c2a513f0513f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_775f1cc61dcd4eb1bf72c2a513f0513f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_775f1cc61dcd4eb1bf72c2a513f0513f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_775f1cc61dcd4eb1bf72c2a513f0513f(_51689b3267e6c0d459907e8aeca19cdd_775f1cc61dcd4eb1bf72c2a513f0513f command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_6203b9ce82db411e95c81add07e2eea5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_6203b9ce82db411e95c81add07e2eea5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_6203b9ce82db411e95c81add07e2eea5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_6203b9ce82db411e95c81add07e2eea5(_51689b3267e6c0d459907e8aeca19cdd_6203b9ce82db411e95c81add07e2eea5 command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_a5ba0d9d19674cb4bfc21e2a7d39cf9f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_a5ba0d9d19674cb4bfc21e2a7d39cf9f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_a5ba0d9d19674cb4bfc21e2a7d39cf9f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_a5ba0d9d19674cb4bfc21e2a7d39cf9f(_51689b3267e6c0d459907e8aeca19cdd_a5ba0d9d19674cb4bfc21e2a7d39cf9f command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_ffa661f45c1a414d9e2ce886aabff431(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_ffa661f45c1a414d9e2ce886aabff431(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_ffa661f45c1a414d9e2ce886aabff431(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_ffa661f45c1a414d9e2ce886aabff431(_51689b3267e6c0d459907e8aeca19cdd_ffa661f45c1a414d9e2ce886aabff431 command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_5182885022fb46dbb661a94d06ea4efb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_5182885022fb46dbb661a94d06ea4efb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_5182885022fb46dbb661a94d06ea4efb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_5182885022fb46dbb661a94d06ea4efb(_51689b3267e6c0d459907e8aeca19cdd_5182885022fb46dbb661a94d06ea4efb command)
		{
		}

		private void BakeCommandBinding__51689b3267e6c0d459907e8aeca19cdd_34c49a2510624327b411e4b93106559c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__51689b3267e6c0d459907e8aeca19cdd_34c49a2510624327b411e4b93106559c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__51689b3267e6c0d459907e8aeca19cdd_34c49a2510624327b411e4b93106559c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__51689b3267e6c0d459907e8aeca19cdd_34c49a2510624327b411e4b93106559c(_51689b3267e6c0d459907e8aeca19cdd_34c49a2510624327b411e4b93106559c command)
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
