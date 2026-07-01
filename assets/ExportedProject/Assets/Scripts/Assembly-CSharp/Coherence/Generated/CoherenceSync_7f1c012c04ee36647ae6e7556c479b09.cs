using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Stages;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_7f1c012c04ee36647ae6e7556c479b09 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private TP_BossArena _7f1c012c04ee36647ae6e7556c479b09_33a93c3633774b78ab795566edb86c23_CommandTarget;

		private TP_BossArena _7f1c012c04ee36647ae6e7556c479b09_c18a0fc9fa004d9ebbd48d00f3a3bc53_CommandTarget;

		private TP_BossArena _7f1c012c04ee36647ae6e7556c479b09_bfda58d31c2f48cdb86213ba0146b3f9_CommandTarget;

		private TP_BossArena _7f1c012c04ee36647ae6e7556c479b09_0240e802489144008b7d60c2a8652e48_CommandTarget;

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

		private void BakeCommandBinding__7f1c012c04ee36647ae6e7556c479b09_33a93c3633774b78ab795566edb86c23(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7f1c012c04ee36647ae6e7556c479b09_33a93c3633774b78ab795566edb86c23(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7f1c012c04ee36647ae6e7556c479b09_33a93c3633774b78ab795566edb86c23(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7f1c012c04ee36647ae6e7556c479b09_33a93c3633774b78ab795566edb86c23(_7f1c012c04ee36647ae6e7556c479b09_33a93c3633774b78ab795566edb86c23 command)
		{
		}

		private void BakeCommandBinding__7f1c012c04ee36647ae6e7556c479b09_c18a0fc9fa004d9ebbd48d00f3a3bc53(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7f1c012c04ee36647ae6e7556c479b09_c18a0fc9fa004d9ebbd48d00f3a3bc53(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7f1c012c04ee36647ae6e7556c479b09_c18a0fc9fa004d9ebbd48d00f3a3bc53(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7f1c012c04ee36647ae6e7556c479b09_c18a0fc9fa004d9ebbd48d00f3a3bc53(_7f1c012c04ee36647ae6e7556c479b09_c18a0fc9fa004d9ebbd48d00f3a3bc53 command)
		{
		}

		private void BakeCommandBinding__7f1c012c04ee36647ae6e7556c479b09_bfda58d31c2f48cdb86213ba0146b3f9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7f1c012c04ee36647ae6e7556c479b09_bfda58d31c2f48cdb86213ba0146b3f9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7f1c012c04ee36647ae6e7556c479b09_bfda58d31c2f48cdb86213ba0146b3f9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7f1c012c04ee36647ae6e7556c479b09_bfda58d31c2f48cdb86213ba0146b3f9(_7f1c012c04ee36647ae6e7556c479b09_bfda58d31c2f48cdb86213ba0146b3f9 command)
		{
		}

		private void BakeCommandBinding__7f1c012c04ee36647ae6e7556c479b09_0240e802489144008b7d60c2a8652e48(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7f1c012c04ee36647ae6e7556c479b09_0240e802489144008b7d60c2a8652e48(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7f1c012c04ee36647ae6e7556c479b09_0240e802489144008b7d60c2a8652e48(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7f1c012c04ee36647ae6e7556c479b09_0240e802489144008b7d60c2a8652e48(_7f1c012c04ee36647ae6e7556c479b09_0240e802489144008b7d60c2a8652e48 command)
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
