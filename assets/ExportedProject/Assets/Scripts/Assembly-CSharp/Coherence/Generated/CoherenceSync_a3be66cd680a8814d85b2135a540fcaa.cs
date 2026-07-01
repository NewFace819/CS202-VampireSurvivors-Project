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
	public class CoherenceSync_a3be66cd680a8814d85b2135a540fcaa : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_4b4f3a20c90045fc8e95cb407a37f42c_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_b53857bcda3d4b0293dc9a8f36ee7ede_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_7e14999ae7f148b494ef8683a2732731_CommandTarget;

		private C1_Crewmate _a3be66cd680a8814d85b2135a540fcaa_5254303dfd7242c591528660d6df8716_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_a00f2b1b81a146d19a2807e0663629ef_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_5be280810aab46ec9f0aa7bfef021604_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_8095ec06d53a48dbbfea7f44e2a53e40_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_625dc74e84c2452782ba8a6f44e88217_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_7f4da7ad0ae24b6aaf744fb80b4b910e_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_52bf6be43dc04d3ba097179910a950c4_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_7e208c3bb65549259aadf83a071bdf08_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_15b40c74c6644cc6b045044e833ca740_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_16ab53b773fd410baa730e984ff3e8cd_CommandTarget;

		private CharacterController _a3be66cd680a8814d85b2135a540fcaa_adcb9ff4f05349abae719f29306fb673_CommandTarget;

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

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_4b4f3a20c90045fc8e95cb407a37f42c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_4b4f3a20c90045fc8e95cb407a37f42c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_4b4f3a20c90045fc8e95cb407a37f42c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_4b4f3a20c90045fc8e95cb407a37f42c(_a3be66cd680a8814d85b2135a540fcaa_4b4f3a20c90045fc8e95cb407a37f42c command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_b53857bcda3d4b0293dc9a8f36ee7ede(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_b53857bcda3d4b0293dc9a8f36ee7ede(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_b53857bcda3d4b0293dc9a8f36ee7ede(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_b53857bcda3d4b0293dc9a8f36ee7ede(_a3be66cd680a8814d85b2135a540fcaa_b53857bcda3d4b0293dc9a8f36ee7ede command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_7e14999ae7f148b494ef8683a2732731(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_7e14999ae7f148b494ef8683a2732731(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_7e14999ae7f148b494ef8683a2732731(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_7e14999ae7f148b494ef8683a2732731(_a3be66cd680a8814d85b2135a540fcaa_7e14999ae7f148b494ef8683a2732731 command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_5254303dfd7242c591528660d6df8716(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_5254303dfd7242c591528660d6df8716(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_5254303dfd7242c591528660d6df8716(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_5254303dfd7242c591528660d6df8716(_a3be66cd680a8814d85b2135a540fcaa_5254303dfd7242c591528660d6df8716 command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_a00f2b1b81a146d19a2807e0663629ef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_a00f2b1b81a146d19a2807e0663629ef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_a00f2b1b81a146d19a2807e0663629ef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_a00f2b1b81a146d19a2807e0663629ef(_a3be66cd680a8814d85b2135a540fcaa_a00f2b1b81a146d19a2807e0663629ef command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_5be280810aab46ec9f0aa7bfef021604(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_5be280810aab46ec9f0aa7bfef021604(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_5be280810aab46ec9f0aa7bfef021604(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_5be280810aab46ec9f0aa7bfef021604(_a3be66cd680a8814d85b2135a540fcaa_5be280810aab46ec9f0aa7bfef021604 command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_8095ec06d53a48dbbfea7f44e2a53e40(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_8095ec06d53a48dbbfea7f44e2a53e40(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_8095ec06d53a48dbbfea7f44e2a53e40(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_8095ec06d53a48dbbfea7f44e2a53e40(_a3be66cd680a8814d85b2135a540fcaa_8095ec06d53a48dbbfea7f44e2a53e40 command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_625dc74e84c2452782ba8a6f44e88217(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_625dc74e84c2452782ba8a6f44e88217(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_625dc74e84c2452782ba8a6f44e88217(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_625dc74e84c2452782ba8a6f44e88217(_a3be66cd680a8814d85b2135a540fcaa_625dc74e84c2452782ba8a6f44e88217 command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_7f4da7ad0ae24b6aaf744fb80b4b910e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_7f4da7ad0ae24b6aaf744fb80b4b910e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_7f4da7ad0ae24b6aaf744fb80b4b910e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_7f4da7ad0ae24b6aaf744fb80b4b910e(_a3be66cd680a8814d85b2135a540fcaa_7f4da7ad0ae24b6aaf744fb80b4b910e command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_52bf6be43dc04d3ba097179910a950c4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_52bf6be43dc04d3ba097179910a950c4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_52bf6be43dc04d3ba097179910a950c4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_52bf6be43dc04d3ba097179910a950c4(_a3be66cd680a8814d85b2135a540fcaa_52bf6be43dc04d3ba097179910a950c4 command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_7e208c3bb65549259aadf83a071bdf08(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_7e208c3bb65549259aadf83a071bdf08(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_7e208c3bb65549259aadf83a071bdf08(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_7e208c3bb65549259aadf83a071bdf08(_a3be66cd680a8814d85b2135a540fcaa_7e208c3bb65549259aadf83a071bdf08 command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_15b40c74c6644cc6b045044e833ca740(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_15b40c74c6644cc6b045044e833ca740(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_15b40c74c6644cc6b045044e833ca740(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_15b40c74c6644cc6b045044e833ca740(_a3be66cd680a8814d85b2135a540fcaa_15b40c74c6644cc6b045044e833ca740 command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_16ab53b773fd410baa730e984ff3e8cd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_16ab53b773fd410baa730e984ff3e8cd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_16ab53b773fd410baa730e984ff3e8cd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_16ab53b773fd410baa730e984ff3e8cd(_a3be66cd680a8814d85b2135a540fcaa_16ab53b773fd410baa730e984ff3e8cd command)
		{
		}

		private void BakeCommandBinding__a3be66cd680a8814d85b2135a540fcaa_adcb9ff4f05349abae719f29306fb673(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a3be66cd680a8814d85b2135a540fcaa_adcb9ff4f05349abae719f29306fb673(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a3be66cd680a8814d85b2135a540fcaa_adcb9ff4f05349abae719f29306fb673(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a3be66cd680a8814d85b2135a540fcaa_adcb9ff4f05349abae719f29306fb673(_a3be66cd680a8814d85b2135a540fcaa_adcb9ff4f05349abae719f29306fb673 command)
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
