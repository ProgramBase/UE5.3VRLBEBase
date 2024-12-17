using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CharacterMoveResponsePackedBits")]
	public partial class FCharacterMoveResponsePackedBits : FCharacterNetworkSerializationPackedBits, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CharacterMoveResponsePackedBits");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCharacterMoveResponsePackedBits()
		{
		}

		public static bool operator ==(FCharacterMoveResponsePackedBits A, FCharacterMoveResponsePackedBits B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCharacterMoveResponsePackedBits A, FCharacterMoveResponsePackedBits B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCharacterMoveResponsePackedBits;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}