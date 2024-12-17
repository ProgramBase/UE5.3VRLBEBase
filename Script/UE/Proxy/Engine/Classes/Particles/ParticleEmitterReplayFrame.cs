﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleEmitterReplayFrame")]
	public partial class FParticleEmitterReplayFrame : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ParticleEmitterReplayFrame");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FParticleEmitterReplayFrame() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FParticleEmitterReplayFrame() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FParticleEmitterReplayFrame A, FParticleEmitterReplayFrame B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FParticleEmitterReplayFrame A, FParticleEmitterReplayFrame B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FParticleEmitterReplayFrame;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}