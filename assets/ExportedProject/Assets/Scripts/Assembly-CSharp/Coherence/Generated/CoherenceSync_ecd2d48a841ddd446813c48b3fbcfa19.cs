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
	public class CoherenceSync_ecd2d48a841ddd446813c48b3fbcfa19 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_fac68531bcc44ba7ad944f14716a0eb3_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_0d2126f9e7b5439fb5aed40b07a4c576_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_8f3de7de546744b9a1a8868a6ac114c8_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_2ef9d7afbbe34cf2a0c14607c790f431_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_689403441a7e4c769a9e60e3930121cc_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_500a2ac3c9194e33bb60095252d75446_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_98a31b75196b4252aecb119a46458aed_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_8fd6ced904bc4a1d911a80875997e8cb_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_83cee25417e34259adc345fe9abbec09_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_611cb6e16ff246daa544c7b12a5da068_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_0b8a27286c6846ca83288ffb94ed4143_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_00b83193a0bd4f98bb1abf0a89f3e0c2_CommandTarget;

		private CharacterController _ecd2d48a841ddd446813c48b3fbcfa19_f9cfba931cc84c39b3553e69fc576c19_CommandTarget;

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

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_fac68531bcc44ba7ad944f14716a0eb3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_fac68531bcc44ba7ad944f14716a0eb3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_fac68531bcc44ba7ad944f14716a0eb3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_fac68531bcc44ba7ad944f14716a0eb3(_ecd2d48a841ddd446813c48b3fbcfa19_fac68531bcc44ba7ad944f14716a0eb3 command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_0d2126f9e7b5439fb5aed40b07a4c576(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_0d2126f9e7b5439fb5aed40b07a4c576(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_0d2126f9e7b5439fb5aed40b07a4c576(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_0d2126f9e7b5439fb5aed40b07a4c576(_ecd2d48a841ddd446813c48b3fbcfa19_0d2126f9e7b5439fb5aed40b07a4c576 command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_8f3de7de546744b9a1a8868a6ac114c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_8f3de7de546744b9a1a8868a6ac114c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_8f3de7de546744b9a1a8868a6ac114c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_8f3de7de546744b9a1a8868a6ac114c8(_ecd2d48a841ddd446813c48b3fbcfa19_8f3de7de546744b9a1a8868a6ac114c8 command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_2ef9d7afbbe34cf2a0c14607c790f431(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_2ef9d7afbbe34cf2a0c14607c790f431(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_2ef9d7afbbe34cf2a0c14607c790f431(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_2ef9d7afbbe34cf2a0c14607c790f431(_ecd2d48a841ddd446813c48b3fbcfa19_2ef9d7afbbe34cf2a0c14607c790f431 command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_689403441a7e4c769a9e60e3930121cc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_689403441a7e4c769a9e60e3930121cc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_689403441a7e4c769a9e60e3930121cc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_689403441a7e4c769a9e60e3930121cc(_ecd2d48a841ddd446813c48b3fbcfa19_689403441a7e4c769a9e60e3930121cc command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_500a2ac3c9194e33bb60095252d75446(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_500a2ac3c9194e33bb60095252d75446(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_500a2ac3c9194e33bb60095252d75446(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_500a2ac3c9194e33bb60095252d75446(_ecd2d48a841ddd446813c48b3fbcfa19_500a2ac3c9194e33bb60095252d75446 command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_98a31b75196b4252aecb119a46458aed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_98a31b75196b4252aecb119a46458aed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_98a31b75196b4252aecb119a46458aed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_98a31b75196b4252aecb119a46458aed(_ecd2d48a841ddd446813c48b3fbcfa19_98a31b75196b4252aecb119a46458aed command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_8fd6ced904bc4a1d911a80875997e8cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_8fd6ced904bc4a1d911a80875997e8cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_8fd6ced904bc4a1d911a80875997e8cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_8fd6ced904bc4a1d911a80875997e8cb(_ecd2d48a841ddd446813c48b3fbcfa19_8fd6ced904bc4a1d911a80875997e8cb command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_83cee25417e34259adc345fe9abbec09(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_83cee25417e34259adc345fe9abbec09(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_83cee25417e34259adc345fe9abbec09(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_83cee25417e34259adc345fe9abbec09(_ecd2d48a841ddd446813c48b3fbcfa19_83cee25417e34259adc345fe9abbec09 command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_611cb6e16ff246daa544c7b12a5da068(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_611cb6e16ff246daa544c7b12a5da068(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_611cb6e16ff246daa544c7b12a5da068(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_611cb6e16ff246daa544c7b12a5da068(_ecd2d48a841ddd446813c48b3fbcfa19_611cb6e16ff246daa544c7b12a5da068 command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_0b8a27286c6846ca83288ffb94ed4143(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_0b8a27286c6846ca83288ffb94ed4143(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_0b8a27286c6846ca83288ffb94ed4143(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_0b8a27286c6846ca83288ffb94ed4143(_ecd2d48a841ddd446813c48b3fbcfa19_0b8a27286c6846ca83288ffb94ed4143 command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_00b83193a0bd4f98bb1abf0a89f3e0c2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_00b83193a0bd4f98bb1abf0a89f3e0c2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_00b83193a0bd4f98bb1abf0a89f3e0c2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_00b83193a0bd4f98bb1abf0a89f3e0c2(_ecd2d48a841ddd446813c48b3fbcfa19_00b83193a0bd4f98bb1abf0a89f3e0c2 command)
		{
		}

		private void BakeCommandBinding__ecd2d48a841ddd446813c48b3fbcfa19_f9cfba931cc84c39b3553e69fc576c19(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ecd2d48a841ddd446813c48b3fbcfa19_f9cfba931cc84c39b3553e69fc576c19(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ecd2d48a841ddd446813c48b3fbcfa19_f9cfba931cc84c39b3553e69fc576c19(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ecd2d48a841ddd446813c48b3fbcfa19_f9cfba931cc84c39b3553e69fc576c19(_ecd2d48a841ddd446813c48b3fbcfa19_f9cfba931cc84c39b3553e69fc576c19 command)
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
