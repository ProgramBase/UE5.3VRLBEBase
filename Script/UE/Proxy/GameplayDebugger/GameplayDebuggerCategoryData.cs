using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerCategoryData")]
	public partial class FGameplayDebuggerCategoryData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayDebugger.GameplayDebuggerCategoryData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayDebuggerCategoryData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayDebuggerCategoryData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayDebuggerCategoryData A, FGameplayDebuggerCategoryData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayDebuggerCategoryData A, FGameplayDebuggerCategoryData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayDebuggerCategoryData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName CategoryName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CategoryName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CategoryName, __InBuffer);
				}
			}
		}

		public TArray<FString> TextLines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextLines, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextLines, __InBuffer);
				}
			}
		}

		public TArray<FGameplayDebuggerShape> Shapes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Shapes, __ReturnBuffer);

					return *(TArray<FGameplayDebuggerShape>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Shapes, __InBuffer);
				}
			}
		}

		public TArray<FGameplayDebuggerDataPackHeader> DataPacks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataPacks, __ReturnBuffer);

					return *(TArray<FGameplayDebuggerDataPackHeader>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataPacks, __InBuffer);
				}
			}
		}

		public bool bIsEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __InBuffer);
				}
			}
		}

		private static uint __CategoryName = 0;

		private static uint __TextLines = 0;

		private static uint __Shapes = 0;

		private static uint __DataPacks = 0;

		private static uint __bIsEnabled = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}