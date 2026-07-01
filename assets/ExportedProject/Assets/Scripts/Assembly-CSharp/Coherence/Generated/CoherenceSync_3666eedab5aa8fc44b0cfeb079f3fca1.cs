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
	public class CoherenceSync_3666eedab5aa8fc44b0cfeb079f3fca1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_93b30b949dfa4aa9b322da8107080450_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_d55b25e5c4684893b3b28e5baaf6b360_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_c42538aa8ffe41c695986ccd45307711_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_fa65b9c723784d808009b9dca9fb941b_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_e4dec170d6e844bdb8cc4c7a0079a27f_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_6015e9171c7344b7ab125fe934e26656_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_8a559f157c694f908e49aa0b35f98d88_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_53d335d1dc844e1f9f72eacb2a144697_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_29bbe08744f94311ad938a1f64c6f2dc_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_376c80fca5e1452497717d25613a0237_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_4152b934ab0046febe9f1774ebc68180_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_2e6644e0b73f4e4bba765f6b7811db76_CommandTarget;

		private CharacterController _3666eedab5aa8fc44b0cfeb079f3fca1_5c5d3c2acd474f7ab91fdd08a22594f2_CommandTarget;

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

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_93b30b949dfa4aa9b322da8107080450(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_93b30b949dfa4aa9b322da8107080450(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_93b30b949dfa4aa9b322da8107080450(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_93b30b949dfa4aa9b322da8107080450(_3666eedab5aa8fc44b0cfeb079f3fca1_93b30b949dfa4aa9b322da8107080450 command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_d55b25e5c4684893b3b28e5baaf6b360(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_d55b25e5c4684893b3b28e5baaf6b360(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_d55b25e5c4684893b3b28e5baaf6b360(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_d55b25e5c4684893b3b28e5baaf6b360(_3666eedab5aa8fc44b0cfeb079f3fca1_d55b25e5c4684893b3b28e5baaf6b360 command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_c42538aa8ffe41c695986ccd45307711(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_c42538aa8ffe41c695986ccd45307711(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_c42538aa8ffe41c695986ccd45307711(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_c42538aa8ffe41c695986ccd45307711(_3666eedab5aa8fc44b0cfeb079f3fca1_c42538aa8ffe41c695986ccd45307711 command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_fa65b9c723784d808009b9dca9fb941b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_fa65b9c723784d808009b9dca9fb941b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_fa65b9c723784d808009b9dca9fb941b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_fa65b9c723784d808009b9dca9fb941b(_3666eedab5aa8fc44b0cfeb079f3fca1_fa65b9c723784d808009b9dca9fb941b command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_e4dec170d6e844bdb8cc4c7a0079a27f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_e4dec170d6e844bdb8cc4c7a0079a27f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_e4dec170d6e844bdb8cc4c7a0079a27f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_e4dec170d6e844bdb8cc4c7a0079a27f(_3666eedab5aa8fc44b0cfeb079f3fca1_e4dec170d6e844bdb8cc4c7a0079a27f command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_6015e9171c7344b7ab125fe934e26656(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_6015e9171c7344b7ab125fe934e26656(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_6015e9171c7344b7ab125fe934e26656(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_6015e9171c7344b7ab125fe934e26656(_3666eedab5aa8fc44b0cfeb079f3fca1_6015e9171c7344b7ab125fe934e26656 command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_8a559f157c694f908e49aa0b35f98d88(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_8a559f157c694f908e49aa0b35f98d88(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_8a559f157c694f908e49aa0b35f98d88(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_8a559f157c694f908e49aa0b35f98d88(_3666eedab5aa8fc44b0cfeb079f3fca1_8a559f157c694f908e49aa0b35f98d88 command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_53d335d1dc844e1f9f72eacb2a144697(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_53d335d1dc844e1f9f72eacb2a144697(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_53d335d1dc844e1f9f72eacb2a144697(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_53d335d1dc844e1f9f72eacb2a144697(_3666eedab5aa8fc44b0cfeb079f3fca1_53d335d1dc844e1f9f72eacb2a144697 command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_29bbe08744f94311ad938a1f64c6f2dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_29bbe08744f94311ad938a1f64c6f2dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_29bbe08744f94311ad938a1f64c6f2dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_29bbe08744f94311ad938a1f64c6f2dc(_3666eedab5aa8fc44b0cfeb079f3fca1_29bbe08744f94311ad938a1f64c6f2dc command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_376c80fca5e1452497717d25613a0237(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_376c80fca5e1452497717d25613a0237(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_376c80fca5e1452497717d25613a0237(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_376c80fca5e1452497717d25613a0237(_3666eedab5aa8fc44b0cfeb079f3fca1_376c80fca5e1452497717d25613a0237 command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_4152b934ab0046febe9f1774ebc68180(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_4152b934ab0046febe9f1774ebc68180(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_4152b934ab0046febe9f1774ebc68180(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_4152b934ab0046febe9f1774ebc68180(_3666eedab5aa8fc44b0cfeb079f3fca1_4152b934ab0046febe9f1774ebc68180 command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_2e6644e0b73f4e4bba765f6b7811db76(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_2e6644e0b73f4e4bba765f6b7811db76(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_2e6644e0b73f4e4bba765f6b7811db76(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_2e6644e0b73f4e4bba765f6b7811db76(_3666eedab5aa8fc44b0cfeb079f3fca1_2e6644e0b73f4e4bba765f6b7811db76 command)
		{
		}

		private void BakeCommandBinding__3666eedab5aa8fc44b0cfeb079f3fca1_5c5d3c2acd474f7ab91fdd08a22594f2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__3666eedab5aa8fc44b0cfeb079f3fca1_5c5d3c2acd474f7ab91fdd08a22594f2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__3666eedab5aa8fc44b0cfeb079f3fca1_5c5d3c2acd474f7ab91fdd08a22594f2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__3666eedab5aa8fc44b0cfeb079f3fca1_5c5d3c2acd474f7ab91fdd08a22594f2(_3666eedab5aa8fc44b0cfeb079f3fca1_5c5d3c2acd474f7ab91fdd08a22594f2 command)
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
