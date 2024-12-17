using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.DeprecateSlateVector2D")]
	public partial class FDeprecateSlateVector2D : FVector2f, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.DeprecateSlateVector2D");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDeprecateSlateVector2D()
		{
		}

		public static bool operator ==(FDeprecateSlateVector2D A, FDeprecateSlateVector2D B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDeprecateSlateVector2D A, FDeprecateSlateVector2D B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDeprecateSlateVector2D;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}