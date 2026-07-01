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
	public class CoherenceSync_2e752b2d75b3fb0409ac1c6f0166bc09 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_016059c38a2348feb65126e9794b7e57_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_0043debf05384c05ba230d86649a5e90_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_ee82c333152e4b1db338c9781a3c5240_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_b6b4e5679ef04ba68f99a59a8002fd98_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_01a63aa5caf048e796d086535444b264_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_b09f15d193c745a2a1a5d329b0fa3bc6_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_419c8d7f59824f398f50837d23c6c3fb_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_0d63986170094af88a7ca011acf5b8f8_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_6dc67c7b2a964085956ddba9881da60f_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_6aaeb960915e49d3bbdd79832361f51a_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_217f232db56e4962885165e582914694_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_a638bfca958c417eb10e3427e19ef533_CommandTarget;

		private CharacterController _2e752b2d75b3fb0409ac1c6f0166bc09_b86a0d5f92bf48e388e1e22f4999afb2_CommandTarget;

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

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_016059c38a2348feb65126e9794b7e57(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_016059c38a2348feb65126e9794b7e57(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_016059c38a2348feb65126e9794b7e57(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_016059c38a2348feb65126e9794b7e57(_2e752b2d75b3fb0409ac1c6f0166bc09_016059c38a2348feb65126e9794b7e57 command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_0043debf05384c05ba230d86649a5e90(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_0043debf05384c05ba230d86649a5e90(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_0043debf05384c05ba230d86649a5e90(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_0043debf05384c05ba230d86649a5e90(_2e752b2d75b3fb0409ac1c6f0166bc09_0043debf05384c05ba230d86649a5e90 command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_ee82c333152e4b1db338c9781a3c5240(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_ee82c333152e4b1db338c9781a3c5240(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_ee82c333152e4b1db338c9781a3c5240(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_ee82c333152e4b1db338c9781a3c5240(_2e752b2d75b3fb0409ac1c6f0166bc09_ee82c333152e4b1db338c9781a3c5240 command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_b6b4e5679ef04ba68f99a59a8002fd98(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_b6b4e5679ef04ba68f99a59a8002fd98(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_b6b4e5679ef04ba68f99a59a8002fd98(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_b6b4e5679ef04ba68f99a59a8002fd98(_2e752b2d75b3fb0409ac1c6f0166bc09_b6b4e5679ef04ba68f99a59a8002fd98 command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_01a63aa5caf048e796d086535444b264(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_01a63aa5caf048e796d086535444b264(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_01a63aa5caf048e796d086535444b264(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_01a63aa5caf048e796d086535444b264(_2e752b2d75b3fb0409ac1c6f0166bc09_01a63aa5caf048e796d086535444b264 command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_b09f15d193c745a2a1a5d329b0fa3bc6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_b09f15d193c745a2a1a5d329b0fa3bc6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_b09f15d193c745a2a1a5d329b0fa3bc6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_b09f15d193c745a2a1a5d329b0fa3bc6(_2e752b2d75b3fb0409ac1c6f0166bc09_b09f15d193c745a2a1a5d329b0fa3bc6 command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_419c8d7f59824f398f50837d23c6c3fb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_419c8d7f59824f398f50837d23c6c3fb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_419c8d7f59824f398f50837d23c6c3fb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_419c8d7f59824f398f50837d23c6c3fb(_2e752b2d75b3fb0409ac1c6f0166bc09_419c8d7f59824f398f50837d23c6c3fb command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_0d63986170094af88a7ca011acf5b8f8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_0d63986170094af88a7ca011acf5b8f8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_0d63986170094af88a7ca011acf5b8f8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_0d63986170094af88a7ca011acf5b8f8(_2e752b2d75b3fb0409ac1c6f0166bc09_0d63986170094af88a7ca011acf5b8f8 command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_6dc67c7b2a964085956ddba9881da60f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_6dc67c7b2a964085956ddba9881da60f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_6dc67c7b2a964085956ddba9881da60f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_6dc67c7b2a964085956ddba9881da60f(_2e752b2d75b3fb0409ac1c6f0166bc09_6dc67c7b2a964085956ddba9881da60f command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_6aaeb960915e49d3bbdd79832361f51a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_6aaeb960915e49d3bbdd79832361f51a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_6aaeb960915e49d3bbdd79832361f51a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_6aaeb960915e49d3bbdd79832361f51a(_2e752b2d75b3fb0409ac1c6f0166bc09_6aaeb960915e49d3bbdd79832361f51a command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_217f232db56e4962885165e582914694(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_217f232db56e4962885165e582914694(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_217f232db56e4962885165e582914694(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_217f232db56e4962885165e582914694(_2e752b2d75b3fb0409ac1c6f0166bc09_217f232db56e4962885165e582914694 command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_a638bfca958c417eb10e3427e19ef533(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_a638bfca958c417eb10e3427e19ef533(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_a638bfca958c417eb10e3427e19ef533(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_a638bfca958c417eb10e3427e19ef533(_2e752b2d75b3fb0409ac1c6f0166bc09_a638bfca958c417eb10e3427e19ef533 command)
		{
		}

		private void BakeCommandBinding__2e752b2d75b3fb0409ac1c6f0166bc09_b86a0d5f92bf48e388e1e22f4999afb2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2e752b2d75b3fb0409ac1c6f0166bc09_b86a0d5f92bf48e388e1e22f4999afb2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2e752b2d75b3fb0409ac1c6f0166bc09_b86a0d5f92bf48e388e1e22f4999afb2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2e752b2d75b3fb0409ac1c6f0166bc09_b86a0d5f92bf48e388e1e22f4999afb2(_2e752b2d75b3fb0409ac1c6f0166bc09_b86a0d5f92bf48e388e1e22f4999afb2 command)
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
