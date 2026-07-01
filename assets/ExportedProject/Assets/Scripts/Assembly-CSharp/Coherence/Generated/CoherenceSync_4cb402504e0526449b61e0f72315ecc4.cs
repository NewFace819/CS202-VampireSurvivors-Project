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
	public class CoherenceSync_4cb402504e0526449b61e0f72315ecc4 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_51271b5de91f420fb2e02054bb5b3e64_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_19358b5aaca242dc873a513b007c48d0_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_61b5687911d54080817b382016e84c19_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_e91951c7a92d465abd65fab725fd7e64_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_6f3df3ce57224ca29d94505b490c2e8f_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_43e7f24a392749bb80de61aa41916a07_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_845ca27d2b704896a56c2626c0e26b3d_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_72500c78fac541fb9e671eabc3414b42_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_8772af4310124d7a86a27dc54dd49e52_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_0f0f3129d27743e38226cd328f2ac049_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_c641ee1cbde3425c837399bcd45b39cf_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_b4dd398fdc224080838f602a851d6dae_CommandTarget;

		private CharacterController _4cb402504e0526449b61e0f72315ecc4_524a62e2277341da9d6e6ee260cbc25b_CommandTarget;

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

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_51271b5de91f420fb2e02054bb5b3e64(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_51271b5de91f420fb2e02054bb5b3e64(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_51271b5de91f420fb2e02054bb5b3e64(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_51271b5de91f420fb2e02054bb5b3e64(_4cb402504e0526449b61e0f72315ecc4_51271b5de91f420fb2e02054bb5b3e64 command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_19358b5aaca242dc873a513b007c48d0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_19358b5aaca242dc873a513b007c48d0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_19358b5aaca242dc873a513b007c48d0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_19358b5aaca242dc873a513b007c48d0(_4cb402504e0526449b61e0f72315ecc4_19358b5aaca242dc873a513b007c48d0 command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_61b5687911d54080817b382016e84c19(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_61b5687911d54080817b382016e84c19(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_61b5687911d54080817b382016e84c19(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_61b5687911d54080817b382016e84c19(_4cb402504e0526449b61e0f72315ecc4_61b5687911d54080817b382016e84c19 command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_e91951c7a92d465abd65fab725fd7e64(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_e91951c7a92d465abd65fab725fd7e64(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_e91951c7a92d465abd65fab725fd7e64(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_e91951c7a92d465abd65fab725fd7e64(_4cb402504e0526449b61e0f72315ecc4_e91951c7a92d465abd65fab725fd7e64 command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_6f3df3ce57224ca29d94505b490c2e8f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_6f3df3ce57224ca29d94505b490c2e8f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_6f3df3ce57224ca29d94505b490c2e8f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_6f3df3ce57224ca29d94505b490c2e8f(_4cb402504e0526449b61e0f72315ecc4_6f3df3ce57224ca29d94505b490c2e8f command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_43e7f24a392749bb80de61aa41916a07(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_43e7f24a392749bb80de61aa41916a07(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_43e7f24a392749bb80de61aa41916a07(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_43e7f24a392749bb80de61aa41916a07(_4cb402504e0526449b61e0f72315ecc4_43e7f24a392749bb80de61aa41916a07 command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_845ca27d2b704896a56c2626c0e26b3d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_845ca27d2b704896a56c2626c0e26b3d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_845ca27d2b704896a56c2626c0e26b3d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_845ca27d2b704896a56c2626c0e26b3d(_4cb402504e0526449b61e0f72315ecc4_845ca27d2b704896a56c2626c0e26b3d command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_72500c78fac541fb9e671eabc3414b42(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_72500c78fac541fb9e671eabc3414b42(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_72500c78fac541fb9e671eabc3414b42(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_72500c78fac541fb9e671eabc3414b42(_4cb402504e0526449b61e0f72315ecc4_72500c78fac541fb9e671eabc3414b42 command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_8772af4310124d7a86a27dc54dd49e52(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_8772af4310124d7a86a27dc54dd49e52(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_8772af4310124d7a86a27dc54dd49e52(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_8772af4310124d7a86a27dc54dd49e52(_4cb402504e0526449b61e0f72315ecc4_8772af4310124d7a86a27dc54dd49e52 command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_0f0f3129d27743e38226cd328f2ac049(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_0f0f3129d27743e38226cd328f2ac049(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_0f0f3129d27743e38226cd328f2ac049(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_0f0f3129d27743e38226cd328f2ac049(_4cb402504e0526449b61e0f72315ecc4_0f0f3129d27743e38226cd328f2ac049 command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_c641ee1cbde3425c837399bcd45b39cf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_c641ee1cbde3425c837399bcd45b39cf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_c641ee1cbde3425c837399bcd45b39cf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_c641ee1cbde3425c837399bcd45b39cf(_4cb402504e0526449b61e0f72315ecc4_c641ee1cbde3425c837399bcd45b39cf command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_b4dd398fdc224080838f602a851d6dae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_b4dd398fdc224080838f602a851d6dae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_b4dd398fdc224080838f602a851d6dae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_b4dd398fdc224080838f602a851d6dae(_4cb402504e0526449b61e0f72315ecc4_b4dd398fdc224080838f602a851d6dae command)
		{
		}

		private void BakeCommandBinding__4cb402504e0526449b61e0f72315ecc4_524a62e2277341da9d6e6ee260cbc25b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4cb402504e0526449b61e0f72315ecc4_524a62e2277341da9d6e6ee260cbc25b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4cb402504e0526449b61e0f72315ecc4_524a62e2277341da9d6e6ee260cbc25b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4cb402504e0526449b61e0f72315ecc4_524a62e2277341da9d6e6ee260cbc25b(_4cb402504e0526449b61e0f72315ecc4_524a62e2277341da9d6e6ee260cbc25b command)
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
