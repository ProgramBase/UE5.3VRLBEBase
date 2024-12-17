using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CharacterServerMovePackedBits")]
	public partial class FCharacterServerMovePackedBits : FCharacterNetworkSerializationPackedBits, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CharacterServerMovePackedBits");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCharacterServerMovePackedBits()
		{
		}

		public static bool operator ==(FCharacterServerMovePackedBits A, FCharacterServerMovePackedBits B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCharacterServerMovePackedBits A, FCharacterServerMovePackedBits B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCharacterServerMovePackedBits;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}