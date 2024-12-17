using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleSystemReplayFrame")]
	public partial class FParticleSystemReplayFrame : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ParticleSystemReplayFrame");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FParticleSystemReplayFrame() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FParticleSystemReplayFrame() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FParticleSystemReplayFrame A, FParticleSystemReplayFrame B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FParticleSystemReplayFrame A, FParticleSystemReplayFrame B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FParticleSystemReplayFrame;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}