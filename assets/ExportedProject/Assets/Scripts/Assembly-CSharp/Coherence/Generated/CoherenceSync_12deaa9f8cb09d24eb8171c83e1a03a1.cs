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
	public class CoherenceSync_12deaa9f8cb09d24eb8171c83e1a03a1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_f464f630054e47ae95632ce8de4fe150_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_b0d36562908d4e379f6ff86e77eab673_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_ca4f18d31ef04cd3a4219a07f3af5756_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_62078cb9ffcc4c408664c75d237887bc_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_8a1f45e5ef6c42f6ade92d509fde6ad9_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_1abb9d27ef66424bbf73bb442a59561b_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_f5ce157e30744f1cbd59bb2998c813a2_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_349e0779502b4c14af21374a9dd911d9_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_8214f93c1b93432bb52297b38439a3fd_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_af64629ac1a8402daedfceedfecd431b_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_0ca5d09d068c45d7811a960dc970c5e7_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_78d8036b633545cda66865d800245cfb_CommandTarget;

		private CharacterController _12deaa9f8cb09d24eb8171c83e1a03a1_ff4baf9d60c04a76b7862d1af3db3959_CommandTarget;

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

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_f464f630054e47ae95632ce8de4fe150(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_f464f630054e47ae95632ce8de4fe150(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_f464f630054e47ae95632ce8de4fe150(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_f464f630054e47ae95632ce8de4fe150(_12deaa9f8cb09d24eb8171c83e1a03a1_f464f630054e47ae95632ce8de4fe150 command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_b0d36562908d4e379f6ff86e77eab673(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_b0d36562908d4e379f6ff86e77eab673(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_b0d36562908d4e379f6ff86e77eab673(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_b0d36562908d4e379f6ff86e77eab673(_12deaa9f8cb09d24eb8171c83e1a03a1_b0d36562908d4e379f6ff86e77eab673 command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_ca4f18d31ef04cd3a4219a07f3af5756(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_ca4f18d31ef04cd3a4219a07f3af5756(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_ca4f18d31ef04cd3a4219a07f3af5756(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_ca4f18d31ef04cd3a4219a07f3af5756(_12deaa9f8cb09d24eb8171c83e1a03a1_ca4f18d31ef04cd3a4219a07f3af5756 command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_62078cb9ffcc4c408664c75d237887bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_62078cb9ffcc4c408664c75d237887bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_62078cb9ffcc4c408664c75d237887bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_62078cb9ffcc4c408664c75d237887bc(_12deaa9f8cb09d24eb8171c83e1a03a1_62078cb9ffcc4c408664c75d237887bc command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_8a1f45e5ef6c42f6ade92d509fde6ad9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_8a1f45e5ef6c42f6ade92d509fde6ad9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_8a1f45e5ef6c42f6ade92d509fde6ad9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_8a1f45e5ef6c42f6ade92d509fde6ad9(_12deaa9f8cb09d24eb8171c83e1a03a1_8a1f45e5ef6c42f6ade92d509fde6ad9 command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_1abb9d27ef66424bbf73bb442a59561b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_1abb9d27ef66424bbf73bb442a59561b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_1abb9d27ef66424bbf73bb442a59561b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_1abb9d27ef66424bbf73bb442a59561b(_12deaa9f8cb09d24eb8171c83e1a03a1_1abb9d27ef66424bbf73bb442a59561b command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_f5ce157e30744f1cbd59bb2998c813a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_f5ce157e30744f1cbd59bb2998c813a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_f5ce157e30744f1cbd59bb2998c813a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_f5ce157e30744f1cbd59bb2998c813a2(_12deaa9f8cb09d24eb8171c83e1a03a1_f5ce157e30744f1cbd59bb2998c813a2 command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_349e0779502b4c14af21374a9dd911d9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_349e0779502b4c14af21374a9dd911d9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_349e0779502b4c14af21374a9dd911d9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_349e0779502b4c14af21374a9dd911d9(_12deaa9f8cb09d24eb8171c83e1a03a1_349e0779502b4c14af21374a9dd911d9 command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_8214f93c1b93432bb52297b38439a3fd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_8214f93c1b93432bb52297b38439a3fd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_8214f93c1b93432bb52297b38439a3fd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_8214f93c1b93432bb52297b38439a3fd(_12deaa9f8cb09d24eb8171c83e1a03a1_8214f93c1b93432bb52297b38439a3fd command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_af64629ac1a8402daedfceedfecd431b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_af64629ac1a8402daedfceedfecd431b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_af64629ac1a8402daedfceedfecd431b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_af64629ac1a8402daedfceedfecd431b(_12deaa9f8cb09d24eb8171c83e1a03a1_af64629ac1a8402daedfceedfecd431b command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_0ca5d09d068c45d7811a960dc970c5e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_0ca5d09d068c45d7811a960dc970c5e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_0ca5d09d068c45d7811a960dc970c5e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_0ca5d09d068c45d7811a960dc970c5e7(_12deaa9f8cb09d24eb8171c83e1a03a1_0ca5d09d068c45d7811a960dc970c5e7 command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_78d8036b633545cda66865d800245cfb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_78d8036b633545cda66865d800245cfb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_78d8036b633545cda66865d800245cfb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_78d8036b633545cda66865d800245cfb(_12deaa9f8cb09d24eb8171c83e1a03a1_78d8036b633545cda66865d800245cfb command)
		{
		}

		private void BakeCommandBinding__12deaa9f8cb09d24eb8171c83e1a03a1_ff4baf9d60c04a76b7862d1af3db3959(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__12deaa9f8cb09d24eb8171c83e1a03a1_ff4baf9d60c04a76b7862d1af3db3959(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__12deaa9f8cb09d24eb8171c83e1a03a1_ff4baf9d60c04a76b7862d1af3db3959(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__12deaa9f8cb09d24eb8171c83e1a03a1_ff4baf9d60c04a76b7862d1af3db3959(_12deaa9f8cb09d24eb8171c83e1a03a1_ff4baf9d60c04a76b7862d1af3db3959 command)
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
