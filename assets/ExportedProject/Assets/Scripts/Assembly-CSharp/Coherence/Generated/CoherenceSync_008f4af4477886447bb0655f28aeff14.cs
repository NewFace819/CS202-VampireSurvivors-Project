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
	public class CoherenceSync_008f4af4477886447bb0655f28aeff14 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _008f4af4477886447bb0655f28aeff14_f3a448b29c664682ad206db429e4b2bf_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_161896670d5e467f87f37ea343cd7127_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_ec90eed7fa164432b41d4fd96098ca51_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_e9a4c99fd8b148afa0403156a9ba418c_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_33ed91507ea94d2c92bc43aef6f22fa6_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_a3133220bffa4d07974eb9450f8a3c5e_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_2a0bf19592f54b9cb5c17d333673b4fd_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_461c540b94e94d43b748288091e7b460_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_85e479604e9c4b1e8c36c8c48ced16e3_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_de7eb8e9ea254ba6999121c72a3f4fbf_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_3a12d1e7f6a04c3baff761724d92f266_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_d7f135af86594a618d396cb0b9c6500f_CommandTarget;

		private CharacterController _008f4af4477886447bb0655f28aeff14_8ca5f1f7ed2540e5bc085ffb06fe3ae5_CommandTarget;

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

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_f3a448b29c664682ad206db429e4b2bf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_f3a448b29c664682ad206db429e4b2bf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_f3a448b29c664682ad206db429e4b2bf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_f3a448b29c664682ad206db429e4b2bf(_008f4af4477886447bb0655f28aeff14_f3a448b29c664682ad206db429e4b2bf command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_161896670d5e467f87f37ea343cd7127(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_161896670d5e467f87f37ea343cd7127(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_161896670d5e467f87f37ea343cd7127(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_161896670d5e467f87f37ea343cd7127(_008f4af4477886447bb0655f28aeff14_161896670d5e467f87f37ea343cd7127 command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_ec90eed7fa164432b41d4fd96098ca51(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_ec90eed7fa164432b41d4fd96098ca51(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_ec90eed7fa164432b41d4fd96098ca51(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_ec90eed7fa164432b41d4fd96098ca51(_008f4af4477886447bb0655f28aeff14_ec90eed7fa164432b41d4fd96098ca51 command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_e9a4c99fd8b148afa0403156a9ba418c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_e9a4c99fd8b148afa0403156a9ba418c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_e9a4c99fd8b148afa0403156a9ba418c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_e9a4c99fd8b148afa0403156a9ba418c(_008f4af4477886447bb0655f28aeff14_e9a4c99fd8b148afa0403156a9ba418c command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_33ed91507ea94d2c92bc43aef6f22fa6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_33ed91507ea94d2c92bc43aef6f22fa6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_33ed91507ea94d2c92bc43aef6f22fa6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_33ed91507ea94d2c92bc43aef6f22fa6(_008f4af4477886447bb0655f28aeff14_33ed91507ea94d2c92bc43aef6f22fa6 command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_a3133220bffa4d07974eb9450f8a3c5e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_a3133220bffa4d07974eb9450f8a3c5e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_a3133220bffa4d07974eb9450f8a3c5e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_a3133220bffa4d07974eb9450f8a3c5e(_008f4af4477886447bb0655f28aeff14_a3133220bffa4d07974eb9450f8a3c5e command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_2a0bf19592f54b9cb5c17d333673b4fd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_2a0bf19592f54b9cb5c17d333673b4fd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_2a0bf19592f54b9cb5c17d333673b4fd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_2a0bf19592f54b9cb5c17d333673b4fd(_008f4af4477886447bb0655f28aeff14_2a0bf19592f54b9cb5c17d333673b4fd command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_461c540b94e94d43b748288091e7b460(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_461c540b94e94d43b748288091e7b460(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_461c540b94e94d43b748288091e7b460(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_461c540b94e94d43b748288091e7b460(_008f4af4477886447bb0655f28aeff14_461c540b94e94d43b748288091e7b460 command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_85e479604e9c4b1e8c36c8c48ced16e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_85e479604e9c4b1e8c36c8c48ced16e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_85e479604e9c4b1e8c36c8c48ced16e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_85e479604e9c4b1e8c36c8c48ced16e3(_008f4af4477886447bb0655f28aeff14_85e479604e9c4b1e8c36c8c48ced16e3 command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_de7eb8e9ea254ba6999121c72a3f4fbf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_de7eb8e9ea254ba6999121c72a3f4fbf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_de7eb8e9ea254ba6999121c72a3f4fbf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_de7eb8e9ea254ba6999121c72a3f4fbf(_008f4af4477886447bb0655f28aeff14_de7eb8e9ea254ba6999121c72a3f4fbf command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_3a12d1e7f6a04c3baff761724d92f266(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_3a12d1e7f6a04c3baff761724d92f266(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_3a12d1e7f6a04c3baff761724d92f266(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_3a12d1e7f6a04c3baff761724d92f266(_008f4af4477886447bb0655f28aeff14_3a12d1e7f6a04c3baff761724d92f266 command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_d7f135af86594a618d396cb0b9c6500f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_d7f135af86594a618d396cb0b9c6500f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_d7f135af86594a618d396cb0b9c6500f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_d7f135af86594a618d396cb0b9c6500f(_008f4af4477886447bb0655f28aeff14_d7f135af86594a618d396cb0b9c6500f command)
		{
		}

		private void BakeCommandBinding__008f4af4477886447bb0655f28aeff14_8ca5f1f7ed2540e5bc085ffb06fe3ae5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__008f4af4477886447bb0655f28aeff14_8ca5f1f7ed2540e5bc085ffb06fe3ae5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__008f4af4477886447bb0655f28aeff14_8ca5f1f7ed2540e5bc085ffb06fe3ae5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__008f4af4477886447bb0655f28aeff14_8ca5f1f7ed2540e5bc085ffb06fe3ae5(_008f4af4477886447bb0655f28aeff14_8ca5f1f7ed2540e5bc085ffb06fe3ae5 command)
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
