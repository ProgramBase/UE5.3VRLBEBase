using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.KeyEvent")]
	public partial class FKeyEvent : FInputEvent, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.KeyEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FKeyEvent()
		{
		}

		public static bool operator ==(FKeyEvent A, FKeyEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FKeyEvent A, FKeyEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FKeyEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}