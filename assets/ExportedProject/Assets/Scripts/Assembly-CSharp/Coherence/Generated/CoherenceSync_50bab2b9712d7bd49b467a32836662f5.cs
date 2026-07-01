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
using VampireSurvivors.Objects.Characters.Enemies;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_50bab2b9712d7bd49b467a32836662f5 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _50bab2b9712d7bd49b467a32836662f5_f54466f4a277437b8a641984e685555a_CommandTarget;

		private EnemyTheEnder _50bab2b9712d7bd49b467a32836662f5_584138cc5f0e4283a7a754727acf1f9b_CommandTarget;

		private EnemyTheEnder _50bab2b9712d7bd49b467a32836662f5_812043d85fb844aa9d1ddbe514493ce5_CommandTarget;

		private EnemyTheEnder _50bab2b9712d7bd49b467a32836662f5_afcf47362b7f45ba88152ec3f14fd8b4_CommandTarget;

		private EnemyTheEnder _50bab2b9712d7bd49b467a32836662f5_9c77e5f2b4b748528b6bf86549ed293a_CommandTarget;

		private EnemyTheEnder _50bab2b9712d7bd49b467a32836662f5_f11a35e85bcd45ebb8d08842925656de_CommandTarget;

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

		private void BakeCommandBinding__50bab2b9712d7bd49b467a32836662f5_f54466f4a277437b8a641984e685555a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__50bab2b9712d7bd49b467a32836662f5_f54466f4a277437b8a641984e685555a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__50bab2b9712d7bd49b467a32836662f5_f54466f4a277437b8a641984e685555a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__50bab2b9712d7bd49b467a32836662f5_f54466f4a277437b8a641984e685555a(_50bab2b9712d7bd49b467a32836662f5_f54466f4a277437b8a641984e685555a command)
		{
		}

		private void BakeCommandBinding__50bab2b9712d7bd49b467a32836662f5_584138cc5f0e4283a7a754727acf1f9b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__50bab2b9712d7bd49b467a32836662f5_584138cc5f0e4283a7a754727acf1f9b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__50bab2b9712d7bd49b467a32836662f5_584138cc5f0e4283a7a754727acf1f9b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__50bab2b9712d7bd49b467a32836662f5_584138cc5f0e4283a7a754727acf1f9b(_50bab2b9712d7bd49b467a32836662f5_584138cc5f0e4283a7a754727acf1f9b command)
		{
		}

		private void BakeCommandBinding__50bab2b9712d7bd49b467a32836662f5_812043d85fb844aa9d1ddbe514493ce5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__50bab2b9712d7bd49b467a32836662f5_812043d85fb844aa9d1ddbe514493ce5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__50bab2b9712d7bd49b467a32836662f5_812043d85fb844aa9d1ddbe514493ce5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__50bab2b9712d7bd49b467a32836662f5_812043d85fb844aa9d1ddbe514493ce5(_50bab2b9712d7bd49b467a32836662f5_812043d85fb844aa9d1ddbe514493ce5 command)
		{
		}

		private void BakeCommandBinding__50bab2b9712d7bd49b467a32836662f5_afcf47362b7f45ba88152ec3f14fd8b4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__50bab2b9712d7bd49b467a32836662f5_afcf47362b7f45ba88152ec3f14fd8b4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__50bab2b9712d7bd49b467a32836662f5_afcf47362b7f45ba88152ec3f14fd8b4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__50bab2b9712d7bd49b467a32836662f5_afcf47362b7f45ba88152ec3f14fd8b4(_50bab2b9712d7bd49b467a32836662f5_afcf47362b7f45ba88152ec3f14fd8b4 command)
		{
		}

		private void BakeCommandBinding__50bab2b9712d7bd49b467a32836662f5_9c77e5f2b4b748528b6bf86549ed293a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__50bab2b9712d7bd49b467a32836662f5_9c77e5f2b4b748528b6bf86549ed293a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__50bab2b9712d7bd49b467a32836662f5_9c77e5f2b4b748528b6bf86549ed293a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__50bab2b9712d7bd49b467a32836662f5_9c77e5f2b4b748528b6bf86549ed293a(_50bab2b9712d7bd49b467a32836662f5_9c77e5f2b4b748528b6bf86549ed293a command)
		{
		}

		private void BakeCommandBinding__50bab2b9712d7bd49b467a32836662f5_f11a35e85bcd45ebb8d08842925656de(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__50bab2b9712d7bd49b467a32836662f5_f11a35e85bcd45ebb8d08842925656de(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__50bab2b9712d7bd49b467a32836662f5_f11a35e85bcd45ebb8d08842925656de(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__50bab2b9712d7bd49b467a32836662f5_f11a35e85bcd45ebb8d08842925656de(_50bab2b9712d7bd49b467a32836662f5_f11a35e85bcd45ebb8d08842925656de command)
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
