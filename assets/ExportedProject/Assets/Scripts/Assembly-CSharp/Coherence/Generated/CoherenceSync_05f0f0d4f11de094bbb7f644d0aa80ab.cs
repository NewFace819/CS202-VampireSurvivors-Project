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
	public class CoherenceSync_05f0f0d4f11de094bbb7f644d0aa80ab : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _05f0f0d4f11de094bbb7f644d0aa80ab_fa9e2c12472c4c999652f04e93c7d629_CommandTarget;

		private NetworkPickup _05f0f0d4f11de094bbb7f644d0aa80ab_0ad4eaf1e6da48e484aeaae626f03c9b_CommandTarget;

		private NetworkPickup _05f0f0d4f11de094bbb7f644d0aa80ab_2e38df6cb82f4c20a40ff72228c91e3f_CommandTarget;

		private NetworkPickup _05f0f0d4f11de094bbb7f644d0aa80ab_93162b4168704fb9836385e4fb8bc428_CommandTarget;

		private NetworkPickup _05f0f0d4f11de094bbb7f644d0aa80ab_4a904c6905874a76abda60c68a33ced8_CommandTarget;

		private NetworkPickup _05f0f0d4f11de094bbb7f644d0aa80ab_151cb13ae8a84d52af669c50d90d07ee_CommandTarget;

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

		private void BakeCommandBinding__05f0f0d4f11de094bbb7f644d0aa80ab_fa9e2c12472c4c999652f04e93c7d629(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__05f0f0d4f11de094bbb7f644d0aa80ab_fa9e2c12472c4c999652f04e93c7d629(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__05f0f0d4f11de094bbb7f644d0aa80ab_fa9e2c12472c4c999652f04e93c7d629(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__05f0f0d4f11de094bbb7f644d0aa80ab_fa9e2c12472c4c999652f04e93c7d629(_05f0f0d4f11de094bbb7f644d0aa80ab_fa9e2c12472c4c999652f04e93c7d629 command)
		{
		}

		private void BakeCommandBinding__05f0f0d4f11de094bbb7f644d0aa80ab_0ad4eaf1e6da48e484aeaae626f03c9b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__05f0f0d4f11de094bbb7f644d0aa80ab_0ad4eaf1e6da48e484aeaae626f03c9b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__05f0f0d4f11de094bbb7f644d0aa80ab_0ad4eaf1e6da48e484aeaae626f03c9b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__05f0f0d4f11de094bbb7f644d0aa80ab_0ad4eaf1e6da48e484aeaae626f03c9b(_05f0f0d4f11de094bbb7f644d0aa80ab_0ad4eaf1e6da48e484aeaae626f03c9b command)
		{
		}

		private void BakeCommandBinding__05f0f0d4f11de094bbb7f644d0aa80ab_2e38df6cb82f4c20a40ff72228c91e3f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__05f0f0d4f11de094bbb7f644d0aa80ab_2e38df6cb82f4c20a40ff72228c91e3f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__05f0f0d4f11de094bbb7f644d0aa80ab_2e38df6cb82f4c20a40ff72228c91e3f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__05f0f0d4f11de094bbb7f644d0aa80ab_2e38df6cb82f4c20a40ff72228c91e3f(_05f0f0d4f11de094bbb7f644d0aa80ab_2e38df6cb82f4c20a40ff72228c91e3f command)
		{
		}

		private void BakeCommandBinding__05f0f0d4f11de094bbb7f644d0aa80ab_93162b4168704fb9836385e4fb8bc428(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__05f0f0d4f11de094bbb7f644d0aa80ab_93162b4168704fb9836385e4fb8bc428(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__05f0f0d4f11de094bbb7f644d0aa80ab_93162b4168704fb9836385e4fb8bc428(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__05f0f0d4f11de094bbb7f644d0aa80ab_93162b4168704fb9836385e4fb8bc428(_05f0f0d4f11de094bbb7f644d0aa80ab_93162b4168704fb9836385e4fb8bc428 command)
		{
		}

		private void BakeCommandBinding__05f0f0d4f11de094bbb7f644d0aa80ab_4a904c6905874a76abda60c68a33ced8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__05f0f0d4f11de094bbb7f644d0aa80ab_4a904c6905874a76abda60c68a33ced8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__05f0f0d4f11de094bbb7f644d0aa80ab_4a904c6905874a76abda60c68a33ced8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__05f0f0d4f11de094bbb7f644d0aa80ab_4a904c6905874a76abda60c68a33ced8(_05f0f0d4f11de094bbb7f644d0aa80ab_4a904c6905874a76abda60c68a33ced8 command)
		{
		}

		private void BakeCommandBinding__05f0f0d4f11de094bbb7f644d0aa80ab_151cb13ae8a84d52af669c50d90d07ee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__05f0f0d4f11de094bbb7f644d0aa80ab_151cb13ae8a84d52af669c50d90d07ee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__05f0f0d4f11de094bbb7f644d0aa80ab_151cb13ae8a84d52af669c50d90d07ee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__05f0f0d4f11de094bbb7f644d0aa80ab_151cb13ae8a84d52af669c50d90d07ee(_05f0f0d4f11de094bbb7f644d0aa80ab_151cb13ae8a84d52af669c50d90d07ee command)
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
