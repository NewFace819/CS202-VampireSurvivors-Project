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
	public class CoherenceSync_fcd65334626bcc24799d6993331abcf6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_aeef293dd6b947ec9c49cc164ada261a_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_cadb9bbcfc0943e4b9dc6d1f7096418b_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_ee1f20e8ab0a4250a9d7261fdefe07e7_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_4a267285bf9d4cedb4f9ea52872a44cc_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_c240598de4024883bbab61092386b940_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_2cb5cbd8d26445e9a3d4c11b32eab1fb_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_7f26276067d34ebeaab79c69dc464699_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_02bc2c916b2342aa9252d52d7751c026_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_8d3b3b5caccd495fb26c3dfa40858b51_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_70f1336286894fcdb9a69c9c06272805_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_fedbf67aa6014a9d964596e2cc87e691_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_31001425da494991817059f69709b06a_CommandTarget;

		private CharacterController _fcd65334626bcc24799d6993331abcf6_b408770aefd94ebe99b004da8c7110e2_CommandTarget;

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

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_aeef293dd6b947ec9c49cc164ada261a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_aeef293dd6b947ec9c49cc164ada261a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_aeef293dd6b947ec9c49cc164ada261a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_aeef293dd6b947ec9c49cc164ada261a(_fcd65334626bcc24799d6993331abcf6_aeef293dd6b947ec9c49cc164ada261a command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_cadb9bbcfc0943e4b9dc6d1f7096418b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_cadb9bbcfc0943e4b9dc6d1f7096418b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_cadb9bbcfc0943e4b9dc6d1f7096418b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_cadb9bbcfc0943e4b9dc6d1f7096418b(_fcd65334626bcc24799d6993331abcf6_cadb9bbcfc0943e4b9dc6d1f7096418b command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_ee1f20e8ab0a4250a9d7261fdefe07e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_ee1f20e8ab0a4250a9d7261fdefe07e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_ee1f20e8ab0a4250a9d7261fdefe07e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_ee1f20e8ab0a4250a9d7261fdefe07e7(_fcd65334626bcc24799d6993331abcf6_ee1f20e8ab0a4250a9d7261fdefe07e7 command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_4a267285bf9d4cedb4f9ea52872a44cc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_4a267285bf9d4cedb4f9ea52872a44cc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_4a267285bf9d4cedb4f9ea52872a44cc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_4a267285bf9d4cedb4f9ea52872a44cc(_fcd65334626bcc24799d6993331abcf6_4a267285bf9d4cedb4f9ea52872a44cc command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_c240598de4024883bbab61092386b940(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_c240598de4024883bbab61092386b940(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_c240598de4024883bbab61092386b940(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_c240598de4024883bbab61092386b940(_fcd65334626bcc24799d6993331abcf6_c240598de4024883bbab61092386b940 command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_2cb5cbd8d26445e9a3d4c11b32eab1fb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_2cb5cbd8d26445e9a3d4c11b32eab1fb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_2cb5cbd8d26445e9a3d4c11b32eab1fb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_2cb5cbd8d26445e9a3d4c11b32eab1fb(_fcd65334626bcc24799d6993331abcf6_2cb5cbd8d26445e9a3d4c11b32eab1fb command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_7f26276067d34ebeaab79c69dc464699(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_7f26276067d34ebeaab79c69dc464699(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_7f26276067d34ebeaab79c69dc464699(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_7f26276067d34ebeaab79c69dc464699(_fcd65334626bcc24799d6993331abcf6_7f26276067d34ebeaab79c69dc464699 command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_02bc2c916b2342aa9252d52d7751c026(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_02bc2c916b2342aa9252d52d7751c026(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_02bc2c916b2342aa9252d52d7751c026(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_02bc2c916b2342aa9252d52d7751c026(_fcd65334626bcc24799d6993331abcf6_02bc2c916b2342aa9252d52d7751c026 command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_8d3b3b5caccd495fb26c3dfa40858b51(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_8d3b3b5caccd495fb26c3dfa40858b51(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_8d3b3b5caccd495fb26c3dfa40858b51(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_8d3b3b5caccd495fb26c3dfa40858b51(_fcd65334626bcc24799d6993331abcf6_8d3b3b5caccd495fb26c3dfa40858b51 command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_70f1336286894fcdb9a69c9c06272805(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_70f1336286894fcdb9a69c9c06272805(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_70f1336286894fcdb9a69c9c06272805(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_70f1336286894fcdb9a69c9c06272805(_fcd65334626bcc24799d6993331abcf6_70f1336286894fcdb9a69c9c06272805 command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_fedbf67aa6014a9d964596e2cc87e691(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_fedbf67aa6014a9d964596e2cc87e691(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_fedbf67aa6014a9d964596e2cc87e691(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_fedbf67aa6014a9d964596e2cc87e691(_fcd65334626bcc24799d6993331abcf6_fedbf67aa6014a9d964596e2cc87e691 command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_31001425da494991817059f69709b06a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_31001425da494991817059f69709b06a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_31001425da494991817059f69709b06a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_31001425da494991817059f69709b06a(_fcd65334626bcc24799d6993331abcf6_31001425da494991817059f69709b06a command)
		{
		}

		private void BakeCommandBinding__fcd65334626bcc24799d6993331abcf6_b408770aefd94ebe99b004da8c7110e2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__fcd65334626bcc24799d6993331abcf6_b408770aefd94ebe99b004da8c7110e2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__fcd65334626bcc24799d6993331abcf6_b408770aefd94ebe99b004da8c7110e2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__fcd65334626bcc24799d6993331abcf6_b408770aefd94ebe99b004da8c7110e2(_fcd65334626bcc24799d6993331abcf6_b408770aefd94ebe99b004da8c7110e2 command)
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
