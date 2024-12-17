using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTagCreationWidgetHelper")]
	public partial class FGameplayTagCreationWidgetHelper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTags.GameplayTagCreationWidgetHelper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayTagCreationWidgetHelper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayTagCreationWidgetHelper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayTagCreationWidgetHelper A, FGameplayTagCreationWidgetHelper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayTagCreationWidgetHelper A, FGameplayTagCreationWidgetHelper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayTagCreationWidgetHelper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}