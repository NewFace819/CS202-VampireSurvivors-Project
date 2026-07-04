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
	public class CoherenceSync_e896f05866b72d44a9d8a14ae0889cc5 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_8637fd3d511c4f88bfae4af9280ddd07_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_13015cb157c64b99876e3127944ff047_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_1cbf58a22e204c459d3ce232aab81e5e_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_48fb799a0eb442ed8b7c104619d91d86_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_2146d10cdeab47668694d2afd12b868a_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_6bc8b748778c48adaf31a5fcbacf47ce_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_d7ce06ddda42400ab457b028f2d48eef_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_7d8a5c34365f49699121d9dc205e11ca_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_0d3a23bb154d449b9c62f2f47109b95c_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_4c5d16c8c7ac4879b95b831e17a38964_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_eb578d3cbfdb4d34900ede4847d2ba8c_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_d583ee0c467f4cf6a17be8325dc8cece_CommandTarget;

		private CharacterController _e896f05866b72d44a9d8a14ae0889cc5_e9a5abda90de4109a7e3602987ea51cb_CommandTarget;

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

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_8637fd3d511c4f88bfae4af9280ddd07(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_8637fd3d511c4f88bfae4af9280ddd07(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_8637fd3d511c4f88bfae4af9280ddd07(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_8637fd3d511c4f88bfae4af9280ddd07(_e896f05866b72d44a9d8a14ae0889cc5_8637fd3d511c4f88bfae4af9280ddd07 command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_13015cb157c64b99876e3127944ff047(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_13015cb157c64b99876e3127944ff047(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_13015cb157c64b99876e3127944ff047(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_13015cb157c64b99876e3127944ff047(_e896f05866b72d44a9d8a14ae0889cc5_13015cb157c64b99876e3127944ff047 command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_1cbf58a22e204c459d3ce232aab81e5e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_1cbf58a22e204c459d3ce232aab81e5e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_1cbf58a22e204c459d3ce232aab81e5e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_1cbf58a22e204c459d3ce232aab81e5e(_e896f05866b72d44a9d8a14ae0889cc5_1cbf58a22e204c459d3ce232aab81e5e command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_48fb799a0eb442ed8b7c104619d91d86(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_48fb799a0eb442ed8b7c104619d91d86(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_48fb799a0eb442ed8b7c104619d91d86(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_48fb799a0eb442ed8b7c104619d91d86(_e896f05866b72d44a9d8a14ae0889cc5_48fb799a0eb442ed8b7c104619d91d86 command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_2146d10cdeab47668694d2afd12b868a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_2146d10cdeab47668694d2afd12b868a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_2146d10cdeab47668694d2afd12b868a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_2146d10cdeab47668694d2afd12b868a(_e896f05866b72d44a9d8a14ae0889cc5_2146d10cdeab47668694d2afd12b868a command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_6bc8b748778c48adaf31a5fcbacf47ce(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_6bc8b748778c48adaf31a5fcbacf47ce(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_6bc8b748778c48adaf31a5fcbacf47ce(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_6bc8b748778c48adaf31a5fcbacf47ce(_e896f05866b72d44a9d8a14ae0889cc5_6bc8b748778c48adaf31a5fcbacf47ce command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_d7ce06ddda42400ab457b028f2d48eef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_d7ce06ddda42400ab457b028f2d48eef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_d7ce06ddda42400ab457b028f2d48eef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_d7ce06ddda42400ab457b028f2d48eef(_e896f05866b72d44a9d8a14ae0889cc5_d7ce06ddda42400ab457b028f2d48eef command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_7d8a5c34365f49699121d9dc205e11ca(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_7d8a5c34365f49699121d9dc205e11ca(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_7d8a5c34365f49699121d9dc205e11ca(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_7d8a5c34365f49699121d9dc205e11ca(_e896f05866b72d44a9d8a14ae0889cc5_7d8a5c34365f49699121d9dc205e11ca command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_0d3a23bb154d449b9c62f2f47109b95c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_0d3a23bb154d449b9c62f2f47109b95c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_0d3a23bb154d449b9c62f2f47109b95c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_0d3a23bb154d449b9c62f2f47109b95c(_e896f05866b72d44a9d8a14ae0889cc5_0d3a23bb154d449b9c62f2f47109b95c command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_4c5d16c8c7ac4879b95b831e17a38964(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_4c5d16c8c7ac4879b95b831e17a38964(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_4c5d16c8c7ac4879b95b831e17a38964(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_4c5d16c8c7ac4879b95b831e17a38964(_e896f05866b72d44a9d8a14ae0889cc5_4c5d16c8c7ac4879b95b831e17a38964 command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_eb578d3cbfdb4d34900ede4847d2ba8c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_eb578d3cbfdb4d34900ede4847d2ba8c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_eb578d3cbfdb4d34900ede4847d2ba8c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_eb578d3cbfdb4d34900ede4847d2ba8c(_e896f05866b72d44a9d8a14ae0889cc5_eb578d3cbfdb4d34900ede4847d2ba8c command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_d583ee0c467f4cf6a17be8325dc8cece(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_d583ee0c467f4cf6a17be8325dc8cece(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_d583ee0c467f4cf6a17be8325dc8cece(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_d583ee0c467f4cf6a17be8325dc8cece(_e896f05866b72d44a9d8a14ae0889cc5_d583ee0c467f4cf6a17be8325dc8cece command)
		{
		}

		private void BakeCommandBinding__e896f05866b72d44a9d8a14ae0889cc5_e9a5abda90de4109a7e3602987ea51cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e896f05866b72d44a9d8a14ae0889cc5_e9a5abda90de4109a7e3602987ea51cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e896f05866b72d44a9d8a14ae0889cc5_e9a5abda90de4109a7e3602987ea51cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e896f05866b72d44a9d8a14ae0889cc5_e9a5abda90de4109a7e3602987ea51cb(_e896f05866b72d44a9d8a14ae0889cc5_e9a5abda90de4109a7e3602987ea51cb command)
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
