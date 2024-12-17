using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerCategoryConfig")]
	public partial class FGameplayDebuggerCategoryConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayDebugger.GameplayDebuggerCategoryConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayDebuggerCategoryConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayDebuggerCategoryConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayDebuggerCategoryConfig A, FGameplayDebuggerCategoryConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayDebuggerCategoryConfig A, FGameplayDebuggerCategoryConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayDebuggerCategoryConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString CategoryName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CategoryName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
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

		public int SlotIdx
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SlotIdx, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SlotIdx, __InBuffer);
				}
			}
		}

		public EGameplayDebuggerOverrideMode ActiveInGame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveInGame, __ReturnBuffer);

					return *(EGameplayDebuggerOverrideMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveInGame, __InBuffer);
				}
			}
		}

		public EGameplayDebuggerOverrideMode ActiveInSimulate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveInSimulate, __ReturnBuffer);

					return *(EGameplayDebuggerOverrideMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveInSimulate, __InBuffer);
				}
			}
		}

		public EGameplayDebuggerOverrideMode Hidden
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Hidden, __ReturnBuffer);

					return *(EGameplayDebuggerOverrideMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Hidden, __InBuffer);
				}
			}
		}

		public bool bOverrideSlotIdx
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideSlotIdx, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideSlotIdx, __InBuffer);
				}
			}
		}

		public TArray<FGameplayDebuggerInputConfig> InputHandlers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputHandlers, __ReturnBuffer);

					return *(TArray<FGameplayDebuggerInputConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputHandlers, __InBuffer);
				}
			}
		}

		private static uint __CategoryName = 0;

		private static uint __SlotIdx = 0;

		private static uint __ActiveInGame = 0;

		private static uint __ActiveInSimulate = 0;

		private static uint __Hidden = 0;

		private static uint __bOverrideSlotIdx = 0;

		private static uint __InputHandlers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}