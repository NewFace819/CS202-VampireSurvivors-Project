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
	public class CoherenceSync_0b99a7c92f39d8e46aaaaad9648fbbb7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _0b99a7c92f39d8e46aaaaad9648fbbb7_3895a818b2044a7ab5d6606ebb764c0d_CommandTarget;

		private NetworkPickup _0b99a7c92f39d8e46aaaaad9648fbbb7_d425b9ea53f14f998a5ca870be4ba243_CommandTarget;

		private NetworkPickup _0b99a7c92f39d8e46aaaaad9648fbbb7_64b5effbe29f4f879825a0c2a6c12e45_CommandTarget;

		private NetworkPickup _0b99a7c92f39d8e46aaaaad9648fbbb7_5f950300f49042d2933493a107cc8229_CommandTarget;

		private NetworkPickup _0b99a7c92f39d8e46aaaaad9648fbbb7_744dcff17a30421980b7ed05ca7f6d51_CommandTarget;

		private NetworkPickup _0b99a7c92f39d8e46aaaaad9648fbbb7_8bc04f29883a4297bc5485b5c95cffd7_CommandTarget;

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

		private void BakeCommandBinding__0b99a7c92f39d8e46aaaaad9648fbbb7_3895a818b2044a7ab5d6606ebb764c0d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_3895a818b2044a7ab5d6606ebb764c0d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_3895a818b2044a7ab5d6606ebb764c0d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_3895a818b2044a7ab5d6606ebb764c0d(_0b99a7c92f39d8e46aaaaad9648fbbb7_3895a818b2044a7ab5d6606ebb764c0d command)
		{
		}

		private void BakeCommandBinding__0b99a7c92f39d8e46aaaaad9648fbbb7_d425b9ea53f14f998a5ca870be4ba243(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_d425b9ea53f14f998a5ca870be4ba243(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_d425b9ea53f14f998a5ca870be4ba243(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_d425b9ea53f14f998a5ca870be4ba243(_0b99a7c92f39d8e46aaaaad9648fbbb7_d425b9ea53f14f998a5ca870be4ba243 command)
		{
		}

		private void BakeCommandBinding__0b99a7c92f39d8e46aaaaad9648fbbb7_64b5effbe29f4f879825a0c2a6c12e45(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_64b5effbe29f4f879825a0c2a6c12e45(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_64b5effbe29f4f879825a0c2a6c12e45(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_64b5effbe29f4f879825a0c2a6c12e45(_0b99a7c92f39d8e46aaaaad9648fbbb7_64b5effbe29f4f879825a0c2a6c12e45 command)
		{
		}

		private void BakeCommandBinding__0b99a7c92f39d8e46aaaaad9648fbbb7_5f950300f49042d2933493a107cc8229(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_5f950300f49042d2933493a107cc8229(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_5f950300f49042d2933493a107cc8229(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_5f950300f49042d2933493a107cc8229(_0b99a7c92f39d8e46aaaaad9648fbbb7_5f950300f49042d2933493a107cc8229 command)
		{
		}

		private void BakeCommandBinding__0b99a7c92f39d8e46aaaaad9648fbbb7_744dcff17a30421980b7ed05ca7f6d51(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_744dcff17a30421980b7ed05ca7f6d51(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_744dcff17a30421980b7ed05ca7f6d51(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_744dcff17a30421980b7ed05ca7f6d51(_0b99a7c92f39d8e46aaaaad9648fbbb7_744dcff17a30421980b7ed05ca7f6d51 command)
		{
		}

		private void BakeCommandBinding__0b99a7c92f39d8e46aaaaad9648fbbb7_8bc04f29883a4297bc5485b5c95cffd7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_8bc04f29883a4297bc5485b5c95cffd7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_8bc04f29883a4297bc5485b5c95cffd7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b99a7c92f39d8e46aaaaad9648fbbb7_8bc04f29883a4297bc5485b5c95cffd7(_0b99a7c92f39d8e46aaaaad9648fbbb7_8bc04f29883a4297bc5485b5c95cffd7 command)
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
