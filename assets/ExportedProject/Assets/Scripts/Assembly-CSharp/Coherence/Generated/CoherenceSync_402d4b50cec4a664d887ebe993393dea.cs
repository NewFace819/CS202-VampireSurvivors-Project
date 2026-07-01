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
	public class CoherenceSync_402d4b50cec4a664d887ebe993393dea : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_a449fa516bbe4997a0ff2e734c206bff_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_306adbe1494a4bdda72c5f3a9d19b087_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_a9822e34d5e642e480712de5b6c410cd_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_50bfad94a27e4bc08a88f842d2ae3263_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_14ffc30aa4554f83ad8cecc4824f102b_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_8d9637bc60ab42bf862ed085f9457c6f_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_2552180bdfae4618b6895af1e6378dbf_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_20e45fc4b78d4e28898f0b47f675b501_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_6b44db5d31cd48b08740ae5b91071013_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_13119706ab3f4062936fe47ced7906b7_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_7566e2f20df54d76b10dfad45b9eea52_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_8c20a5fdaabb4d99862fc9c2f87fda93_CommandTarget;

		private CharacterController _402d4b50cec4a664d887ebe993393dea_d3afc21946814bb9a65328838065f1e4_CommandTarget;

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

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_a449fa516bbe4997a0ff2e734c206bff(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_a449fa516bbe4997a0ff2e734c206bff(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_a449fa516bbe4997a0ff2e734c206bff(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_a449fa516bbe4997a0ff2e734c206bff(_402d4b50cec4a664d887ebe993393dea_a449fa516bbe4997a0ff2e734c206bff command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_306adbe1494a4bdda72c5f3a9d19b087(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_306adbe1494a4bdda72c5f3a9d19b087(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_306adbe1494a4bdda72c5f3a9d19b087(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_306adbe1494a4bdda72c5f3a9d19b087(_402d4b50cec4a664d887ebe993393dea_306adbe1494a4bdda72c5f3a9d19b087 command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_a9822e34d5e642e480712de5b6c410cd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_a9822e34d5e642e480712de5b6c410cd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_a9822e34d5e642e480712de5b6c410cd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_a9822e34d5e642e480712de5b6c410cd(_402d4b50cec4a664d887ebe993393dea_a9822e34d5e642e480712de5b6c410cd command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_50bfad94a27e4bc08a88f842d2ae3263(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_50bfad94a27e4bc08a88f842d2ae3263(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_50bfad94a27e4bc08a88f842d2ae3263(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_50bfad94a27e4bc08a88f842d2ae3263(_402d4b50cec4a664d887ebe993393dea_50bfad94a27e4bc08a88f842d2ae3263 command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_14ffc30aa4554f83ad8cecc4824f102b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_14ffc30aa4554f83ad8cecc4824f102b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_14ffc30aa4554f83ad8cecc4824f102b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_14ffc30aa4554f83ad8cecc4824f102b(_402d4b50cec4a664d887ebe993393dea_14ffc30aa4554f83ad8cecc4824f102b command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_8d9637bc60ab42bf862ed085f9457c6f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_8d9637bc60ab42bf862ed085f9457c6f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_8d9637bc60ab42bf862ed085f9457c6f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_8d9637bc60ab42bf862ed085f9457c6f(_402d4b50cec4a664d887ebe993393dea_8d9637bc60ab42bf862ed085f9457c6f command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_2552180bdfae4618b6895af1e6378dbf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_2552180bdfae4618b6895af1e6378dbf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_2552180bdfae4618b6895af1e6378dbf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_2552180bdfae4618b6895af1e6378dbf(_402d4b50cec4a664d887ebe993393dea_2552180bdfae4618b6895af1e6378dbf command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_20e45fc4b78d4e28898f0b47f675b501(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_20e45fc4b78d4e28898f0b47f675b501(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_20e45fc4b78d4e28898f0b47f675b501(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_20e45fc4b78d4e28898f0b47f675b501(_402d4b50cec4a664d887ebe993393dea_20e45fc4b78d4e28898f0b47f675b501 command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_6b44db5d31cd48b08740ae5b91071013(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_6b44db5d31cd48b08740ae5b91071013(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_6b44db5d31cd48b08740ae5b91071013(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_6b44db5d31cd48b08740ae5b91071013(_402d4b50cec4a664d887ebe993393dea_6b44db5d31cd48b08740ae5b91071013 command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_13119706ab3f4062936fe47ced7906b7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_13119706ab3f4062936fe47ced7906b7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_13119706ab3f4062936fe47ced7906b7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_13119706ab3f4062936fe47ced7906b7(_402d4b50cec4a664d887ebe993393dea_13119706ab3f4062936fe47ced7906b7 command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_7566e2f20df54d76b10dfad45b9eea52(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_7566e2f20df54d76b10dfad45b9eea52(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_7566e2f20df54d76b10dfad45b9eea52(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_7566e2f20df54d76b10dfad45b9eea52(_402d4b50cec4a664d887ebe993393dea_7566e2f20df54d76b10dfad45b9eea52 command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_8c20a5fdaabb4d99862fc9c2f87fda93(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_8c20a5fdaabb4d99862fc9c2f87fda93(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_8c20a5fdaabb4d99862fc9c2f87fda93(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_8c20a5fdaabb4d99862fc9c2f87fda93(_402d4b50cec4a664d887ebe993393dea_8c20a5fdaabb4d99862fc9c2f87fda93 command)
		{
		}

		private void BakeCommandBinding__402d4b50cec4a664d887ebe993393dea_d3afc21946814bb9a65328838065f1e4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__402d4b50cec4a664d887ebe993393dea_d3afc21946814bb9a65328838065f1e4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__402d4b50cec4a664d887ebe993393dea_d3afc21946814bb9a65328838065f1e4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__402d4b50cec4a664d887ebe993393dea_d3afc21946814bb9a65328838065f1e4(_402d4b50cec4a664d887ebe993393dea_d3afc21946814bb9a65328838065f1e4 command)
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
