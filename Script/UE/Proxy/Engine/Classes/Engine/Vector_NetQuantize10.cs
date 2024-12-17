using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Vector_NetQuantize10")]
	public partial class FVector_NetQuantize10 : FVector, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.Vector_NetQuantize10");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVector_NetQuantize10()
		{
		}

		public static bool operator ==(FVector_NetQuantize10 A, FVector_NetQuantize10 B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVector_NetQuantize10 A, FVector_NetQuantize10 B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVector_NetQuantize10;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}