using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Vector_NetQuantizeNormal")]
	public partial class FVector_NetQuantizeNormal : FVector, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.Vector_NetQuantizeNormal");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVector_NetQuantizeNormal()
		{
		}

		public static bool operator ==(FVector_NetQuantizeNormal A, FVector_NetQuantizeNormal B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVector_NetQuantizeNormal A, FVector_NetQuantizeNormal B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVector_NetQuantizeNormal;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}