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
	public class CoherenceSync_c22c3fd5d45b3b642b2f24482a1ca643 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_df355cf5464d490099d8f1706a47fa05_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_fb5c47a93829419dae7339cf9cff8d71_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_3cf4ce854fc245b9aa3c361a49988ee0_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_b99cedf693034aa58643258787f33a37_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_0bc82414ffae4ea4a03449efce0ab6ca_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_b48fcf624af34814849c3327b997569b_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_b7e3b9ed822e49a69d3ea2b15c23a5dd_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_1296132c53e6462a863a08dbb42deeb5_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_b31360b267ab48a1a820e6c039d1aaf8_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_94f25f89b35b4cae89f67de4962e4a9b_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_fd3b740e65944c61a2aae841680696cb_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_1b6842eb93f6471989a5ed19394bac8e_CommandTarget;

		private CharacterController _c22c3fd5d45b3b642b2f24482a1ca643_1036bf95578e4f35a6cc5c657820fecc_CommandTarget;

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

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_df355cf5464d490099d8f1706a47fa05(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_df355cf5464d490099d8f1706a47fa05(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_df355cf5464d490099d8f1706a47fa05(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_df355cf5464d490099d8f1706a47fa05(_c22c3fd5d45b3b642b2f24482a1ca643_df355cf5464d490099d8f1706a47fa05 command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_fb5c47a93829419dae7339cf9cff8d71(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_fb5c47a93829419dae7339cf9cff8d71(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_fb5c47a93829419dae7339cf9cff8d71(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_fb5c47a93829419dae7339cf9cff8d71(_c22c3fd5d45b3b642b2f24482a1ca643_fb5c47a93829419dae7339cf9cff8d71 command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_3cf4ce854fc245b9aa3c361a49988ee0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_3cf4ce854fc245b9aa3c361a49988ee0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_3cf4ce854fc245b9aa3c361a49988ee0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_3cf4ce854fc245b9aa3c361a49988ee0(_c22c3fd5d45b3b642b2f24482a1ca643_3cf4ce854fc245b9aa3c361a49988ee0 command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_b99cedf693034aa58643258787f33a37(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_b99cedf693034aa58643258787f33a37(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_b99cedf693034aa58643258787f33a37(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_b99cedf693034aa58643258787f33a37(_c22c3fd5d45b3b642b2f24482a1ca643_b99cedf693034aa58643258787f33a37 command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_0bc82414ffae4ea4a03449efce0ab6ca(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_0bc82414ffae4ea4a03449efce0ab6ca(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_0bc82414ffae4ea4a03449efce0ab6ca(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_0bc82414ffae4ea4a03449efce0ab6ca(_c22c3fd5d45b3b642b2f24482a1ca643_0bc82414ffae4ea4a03449efce0ab6ca command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_b48fcf624af34814849c3327b997569b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_b48fcf624af34814849c3327b997569b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_b48fcf624af34814849c3327b997569b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_b48fcf624af34814849c3327b997569b(_c22c3fd5d45b3b642b2f24482a1ca643_b48fcf624af34814849c3327b997569b command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_b7e3b9ed822e49a69d3ea2b15c23a5dd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_b7e3b9ed822e49a69d3ea2b15c23a5dd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_b7e3b9ed822e49a69d3ea2b15c23a5dd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_b7e3b9ed822e49a69d3ea2b15c23a5dd(_c22c3fd5d45b3b642b2f24482a1ca643_b7e3b9ed822e49a69d3ea2b15c23a5dd command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_1296132c53e6462a863a08dbb42deeb5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_1296132c53e6462a863a08dbb42deeb5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_1296132c53e6462a863a08dbb42deeb5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_1296132c53e6462a863a08dbb42deeb5(_c22c3fd5d45b3b642b2f24482a1ca643_1296132c53e6462a863a08dbb42deeb5 command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_b31360b267ab48a1a820e6c039d1aaf8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_b31360b267ab48a1a820e6c039d1aaf8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_b31360b267ab48a1a820e6c039d1aaf8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_b31360b267ab48a1a820e6c039d1aaf8(_c22c3fd5d45b3b642b2f24482a1ca643_b31360b267ab48a1a820e6c039d1aaf8 command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_94f25f89b35b4cae89f67de4962e4a9b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_94f25f89b35b4cae89f67de4962e4a9b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_94f25f89b35b4cae89f67de4962e4a9b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_94f25f89b35b4cae89f67de4962e4a9b(_c22c3fd5d45b3b642b2f24482a1ca643_94f25f89b35b4cae89f67de4962e4a9b command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_fd3b740e65944c61a2aae841680696cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_fd3b740e65944c61a2aae841680696cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_fd3b740e65944c61a2aae841680696cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_fd3b740e65944c61a2aae841680696cb(_c22c3fd5d45b3b642b2f24482a1ca643_fd3b740e65944c61a2aae841680696cb command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_1b6842eb93f6471989a5ed19394bac8e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_1b6842eb93f6471989a5ed19394bac8e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_1b6842eb93f6471989a5ed19394bac8e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_1b6842eb93f6471989a5ed19394bac8e(_c22c3fd5d45b3b642b2f24482a1ca643_1b6842eb93f6471989a5ed19394bac8e command)
		{
		}

		private void BakeCommandBinding__c22c3fd5d45b3b642b2f24482a1ca643_1036bf95578e4f35a6cc5c657820fecc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c22c3fd5d45b3b642b2f24482a1ca643_1036bf95578e4f35a6cc5c657820fecc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c22c3fd5d45b3b642b2f24482a1ca643_1036bf95578e4f35a6cc5c657820fecc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c22c3fd5d45b3b642b2f24482a1ca643_1036bf95578e4f35a6cc5c657820fecc(_c22c3fd5d45b3b642b2f24482a1ca643_1036bf95578e4f35a6cc5c657820fecc command)
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
