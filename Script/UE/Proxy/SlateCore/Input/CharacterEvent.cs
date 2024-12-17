using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.CharacterEvent")]
	public partial class FCharacterEvent : FInputEvent, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.CharacterEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCharacterEvent()
		{
		}

		public static bool operator ==(FCharacterEvent A, FCharacterEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCharacterEvent A, FCharacterEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCharacterEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}