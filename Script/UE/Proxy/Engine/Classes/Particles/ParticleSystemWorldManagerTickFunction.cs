using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleSystemWorldManagerTickFunction")]
	public partial class FParticleSystemWorldManagerTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ParticleSystemWorldManagerTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FParticleSystemWorldManagerTickFunction()
		{
		}

		public static bool operator ==(FParticleSystemWorldManagerTickFunction A, FParticleSystemWorldManagerTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FParticleSystemWorldManagerTickFunction A, FParticleSystemWorldManagerTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FParticleSystemWorldManagerTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}