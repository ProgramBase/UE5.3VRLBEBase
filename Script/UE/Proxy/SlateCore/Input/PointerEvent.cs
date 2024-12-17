using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.PointerEvent")]
	public partial class FPointerEvent : FInputEvent, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.PointerEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPointerEvent()
		{
		}

		public static bool operator ==(FPointerEvent A, FPointerEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPointerEvent A, FPointerEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPointerEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}