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
	public class CoherenceSync_1ee4e97c7eb3fda4a85f62cf386e89a5 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_5ce1a55eff4f46ce95e7b351694ba9d4_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_235e186a50fc4d148d143ac4f7be368e_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_01bfbc81a91142eebad70a383fba33c3_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_0468d554ad434eaf9559c3548d777e17_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_409aef55e8e74feba80d4d53f4a01adf_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_48d0846ae3734ebfb9fb4f24c33d337e_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_660d9aaa990346a9848c0e6ea57e943e_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_723e4c66b7284d5ba0d1032e356e88d9_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_930bc5f2181345fd83bae8775867d46c_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_95b5021cb2954ecd9aa5e026e579bb66_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_f86bffeb47ff4a8f844756292fc73343_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_4972751085ef4700859cd3d5ece17f91_CommandTarget;

		private CharacterController _1ee4e97c7eb3fda4a85f62cf386e89a5_51a34baf51974bb3b1d83e6ae764443b_CommandTarget;

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

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_5ce1a55eff4f46ce95e7b351694ba9d4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_5ce1a55eff4f46ce95e7b351694ba9d4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_5ce1a55eff4f46ce95e7b351694ba9d4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_5ce1a55eff4f46ce95e7b351694ba9d4(_1ee4e97c7eb3fda4a85f62cf386e89a5_5ce1a55eff4f46ce95e7b351694ba9d4 command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_235e186a50fc4d148d143ac4f7be368e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_235e186a50fc4d148d143ac4f7be368e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_235e186a50fc4d148d143ac4f7be368e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_235e186a50fc4d148d143ac4f7be368e(_1ee4e97c7eb3fda4a85f62cf386e89a5_235e186a50fc4d148d143ac4f7be368e command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_01bfbc81a91142eebad70a383fba33c3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_01bfbc81a91142eebad70a383fba33c3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_01bfbc81a91142eebad70a383fba33c3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_01bfbc81a91142eebad70a383fba33c3(_1ee4e97c7eb3fda4a85f62cf386e89a5_01bfbc81a91142eebad70a383fba33c3 command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_0468d554ad434eaf9559c3548d777e17(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_0468d554ad434eaf9559c3548d777e17(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_0468d554ad434eaf9559c3548d777e17(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_0468d554ad434eaf9559c3548d777e17(_1ee4e97c7eb3fda4a85f62cf386e89a5_0468d554ad434eaf9559c3548d777e17 command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_409aef55e8e74feba80d4d53f4a01adf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_409aef55e8e74feba80d4d53f4a01adf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_409aef55e8e74feba80d4d53f4a01adf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_409aef55e8e74feba80d4d53f4a01adf(_1ee4e97c7eb3fda4a85f62cf386e89a5_409aef55e8e74feba80d4d53f4a01adf command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_48d0846ae3734ebfb9fb4f24c33d337e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_48d0846ae3734ebfb9fb4f24c33d337e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_48d0846ae3734ebfb9fb4f24c33d337e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_48d0846ae3734ebfb9fb4f24c33d337e(_1ee4e97c7eb3fda4a85f62cf386e89a5_48d0846ae3734ebfb9fb4f24c33d337e command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_660d9aaa990346a9848c0e6ea57e943e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_660d9aaa990346a9848c0e6ea57e943e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_660d9aaa990346a9848c0e6ea57e943e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_660d9aaa990346a9848c0e6ea57e943e(_1ee4e97c7eb3fda4a85f62cf386e89a5_660d9aaa990346a9848c0e6ea57e943e command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_723e4c66b7284d5ba0d1032e356e88d9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_723e4c66b7284d5ba0d1032e356e88d9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_723e4c66b7284d5ba0d1032e356e88d9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_723e4c66b7284d5ba0d1032e356e88d9(_1ee4e97c7eb3fda4a85f62cf386e89a5_723e4c66b7284d5ba0d1032e356e88d9 command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_930bc5f2181345fd83bae8775867d46c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_930bc5f2181345fd83bae8775867d46c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_930bc5f2181345fd83bae8775867d46c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_930bc5f2181345fd83bae8775867d46c(_1ee4e97c7eb3fda4a85f62cf386e89a5_930bc5f2181345fd83bae8775867d46c command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_95b5021cb2954ecd9aa5e026e579bb66(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_95b5021cb2954ecd9aa5e026e579bb66(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_95b5021cb2954ecd9aa5e026e579bb66(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_95b5021cb2954ecd9aa5e026e579bb66(_1ee4e97c7eb3fda4a85f62cf386e89a5_95b5021cb2954ecd9aa5e026e579bb66 command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_f86bffeb47ff4a8f844756292fc73343(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_f86bffeb47ff4a8f844756292fc73343(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_f86bffeb47ff4a8f844756292fc73343(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_f86bffeb47ff4a8f844756292fc73343(_1ee4e97c7eb3fda4a85f62cf386e89a5_f86bffeb47ff4a8f844756292fc73343 command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_4972751085ef4700859cd3d5ece17f91(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_4972751085ef4700859cd3d5ece17f91(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_4972751085ef4700859cd3d5ece17f91(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_4972751085ef4700859cd3d5ece17f91(_1ee4e97c7eb3fda4a85f62cf386e89a5_4972751085ef4700859cd3d5ece17f91 command)
		{
		}

		private void BakeCommandBinding__1ee4e97c7eb3fda4a85f62cf386e89a5_51a34baf51974bb3b1d83e6ae764443b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_51a34baf51974bb3b1d83e6ae764443b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_51a34baf51974bb3b1d83e6ae764443b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1ee4e97c7eb3fda4a85f62cf386e89a5_51a34baf51974bb3b1d83e6ae764443b(_1ee4e97c7eb3fda4a85f62cf386e89a5_51a34baf51974bb3b1d83e6ae764443b command)
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
