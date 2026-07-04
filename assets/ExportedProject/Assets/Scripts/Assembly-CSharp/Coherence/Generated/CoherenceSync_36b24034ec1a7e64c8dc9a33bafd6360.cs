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
	public class CoherenceSync_36b24034ec1a7e64c8dc9a33bafd6360 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_7b9a44feab994f80a28e28f08a07fc73_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_3db5df6db22a4b9b8bc3c68550fa3208_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_a84d0bf62c2f49699452ab7b63f91b5b_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_bd10db063a7b4f7a986732126f6b9451_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_292dc6e2d062465bb253ca5edb29a1d7_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_637d8382d0914983b89a9ea696694186_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_ced394260d004873b5ee1e1da1bf876c_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_9961918c7de5438b8cb2a1d7e804901a_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_b5999be052564ff39506505dbfc8b221_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_4293d8bf480446f0bcf1bd6c6795aed7_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_49409322c8b34ddc9bbe3ae5c6b00319_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_e0c67fc35b59426da274a6516673812e_CommandTarget;

		private CharacterController _36b24034ec1a7e64c8dc9a33bafd6360_9ceb260c8d2f4606b0fe9caea34d168a_CommandTarget;

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

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_7b9a44feab994f80a28e28f08a07fc73(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_7b9a44feab994f80a28e28f08a07fc73(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_7b9a44feab994f80a28e28f08a07fc73(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_7b9a44feab994f80a28e28f08a07fc73(_36b24034ec1a7e64c8dc9a33bafd6360_7b9a44feab994f80a28e28f08a07fc73 command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_3db5df6db22a4b9b8bc3c68550fa3208(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_3db5df6db22a4b9b8bc3c68550fa3208(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_3db5df6db22a4b9b8bc3c68550fa3208(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_3db5df6db22a4b9b8bc3c68550fa3208(_36b24034ec1a7e64c8dc9a33bafd6360_3db5df6db22a4b9b8bc3c68550fa3208 command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_a84d0bf62c2f49699452ab7b63f91b5b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_a84d0bf62c2f49699452ab7b63f91b5b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_a84d0bf62c2f49699452ab7b63f91b5b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_a84d0bf62c2f49699452ab7b63f91b5b(_36b24034ec1a7e64c8dc9a33bafd6360_a84d0bf62c2f49699452ab7b63f91b5b command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_bd10db063a7b4f7a986732126f6b9451(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_bd10db063a7b4f7a986732126f6b9451(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_bd10db063a7b4f7a986732126f6b9451(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_bd10db063a7b4f7a986732126f6b9451(_36b24034ec1a7e64c8dc9a33bafd6360_bd10db063a7b4f7a986732126f6b9451 command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_292dc6e2d062465bb253ca5edb29a1d7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_292dc6e2d062465bb253ca5edb29a1d7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_292dc6e2d062465bb253ca5edb29a1d7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_292dc6e2d062465bb253ca5edb29a1d7(_36b24034ec1a7e64c8dc9a33bafd6360_292dc6e2d062465bb253ca5edb29a1d7 command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_637d8382d0914983b89a9ea696694186(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_637d8382d0914983b89a9ea696694186(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_637d8382d0914983b89a9ea696694186(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_637d8382d0914983b89a9ea696694186(_36b24034ec1a7e64c8dc9a33bafd6360_637d8382d0914983b89a9ea696694186 command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_ced394260d004873b5ee1e1da1bf876c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_ced394260d004873b5ee1e1da1bf876c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_ced394260d004873b5ee1e1da1bf876c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_ced394260d004873b5ee1e1da1bf876c(_36b24034ec1a7e64c8dc9a33bafd6360_ced394260d004873b5ee1e1da1bf876c command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_9961918c7de5438b8cb2a1d7e804901a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_9961918c7de5438b8cb2a1d7e804901a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_9961918c7de5438b8cb2a1d7e804901a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_9961918c7de5438b8cb2a1d7e804901a(_36b24034ec1a7e64c8dc9a33bafd6360_9961918c7de5438b8cb2a1d7e804901a command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_b5999be052564ff39506505dbfc8b221(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_b5999be052564ff39506505dbfc8b221(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_b5999be052564ff39506505dbfc8b221(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_b5999be052564ff39506505dbfc8b221(_36b24034ec1a7e64c8dc9a33bafd6360_b5999be052564ff39506505dbfc8b221 command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_4293d8bf480446f0bcf1bd6c6795aed7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_4293d8bf480446f0bcf1bd6c6795aed7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_4293d8bf480446f0bcf1bd6c6795aed7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_4293d8bf480446f0bcf1bd6c6795aed7(_36b24034ec1a7e64c8dc9a33bafd6360_4293d8bf480446f0bcf1bd6c6795aed7 command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_49409322c8b34ddc9bbe3ae5c6b00319(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_49409322c8b34ddc9bbe3ae5c6b00319(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_49409322c8b34ddc9bbe3ae5c6b00319(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_49409322c8b34ddc9bbe3ae5c6b00319(_36b24034ec1a7e64c8dc9a33bafd6360_49409322c8b34ddc9bbe3ae5c6b00319 command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_e0c67fc35b59426da274a6516673812e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_e0c67fc35b59426da274a6516673812e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_e0c67fc35b59426da274a6516673812e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_e0c67fc35b59426da274a6516673812e(_36b24034ec1a7e64c8dc9a33bafd6360_e0c67fc35b59426da274a6516673812e command)
		{
		}

		private void BakeCommandBinding__36b24034ec1a7e64c8dc9a33bafd6360_9ceb260c8d2f4606b0fe9caea34d168a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__36b24034ec1a7e64c8dc9a33bafd6360_9ceb260c8d2f4606b0fe9caea34d168a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__36b24034ec1a7e64c8dc9a33bafd6360_9ceb260c8d2f4606b0fe9caea34d168a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__36b24034ec1a7e64c8dc9a33bafd6360_9ceb260c8d2f4606b0fe9caea34d168a(_36b24034ec1a7e64c8dc9a33bafd6360_9ceb260c8d2f4606b0fe9caea34d168a command)
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
