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
	public class CoherenceSync_553304c5f197d5d43b0145f3c53d7d03 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_eae94232ddb1492785f5cb2d00ce43cf_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_261dae57587b4c9980fb9a55c20c7d0c_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_129ab378f44c4bf1b9d4e3fd230be907_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_f2eb12606c2d4a9faae2047151ee3d2e_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_20309307a0144758874a5467cfe792ac_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_e2722a4872054c748264efdb820eb87b_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_a63be70c1c5a4042b3688c9e7f0634ab_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_89cf2794e8514e54beea231c39e8199b_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_08574c35376245999e74bc60dea0718c_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_1c95341997a04b75a3d7ab4bfd3cb885_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_7c814e81d8c3423794ed9e4df81e2749_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_39eebfb52f334006a5ec8f31079f4a13_CommandTarget;

		private CharacterController _553304c5f197d5d43b0145f3c53d7d03_54b23a13c8e9490081b851bb71830673_CommandTarget;

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

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_eae94232ddb1492785f5cb2d00ce43cf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_eae94232ddb1492785f5cb2d00ce43cf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_eae94232ddb1492785f5cb2d00ce43cf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_eae94232ddb1492785f5cb2d00ce43cf(_553304c5f197d5d43b0145f3c53d7d03_eae94232ddb1492785f5cb2d00ce43cf command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_261dae57587b4c9980fb9a55c20c7d0c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_261dae57587b4c9980fb9a55c20c7d0c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_261dae57587b4c9980fb9a55c20c7d0c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_261dae57587b4c9980fb9a55c20c7d0c(_553304c5f197d5d43b0145f3c53d7d03_261dae57587b4c9980fb9a55c20c7d0c command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_129ab378f44c4bf1b9d4e3fd230be907(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_129ab378f44c4bf1b9d4e3fd230be907(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_129ab378f44c4bf1b9d4e3fd230be907(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_129ab378f44c4bf1b9d4e3fd230be907(_553304c5f197d5d43b0145f3c53d7d03_129ab378f44c4bf1b9d4e3fd230be907 command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_f2eb12606c2d4a9faae2047151ee3d2e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_f2eb12606c2d4a9faae2047151ee3d2e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_f2eb12606c2d4a9faae2047151ee3d2e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_f2eb12606c2d4a9faae2047151ee3d2e(_553304c5f197d5d43b0145f3c53d7d03_f2eb12606c2d4a9faae2047151ee3d2e command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_20309307a0144758874a5467cfe792ac(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_20309307a0144758874a5467cfe792ac(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_20309307a0144758874a5467cfe792ac(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_20309307a0144758874a5467cfe792ac(_553304c5f197d5d43b0145f3c53d7d03_20309307a0144758874a5467cfe792ac command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_e2722a4872054c748264efdb820eb87b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_e2722a4872054c748264efdb820eb87b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_e2722a4872054c748264efdb820eb87b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_e2722a4872054c748264efdb820eb87b(_553304c5f197d5d43b0145f3c53d7d03_e2722a4872054c748264efdb820eb87b command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_a63be70c1c5a4042b3688c9e7f0634ab(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_a63be70c1c5a4042b3688c9e7f0634ab(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_a63be70c1c5a4042b3688c9e7f0634ab(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_a63be70c1c5a4042b3688c9e7f0634ab(_553304c5f197d5d43b0145f3c53d7d03_a63be70c1c5a4042b3688c9e7f0634ab command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_89cf2794e8514e54beea231c39e8199b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_89cf2794e8514e54beea231c39e8199b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_89cf2794e8514e54beea231c39e8199b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_89cf2794e8514e54beea231c39e8199b(_553304c5f197d5d43b0145f3c53d7d03_89cf2794e8514e54beea231c39e8199b command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_08574c35376245999e74bc60dea0718c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_08574c35376245999e74bc60dea0718c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_08574c35376245999e74bc60dea0718c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_08574c35376245999e74bc60dea0718c(_553304c5f197d5d43b0145f3c53d7d03_08574c35376245999e74bc60dea0718c command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_1c95341997a04b75a3d7ab4bfd3cb885(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_1c95341997a04b75a3d7ab4bfd3cb885(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_1c95341997a04b75a3d7ab4bfd3cb885(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_1c95341997a04b75a3d7ab4bfd3cb885(_553304c5f197d5d43b0145f3c53d7d03_1c95341997a04b75a3d7ab4bfd3cb885 command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_7c814e81d8c3423794ed9e4df81e2749(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_7c814e81d8c3423794ed9e4df81e2749(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_7c814e81d8c3423794ed9e4df81e2749(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_7c814e81d8c3423794ed9e4df81e2749(_553304c5f197d5d43b0145f3c53d7d03_7c814e81d8c3423794ed9e4df81e2749 command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_39eebfb52f334006a5ec8f31079f4a13(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_39eebfb52f334006a5ec8f31079f4a13(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_39eebfb52f334006a5ec8f31079f4a13(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_39eebfb52f334006a5ec8f31079f4a13(_553304c5f197d5d43b0145f3c53d7d03_39eebfb52f334006a5ec8f31079f4a13 command)
		{
		}

		private void BakeCommandBinding__553304c5f197d5d43b0145f3c53d7d03_54b23a13c8e9490081b851bb71830673(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__553304c5f197d5d43b0145f3c53d7d03_54b23a13c8e9490081b851bb71830673(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__553304c5f197d5d43b0145f3c53d7d03_54b23a13c8e9490081b851bb71830673(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__553304c5f197d5d43b0145f3c53d7d03_54b23a13c8e9490081b851bb71830673(_553304c5f197d5d43b0145f3c53d7d03_54b23a13c8e9490081b851bb71830673 command)
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
