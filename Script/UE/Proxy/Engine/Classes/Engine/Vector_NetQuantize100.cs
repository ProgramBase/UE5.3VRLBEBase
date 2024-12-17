using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Vector_NetQuantize100")]
	public partial class FVector_NetQuantize100 : FVector, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.Vector_NetQuantize100");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVector_NetQuantize100()
		{
		}

		public static bool operator ==(FVector_NetQuantize100 A, FVector_NetQuantize100 B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVector_NetQuantize100 A, FVector_NetQuantize100 B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVector_NetQuantize100;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}