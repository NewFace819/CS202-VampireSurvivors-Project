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
	public class CoherenceSync_de05d1ac240105148a399ffba1e0e071 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _de05d1ac240105148a399ffba1e0e071_a337dc9036024a3f83910286bd4dc44c_CommandTarget;

		private NetworkPickup _de05d1ac240105148a399ffba1e0e071_ca3f3260486a4a189434cfa36eddf456_CommandTarget;

		private NetworkPickup _de05d1ac240105148a399ffba1e0e071_bf7c2bf3923646f59a0be00a83a72f59_CommandTarget;

		private NetworkPickup _de05d1ac240105148a399ffba1e0e071_a2e692be74fd462281aef254d807164a_CommandTarget;

		private NetworkPickup _de05d1ac240105148a399ffba1e0e071_6e410de111ca4d44a3dd80951f7221a5_CommandTarget;

		private NetworkPickup _de05d1ac240105148a399ffba1e0e071_9f76c05ce1b145ab88d7a60e7ea8c9d1_CommandTarget;

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

		private void BakeCommandBinding__de05d1ac240105148a399ffba1e0e071_a337dc9036024a3f83910286bd4dc44c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de05d1ac240105148a399ffba1e0e071_a337dc9036024a3f83910286bd4dc44c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de05d1ac240105148a399ffba1e0e071_a337dc9036024a3f83910286bd4dc44c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de05d1ac240105148a399ffba1e0e071_a337dc9036024a3f83910286bd4dc44c(_de05d1ac240105148a399ffba1e0e071_a337dc9036024a3f83910286bd4dc44c command)
		{
		}

		private void BakeCommandBinding__de05d1ac240105148a399ffba1e0e071_ca3f3260486a4a189434cfa36eddf456(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de05d1ac240105148a399ffba1e0e071_ca3f3260486a4a189434cfa36eddf456(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de05d1ac240105148a399ffba1e0e071_ca3f3260486a4a189434cfa36eddf456(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de05d1ac240105148a399ffba1e0e071_ca3f3260486a4a189434cfa36eddf456(_de05d1ac240105148a399ffba1e0e071_ca3f3260486a4a189434cfa36eddf456 command)
		{
		}

		private void BakeCommandBinding__de05d1ac240105148a399ffba1e0e071_bf7c2bf3923646f59a0be00a83a72f59(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de05d1ac240105148a399ffba1e0e071_bf7c2bf3923646f59a0be00a83a72f59(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de05d1ac240105148a399ffba1e0e071_bf7c2bf3923646f59a0be00a83a72f59(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de05d1ac240105148a399ffba1e0e071_bf7c2bf3923646f59a0be00a83a72f59(_de05d1ac240105148a399ffba1e0e071_bf7c2bf3923646f59a0be00a83a72f59 command)
		{
		}

		private void BakeCommandBinding__de05d1ac240105148a399ffba1e0e071_a2e692be74fd462281aef254d807164a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de05d1ac240105148a399ffba1e0e071_a2e692be74fd462281aef254d807164a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de05d1ac240105148a399ffba1e0e071_a2e692be74fd462281aef254d807164a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de05d1ac240105148a399ffba1e0e071_a2e692be74fd462281aef254d807164a(_de05d1ac240105148a399ffba1e0e071_a2e692be74fd462281aef254d807164a command)
		{
		}

		private void BakeCommandBinding__de05d1ac240105148a399ffba1e0e071_6e410de111ca4d44a3dd80951f7221a5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de05d1ac240105148a399ffba1e0e071_6e410de111ca4d44a3dd80951f7221a5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de05d1ac240105148a399ffba1e0e071_6e410de111ca4d44a3dd80951f7221a5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de05d1ac240105148a399ffba1e0e071_6e410de111ca4d44a3dd80951f7221a5(_de05d1ac240105148a399ffba1e0e071_6e410de111ca4d44a3dd80951f7221a5 command)
		{
		}

		private void BakeCommandBinding__de05d1ac240105148a399ffba1e0e071_9f76c05ce1b145ab88d7a60e7ea8c9d1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de05d1ac240105148a399ffba1e0e071_9f76c05ce1b145ab88d7a60e7ea8c9d1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de05d1ac240105148a399ffba1e0e071_9f76c05ce1b145ab88d7a60e7ea8c9d1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de05d1ac240105148a399ffba1e0e071_9f76c05ce1b145ab88d7a60e7ea8c9d1(_de05d1ac240105148a399ffba1e0e071_9f76c05ce1b145ab88d7a60e7ea8c9d1 command)
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
