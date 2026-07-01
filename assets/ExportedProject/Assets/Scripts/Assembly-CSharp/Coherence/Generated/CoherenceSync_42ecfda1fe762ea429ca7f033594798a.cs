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
	public class CoherenceSync_42ecfda1fe762ea429ca7f033594798a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_6819c994d2d347b281ddf54010e2262b_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_0848172b012c4c609d22b090e67040bc_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_b43a6d1300be455a89b991af546b65b8_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_31bc21296205424b850939883207a584_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_a072f07cc56a45a39ad98a3c4d8c8ab6_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_e7fe1254b5ed49eeafc71224d5b7c494_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_b4589a7d69de4c0e9f387da0d41cd834_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_34910a9c9f69462ca64ff32091552141_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_dacb695e943d41cab3d5d87be9bc0804_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_7ed4385ff3b24e35aba401f807279958_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_bb3e0a4bd0924272888130f8a2ce601b_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_5f93d3b046b2423ca1d1b63d3a4c611d_CommandTarget;

		private CharacterController _42ecfda1fe762ea429ca7f033594798a_e4f29e07d18f45eeb095dec24caaafdf_CommandTarget;

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

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_6819c994d2d347b281ddf54010e2262b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_6819c994d2d347b281ddf54010e2262b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_6819c994d2d347b281ddf54010e2262b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_6819c994d2d347b281ddf54010e2262b(_42ecfda1fe762ea429ca7f033594798a_6819c994d2d347b281ddf54010e2262b command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_0848172b012c4c609d22b090e67040bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_0848172b012c4c609d22b090e67040bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_0848172b012c4c609d22b090e67040bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_0848172b012c4c609d22b090e67040bc(_42ecfda1fe762ea429ca7f033594798a_0848172b012c4c609d22b090e67040bc command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_b43a6d1300be455a89b991af546b65b8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_b43a6d1300be455a89b991af546b65b8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_b43a6d1300be455a89b991af546b65b8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_b43a6d1300be455a89b991af546b65b8(_42ecfda1fe762ea429ca7f033594798a_b43a6d1300be455a89b991af546b65b8 command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_31bc21296205424b850939883207a584(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_31bc21296205424b850939883207a584(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_31bc21296205424b850939883207a584(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_31bc21296205424b850939883207a584(_42ecfda1fe762ea429ca7f033594798a_31bc21296205424b850939883207a584 command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_a072f07cc56a45a39ad98a3c4d8c8ab6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_a072f07cc56a45a39ad98a3c4d8c8ab6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_a072f07cc56a45a39ad98a3c4d8c8ab6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_a072f07cc56a45a39ad98a3c4d8c8ab6(_42ecfda1fe762ea429ca7f033594798a_a072f07cc56a45a39ad98a3c4d8c8ab6 command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_e7fe1254b5ed49eeafc71224d5b7c494(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_e7fe1254b5ed49eeafc71224d5b7c494(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_e7fe1254b5ed49eeafc71224d5b7c494(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_e7fe1254b5ed49eeafc71224d5b7c494(_42ecfda1fe762ea429ca7f033594798a_e7fe1254b5ed49eeafc71224d5b7c494 command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_b4589a7d69de4c0e9f387da0d41cd834(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_b4589a7d69de4c0e9f387da0d41cd834(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_b4589a7d69de4c0e9f387da0d41cd834(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_b4589a7d69de4c0e9f387da0d41cd834(_42ecfda1fe762ea429ca7f033594798a_b4589a7d69de4c0e9f387da0d41cd834 command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_34910a9c9f69462ca64ff32091552141(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_34910a9c9f69462ca64ff32091552141(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_34910a9c9f69462ca64ff32091552141(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_34910a9c9f69462ca64ff32091552141(_42ecfda1fe762ea429ca7f033594798a_34910a9c9f69462ca64ff32091552141 command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_dacb695e943d41cab3d5d87be9bc0804(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_dacb695e943d41cab3d5d87be9bc0804(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_dacb695e943d41cab3d5d87be9bc0804(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_dacb695e943d41cab3d5d87be9bc0804(_42ecfda1fe762ea429ca7f033594798a_dacb695e943d41cab3d5d87be9bc0804 command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_7ed4385ff3b24e35aba401f807279958(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_7ed4385ff3b24e35aba401f807279958(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_7ed4385ff3b24e35aba401f807279958(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_7ed4385ff3b24e35aba401f807279958(_42ecfda1fe762ea429ca7f033594798a_7ed4385ff3b24e35aba401f807279958 command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_bb3e0a4bd0924272888130f8a2ce601b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_bb3e0a4bd0924272888130f8a2ce601b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_bb3e0a4bd0924272888130f8a2ce601b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_bb3e0a4bd0924272888130f8a2ce601b(_42ecfda1fe762ea429ca7f033594798a_bb3e0a4bd0924272888130f8a2ce601b command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_5f93d3b046b2423ca1d1b63d3a4c611d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_5f93d3b046b2423ca1d1b63d3a4c611d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_5f93d3b046b2423ca1d1b63d3a4c611d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_5f93d3b046b2423ca1d1b63d3a4c611d(_42ecfda1fe762ea429ca7f033594798a_5f93d3b046b2423ca1d1b63d3a4c611d command)
		{
		}

		private void BakeCommandBinding__42ecfda1fe762ea429ca7f033594798a_e4f29e07d18f45eeb095dec24caaafdf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42ecfda1fe762ea429ca7f033594798a_e4f29e07d18f45eeb095dec24caaafdf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42ecfda1fe762ea429ca7f033594798a_e4f29e07d18f45eeb095dec24caaafdf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42ecfda1fe762ea429ca7f033594798a_e4f29e07d18f45eeb095dec24caaafdf(_42ecfda1fe762ea429ca7f033594798a_e4f29e07d18f45eeb095dec24caaafdf command)
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
