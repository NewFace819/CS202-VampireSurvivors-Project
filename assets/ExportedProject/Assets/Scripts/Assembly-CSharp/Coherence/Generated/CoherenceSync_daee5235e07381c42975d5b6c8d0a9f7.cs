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
	public class CoherenceSync_daee5235e07381c42975d5b6c8d0a9f7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_055deeea6d9142b78a02c50b392f023b_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_e56fbec185514ad28c9613bd7dfcd7eb_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_d38986560be64894a78af4341104ebbf_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_1fd16102a52f4ca4aaf180b51eeb99bd_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_3283422237d14675b24b847628273905_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_7632421a448749aa80a90e6326b48141_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_f1f520af47044dd28020de277a3e45bd_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_791cb89af8fb4d089b8509b04e05f207_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_645c3d79d1814eb4b9121fe03d5cd9c0_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_2218d836144940f2b0312eae12cec677_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_e62b0571ad8f4efe87e6c5eaa99aad46_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_24b763259cda4d41878fc39bbf6031c2_CommandTarget;

		private CharacterController _daee5235e07381c42975d5b6c8d0a9f7_c44132212f994976bbdf6a7dfb5527b6_CommandTarget;

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

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_055deeea6d9142b78a02c50b392f023b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_055deeea6d9142b78a02c50b392f023b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_055deeea6d9142b78a02c50b392f023b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_055deeea6d9142b78a02c50b392f023b(_daee5235e07381c42975d5b6c8d0a9f7_055deeea6d9142b78a02c50b392f023b command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_e56fbec185514ad28c9613bd7dfcd7eb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_e56fbec185514ad28c9613bd7dfcd7eb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_e56fbec185514ad28c9613bd7dfcd7eb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_e56fbec185514ad28c9613bd7dfcd7eb(_daee5235e07381c42975d5b6c8d0a9f7_e56fbec185514ad28c9613bd7dfcd7eb command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_d38986560be64894a78af4341104ebbf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_d38986560be64894a78af4341104ebbf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_d38986560be64894a78af4341104ebbf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_d38986560be64894a78af4341104ebbf(_daee5235e07381c42975d5b6c8d0a9f7_d38986560be64894a78af4341104ebbf command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_1fd16102a52f4ca4aaf180b51eeb99bd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_1fd16102a52f4ca4aaf180b51eeb99bd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_1fd16102a52f4ca4aaf180b51eeb99bd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_1fd16102a52f4ca4aaf180b51eeb99bd(_daee5235e07381c42975d5b6c8d0a9f7_1fd16102a52f4ca4aaf180b51eeb99bd command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_3283422237d14675b24b847628273905(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_3283422237d14675b24b847628273905(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_3283422237d14675b24b847628273905(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_3283422237d14675b24b847628273905(_daee5235e07381c42975d5b6c8d0a9f7_3283422237d14675b24b847628273905 command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_7632421a448749aa80a90e6326b48141(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_7632421a448749aa80a90e6326b48141(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_7632421a448749aa80a90e6326b48141(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_7632421a448749aa80a90e6326b48141(_daee5235e07381c42975d5b6c8d0a9f7_7632421a448749aa80a90e6326b48141 command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_f1f520af47044dd28020de277a3e45bd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_f1f520af47044dd28020de277a3e45bd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_f1f520af47044dd28020de277a3e45bd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_f1f520af47044dd28020de277a3e45bd(_daee5235e07381c42975d5b6c8d0a9f7_f1f520af47044dd28020de277a3e45bd command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_791cb89af8fb4d089b8509b04e05f207(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_791cb89af8fb4d089b8509b04e05f207(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_791cb89af8fb4d089b8509b04e05f207(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_791cb89af8fb4d089b8509b04e05f207(_daee5235e07381c42975d5b6c8d0a9f7_791cb89af8fb4d089b8509b04e05f207 command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_645c3d79d1814eb4b9121fe03d5cd9c0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_645c3d79d1814eb4b9121fe03d5cd9c0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_645c3d79d1814eb4b9121fe03d5cd9c0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_645c3d79d1814eb4b9121fe03d5cd9c0(_daee5235e07381c42975d5b6c8d0a9f7_645c3d79d1814eb4b9121fe03d5cd9c0 command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_2218d836144940f2b0312eae12cec677(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_2218d836144940f2b0312eae12cec677(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_2218d836144940f2b0312eae12cec677(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_2218d836144940f2b0312eae12cec677(_daee5235e07381c42975d5b6c8d0a9f7_2218d836144940f2b0312eae12cec677 command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_e62b0571ad8f4efe87e6c5eaa99aad46(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_e62b0571ad8f4efe87e6c5eaa99aad46(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_e62b0571ad8f4efe87e6c5eaa99aad46(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_e62b0571ad8f4efe87e6c5eaa99aad46(_daee5235e07381c42975d5b6c8d0a9f7_e62b0571ad8f4efe87e6c5eaa99aad46 command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_24b763259cda4d41878fc39bbf6031c2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_24b763259cda4d41878fc39bbf6031c2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_24b763259cda4d41878fc39bbf6031c2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_24b763259cda4d41878fc39bbf6031c2(_daee5235e07381c42975d5b6c8d0a9f7_24b763259cda4d41878fc39bbf6031c2 command)
		{
		}

		private void BakeCommandBinding__daee5235e07381c42975d5b6c8d0a9f7_c44132212f994976bbdf6a7dfb5527b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__daee5235e07381c42975d5b6c8d0a9f7_c44132212f994976bbdf6a7dfb5527b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__daee5235e07381c42975d5b6c8d0a9f7_c44132212f994976bbdf6a7dfb5527b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__daee5235e07381c42975d5b6c8d0a9f7_c44132212f994976bbdf6a7dfb5527b6(_daee5235e07381c42975d5b6c8d0a9f7_c44132212f994976bbdf6a7dfb5527b6 command)
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
