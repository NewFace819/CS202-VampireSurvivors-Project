using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;
using VampireSurvivors.Objects.Items;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_7275c9156596248468c4ce7faa234e2f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _7275c9156596248468c4ce7faa234e2f_47e95682edb045199e0cc953fa5231ed_CommandTarget;

		private NetworkPickup _7275c9156596248468c4ce7faa234e2f_ba9ac3ac35a64faf96d84fa026b7d97a_CommandTarget;

		private TreasureChest _7275c9156596248468c4ce7faa234e2f_419b62d9f5b241cfbbefa7b1a437c81c_CommandTarget;

		private NetworkPickup _7275c9156596248468c4ce7faa234e2f_83e6b59ae05c4ea8a0233e328ec8dac6_CommandTarget;

		private NetworkPickup _7275c9156596248468c4ce7faa234e2f_b5236609ff784ec1a75eabbe5034d003_CommandTarget;

		private NetworkPickup _7275c9156596248468c4ce7faa234e2f_a2ab4bf55456411caee1e344d908f59e_CommandTarget;

		private NetworkPickup _7275c9156596248468c4ce7faa234e2f_171c1dd1561f4f1abe83f2c373713a8d_CommandTarget;

		private TreasureChest _7275c9156596248468c4ce7faa234e2f_86977c9971314cc4995b5390a9507d11_CommandTarget;

		private TreasureChest _7275c9156596248468c4ce7faa234e2f_e40c0a8862104f32ab9b80d2f881386d_CommandTarget;

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

		private void BakeCommandBinding__7275c9156596248468c4ce7faa234e2f_47e95682edb045199e0cc953fa5231ed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7275c9156596248468c4ce7faa234e2f_47e95682edb045199e0cc953fa5231ed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7275c9156596248468c4ce7faa234e2f_47e95682edb045199e0cc953fa5231ed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7275c9156596248468c4ce7faa234e2f_47e95682edb045199e0cc953fa5231ed(_7275c9156596248468c4ce7faa234e2f_47e95682edb045199e0cc953fa5231ed command)
		{
		}

		private void BakeCommandBinding__7275c9156596248468c4ce7faa234e2f_ba9ac3ac35a64faf96d84fa026b7d97a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7275c9156596248468c4ce7faa234e2f_ba9ac3ac35a64faf96d84fa026b7d97a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7275c9156596248468c4ce7faa234e2f_ba9ac3ac35a64faf96d84fa026b7d97a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7275c9156596248468c4ce7faa234e2f_ba9ac3ac35a64faf96d84fa026b7d97a(_7275c9156596248468c4ce7faa234e2f_ba9ac3ac35a64faf96d84fa026b7d97a command)
		{
		}

		private void BakeCommandBinding__7275c9156596248468c4ce7faa234e2f_419b62d9f5b241cfbbefa7b1a437c81c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7275c9156596248468c4ce7faa234e2f_419b62d9f5b241cfbbefa7b1a437c81c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7275c9156596248468c4ce7faa234e2f_419b62d9f5b241cfbbefa7b1a437c81c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7275c9156596248468c4ce7faa234e2f_419b62d9f5b241cfbbefa7b1a437c81c(_7275c9156596248468c4ce7faa234e2f_419b62d9f5b241cfbbefa7b1a437c81c command)
		{
		}

		private void BakeCommandBinding__7275c9156596248468c4ce7faa234e2f_83e6b59ae05c4ea8a0233e328ec8dac6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7275c9156596248468c4ce7faa234e2f_83e6b59ae05c4ea8a0233e328ec8dac6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7275c9156596248468c4ce7faa234e2f_83e6b59ae05c4ea8a0233e328ec8dac6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7275c9156596248468c4ce7faa234e2f_83e6b59ae05c4ea8a0233e328ec8dac6(_7275c9156596248468c4ce7faa234e2f_83e6b59ae05c4ea8a0233e328ec8dac6 command)
		{
		}

		private void BakeCommandBinding__7275c9156596248468c4ce7faa234e2f_b5236609ff784ec1a75eabbe5034d003(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7275c9156596248468c4ce7faa234e2f_b5236609ff784ec1a75eabbe5034d003(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7275c9156596248468c4ce7faa234e2f_b5236609ff784ec1a75eabbe5034d003(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7275c9156596248468c4ce7faa234e2f_b5236609ff784ec1a75eabbe5034d003(_7275c9156596248468c4ce7faa234e2f_b5236609ff784ec1a75eabbe5034d003 command)
		{
		}

		private void BakeCommandBinding__7275c9156596248468c4ce7faa234e2f_a2ab4bf55456411caee1e344d908f59e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7275c9156596248468c4ce7faa234e2f_a2ab4bf55456411caee1e344d908f59e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7275c9156596248468c4ce7faa234e2f_a2ab4bf55456411caee1e344d908f59e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7275c9156596248468c4ce7faa234e2f_a2ab4bf55456411caee1e344d908f59e(_7275c9156596248468c4ce7faa234e2f_a2ab4bf55456411caee1e344d908f59e command)
		{
		}

		private void BakeCommandBinding__7275c9156596248468c4ce7faa234e2f_171c1dd1561f4f1abe83f2c373713a8d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7275c9156596248468c4ce7faa234e2f_171c1dd1561f4f1abe83f2c373713a8d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7275c9156596248468c4ce7faa234e2f_171c1dd1561f4f1abe83f2c373713a8d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7275c9156596248468c4ce7faa234e2f_171c1dd1561f4f1abe83f2c373713a8d(_7275c9156596248468c4ce7faa234e2f_171c1dd1561f4f1abe83f2c373713a8d command)
		{
		}

		private void BakeCommandBinding__7275c9156596248468c4ce7faa234e2f_86977c9971314cc4995b5390a9507d11(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7275c9156596248468c4ce7faa234e2f_86977c9971314cc4995b5390a9507d11(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7275c9156596248468c4ce7faa234e2f_86977c9971314cc4995b5390a9507d11(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7275c9156596248468c4ce7faa234e2f_86977c9971314cc4995b5390a9507d11(_7275c9156596248468c4ce7faa234e2f_86977c9971314cc4995b5390a9507d11 command)
		{
		}

		private void BakeCommandBinding__7275c9156596248468c4ce7faa234e2f_e40c0a8862104f32ab9b80d2f881386d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7275c9156596248468c4ce7faa234e2f_e40c0a8862104f32ab9b80d2f881386d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7275c9156596248468c4ce7faa234e2f_e40c0a8862104f32ab9b80d2f881386d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7275c9156596248468c4ce7faa234e2f_e40c0a8862104f32ab9b80d2f881386d(_7275c9156596248468c4ce7faa234e2f_e40c0a8862104f32ab9b80d2f881386d command)
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
