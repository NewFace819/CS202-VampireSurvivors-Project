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
	public class CoherenceSync_1ecfaa20fd2799545aed845d33ff6c46 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private PropFoscariSeal3 _1ecfaa20fd2799545aed845d33ff6c46_75e315fe6b0b41c7b6f7c3569a5e7409_CommandTarget;

		private Destructible _1ecfaa20fd2799545aed845d33ff6c46_0523bc1e31d244b1a902406ff953c897_CommandTarget;

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

		private void BakeCommandBinding__1ecfaa20fd2799545aed845d33ff6c46_75e315fe6b0b41c7b6f7c3569a5e7409(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ecfaa20fd2799545aed845d33ff6c46_75e315fe6b0b41c7b6f7c3569a5e7409(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ecfaa20fd2799545aed845d33ff6c46_75e315fe6b0b41c7b6f7c3569a5e7409(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ecfaa20fd2799545aed845d33ff6c46_75e315fe6b0b41c7b6f7c3569a5e7409(_1ecfaa20fd2799545aed845d33ff6c46_75e315fe6b0b41c7b6f7c3569a5e7409 command)
		{
		}

		private void BakeCommandBinding__1ecfaa20fd2799545aed845d33ff6c46_0523bc1e31d244b1a902406ff953c897(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ecfaa20fd2799545aed845d33ff6c46_0523bc1e31d244b1a902406ff953c897(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ecfaa20fd2799545aed845d33ff6c46_0523bc1e31d244b1a902406ff953c897(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ecfaa20fd2799545aed845d33ff6c46_0523bc1e31d244b1a902406ff953c897(_1ecfaa20fd2799545aed845d33ff6c46_0523bc1e31d244b1a902406ff953c897 command)
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
