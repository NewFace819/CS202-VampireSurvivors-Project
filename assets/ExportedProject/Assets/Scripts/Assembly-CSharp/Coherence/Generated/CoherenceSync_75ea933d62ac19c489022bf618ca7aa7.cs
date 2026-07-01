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
	public class CoherenceSync_75ea933d62ac19c489022bf618ca7aa7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_47137a9ae190403886ae8ab3ad800bf5_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_810288517c444e019234b808af18fb04_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_d95e335bb845441d8ebb2828127330c6_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_7f8db548583a40178e219fc9a0e8c472_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_2203d71a1109458d9b6901591d844bab_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_e8b3eb2e16324418bbbb526f5eeb5315_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_60ac38d4102349b1b88dbe70fe209747_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_2e969a921ab046c29e6d5668f15c84ba_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_8940fd9663e14f88bfe1ea03d6ec67fe_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_20a175818840490aba4c133cf2de26ed_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_23e36d8644bb4ca3a22f4ca1d7b1e9e3_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_b5d7ad683f794992be167c8cd87ded2b_CommandTarget;

		private CharacterController _75ea933d62ac19c489022bf618ca7aa7_c58260ff2da04cf5952f35dfa3115b24_CommandTarget;

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

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_47137a9ae190403886ae8ab3ad800bf5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_47137a9ae190403886ae8ab3ad800bf5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_47137a9ae190403886ae8ab3ad800bf5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_47137a9ae190403886ae8ab3ad800bf5(_75ea933d62ac19c489022bf618ca7aa7_47137a9ae190403886ae8ab3ad800bf5 command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_810288517c444e019234b808af18fb04(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_810288517c444e019234b808af18fb04(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_810288517c444e019234b808af18fb04(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_810288517c444e019234b808af18fb04(_75ea933d62ac19c489022bf618ca7aa7_810288517c444e019234b808af18fb04 command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_d95e335bb845441d8ebb2828127330c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_d95e335bb845441d8ebb2828127330c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_d95e335bb845441d8ebb2828127330c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_d95e335bb845441d8ebb2828127330c6(_75ea933d62ac19c489022bf618ca7aa7_d95e335bb845441d8ebb2828127330c6 command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_7f8db548583a40178e219fc9a0e8c472(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_7f8db548583a40178e219fc9a0e8c472(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_7f8db548583a40178e219fc9a0e8c472(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_7f8db548583a40178e219fc9a0e8c472(_75ea933d62ac19c489022bf618ca7aa7_7f8db548583a40178e219fc9a0e8c472 command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_2203d71a1109458d9b6901591d844bab(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_2203d71a1109458d9b6901591d844bab(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_2203d71a1109458d9b6901591d844bab(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_2203d71a1109458d9b6901591d844bab(_75ea933d62ac19c489022bf618ca7aa7_2203d71a1109458d9b6901591d844bab command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_e8b3eb2e16324418bbbb526f5eeb5315(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_e8b3eb2e16324418bbbb526f5eeb5315(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_e8b3eb2e16324418bbbb526f5eeb5315(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_e8b3eb2e16324418bbbb526f5eeb5315(_75ea933d62ac19c489022bf618ca7aa7_e8b3eb2e16324418bbbb526f5eeb5315 command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_60ac38d4102349b1b88dbe70fe209747(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_60ac38d4102349b1b88dbe70fe209747(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_60ac38d4102349b1b88dbe70fe209747(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_60ac38d4102349b1b88dbe70fe209747(_75ea933d62ac19c489022bf618ca7aa7_60ac38d4102349b1b88dbe70fe209747 command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_2e969a921ab046c29e6d5668f15c84ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_2e969a921ab046c29e6d5668f15c84ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_2e969a921ab046c29e6d5668f15c84ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_2e969a921ab046c29e6d5668f15c84ba(_75ea933d62ac19c489022bf618ca7aa7_2e969a921ab046c29e6d5668f15c84ba command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_8940fd9663e14f88bfe1ea03d6ec67fe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_8940fd9663e14f88bfe1ea03d6ec67fe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_8940fd9663e14f88bfe1ea03d6ec67fe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_8940fd9663e14f88bfe1ea03d6ec67fe(_75ea933d62ac19c489022bf618ca7aa7_8940fd9663e14f88bfe1ea03d6ec67fe command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_20a175818840490aba4c133cf2de26ed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_20a175818840490aba4c133cf2de26ed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_20a175818840490aba4c133cf2de26ed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_20a175818840490aba4c133cf2de26ed(_75ea933d62ac19c489022bf618ca7aa7_20a175818840490aba4c133cf2de26ed command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_23e36d8644bb4ca3a22f4ca1d7b1e9e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_23e36d8644bb4ca3a22f4ca1d7b1e9e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_23e36d8644bb4ca3a22f4ca1d7b1e9e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_23e36d8644bb4ca3a22f4ca1d7b1e9e3(_75ea933d62ac19c489022bf618ca7aa7_23e36d8644bb4ca3a22f4ca1d7b1e9e3 command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_b5d7ad683f794992be167c8cd87ded2b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_b5d7ad683f794992be167c8cd87ded2b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_b5d7ad683f794992be167c8cd87ded2b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_b5d7ad683f794992be167c8cd87ded2b(_75ea933d62ac19c489022bf618ca7aa7_b5d7ad683f794992be167c8cd87ded2b command)
		{
		}

		private void BakeCommandBinding__75ea933d62ac19c489022bf618ca7aa7_c58260ff2da04cf5952f35dfa3115b24(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__75ea933d62ac19c489022bf618ca7aa7_c58260ff2da04cf5952f35dfa3115b24(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__75ea933d62ac19c489022bf618ca7aa7_c58260ff2da04cf5952f35dfa3115b24(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__75ea933d62ac19c489022bf618ca7aa7_c58260ff2da04cf5952f35dfa3115b24(_75ea933d62ac19c489022bf618ca7aa7_c58260ff2da04cf5952f35dfa3115b24 command)
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
