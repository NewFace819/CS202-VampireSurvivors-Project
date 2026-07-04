using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Props;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_4a18ef90fc76b674d9e83d3efeb63df8 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private PropFoscariSeal1 _4a18ef90fc76b674d9e83d3efeb63df8_e0cc0391552548a1b118559759fda026_CommandTarget;

		private Destructible _4a18ef90fc76b674d9e83d3efeb63df8_63404b3da7ea422cb25f78eebcee2ef0_CommandTarget;

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

		private void BakeCommandBinding__4a18ef90fc76b674d9e83d3efeb63df8_e0cc0391552548a1b118559759fda026(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4a18ef90fc76b674d9e83d3efeb63df8_e0cc0391552548a1b118559759fda026(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4a18ef90fc76b674d9e83d3efeb63df8_e0cc0391552548a1b118559759fda026(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4a18ef90fc76b674d9e83d3efeb63df8_e0cc0391552548a1b118559759fda026(_4a18ef90fc76b674d9e83d3efeb63df8_e0cc0391552548a1b118559759fda026 command)
		{
		}

		private void BakeCommandBinding__4a18ef90fc76b674d9e83d3efeb63df8_63404b3da7ea422cb25f78eebcee2ef0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4a18ef90fc76b674d9e83d3efeb63df8_63404b3da7ea422cb25f78eebcee2ef0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4a18ef90fc76b674d9e83d3efeb63df8_63404b3da7ea422cb25f78eebcee2ef0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4a18ef90fc76b674d9e83d3efeb63df8_63404b3da7ea422cb25f78eebcee2ef0(_4a18ef90fc76b674d9e83d3efeb63df8_63404b3da7ea422cb25f78eebcee2ef0 command)
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
