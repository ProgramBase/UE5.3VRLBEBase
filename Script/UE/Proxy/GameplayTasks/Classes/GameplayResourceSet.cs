using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.GameplayResourceSet")]
	public partial class FGameplayResourceSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayTasks.GameplayResourceSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayResourceSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayResourceSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayResourceSet A, FGameplayResourceSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayResourceSet A, FGameplayResourceSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayResourceSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}