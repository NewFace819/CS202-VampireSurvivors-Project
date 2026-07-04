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
	public class CoherenceSync_6c7370e1a1cb09243a87e36c01eb5f91 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_3f6463faf7df4339870a0b033132ef27_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_cc789c9f1b3a4d1ea09d49b949169d2c_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_0d21d9c0c2824e87a54466fd17ef7ed8_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_6630aecb32264388af40262f9a55a3b1_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_3179a955ac4f45078fd0d0dc263912c2_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_0a4911d100a24d2c82be0a6332a0af4b_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_298759c74d73430db549dc313f2975ef_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_93db36c7b152474bbb84f294186cd310_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_928ab77a48304eefaaebec08bc3d36e7_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_3de50a7eb737421c8578de963ce3f92b_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_5ffbb482684249378db0e5331da578c5_CommandTarget;

		private TP_Elizabeth_Character _6c7370e1a1cb09243a87e36c01eb5f91_453f7d2bbfc342deb96898c1cedd4a1d_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_3f45578e53594b32bc1c10058158c065_CommandTarget;

		private CharacterController _6c7370e1a1cb09243a87e36c01eb5f91_a43e764f7b6540aaa78a52cf40f3eb44_CommandTarget;

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

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_3f6463faf7df4339870a0b033132ef27(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_3f6463faf7df4339870a0b033132ef27(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_3f6463faf7df4339870a0b033132ef27(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_3f6463faf7df4339870a0b033132ef27(_6c7370e1a1cb09243a87e36c01eb5f91_3f6463faf7df4339870a0b033132ef27 command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_cc789c9f1b3a4d1ea09d49b949169d2c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_cc789c9f1b3a4d1ea09d49b949169d2c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_cc789c9f1b3a4d1ea09d49b949169d2c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_cc789c9f1b3a4d1ea09d49b949169d2c(_6c7370e1a1cb09243a87e36c01eb5f91_cc789c9f1b3a4d1ea09d49b949169d2c command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_0d21d9c0c2824e87a54466fd17ef7ed8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_0d21d9c0c2824e87a54466fd17ef7ed8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_0d21d9c0c2824e87a54466fd17ef7ed8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_0d21d9c0c2824e87a54466fd17ef7ed8(_6c7370e1a1cb09243a87e36c01eb5f91_0d21d9c0c2824e87a54466fd17ef7ed8 command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_6630aecb32264388af40262f9a55a3b1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_6630aecb32264388af40262f9a55a3b1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_6630aecb32264388af40262f9a55a3b1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_6630aecb32264388af40262f9a55a3b1(_6c7370e1a1cb09243a87e36c01eb5f91_6630aecb32264388af40262f9a55a3b1 command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_3179a955ac4f45078fd0d0dc263912c2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_3179a955ac4f45078fd0d0dc263912c2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_3179a955ac4f45078fd0d0dc263912c2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_3179a955ac4f45078fd0d0dc263912c2(_6c7370e1a1cb09243a87e36c01eb5f91_3179a955ac4f45078fd0d0dc263912c2 command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_0a4911d100a24d2c82be0a6332a0af4b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_0a4911d100a24d2c82be0a6332a0af4b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_0a4911d100a24d2c82be0a6332a0af4b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_0a4911d100a24d2c82be0a6332a0af4b(_6c7370e1a1cb09243a87e36c01eb5f91_0a4911d100a24d2c82be0a6332a0af4b command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_298759c74d73430db549dc313f2975ef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_298759c74d73430db549dc313f2975ef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_298759c74d73430db549dc313f2975ef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_298759c74d73430db549dc313f2975ef(_6c7370e1a1cb09243a87e36c01eb5f91_298759c74d73430db549dc313f2975ef command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_93db36c7b152474bbb84f294186cd310(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_93db36c7b152474bbb84f294186cd310(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_93db36c7b152474bbb84f294186cd310(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_93db36c7b152474bbb84f294186cd310(_6c7370e1a1cb09243a87e36c01eb5f91_93db36c7b152474bbb84f294186cd310 command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_928ab77a48304eefaaebec08bc3d36e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_928ab77a48304eefaaebec08bc3d36e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_928ab77a48304eefaaebec08bc3d36e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_928ab77a48304eefaaebec08bc3d36e7(_6c7370e1a1cb09243a87e36c01eb5f91_928ab77a48304eefaaebec08bc3d36e7 command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_3de50a7eb737421c8578de963ce3f92b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_3de50a7eb737421c8578de963ce3f92b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_3de50a7eb737421c8578de963ce3f92b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_3de50a7eb737421c8578de963ce3f92b(_6c7370e1a1cb09243a87e36c01eb5f91_3de50a7eb737421c8578de963ce3f92b command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_5ffbb482684249378db0e5331da578c5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_5ffbb482684249378db0e5331da578c5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_5ffbb482684249378db0e5331da578c5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_5ffbb482684249378db0e5331da578c5(_6c7370e1a1cb09243a87e36c01eb5f91_5ffbb482684249378db0e5331da578c5 command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_453f7d2bbfc342deb96898c1cedd4a1d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_453f7d2bbfc342deb96898c1cedd4a1d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_453f7d2bbfc342deb96898c1cedd4a1d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_453f7d2bbfc342deb96898c1cedd4a1d(_6c7370e1a1cb09243a87e36c01eb5f91_453f7d2bbfc342deb96898c1cedd4a1d command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_3f45578e53594b32bc1c10058158c065(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_3f45578e53594b32bc1c10058158c065(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_3f45578e53594b32bc1c10058158c065(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_3f45578e53594b32bc1c10058158c065(_6c7370e1a1cb09243a87e36c01eb5f91_3f45578e53594b32bc1c10058158c065 command)
		{
		}

		private void BakeCommandBinding__6c7370e1a1cb09243a87e36c01eb5f91_a43e764f7b6540aaa78a52cf40f3eb44(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6c7370e1a1cb09243a87e36c01eb5f91_a43e764f7b6540aaa78a52cf40f3eb44(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6c7370e1a1cb09243a87e36c01eb5f91_a43e764f7b6540aaa78a52cf40f3eb44(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6c7370e1a1cb09243a87e36c01eb5f91_a43e764f7b6540aaa78a52cf40f3eb44(_6c7370e1a1cb09243a87e36c01eb5f91_a43e764f7b6540aaa78a52cf40f3eb44 command)
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
