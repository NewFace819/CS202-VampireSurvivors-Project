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
	public class CoherenceSync_27957485854eab745b350504d6a22aa1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _27957485854eab745b350504d6a22aa1_2a971236110a4921955ca2ff2d09749f_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_37f12632ac084654a4302b660e8c8685_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_0abf1ea15af14c979681ac6f86210a24_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_fec355a5a97448e5a881626291b6c422_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_85e58510eb1a4bfcb456f91ed49a3cbc_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_6f497a34e25f483f920cf9edc852877f_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_a9bd2da3b67b4965b8bc012df00d6f0c_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_bbb0b2be67f64da89ed3afd9ed1fe83d_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_09ce826fee72482581de56ca74192b5d_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_2cc2be894564496eb16417ee566bc367_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_9deba89e0783450ab01896d99a4c0777_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_9e341f171f174fac92888e0da0fb4003_CommandTarget;

		private CharacterController _27957485854eab745b350504d6a22aa1_89afd2ec58924d4294e7174b23408478_CommandTarget;

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

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_2a971236110a4921955ca2ff2d09749f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_2a971236110a4921955ca2ff2d09749f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_2a971236110a4921955ca2ff2d09749f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_2a971236110a4921955ca2ff2d09749f(_27957485854eab745b350504d6a22aa1_2a971236110a4921955ca2ff2d09749f command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_37f12632ac084654a4302b660e8c8685(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_37f12632ac084654a4302b660e8c8685(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_37f12632ac084654a4302b660e8c8685(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_37f12632ac084654a4302b660e8c8685(_27957485854eab745b350504d6a22aa1_37f12632ac084654a4302b660e8c8685 command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_0abf1ea15af14c979681ac6f86210a24(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_0abf1ea15af14c979681ac6f86210a24(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_0abf1ea15af14c979681ac6f86210a24(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_0abf1ea15af14c979681ac6f86210a24(_27957485854eab745b350504d6a22aa1_0abf1ea15af14c979681ac6f86210a24 command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_fec355a5a97448e5a881626291b6c422(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_fec355a5a97448e5a881626291b6c422(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_fec355a5a97448e5a881626291b6c422(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_fec355a5a97448e5a881626291b6c422(_27957485854eab745b350504d6a22aa1_fec355a5a97448e5a881626291b6c422 command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_85e58510eb1a4bfcb456f91ed49a3cbc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_85e58510eb1a4bfcb456f91ed49a3cbc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_85e58510eb1a4bfcb456f91ed49a3cbc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_85e58510eb1a4bfcb456f91ed49a3cbc(_27957485854eab745b350504d6a22aa1_85e58510eb1a4bfcb456f91ed49a3cbc command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_6f497a34e25f483f920cf9edc852877f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_6f497a34e25f483f920cf9edc852877f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_6f497a34e25f483f920cf9edc852877f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_6f497a34e25f483f920cf9edc852877f(_27957485854eab745b350504d6a22aa1_6f497a34e25f483f920cf9edc852877f command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_a9bd2da3b67b4965b8bc012df00d6f0c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_a9bd2da3b67b4965b8bc012df00d6f0c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_a9bd2da3b67b4965b8bc012df00d6f0c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_a9bd2da3b67b4965b8bc012df00d6f0c(_27957485854eab745b350504d6a22aa1_a9bd2da3b67b4965b8bc012df00d6f0c command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_bbb0b2be67f64da89ed3afd9ed1fe83d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_bbb0b2be67f64da89ed3afd9ed1fe83d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_bbb0b2be67f64da89ed3afd9ed1fe83d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_bbb0b2be67f64da89ed3afd9ed1fe83d(_27957485854eab745b350504d6a22aa1_bbb0b2be67f64da89ed3afd9ed1fe83d command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_09ce826fee72482581de56ca74192b5d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_09ce826fee72482581de56ca74192b5d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_09ce826fee72482581de56ca74192b5d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_09ce826fee72482581de56ca74192b5d(_27957485854eab745b350504d6a22aa1_09ce826fee72482581de56ca74192b5d command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_2cc2be894564496eb16417ee566bc367(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_2cc2be894564496eb16417ee566bc367(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_2cc2be894564496eb16417ee566bc367(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_2cc2be894564496eb16417ee566bc367(_27957485854eab745b350504d6a22aa1_2cc2be894564496eb16417ee566bc367 command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_9deba89e0783450ab01896d99a4c0777(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_9deba89e0783450ab01896d99a4c0777(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_9deba89e0783450ab01896d99a4c0777(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_9deba89e0783450ab01896d99a4c0777(_27957485854eab745b350504d6a22aa1_9deba89e0783450ab01896d99a4c0777 command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_9e341f171f174fac92888e0da0fb4003(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_9e341f171f174fac92888e0da0fb4003(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_9e341f171f174fac92888e0da0fb4003(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_9e341f171f174fac92888e0da0fb4003(_27957485854eab745b350504d6a22aa1_9e341f171f174fac92888e0da0fb4003 command)
		{
		}

		private void BakeCommandBinding__27957485854eab745b350504d6a22aa1_89afd2ec58924d4294e7174b23408478(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__27957485854eab745b350504d6a22aa1_89afd2ec58924d4294e7174b23408478(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__27957485854eab745b350504d6a22aa1_89afd2ec58924d4294e7174b23408478(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__27957485854eab745b350504d6a22aa1_89afd2ec58924d4294e7174b23408478(_27957485854eab745b350504d6a22aa1_89afd2ec58924d4294e7174b23408478 command)
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
