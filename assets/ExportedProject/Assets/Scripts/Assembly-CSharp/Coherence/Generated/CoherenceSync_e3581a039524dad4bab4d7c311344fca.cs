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
	public class CoherenceSync_e3581a039524dad4bab4d7c311344fca : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_a3b9e91a545b4b85ab1b2b26068c6220_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_1e3dd0cf0c1340e9b4ecd59d2ae13377_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_751ee1bceaeb4b958f69379779adb351_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_2dcab116bedd4cf1894a8a91d620a7eb_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_b02fedb02abc41c293c2d278ddd7ed41_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_ba1fbd709e6840e8ad5b3e9354bffcb2_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_6327b5ffe28544a2bc538c6eab2ca247_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_ced9e9ada5de4c229630a8b3cdf5e4c3_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_1230deb5cdda4dd6bd019a8fcaeeb135_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_c6c06fbb7b714f04a43519cc93fd2654_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_de24cb0fcf6d42f78833e3e6a66508f4_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_c259947258524adcbec389ce922920ae_CommandTarget;

		private CharacterController _e3581a039524dad4bab4d7c311344fca_c08738d2bcb64f7786a2f06a075d440b_CommandTarget;

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

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_a3b9e91a545b4b85ab1b2b26068c6220(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_a3b9e91a545b4b85ab1b2b26068c6220(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_a3b9e91a545b4b85ab1b2b26068c6220(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_a3b9e91a545b4b85ab1b2b26068c6220(_e3581a039524dad4bab4d7c311344fca_a3b9e91a545b4b85ab1b2b26068c6220 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_1e3dd0cf0c1340e9b4ecd59d2ae13377(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_1e3dd0cf0c1340e9b4ecd59d2ae13377(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_1e3dd0cf0c1340e9b4ecd59d2ae13377(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_1e3dd0cf0c1340e9b4ecd59d2ae13377(_e3581a039524dad4bab4d7c311344fca_1e3dd0cf0c1340e9b4ecd59d2ae13377 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_751ee1bceaeb4b958f69379779adb351(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_751ee1bceaeb4b958f69379779adb351(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_751ee1bceaeb4b958f69379779adb351(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_751ee1bceaeb4b958f69379779adb351(_e3581a039524dad4bab4d7c311344fca_751ee1bceaeb4b958f69379779adb351 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_2dcab116bedd4cf1894a8a91d620a7eb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_2dcab116bedd4cf1894a8a91d620a7eb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_2dcab116bedd4cf1894a8a91d620a7eb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_2dcab116bedd4cf1894a8a91d620a7eb(_e3581a039524dad4bab4d7c311344fca_2dcab116bedd4cf1894a8a91d620a7eb command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_b02fedb02abc41c293c2d278ddd7ed41(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_b02fedb02abc41c293c2d278ddd7ed41(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_b02fedb02abc41c293c2d278ddd7ed41(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_b02fedb02abc41c293c2d278ddd7ed41(_e3581a039524dad4bab4d7c311344fca_b02fedb02abc41c293c2d278ddd7ed41 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_ba1fbd709e6840e8ad5b3e9354bffcb2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_ba1fbd709e6840e8ad5b3e9354bffcb2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_ba1fbd709e6840e8ad5b3e9354bffcb2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_ba1fbd709e6840e8ad5b3e9354bffcb2(_e3581a039524dad4bab4d7c311344fca_ba1fbd709e6840e8ad5b3e9354bffcb2 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_6327b5ffe28544a2bc538c6eab2ca247(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_6327b5ffe28544a2bc538c6eab2ca247(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_6327b5ffe28544a2bc538c6eab2ca247(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_6327b5ffe28544a2bc538c6eab2ca247(_e3581a039524dad4bab4d7c311344fca_6327b5ffe28544a2bc538c6eab2ca247 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_ced9e9ada5de4c229630a8b3cdf5e4c3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_ced9e9ada5de4c229630a8b3cdf5e4c3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_ced9e9ada5de4c229630a8b3cdf5e4c3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_ced9e9ada5de4c229630a8b3cdf5e4c3(_e3581a039524dad4bab4d7c311344fca_ced9e9ada5de4c229630a8b3cdf5e4c3 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_1230deb5cdda4dd6bd019a8fcaeeb135(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_1230deb5cdda4dd6bd019a8fcaeeb135(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_1230deb5cdda4dd6bd019a8fcaeeb135(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_1230deb5cdda4dd6bd019a8fcaeeb135(_e3581a039524dad4bab4d7c311344fca_1230deb5cdda4dd6bd019a8fcaeeb135 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_c6c06fbb7b714f04a43519cc93fd2654(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_c6c06fbb7b714f04a43519cc93fd2654(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_c6c06fbb7b714f04a43519cc93fd2654(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_c6c06fbb7b714f04a43519cc93fd2654(_e3581a039524dad4bab4d7c311344fca_c6c06fbb7b714f04a43519cc93fd2654 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_de24cb0fcf6d42f78833e3e6a66508f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_de24cb0fcf6d42f78833e3e6a66508f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_de24cb0fcf6d42f78833e3e6a66508f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_de24cb0fcf6d42f78833e3e6a66508f4(_e3581a039524dad4bab4d7c311344fca_de24cb0fcf6d42f78833e3e6a66508f4 command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_c259947258524adcbec389ce922920ae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_c259947258524adcbec389ce922920ae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_c259947258524adcbec389ce922920ae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_c259947258524adcbec389ce922920ae(_e3581a039524dad4bab4d7c311344fca_c259947258524adcbec389ce922920ae command)
		{
		}

		private void BakeCommandBinding__e3581a039524dad4bab4d7c311344fca_c08738d2bcb64f7786a2f06a075d440b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e3581a039524dad4bab4d7c311344fca_c08738d2bcb64f7786a2f06a075d440b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e3581a039524dad4bab4d7c311344fca_c08738d2bcb64f7786a2f06a075d440b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e3581a039524dad4bab4d7c311344fca_c08738d2bcb64f7786a2f06a075d440b(_e3581a039524dad4bab4d7c311344fca_c08738d2bcb64f7786a2f06a075d440b command)
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
