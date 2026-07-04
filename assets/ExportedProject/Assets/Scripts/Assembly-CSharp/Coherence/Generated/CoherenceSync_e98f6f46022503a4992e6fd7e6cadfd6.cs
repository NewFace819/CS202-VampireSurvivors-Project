using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_e98f6f46022503a4992e6fd7e6cadfd6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _e98f6f46022503a4992e6fd7e6cadfd6_86833cb2275b4d27bf35b1cb88dc3f67_CommandTarget;

		private NetworkPickup _e98f6f46022503a4992e6fd7e6cadfd6_45a5c1c535db44b7ac1d0a35e05accc9_CommandTarget;

		private NetworkPickup _e98f6f46022503a4992e6fd7e6cadfd6_ff4a443ff48b44f0ba8e0f885fbfa99b_CommandTarget;

		private NetworkPickup _e98f6f46022503a4992e6fd7e6cadfd6_2d2112426e1a4cac99574ebd1c11b220_CommandTarget;

		private NetworkPickup _e98f6f46022503a4992e6fd7e6cadfd6_da6e8fc15acd4417b922aa620272741a_CommandTarget;

		private NetworkPickup _e98f6f46022503a4992e6fd7e6cadfd6_d7cd91596de2462aa1b370fb5576e233_CommandTarget;

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

		private void BakeCommandBinding__e98f6f46022503a4992e6fd7e6cadfd6_86833cb2275b4d27bf35b1cb88dc3f67(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e98f6f46022503a4992e6fd7e6cadfd6_86833cb2275b4d27bf35b1cb88dc3f67(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e98f6f46022503a4992e6fd7e6cadfd6_86833cb2275b4d27bf35b1cb88dc3f67(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e98f6f46022503a4992e6fd7e6cadfd6_86833cb2275b4d27bf35b1cb88dc3f67(_e98f6f46022503a4992e6fd7e6cadfd6_86833cb2275b4d27bf35b1cb88dc3f67 command)
		{
		}

		private void BakeCommandBinding__e98f6f46022503a4992e6fd7e6cadfd6_45a5c1c535db44b7ac1d0a35e05accc9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e98f6f46022503a4992e6fd7e6cadfd6_45a5c1c535db44b7ac1d0a35e05accc9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e98f6f46022503a4992e6fd7e6cadfd6_45a5c1c535db44b7ac1d0a35e05accc9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e98f6f46022503a4992e6fd7e6cadfd6_45a5c1c535db44b7ac1d0a35e05accc9(_e98f6f46022503a4992e6fd7e6cadfd6_45a5c1c535db44b7ac1d0a35e05accc9 command)
		{
		}

		private void BakeCommandBinding__e98f6f46022503a4992e6fd7e6cadfd6_ff4a443ff48b44f0ba8e0f885fbfa99b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e98f6f46022503a4992e6fd7e6cadfd6_ff4a443ff48b44f0ba8e0f885fbfa99b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e98f6f46022503a4992e6fd7e6cadfd6_ff4a443ff48b44f0ba8e0f885fbfa99b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e98f6f46022503a4992e6fd7e6cadfd6_ff4a443ff48b44f0ba8e0f885fbfa99b(_e98f6f46022503a4992e6fd7e6cadfd6_ff4a443ff48b44f0ba8e0f885fbfa99b command)
		{
		}

		private void BakeCommandBinding__e98f6f46022503a4992e6fd7e6cadfd6_2d2112426e1a4cac99574ebd1c11b220(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e98f6f46022503a4992e6fd7e6cadfd6_2d2112426e1a4cac99574ebd1c11b220(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e98f6f46022503a4992e6fd7e6cadfd6_2d2112426e1a4cac99574ebd1c11b220(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e98f6f46022503a4992e6fd7e6cadfd6_2d2112426e1a4cac99574ebd1c11b220(_e98f6f46022503a4992e6fd7e6cadfd6_2d2112426e1a4cac99574ebd1c11b220 command)
		{
		}

		private void BakeCommandBinding__e98f6f46022503a4992e6fd7e6cadfd6_da6e8fc15acd4417b922aa620272741a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e98f6f46022503a4992e6fd7e6cadfd6_da6e8fc15acd4417b922aa620272741a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e98f6f46022503a4992e6fd7e6cadfd6_da6e8fc15acd4417b922aa620272741a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e98f6f46022503a4992e6fd7e6cadfd6_da6e8fc15acd4417b922aa620272741a(_e98f6f46022503a4992e6fd7e6cadfd6_da6e8fc15acd4417b922aa620272741a command)
		{
		}

		private void BakeCommandBinding__e98f6f46022503a4992e6fd7e6cadfd6_d7cd91596de2462aa1b370fb5576e233(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e98f6f46022503a4992e6fd7e6cadfd6_d7cd91596de2462aa1b370fb5576e233(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e98f6f46022503a4992e6fd7e6cadfd6_d7cd91596de2462aa1b370fb5576e233(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e98f6f46022503a4992e6fd7e6cadfd6_d7cd91596de2462aa1b370fb5576e233(_e98f6f46022503a4992e6fd7e6cadfd6_d7cd91596de2462aa1b370fb5576e233 command)
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
