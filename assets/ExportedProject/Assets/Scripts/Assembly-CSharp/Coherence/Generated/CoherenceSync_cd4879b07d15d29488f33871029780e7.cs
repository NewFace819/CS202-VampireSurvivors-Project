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
	public class CoherenceSync_cd4879b07d15d29488f33871029780e7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _cd4879b07d15d29488f33871029780e7_a34c63ea3f824c8f98f9fc556fb27057_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_d8ab00928d5e43ad84068854b1966d87_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_e2619b7dc76f41a28f7792231f0b43b1_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_ad25898062e04b6bb712f0946c26517d_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_6e4fc20a37aa4dd1863c42f34c29a440_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_a268320d5e9c484487ceb5b8baa09b1f_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_423115eb55dc486aa0ca921c1732e214_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_ecee25ebaac4464585566c1b171a1039_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_5dd4f0a6317848cc9c969e2006a43c43_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_20f74e9713024910842847e3ac5ab24d_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_34d37e90af0a4736b491449c3b427b17_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_73c818615f48437e8169555977274ae0_CommandTarget;

		private CharacterController _cd4879b07d15d29488f33871029780e7_b78738640f8a4237929eed31eeea841f_CommandTarget;

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

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_a34c63ea3f824c8f98f9fc556fb27057(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_a34c63ea3f824c8f98f9fc556fb27057(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_a34c63ea3f824c8f98f9fc556fb27057(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_a34c63ea3f824c8f98f9fc556fb27057(_cd4879b07d15d29488f33871029780e7_a34c63ea3f824c8f98f9fc556fb27057 command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_d8ab00928d5e43ad84068854b1966d87(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_d8ab00928d5e43ad84068854b1966d87(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_d8ab00928d5e43ad84068854b1966d87(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_d8ab00928d5e43ad84068854b1966d87(_cd4879b07d15d29488f33871029780e7_d8ab00928d5e43ad84068854b1966d87 command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_e2619b7dc76f41a28f7792231f0b43b1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_e2619b7dc76f41a28f7792231f0b43b1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_e2619b7dc76f41a28f7792231f0b43b1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_e2619b7dc76f41a28f7792231f0b43b1(_cd4879b07d15d29488f33871029780e7_e2619b7dc76f41a28f7792231f0b43b1 command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_ad25898062e04b6bb712f0946c26517d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_ad25898062e04b6bb712f0946c26517d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_ad25898062e04b6bb712f0946c26517d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_ad25898062e04b6bb712f0946c26517d(_cd4879b07d15d29488f33871029780e7_ad25898062e04b6bb712f0946c26517d command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_6e4fc20a37aa4dd1863c42f34c29a440(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_6e4fc20a37aa4dd1863c42f34c29a440(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_6e4fc20a37aa4dd1863c42f34c29a440(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_6e4fc20a37aa4dd1863c42f34c29a440(_cd4879b07d15d29488f33871029780e7_6e4fc20a37aa4dd1863c42f34c29a440 command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_a268320d5e9c484487ceb5b8baa09b1f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_a268320d5e9c484487ceb5b8baa09b1f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_a268320d5e9c484487ceb5b8baa09b1f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_a268320d5e9c484487ceb5b8baa09b1f(_cd4879b07d15d29488f33871029780e7_a268320d5e9c484487ceb5b8baa09b1f command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_423115eb55dc486aa0ca921c1732e214(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_423115eb55dc486aa0ca921c1732e214(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_423115eb55dc486aa0ca921c1732e214(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_423115eb55dc486aa0ca921c1732e214(_cd4879b07d15d29488f33871029780e7_423115eb55dc486aa0ca921c1732e214 command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_ecee25ebaac4464585566c1b171a1039(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_ecee25ebaac4464585566c1b171a1039(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_ecee25ebaac4464585566c1b171a1039(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_ecee25ebaac4464585566c1b171a1039(_cd4879b07d15d29488f33871029780e7_ecee25ebaac4464585566c1b171a1039 command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_5dd4f0a6317848cc9c969e2006a43c43(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_5dd4f0a6317848cc9c969e2006a43c43(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_5dd4f0a6317848cc9c969e2006a43c43(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_5dd4f0a6317848cc9c969e2006a43c43(_cd4879b07d15d29488f33871029780e7_5dd4f0a6317848cc9c969e2006a43c43 command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_20f74e9713024910842847e3ac5ab24d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_20f74e9713024910842847e3ac5ab24d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_20f74e9713024910842847e3ac5ab24d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_20f74e9713024910842847e3ac5ab24d(_cd4879b07d15d29488f33871029780e7_20f74e9713024910842847e3ac5ab24d command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_34d37e90af0a4736b491449c3b427b17(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_34d37e90af0a4736b491449c3b427b17(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_34d37e90af0a4736b491449c3b427b17(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_34d37e90af0a4736b491449c3b427b17(_cd4879b07d15d29488f33871029780e7_34d37e90af0a4736b491449c3b427b17 command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_73c818615f48437e8169555977274ae0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_73c818615f48437e8169555977274ae0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_73c818615f48437e8169555977274ae0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_73c818615f48437e8169555977274ae0(_cd4879b07d15d29488f33871029780e7_73c818615f48437e8169555977274ae0 command)
		{
		}

		private void BakeCommandBinding__cd4879b07d15d29488f33871029780e7_b78738640f8a4237929eed31eeea841f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cd4879b07d15d29488f33871029780e7_b78738640f8a4237929eed31eeea841f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cd4879b07d15d29488f33871029780e7_b78738640f8a4237929eed31eeea841f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cd4879b07d15d29488f33871029780e7_b78738640f8a4237929eed31eeea841f(_cd4879b07d15d29488f33871029780e7_b78738640f8a4237929eed31eeea841f command)
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
