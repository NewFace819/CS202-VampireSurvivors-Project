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
	public class CoherenceSync_c51d7260f424aea42985eda3bc6495f9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_dbe7e22fd55e4f719b84181a9441fd1d_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_85a3185577ff45bdbd69a30e0555d5e6_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_bfd20e99c0d54ee6ad19e885a6496704_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_256a0f6a2f8549e3bd295a89b3191a35_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_42de18d1022340ff98e4ca3edac05377_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_929a23e0804d461891771b3f12acf0cb_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_b414b415147d45a4a12b3b44e6f6770e_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_f3c33ca52135459aa2eced346da9007a_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_95f13004bdfe42fc9d13f15bbac17cf8_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_58f010af5bac42beab75e48730ab8673_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_05db46c8362748d08290ae23a84c6a55_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_be476f52f0c04f38a9f362ad73ff8970_CommandTarget;

		private CharacterController _c51d7260f424aea42985eda3bc6495f9_d8f7ec520606461eb5a644b5201d96a2_CommandTarget;

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

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_dbe7e22fd55e4f719b84181a9441fd1d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_dbe7e22fd55e4f719b84181a9441fd1d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_dbe7e22fd55e4f719b84181a9441fd1d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_dbe7e22fd55e4f719b84181a9441fd1d(_c51d7260f424aea42985eda3bc6495f9_dbe7e22fd55e4f719b84181a9441fd1d command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_85a3185577ff45bdbd69a30e0555d5e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_85a3185577ff45bdbd69a30e0555d5e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_85a3185577ff45bdbd69a30e0555d5e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_85a3185577ff45bdbd69a30e0555d5e6(_c51d7260f424aea42985eda3bc6495f9_85a3185577ff45bdbd69a30e0555d5e6 command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_bfd20e99c0d54ee6ad19e885a6496704(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_bfd20e99c0d54ee6ad19e885a6496704(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_bfd20e99c0d54ee6ad19e885a6496704(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_bfd20e99c0d54ee6ad19e885a6496704(_c51d7260f424aea42985eda3bc6495f9_bfd20e99c0d54ee6ad19e885a6496704 command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_256a0f6a2f8549e3bd295a89b3191a35(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_256a0f6a2f8549e3bd295a89b3191a35(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_256a0f6a2f8549e3bd295a89b3191a35(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_256a0f6a2f8549e3bd295a89b3191a35(_c51d7260f424aea42985eda3bc6495f9_256a0f6a2f8549e3bd295a89b3191a35 command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_42de18d1022340ff98e4ca3edac05377(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_42de18d1022340ff98e4ca3edac05377(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_42de18d1022340ff98e4ca3edac05377(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_42de18d1022340ff98e4ca3edac05377(_c51d7260f424aea42985eda3bc6495f9_42de18d1022340ff98e4ca3edac05377 command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_929a23e0804d461891771b3f12acf0cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_929a23e0804d461891771b3f12acf0cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_929a23e0804d461891771b3f12acf0cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_929a23e0804d461891771b3f12acf0cb(_c51d7260f424aea42985eda3bc6495f9_929a23e0804d461891771b3f12acf0cb command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_b414b415147d45a4a12b3b44e6f6770e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_b414b415147d45a4a12b3b44e6f6770e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_b414b415147d45a4a12b3b44e6f6770e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_b414b415147d45a4a12b3b44e6f6770e(_c51d7260f424aea42985eda3bc6495f9_b414b415147d45a4a12b3b44e6f6770e command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_f3c33ca52135459aa2eced346da9007a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_f3c33ca52135459aa2eced346da9007a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_f3c33ca52135459aa2eced346da9007a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_f3c33ca52135459aa2eced346da9007a(_c51d7260f424aea42985eda3bc6495f9_f3c33ca52135459aa2eced346da9007a command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_95f13004bdfe42fc9d13f15bbac17cf8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_95f13004bdfe42fc9d13f15bbac17cf8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_95f13004bdfe42fc9d13f15bbac17cf8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_95f13004bdfe42fc9d13f15bbac17cf8(_c51d7260f424aea42985eda3bc6495f9_95f13004bdfe42fc9d13f15bbac17cf8 command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_58f010af5bac42beab75e48730ab8673(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_58f010af5bac42beab75e48730ab8673(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_58f010af5bac42beab75e48730ab8673(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_58f010af5bac42beab75e48730ab8673(_c51d7260f424aea42985eda3bc6495f9_58f010af5bac42beab75e48730ab8673 command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_05db46c8362748d08290ae23a84c6a55(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_05db46c8362748d08290ae23a84c6a55(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_05db46c8362748d08290ae23a84c6a55(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_05db46c8362748d08290ae23a84c6a55(_c51d7260f424aea42985eda3bc6495f9_05db46c8362748d08290ae23a84c6a55 command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_be476f52f0c04f38a9f362ad73ff8970(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_be476f52f0c04f38a9f362ad73ff8970(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_be476f52f0c04f38a9f362ad73ff8970(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_be476f52f0c04f38a9f362ad73ff8970(_c51d7260f424aea42985eda3bc6495f9_be476f52f0c04f38a9f362ad73ff8970 command)
		{
		}

		private void BakeCommandBinding__c51d7260f424aea42985eda3bc6495f9_d8f7ec520606461eb5a644b5201d96a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c51d7260f424aea42985eda3bc6495f9_d8f7ec520606461eb5a644b5201d96a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c51d7260f424aea42985eda3bc6495f9_d8f7ec520606461eb5a644b5201d96a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c51d7260f424aea42985eda3bc6495f9_d8f7ec520606461eb5a644b5201d96a2(_c51d7260f424aea42985eda3bc6495f9_d8f7ec520606461eb5a644b5201d96a2 command)
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
