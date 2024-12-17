using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CharacterNetworkSerializationPackedBits")]
	public partial class FCharacterNetworkSerializationPackedBits : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CharacterNetworkSerializationPackedBits");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCharacterNetworkSerializationPackedBits() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCharacterNetworkSerializationPackedBits() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCharacterNetworkSerializationPackedBits A, FCharacterNetworkSerializationPackedBits B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCharacterNetworkSerializationPackedBits A, FCharacterNetworkSerializationPackedBits B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCharacterNetworkSerializationPackedBits;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}