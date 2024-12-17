using Script.CoreUObject;
using Script.Library;
using Script.IrisCore;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTagNetSerializerConfig")]
	public partial class FGameplayTagNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTags.GameplayTagNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayTagNetSerializerConfig()
		{
		}

		public static bool operator ==(FGameplayTagNetSerializerConfig A, FGameplayTagNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayTagNetSerializerConfig A, FGameplayTagNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayTagNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}