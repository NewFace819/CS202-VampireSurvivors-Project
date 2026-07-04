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
	public class CoherenceSync_ec21cdaeffd11af429156db0dbd36e5c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_c63fe8e4296743dc8b67d8bc62a979ec_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_07ec94fc55934757a9b7615e78addcc1_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_de3eb3f5c5d9431caa24fc32392f6423_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_6fe3d2dd4752416eaec8bee449d233fb_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_093eca73ee3b41f18c6d400ff6b30d94_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_d435c4eaf62f48a89c4e86411fcf0425_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_5e71357d7521440f9c89c05a240b6191_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_454bb53884e94de99a14c31f283bdf8b_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_437b5aec72e44acfbff4fbcbbfb27a66_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_e41981d9e6a949b2b26fee0060f03eb6_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_c2b5557b5ec34ef5bb0f6f72c2e372a9_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_0df2fd90e8214b12933631bbb2b71cd9_CommandTarget;

		private CharacterController _ec21cdaeffd11af429156db0dbd36e5c_b6118325bac946749b0d04715696db23_CommandTarget;

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

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_c63fe8e4296743dc8b67d8bc62a979ec(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_c63fe8e4296743dc8b67d8bc62a979ec(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_c63fe8e4296743dc8b67d8bc62a979ec(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_c63fe8e4296743dc8b67d8bc62a979ec(_ec21cdaeffd11af429156db0dbd36e5c_c63fe8e4296743dc8b67d8bc62a979ec command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_07ec94fc55934757a9b7615e78addcc1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_07ec94fc55934757a9b7615e78addcc1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_07ec94fc55934757a9b7615e78addcc1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_07ec94fc55934757a9b7615e78addcc1(_ec21cdaeffd11af429156db0dbd36e5c_07ec94fc55934757a9b7615e78addcc1 command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_de3eb3f5c5d9431caa24fc32392f6423(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_de3eb3f5c5d9431caa24fc32392f6423(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_de3eb3f5c5d9431caa24fc32392f6423(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_de3eb3f5c5d9431caa24fc32392f6423(_ec21cdaeffd11af429156db0dbd36e5c_de3eb3f5c5d9431caa24fc32392f6423 command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_6fe3d2dd4752416eaec8bee449d233fb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_6fe3d2dd4752416eaec8bee449d233fb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_6fe3d2dd4752416eaec8bee449d233fb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_6fe3d2dd4752416eaec8bee449d233fb(_ec21cdaeffd11af429156db0dbd36e5c_6fe3d2dd4752416eaec8bee449d233fb command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_093eca73ee3b41f18c6d400ff6b30d94(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_093eca73ee3b41f18c6d400ff6b30d94(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_093eca73ee3b41f18c6d400ff6b30d94(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_093eca73ee3b41f18c6d400ff6b30d94(_ec21cdaeffd11af429156db0dbd36e5c_093eca73ee3b41f18c6d400ff6b30d94 command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_d435c4eaf62f48a89c4e86411fcf0425(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_d435c4eaf62f48a89c4e86411fcf0425(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_d435c4eaf62f48a89c4e86411fcf0425(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_d435c4eaf62f48a89c4e86411fcf0425(_ec21cdaeffd11af429156db0dbd36e5c_d435c4eaf62f48a89c4e86411fcf0425 command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_5e71357d7521440f9c89c05a240b6191(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_5e71357d7521440f9c89c05a240b6191(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_5e71357d7521440f9c89c05a240b6191(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_5e71357d7521440f9c89c05a240b6191(_ec21cdaeffd11af429156db0dbd36e5c_5e71357d7521440f9c89c05a240b6191 command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_454bb53884e94de99a14c31f283bdf8b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_454bb53884e94de99a14c31f283bdf8b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_454bb53884e94de99a14c31f283bdf8b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_454bb53884e94de99a14c31f283bdf8b(_ec21cdaeffd11af429156db0dbd36e5c_454bb53884e94de99a14c31f283bdf8b command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_437b5aec72e44acfbff4fbcbbfb27a66(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_437b5aec72e44acfbff4fbcbbfb27a66(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_437b5aec72e44acfbff4fbcbbfb27a66(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_437b5aec72e44acfbff4fbcbbfb27a66(_ec21cdaeffd11af429156db0dbd36e5c_437b5aec72e44acfbff4fbcbbfb27a66 command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_e41981d9e6a949b2b26fee0060f03eb6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_e41981d9e6a949b2b26fee0060f03eb6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_e41981d9e6a949b2b26fee0060f03eb6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_e41981d9e6a949b2b26fee0060f03eb6(_ec21cdaeffd11af429156db0dbd36e5c_e41981d9e6a949b2b26fee0060f03eb6 command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_c2b5557b5ec34ef5bb0f6f72c2e372a9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_c2b5557b5ec34ef5bb0f6f72c2e372a9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_c2b5557b5ec34ef5bb0f6f72c2e372a9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_c2b5557b5ec34ef5bb0f6f72c2e372a9(_ec21cdaeffd11af429156db0dbd36e5c_c2b5557b5ec34ef5bb0f6f72c2e372a9 command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_0df2fd90e8214b12933631bbb2b71cd9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_0df2fd90e8214b12933631bbb2b71cd9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_0df2fd90e8214b12933631bbb2b71cd9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_0df2fd90e8214b12933631bbb2b71cd9(_ec21cdaeffd11af429156db0dbd36e5c_0df2fd90e8214b12933631bbb2b71cd9 command)
		{
		}

		private void BakeCommandBinding__ec21cdaeffd11af429156db0dbd36e5c_b6118325bac946749b0d04715696db23(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ec21cdaeffd11af429156db0dbd36e5c_b6118325bac946749b0d04715696db23(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ec21cdaeffd11af429156db0dbd36e5c_b6118325bac946749b0d04715696db23(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ec21cdaeffd11af429156db0dbd36e5c_b6118325bac946749b0d04715696db23(_ec21cdaeffd11af429156db0dbd36e5c_b6118325bac946749b0d04715696db23 command)
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
