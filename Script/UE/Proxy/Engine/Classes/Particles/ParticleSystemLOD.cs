using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleSystemLOD")]
	public partial class FParticleSystemLOD : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ParticleSystemLOD");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FParticleSystemLOD() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FParticleSystemLOD() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FParticleSystemLOD A, FParticleSystemLOD B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FParticleSystemLOD A, FParticleSystemLOD B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FParticleSystemLOD;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}