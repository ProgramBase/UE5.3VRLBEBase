using Script.CoreUObject;
using Script.Library;
using Script.IrisCore;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTagContainerNetSerializerConfig")]
	public partial class FGameplayTagContainerNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTags.GameplayTagContainerNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayTagContainerNetSerializerConfig()
		{
		}

		public static bool operator ==(FGameplayTagContainerNetSerializerConfig A, FGameplayTagContainerNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayTagContainerNetSerializerConfig A, FGameplayTagContainerNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayTagContainerNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}