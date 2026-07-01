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
	public class CoherenceSync_af6505b3805b9c5449b68712394f0392 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _af6505b3805b9c5449b68712394f0392_2fc811ebfed8485b98cab30002ee40ee_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_f93c5c006cb14977ac5d9b593b36b564_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_11a5047c2b5e4168b4205ea024fdcd82_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_9f7b29b490c14dc592d6f5589c388354_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_24e5edf4fcb64166b2e1e098bad79f19_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_7c96677859e34631888737afb27fb1d9_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_cd1f66cb6ac84c34acf409bae7408d56_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_c05ad187057f4e47a6e376e2359529d3_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_8866cc864e384142b7254a9d90ca7c1c_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_324dd545c35c475ca556ade21b2cec0b_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_96b86239a7904b4198ad436a549d1b24_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_8798193a4bd644a18552960ea364f14e_CommandTarget;

		private CharacterController _af6505b3805b9c5449b68712394f0392_5e01aea0767e47b6b761bb630daaea6c_CommandTarget;

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

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_2fc811ebfed8485b98cab30002ee40ee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_2fc811ebfed8485b98cab30002ee40ee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_2fc811ebfed8485b98cab30002ee40ee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_2fc811ebfed8485b98cab30002ee40ee(_af6505b3805b9c5449b68712394f0392_2fc811ebfed8485b98cab30002ee40ee command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_f93c5c006cb14977ac5d9b593b36b564(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_f93c5c006cb14977ac5d9b593b36b564(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_f93c5c006cb14977ac5d9b593b36b564(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_f93c5c006cb14977ac5d9b593b36b564(_af6505b3805b9c5449b68712394f0392_f93c5c006cb14977ac5d9b593b36b564 command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_11a5047c2b5e4168b4205ea024fdcd82(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_11a5047c2b5e4168b4205ea024fdcd82(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_11a5047c2b5e4168b4205ea024fdcd82(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_11a5047c2b5e4168b4205ea024fdcd82(_af6505b3805b9c5449b68712394f0392_11a5047c2b5e4168b4205ea024fdcd82 command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_9f7b29b490c14dc592d6f5589c388354(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_9f7b29b490c14dc592d6f5589c388354(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_9f7b29b490c14dc592d6f5589c388354(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_9f7b29b490c14dc592d6f5589c388354(_af6505b3805b9c5449b68712394f0392_9f7b29b490c14dc592d6f5589c388354 command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_24e5edf4fcb64166b2e1e098bad79f19(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_24e5edf4fcb64166b2e1e098bad79f19(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_24e5edf4fcb64166b2e1e098bad79f19(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_24e5edf4fcb64166b2e1e098bad79f19(_af6505b3805b9c5449b68712394f0392_24e5edf4fcb64166b2e1e098bad79f19 command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_7c96677859e34631888737afb27fb1d9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_7c96677859e34631888737afb27fb1d9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_7c96677859e34631888737afb27fb1d9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_7c96677859e34631888737afb27fb1d9(_af6505b3805b9c5449b68712394f0392_7c96677859e34631888737afb27fb1d9 command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_cd1f66cb6ac84c34acf409bae7408d56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_cd1f66cb6ac84c34acf409bae7408d56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_cd1f66cb6ac84c34acf409bae7408d56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_cd1f66cb6ac84c34acf409bae7408d56(_af6505b3805b9c5449b68712394f0392_cd1f66cb6ac84c34acf409bae7408d56 command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_c05ad187057f4e47a6e376e2359529d3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_c05ad187057f4e47a6e376e2359529d3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_c05ad187057f4e47a6e376e2359529d3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_c05ad187057f4e47a6e376e2359529d3(_af6505b3805b9c5449b68712394f0392_c05ad187057f4e47a6e376e2359529d3 command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_8866cc864e384142b7254a9d90ca7c1c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_8866cc864e384142b7254a9d90ca7c1c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_8866cc864e384142b7254a9d90ca7c1c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_8866cc864e384142b7254a9d90ca7c1c(_af6505b3805b9c5449b68712394f0392_8866cc864e384142b7254a9d90ca7c1c command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_324dd545c35c475ca556ade21b2cec0b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_324dd545c35c475ca556ade21b2cec0b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_324dd545c35c475ca556ade21b2cec0b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_324dd545c35c475ca556ade21b2cec0b(_af6505b3805b9c5449b68712394f0392_324dd545c35c475ca556ade21b2cec0b command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_96b86239a7904b4198ad436a549d1b24(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_96b86239a7904b4198ad436a549d1b24(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_96b86239a7904b4198ad436a549d1b24(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_96b86239a7904b4198ad436a549d1b24(_af6505b3805b9c5449b68712394f0392_96b86239a7904b4198ad436a549d1b24 command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_8798193a4bd644a18552960ea364f14e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_8798193a4bd644a18552960ea364f14e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_8798193a4bd644a18552960ea364f14e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_8798193a4bd644a18552960ea364f14e(_af6505b3805b9c5449b68712394f0392_8798193a4bd644a18552960ea364f14e command)
		{
		}

		private void BakeCommandBinding__af6505b3805b9c5449b68712394f0392_5e01aea0767e47b6b761bb630daaea6c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__af6505b3805b9c5449b68712394f0392_5e01aea0767e47b6b761bb630daaea6c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__af6505b3805b9c5449b68712394f0392_5e01aea0767e47b6b761bb630daaea6c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__af6505b3805b9c5449b68712394f0392_5e01aea0767e47b6b761bb630daaea6c(_af6505b3805b9c5449b68712394f0392_5e01aea0767e47b6b761bb630daaea6c command)
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
