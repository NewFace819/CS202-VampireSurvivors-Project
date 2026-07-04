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
	public class CoherenceSync_20432c14463cccc40ba01eb8397d5059 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_3424046f9f5d40278fd91803994b258f_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_f6202ee5af0748269ad0f26ff6b8984a_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_df1396636a3d48beb279148c9fbb442f_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_8e5b15c59c094228aaefe9508bedf866_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_7aeca6cadbd447e6ab3d08363d11e552_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_c3460ad7b6a84899a0e863bb86cec765_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_07e8d9ff909b46ba98ab29a3612e869d_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_fe8d091139ed4744933e0b12d68a5b24_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_debc733a56584443b38b5e45391e7897_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_df044bdd41894d658e30e25dd3361ebb_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_6af0a381d16a425cb37586e878d6b64a_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_abda9332cdde473bbf3b709ebf755bed_CommandTarget;

		private CharacterController _20432c14463cccc40ba01eb8397d5059_16c284e3808441aab6a96df6c3aa7ac8_CommandTarget;

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

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_3424046f9f5d40278fd91803994b258f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_3424046f9f5d40278fd91803994b258f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_3424046f9f5d40278fd91803994b258f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_3424046f9f5d40278fd91803994b258f(_20432c14463cccc40ba01eb8397d5059_3424046f9f5d40278fd91803994b258f command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_f6202ee5af0748269ad0f26ff6b8984a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_f6202ee5af0748269ad0f26ff6b8984a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_f6202ee5af0748269ad0f26ff6b8984a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_f6202ee5af0748269ad0f26ff6b8984a(_20432c14463cccc40ba01eb8397d5059_f6202ee5af0748269ad0f26ff6b8984a command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_df1396636a3d48beb279148c9fbb442f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_df1396636a3d48beb279148c9fbb442f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_df1396636a3d48beb279148c9fbb442f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_df1396636a3d48beb279148c9fbb442f(_20432c14463cccc40ba01eb8397d5059_df1396636a3d48beb279148c9fbb442f command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_8e5b15c59c094228aaefe9508bedf866(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_8e5b15c59c094228aaefe9508bedf866(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_8e5b15c59c094228aaefe9508bedf866(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_8e5b15c59c094228aaefe9508bedf866(_20432c14463cccc40ba01eb8397d5059_8e5b15c59c094228aaefe9508bedf866 command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_7aeca6cadbd447e6ab3d08363d11e552(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_7aeca6cadbd447e6ab3d08363d11e552(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_7aeca6cadbd447e6ab3d08363d11e552(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_7aeca6cadbd447e6ab3d08363d11e552(_20432c14463cccc40ba01eb8397d5059_7aeca6cadbd447e6ab3d08363d11e552 command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_c3460ad7b6a84899a0e863bb86cec765(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_c3460ad7b6a84899a0e863bb86cec765(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_c3460ad7b6a84899a0e863bb86cec765(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_c3460ad7b6a84899a0e863bb86cec765(_20432c14463cccc40ba01eb8397d5059_c3460ad7b6a84899a0e863bb86cec765 command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_07e8d9ff909b46ba98ab29a3612e869d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_07e8d9ff909b46ba98ab29a3612e869d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_07e8d9ff909b46ba98ab29a3612e869d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_07e8d9ff909b46ba98ab29a3612e869d(_20432c14463cccc40ba01eb8397d5059_07e8d9ff909b46ba98ab29a3612e869d command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_fe8d091139ed4744933e0b12d68a5b24(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_fe8d091139ed4744933e0b12d68a5b24(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_fe8d091139ed4744933e0b12d68a5b24(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_fe8d091139ed4744933e0b12d68a5b24(_20432c14463cccc40ba01eb8397d5059_fe8d091139ed4744933e0b12d68a5b24 command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_debc733a56584443b38b5e45391e7897(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_debc733a56584443b38b5e45391e7897(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_debc733a56584443b38b5e45391e7897(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_debc733a56584443b38b5e45391e7897(_20432c14463cccc40ba01eb8397d5059_debc733a56584443b38b5e45391e7897 command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_df044bdd41894d658e30e25dd3361ebb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_df044bdd41894d658e30e25dd3361ebb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_df044bdd41894d658e30e25dd3361ebb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_df044bdd41894d658e30e25dd3361ebb(_20432c14463cccc40ba01eb8397d5059_df044bdd41894d658e30e25dd3361ebb command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_6af0a381d16a425cb37586e878d6b64a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_6af0a381d16a425cb37586e878d6b64a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_6af0a381d16a425cb37586e878d6b64a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_6af0a381d16a425cb37586e878d6b64a(_20432c14463cccc40ba01eb8397d5059_6af0a381d16a425cb37586e878d6b64a command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_abda9332cdde473bbf3b709ebf755bed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_abda9332cdde473bbf3b709ebf755bed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_abda9332cdde473bbf3b709ebf755bed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_abda9332cdde473bbf3b709ebf755bed(_20432c14463cccc40ba01eb8397d5059_abda9332cdde473bbf3b709ebf755bed command)
		{
		}

		private void BakeCommandBinding__20432c14463cccc40ba01eb8397d5059_16c284e3808441aab6a96df6c3aa7ac8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__20432c14463cccc40ba01eb8397d5059_16c284e3808441aab6a96df6c3aa7ac8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__20432c14463cccc40ba01eb8397d5059_16c284e3808441aab6a96df6c3aa7ac8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__20432c14463cccc40ba01eb8397d5059_16c284e3808441aab6a96df6c3aa7ac8(_20432c14463cccc40ba01eb8397d5059_16c284e3808441aab6a96df6c3aa7ac8 command)
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
