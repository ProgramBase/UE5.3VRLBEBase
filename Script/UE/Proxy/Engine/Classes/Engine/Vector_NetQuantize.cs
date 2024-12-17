using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Vector_NetQuantize")]
	public partial class FVector_NetQuantize : FVector, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.Vector_NetQuantize");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVector_NetQuantize()
		{
		}

		public static bool operator ==(FVector_NetQuantize A, FVector_NetQuantize B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVector_NetQuantize A, FVector_NetQuantize B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVector_NetQuantize;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}