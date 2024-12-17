using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.NavigationEvent")]
	public partial class FNavigationEvent : FInputEvent, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.NavigationEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNavigationEvent()
		{
		}

		public static bool operator ==(FNavigationEvent A, FNavigationEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNavigationEvent A, FNavigationEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNavigationEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}