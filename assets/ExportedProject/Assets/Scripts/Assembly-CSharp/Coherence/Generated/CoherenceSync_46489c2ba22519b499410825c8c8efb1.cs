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
	public class CoherenceSync_46489c2ba22519b499410825c8c8efb1 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_8ec217652f714a74bd12df3a623aff12_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_2082232415d8460ea0be5e7b26fc7704_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_8ae6d4c5dafa4139ace83b2bfb92cdb2_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_47328bfc18544f94a3be87f90ca2c54c_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_0101e99a401941ef83919bd61dfb1027_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_04220dc21c5047a9a0bdca037ad10faf_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_18e67945c4fb42029176b541045b7761_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_5b6bd53883384740a8efe834b5afc827_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_41ecb11c7b164d508d9cb9f4020a331f_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_d1782600053448e99a541dc6013fc241_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_1e408e23e0384fc2acdd31b0ed58bd7e_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_0ecaf2fb46d1435fae2b8e0eec8fd079_CommandTarget;

		private CharacterController _46489c2ba22519b499410825c8c8efb1_56bd87cf08fe483eb72873a224b2f159_CommandTarget;

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

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_8ec217652f714a74bd12df3a623aff12(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_8ec217652f714a74bd12df3a623aff12(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_8ec217652f714a74bd12df3a623aff12(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_8ec217652f714a74bd12df3a623aff12(_46489c2ba22519b499410825c8c8efb1_8ec217652f714a74bd12df3a623aff12 command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_2082232415d8460ea0be5e7b26fc7704(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_2082232415d8460ea0be5e7b26fc7704(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_2082232415d8460ea0be5e7b26fc7704(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_2082232415d8460ea0be5e7b26fc7704(_46489c2ba22519b499410825c8c8efb1_2082232415d8460ea0be5e7b26fc7704 command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_8ae6d4c5dafa4139ace83b2bfb92cdb2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_8ae6d4c5dafa4139ace83b2bfb92cdb2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_8ae6d4c5dafa4139ace83b2bfb92cdb2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_8ae6d4c5dafa4139ace83b2bfb92cdb2(_46489c2ba22519b499410825c8c8efb1_8ae6d4c5dafa4139ace83b2bfb92cdb2 command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_47328bfc18544f94a3be87f90ca2c54c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_47328bfc18544f94a3be87f90ca2c54c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_47328bfc18544f94a3be87f90ca2c54c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_47328bfc18544f94a3be87f90ca2c54c(_46489c2ba22519b499410825c8c8efb1_47328bfc18544f94a3be87f90ca2c54c command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_0101e99a401941ef83919bd61dfb1027(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_0101e99a401941ef83919bd61dfb1027(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_0101e99a401941ef83919bd61dfb1027(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_0101e99a401941ef83919bd61dfb1027(_46489c2ba22519b499410825c8c8efb1_0101e99a401941ef83919bd61dfb1027 command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_04220dc21c5047a9a0bdca037ad10faf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_04220dc21c5047a9a0bdca037ad10faf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_04220dc21c5047a9a0bdca037ad10faf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_04220dc21c5047a9a0bdca037ad10faf(_46489c2ba22519b499410825c8c8efb1_04220dc21c5047a9a0bdca037ad10faf command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_18e67945c4fb42029176b541045b7761(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_18e67945c4fb42029176b541045b7761(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_18e67945c4fb42029176b541045b7761(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_18e67945c4fb42029176b541045b7761(_46489c2ba22519b499410825c8c8efb1_18e67945c4fb42029176b541045b7761 command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_5b6bd53883384740a8efe834b5afc827(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_5b6bd53883384740a8efe834b5afc827(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_5b6bd53883384740a8efe834b5afc827(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_5b6bd53883384740a8efe834b5afc827(_46489c2ba22519b499410825c8c8efb1_5b6bd53883384740a8efe834b5afc827 command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_41ecb11c7b164d508d9cb9f4020a331f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_41ecb11c7b164d508d9cb9f4020a331f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_41ecb11c7b164d508d9cb9f4020a331f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_41ecb11c7b164d508d9cb9f4020a331f(_46489c2ba22519b499410825c8c8efb1_41ecb11c7b164d508d9cb9f4020a331f command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_d1782600053448e99a541dc6013fc241(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_d1782600053448e99a541dc6013fc241(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_d1782600053448e99a541dc6013fc241(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_d1782600053448e99a541dc6013fc241(_46489c2ba22519b499410825c8c8efb1_d1782600053448e99a541dc6013fc241 command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_1e408e23e0384fc2acdd31b0ed58bd7e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_1e408e23e0384fc2acdd31b0ed58bd7e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_1e408e23e0384fc2acdd31b0ed58bd7e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_1e408e23e0384fc2acdd31b0ed58bd7e(_46489c2ba22519b499410825c8c8efb1_1e408e23e0384fc2acdd31b0ed58bd7e command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_0ecaf2fb46d1435fae2b8e0eec8fd079(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_0ecaf2fb46d1435fae2b8e0eec8fd079(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_0ecaf2fb46d1435fae2b8e0eec8fd079(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_0ecaf2fb46d1435fae2b8e0eec8fd079(_46489c2ba22519b499410825c8c8efb1_0ecaf2fb46d1435fae2b8e0eec8fd079 command)
		{
		}

		private void BakeCommandBinding__46489c2ba22519b499410825c8c8efb1_56bd87cf08fe483eb72873a224b2f159(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46489c2ba22519b499410825c8c8efb1_56bd87cf08fe483eb72873a224b2f159(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46489c2ba22519b499410825c8c8efb1_56bd87cf08fe483eb72873a224b2f159(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46489c2ba22519b499410825c8c8efb1_56bd87cf08fe483eb72873a224b2f159(_46489c2ba22519b499410825c8c8efb1_56bd87cf08fe483eb72873a224b2f159 command)
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
