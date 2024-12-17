using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerNetPack")]
	public partial class FGameplayDebuggerNetPack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayDebugger.GameplayDebuggerNetPack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayDebuggerNetPack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayDebuggerNetPack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayDebuggerNetPack A, FGameplayDebuggerNetPack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayDebuggerNetPack A, FGameplayDebuggerNetPack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayDebuggerNetPack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public AGameplayDebuggerCategoryReplicator Owner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __ReturnBuffer);

					return *(AGameplayDebuggerCategoryReplicator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __InBuffer);
				}
			}
		}

		public TArray<FGameplayDebuggerCategoryData> SavedData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SavedData, __ReturnBuffer);

					return *(TArray<FGameplayDebuggerCategoryData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SavedData, __InBuffer);
				}
			}
		}

		private static uint __Owner = 0;

		private static uint __SavedData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}