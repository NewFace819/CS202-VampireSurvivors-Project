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
	public class CoherenceSync_7aaf6f4f1903dee4495405c75567fedc : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_e36726697b0548a08c02739d9e576ebf_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_4cbeb1676bc949d380d9b63032507161_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_82e67830815e437892f0aad47eb2a092_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_5dfc9b3fb3784ac2a1d9e39ac6aded73_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_593cde707ccf40cdb0779b3c6c27c3aa_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_06c4a67a449946b6a016ff4802f5b8c6_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_61c8b0cafd84401e9c93e9d96037b46d_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_ca1c3cbb237c4ad9b7e7e1f948edf847_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_ff7294442a57421d95f2cbb5dccea20f_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_1ad18eb28f16459c9e917915c85d52d6_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_e70ab0a146aa4fb3b00fee2e660f31fc_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_feec0b34a4e243a3b2590697c9f21464_CommandTarget;

		private CharacterController _7aaf6f4f1903dee4495405c75567fedc_828f5fa7846d4c7cb2b5f0ec8f079672_CommandTarget;

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

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_e36726697b0548a08c02739d9e576ebf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_e36726697b0548a08c02739d9e576ebf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_e36726697b0548a08c02739d9e576ebf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_e36726697b0548a08c02739d9e576ebf(_7aaf6f4f1903dee4495405c75567fedc_e36726697b0548a08c02739d9e576ebf command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_4cbeb1676bc949d380d9b63032507161(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_4cbeb1676bc949d380d9b63032507161(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_4cbeb1676bc949d380d9b63032507161(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_4cbeb1676bc949d380d9b63032507161(_7aaf6f4f1903dee4495405c75567fedc_4cbeb1676bc949d380d9b63032507161 command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_82e67830815e437892f0aad47eb2a092(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_82e67830815e437892f0aad47eb2a092(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_82e67830815e437892f0aad47eb2a092(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_82e67830815e437892f0aad47eb2a092(_7aaf6f4f1903dee4495405c75567fedc_82e67830815e437892f0aad47eb2a092 command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_5dfc9b3fb3784ac2a1d9e39ac6aded73(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_5dfc9b3fb3784ac2a1d9e39ac6aded73(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_5dfc9b3fb3784ac2a1d9e39ac6aded73(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_5dfc9b3fb3784ac2a1d9e39ac6aded73(_7aaf6f4f1903dee4495405c75567fedc_5dfc9b3fb3784ac2a1d9e39ac6aded73 command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_593cde707ccf40cdb0779b3c6c27c3aa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_593cde707ccf40cdb0779b3c6c27c3aa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_593cde707ccf40cdb0779b3c6c27c3aa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_593cde707ccf40cdb0779b3c6c27c3aa(_7aaf6f4f1903dee4495405c75567fedc_593cde707ccf40cdb0779b3c6c27c3aa command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_06c4a67a449946b6a016ff4802f5b8c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_06c4a67a449946b6a016ff4802f5b8c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_06c4a67a449946b6a016ff4802f5b8c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_06c4a67a449946b6a016ff4802f5b8c6(_7aaf6f4f1903dee4495405c75567fedc_06c4a67a449946b6a016ff4802f5b8c6 command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_61c8b0cafd84401e9c93e9d96037b46d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_61c8b0cafd84401e9c93e9d96037b46d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_61c8b0cafd84401e9c93e9d96037b46d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_61c8b0cafd84401e9c93e9d96037b46d(_7aaf6f4f1903dee4495405c75567fedc_61c8b0cafd84401e9c93e9d96037b46d command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_ca1c3cbb237c4ad9b7e7e1f948edf847(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_ca1c3cbb237c4ad9b7e7e1f948edf847(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_ca1c3cbb237c4ad9b7e7e1f948edf847(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_ca1c3cbb237c4ad9b7e7e1f948edf847(_7aaf6f4f1903dee4495405c75567fedc_ca1c3cbb237c4ad9b7e7e1f948edf847 command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_ff7294442a57421d95f2cbb5dccea20f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_ff7294442a57421d95f2cbb5dccea20f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_ff7294442a57421d95f2cbb5dccea20f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_ff7294442a57421d95f2cbb5dccea20f(_7aaf6f4f1903dee4495405c75567fedc_ff7294442a57421d95f2cbb5dccea20f command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_1ad18eb28f16459c9e917915c85d52d6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_1ad18eb28f16459c9e917915c85d52d6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_1ad18eb28f16459c9e917915c85d52d6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_1ad18eb28f16459c9e917915c85d52d6(_7aaf6f4f1903dee4495405c75567fedc_1ad18eb28f16459c9e917915c85d52d6 command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_e70ab0a146aa4fb3b00fee2e660f31fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_e70ab0a146aa4fb3b00fee2e660f31fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_e70ab0a146aa4fb3b00fee2e660f31fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_e70ab0a146aa4fb3b00fee2e660f31fc(_7aaf6f4f1903dee4495405c75567fedc_e70ab0a146aa4fb3b00fee2e660f31fc command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_feec0b34a4e243a3b2590697c9f21464(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_feec0b34a4e243a3b2590697c9f21464(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_feec0b34a4e243a3b2590697c9f21464(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_feec0b34a4e243a3b2590697c9f21464(_7aaf6f4f1903dee4495405c75567fedc_feec0b34a4e243a3b2590697c9f21464 command)
		{
		}

		private void BakeCommandBinding__7aaf6f4f1903dee4495405c75567fedc_828f5fa7846d4c7cb2b5f0ec8f079672(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7aaf6f4f1903dee4495405c75567fedc_828f5fa7846d4c7cb2b5f0ec8f079672(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7aaf6f4f1903dee4495405c75567fedc_828f5fa7846d4c7cb2b5f0ec8f079672(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7aaf6f4f1903dee4495405c75567fedc_828f5fa7846d4c7cb2b5f0ec8f079672(_7aaf6f4f1903dee4495405c75567fedc_828f5fa7846d4c7cb2b5f0ec8f079672 command)
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
