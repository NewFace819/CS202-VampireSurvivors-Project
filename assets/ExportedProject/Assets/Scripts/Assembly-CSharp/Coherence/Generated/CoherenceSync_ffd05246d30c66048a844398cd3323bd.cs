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
	public class CoherenceSync_ffd05246d30c66048a844398cd3323bd : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_307e125121b247bd9e17d26592792d35_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_6dbebc626ddd4dc593e9c141a435eaaf_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_7c40c939cf924ff68131fe8d13299095_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_2b0a3ef9c5094190b75b85dac8b81788_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_86f495087b3b4a50968f3cafb95c8e16_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_538521e732f04ea5a4f55cfde8d5b98c_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_b871f0e584cc45858134d4a4911b9152_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_9517f6ccea1d43c2a8e060a35da19599_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_e115d6a41bf44e859a61d98e15e5e965_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_6f66315e1cbf40d69e4cd412af739fae_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_29b99295c3594c078886f6656fb74db8_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_4d6952af94c54f7fa988b6fff57fc486_CommandTarget;

		private CharacterController _ffd05246d30c66048a844398cd3323bd_ab8442db44e04d7a869059fde3bcf920_CommandTarget;

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

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_307e125121b247bd9e17d26592792d35(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_307e125121b247bd9e17d26592792d35(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_307e125121b247bd9e17d26592792d35(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_307e125121b247bd9e17d26592792d35(_ffd05246d30c66048a844398cd3323bd_307e125121b247bd9e17d26592792d35 command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_6dbebc626ddd4dc593e9c141a435eaaf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_6dbebc626ddd4dc593e9c141a435eaaf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_6dbebc626ddd4dc593e9c141a435eaaf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_6dbebc626ddd4dc593e9c141a435eaaf(_ffd05246d30c66048a844398cd3323bd_6dbebc626ddd4dc593e9c141a435eaaf command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_7c40c939cf924ff68131fe8d13299095(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_7c40c939cf924ff68131fe8d13299095(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_7c40c939cf924ff68131fe8d13299095(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_7c40c939cf924ff68131fe8d13299095(_ffd05246d30c66048a844398cd3323bd_7c40c939cf924ff68131fe8d13299095 command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_2b0a3ef9c5094190b75b85dac8b81788(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_2b0a3ef9c5094190b75b85dac8b81788(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_2b0a3ef9c5094190b75b85dac8b81788(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_2b0a3ef9c5094190b75b85dac8b81788(_ffd05246d30c66048a844398cd3323bd_2b0a3ef9c5094190b75b85dac8b81788 command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_86f495087b3b4a50968f3cafb95c8e16(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_86f495087b3b4a50968f3cafb95c8e16(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_86f495087b3b4a50968f3cafb95c8e16(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_86f495087b3b4a50968f3cafb95c8e16(_ffd05246d30c66048a844398cd3323bd_86f495087b3b4a50968f3cafb95c8e16 command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_538521e732f04ea5a4f55cfde8d5b98c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_538521e732f04ea5a4f55cfde8d5b98c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_538521e732f04ea5a4f55cfde8d5b98c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_538521e732f04ea5a4f55cfde8d5b98c(_ffd05246d30c66048a844398cd3323bd_538521e732f04ea5a4f55cfde8d5b98c command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_b871f0e584cc45858134d4a4911b9152(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_b871f0e584cc45858134d4a4911b9152(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_b871f0e584cc45858134d4a4911b9152(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_b871f0e584cc45858134d4a4911b9152(_ffd05246d30c66048a844398cd3323bd_b871f0e584cc45858134d4a4911b9152 command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_9517f6ccea1d43c2a8e060a35da19599(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_9517f6ccea1d43c2a8e060a35da19599(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_9517f6ccea1d43c2a8e060a35da19599(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_9517f6ccea1d43c2a8e060a35da19599(_ffd05246d30c66048a844398cd3323bd_9517f6ccea1d43c2a8e060a35da19599 command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_e115d6a41bf44e859a61d98e15e5e965(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_e115d6a41bf44e859a61d98e15e5e965(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_e115d6a41bf44e859a61d98e15e5e965(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_e115d6a41bf44e859a61d98e15e5e965(_ffd05246d30c66048a844398cd3323bd_e115d6a41bf44e859a61d98e15e5e965 command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_6f66315e1cbf40d69e4cd412af739fae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_6f66315e1cbf40d69e4cd412af739fae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_6f66315e1cbf40d69e4cd412af739fae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_6f66315e1cbf40d69e4cd412af739fae(_ffd05246d30c66048a844398cd3323bd_6f66315e1cbf40d69e4cd412af739fae command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_29b99295c3594c078886f6656fb74db8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_29b99295c3594c078886f6656fb74db8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_29b99295c3594c078886f6656fb74db8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_29b99295c3594c078886f6656fb74db8(_ffd05246d30c66048a844398cd3323bd_29b99295c3594c078886f6656fb74db8 command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_4d6952af94c54f7fa988b6fff57fc486(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_4d6952af94c54f7fa988b6fff57fc486(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_4d6952af94c54f7fa988b6fff57fc486(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_4d6952af94c54f7fa988b6fff57fc486(_ffd05246d30c66048a844398cd3323bd_4d6952af94c54f7fa988b6fff57fc486 command)
		{
		}

		private void BakeCommandBinding__ffd05246d30c66048a844398cd3323bd_ab8442db44e04d7a869059fde3bcf920(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ffd05246d30c66048a844398cd3323bd_ab8442db44e04d7a869059fde3bcf920(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ffd05246d30c66048a844398cd3323bd_ab8442db44e04d7a869059fde3bcf920(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ffd05246d30c66048a844398cd3323bd_ab8442db44e04d7a869059fde3bcf920(_ffd05246d30c66048a844398cd3323bd_ab8442db44e04d7a869059fde3bcf920 command)
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
