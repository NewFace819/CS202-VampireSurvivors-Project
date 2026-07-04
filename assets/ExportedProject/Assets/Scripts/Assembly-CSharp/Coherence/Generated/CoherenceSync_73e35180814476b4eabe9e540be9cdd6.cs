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
	public class CoherenceSync_73e35180814476b4eabe9e540be9cdd6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_dee0588370b84e8e802e2be1bb9054c9_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_17b2b8defe0448a288711bf14aa4cf52_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_60ad6933a2fa4ae5bf320fbe6de5a651_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_cd2581f04ee74438a53be0ecd6790d2e_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_09d3c9274361495fa1846751c6f7c65c_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_5a64129c4f4440f18791359627b44676_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_b0e6bb70ebc343d5adb3946bdc9dc24f_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_b0d2a9bdf4814ce9a059ba07e9bc9592_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_8ce234987a8342dd9e1db16121b427e7_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_9dab185075ab48918dadd69df2c310cb_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_2f1b228f9ffa4ea3b4ca7f9c47f6c763_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_67efafc822ed4ea1841b4bd220904bf7_CommandTarget;

		private CharacterController _73e35180814476b4eabe9e540be9cdd6_597850866f1c4152a36bc78d52a5f2ce_CommandTarget;

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

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_dee0588370b84e8e802e2be1bb9054c9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_dee0588370b84e8e802e2be1bb9054c9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_dee0588370b84e8e802e2be1bb9054c9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_dee0588370b84e8e802e2be1bb9054c9(_73e35180814476b4eabe9e540be9cdd6_dee0588370b84e8e802e2be1bb9054c9 command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_17b2b8defe0448a288711bf14aa4cf52(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_17b2b8defe0448a288711bf14aa4cf52(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_17b2b8defe0448a288711bf14aa4cf52(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_17b2b8defe0448a288711bf14aa4cf52(_73e35180814476b4eabe9e540be9cdd6_17b2b8defe0448a288711bf14aa4cf52 command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_60ad6933a2fa4ae5bf320fbe6de5a651(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_60ad6933a2fa4ae5bf320fbe6de5a651(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_60ad6933a2fa4ae5bf320fbe6de5a651(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_60ad6933a2fa4ae5bf320fbe6de5a651(_73e35180814476b4eabe9e540be9cdd6_60ad6933a2fa4ae5bf320fbe6de5a651 command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_cd2581f04ee74438a53be0ecd6790d2e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_cd2581f04ee74438a53be0ecd6790d2e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_cd2581f04ee74438a53be0ecd6790d2e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_cd2581f04ee74438a53be0ecd6790d2e(_73e35180814476b4eabe9e540be9cdd6_cd2581f04ee74438a53be0ecd6790d2e command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_09d3c9274361495fa1846751c6f7c65c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_09d3c9274361495fa1846751c6f7c65c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_09d3c9274361495fa1846751c6f7c65c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_09d3c9274361495fa1846751c6f7c65c(_73e35180814476b4eabe9e540be9cdd6_09d3c9274361495fa1846751c6f7c65c command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_5a64129c4f4440f18791359627b44676(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_5a64129c4f4440f18791359627b44676(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_5a64129c4f4440f18791359627b44676(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_5a64129c4f4440f18791359627b44676(_73e35180814476b4eabe9e540be9cdd6_5a64129c4f4440f18791359627b44676 command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_b0e6bb70ebc343d5adb3946bdc9dc24f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_b0e6bb70ebc343d5adb3946bdc9dc24f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_b0e6bb70ebc343d5adb3946bdc9dc24f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_b0e6bb70ebc343d5adb3946bdc9dc24f(_73e35180814476b4eabe9e540be9cdd6_b0e6bb70ebc343d5adb3946bdc9dc24f command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_b0d2a9bdf4814ce9a059ba07e9bc9592(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_b0d2a9bdf4814ce9a059ba07e9bc9592(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_b0d2a9bdf4814ce9a059ba07e9bc9592(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_b0d2a9bdf4814ce9a059ba07e9bc9592(_73e35180814476b4eabe9e540be9cdd6_b0d2a9bdf4814ce9a059ba07e9bc9592 command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_8ce234987a8342dd9e1db16121b427e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_8ce234987a8342dd9e1db16121b427e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_8ce234987a8342dd9e1db16121b427e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_8ce234987a8342dd9e1db16121b427e7(_73e35180814476b4eabe9e540be9cdd6_8ce234987a8342dd9e1db16121b427e7 command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_9dab185075ab48918dadd69df2c310cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_9dab185075ab48918dadd69df2c310cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_9dab185075ab48918dadd69df2c310cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_9dab185075ab48918dadd69df2c310cb(_73e35180814476b4eabe9e540be9cdd6_9dab185075ab48918dadd69df2c310cb command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_2f1b228f9ffa4ea3b4ca7f9c47f6c763(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_2f1b228f9ffa4ea3b4ca7f9c47f6c763(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_2f1b228f9ffa4ea3b4ca7f9c47f6c763(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_2f1b228f9ffa4ea3b4ca7f9c47f6c763(_73e35180814476b4eabe9e540be9cdd6_2f1b228f9ffa4ea3b4ca7f9c47f6c763 command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_67efafc822ed4ea1841b4bd220904bf7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_67efafc822ed4ea1841b4bd220904bf7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_67efafc822ed4ea1841b4bd220904bf7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_67efafc822ed4ea1841b4bd220904bf7(_73e35180814476b4eabe9e540be9cdd6_67efafc822ed4ea1841b4bd220904bf7 command)
		{
		}

		private void BakeCommandBinding__73e35180814476b4eabe9e540be9cdd6_597850866f1c4152a36bc78d52a5f2ce(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__73e35180814476b4eabe9e540be9cdd6_597850866f1c4152a36bc78d52a5f2ce(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__73e35180814476b4eabe9e540be9cdd6_597850866f1c4152a36bc78d52a5f2ce(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__73e35180814476b4eabe9e540be9cdd6_597850866f1c4152a36bc78d52a5f2ce(_73e35180814476b4eabe9e540be9cdd6_597850866f1c4152a36bc78d52a5f2ce command)
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
