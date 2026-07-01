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
	public class CoherenceSync_b29f1af98803f164bbbef37a5210543c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_eac6e877705c453fa1400f252af36a59_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_a64fc358dc8c4d6599218ea0173049e4_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_40471891c2e84b9fb82278406c3f4754_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_d65d6ee878694f5bb0003c39d9b7c7cd_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_eacd0dbfed2947a58a1204b928718081_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_d4b34707ab784d6887f4429443353c75_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_7a4938bbdfd445ab877937393b66d1a0_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_071953688ab244809afcad376ce27f80_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_e2989ead820740ab96acddedc8304e41_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_30a07a61263c4ddea38599bb2af48be5_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_f42cc496dc904679befe4a93fd4f188e_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_995f81c23e3d4defa8ee3ef3c8cad2c7_CommandTarget;

		private CharacterController _b29f1af98803f164bbbef37a5210543c_e2fae993f5974e9a8c24fb1972f3f00f_CommandTarget;

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

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_eac6e877705c453fa1400f252af36a59(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_eac6e877705c453fa1400f252af36a59(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_eac6e877705c453fa1400f252af36a59(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_eac6e877705c453fa1400f252af36a59(_b29f1af98803f164bbbef37a5210543c_eac6e877705c453fa1400f252af36a59 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_a64fc358dc8c4d6599218ea0173049e4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_a64fc358dc8c4d6599218ea0173049e4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_a64fc358dc8c4d6599218ea0173049e4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_a64fc358dc8c4d6599218ea0173049e4(_b29f1af98803f164bbbef37a5210543c_a64fc358dc8c4d6599218ea0173049e4 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_40471891c2e84b9fb82278406c3f4754(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_40471891c2e84b9fb82278406c3f4754(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_40471891c2e84b9fb82278406c3f4754(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_40471891c2e84b9fb82278406c3f4754(_b29f1af98803f164bbbef37a5210543c_40471891c2e84b9fb82278406c3f4754 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_d65d6ee878694f5bb0003c39d9b7c7cd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_d65d6ee878694f5bb0003c39d9b7c7cd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_d65d6ee878694f5bb0003c39d9b7c7cd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_d65d6ee878694f5bb0003c39d9b7c7cd(_b29f1af98803f164bbbef37a5210543c_d65d6ee878694f5bb0003c39d9b7c7cd command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_eacd0dbfed2947a58a1204b928718081(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_eacd0dbfed2947a58a1204b928718081(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_eacd0dbfed2947a58a1204b928718081(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_eacd0dbfed2947a58a1204b928718081(_b29f1af98803f164bbbef37a5210543c_eacd0dbfed2947a58a1204b928718081 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_d4b34707ab784d6887f4429443353c75(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_d4b34707ab784d6887f4429443353c75(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_d4b34707ab784d6887f4429443353c75(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_d4b34707ab784d6887f4429443353c75(_b29f1af98803f164bbbef37a5210543c_d4b34707ab784d6887f4429443353c75 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_7a4938bbdfd445ab877937393b66d1a0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_7a4938bbdfd445ab877937393b66d1a0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_7a4938bbdfd445ab877937393b66d1a0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_7a4938bbdfd445ab877937393b66d1a0(_b29f1af98803f164bbbef37a5210543c_7a4938bbdfd445ab877937393b66d1a0 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_071953688ab244809afcad376ce27f80(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_071953688ab244809afcad376ce27f80(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_071953688ab244809afcad376ce27f80(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_071953688ab244809afcad376ce27f80(_b29f1af98803f164bbbef37a5210543c_071953688ab244809afcad376ce27f80 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_e2989ead820740ab96acddedc8304e41(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_e2989ead820740ab96acddedc8304e41(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_e2989ead820740ab96acddedc8304e41(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_e2989ead820740ab96acddedc8304e41(_b29f1af98803f164bbbef37a5210543c_e2989ead820740ab96acddedc8304e41 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_30a07a61263c4ddea38599bb2af48be5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_30a07a61263c4ddea38599bb2af48be5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_30a07a61263c4ddea38599bb2af48be5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_30a07a61263c4ddea38599bb2af48be5(_b29f1af98803f164bbbef37a5210543c_30a07a61263c4ddea38599bb2af48be5 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_f42cc496dc904679befe4a93fd4f188e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_f42cc496dc904679befe4a93fd4f188e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_f42cc496dc904679befe4a93fd4f188e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_f42cc496dc904679befe4a93fd4f188e(_b29f1af98803f164bbbef37a5210543c_f42cc496dc904679befe4a93fd4f188e command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_995f81c23e3d4defa8ee3ef3c8cad2c7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_995f81c23e3d4defa8ee3ef3c8cad2c7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_995f81c23e3d4defa8ee3ef3c8cad2c7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_995f81c23e3d4defa8ee3ef3c8cad2c7(_b29f1af98803f164bbbef37a5210543c_995f81c23e3d4defa8ee3ef3c8cad2c7 command)
		{
		}

		private void BakeCommandBinding__b29f1af98803f164bbbef37a5210543c_e2fae993f5974e9a8c24fb1972f3f00f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b29f1af98803f164bbbef37a5210543c_e2fae993f5974e9a8c24fb1972f3f00f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b29f1af98803f164bbbef37a5210543c_e2fae993f5974e9a8c24fb1972f3f00f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b29f1af98803f164bbbef37a5210543c_e2fae993f5974e9a8c24fb1972f3f00f(_b29f1af98803f164bbbef37a5210543c_e2fae993f5974e9a8c24fb1972f3f00f command)
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
