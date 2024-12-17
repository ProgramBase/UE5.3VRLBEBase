using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackEditorData")]
	public partial class UNiagaraStackEditorData : UNiagaraEditorDataBase, IStaticClass
	{
		public bool bHideDisabledModules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHideDisabledModules, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHideDisabledModules, __InBuffer);
				}
			}
		}

		public TMap<FString, bool> StackEntryKeyToExpandedMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StackEntryKeyToExpandedMap, __ReturnBuffer);

					return *(TMap<FString, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StackEntryKeyToExpandedMap, __InBuffer);
				}
			}
		}

		public TMap<FString, ENiagaraStackEntryInlineDisplayMode> StackEntryKeyToInlineDisplayModeMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StackEntryKeyToInlineDisplayModeMap, __ReturnBuffer);

					return *(TMap<FString, ENiagaraStackEntryInlineDisplayMode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StackEntryKeyToInlineDisplayModeMap, __InBuffer);
				}
			}
		}

		public TMap<FString, bool> StackEntryKeyToExpandedOverviewMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StackEntryKeyToExpandedOverviewMap, __ReturnBuffer);

					return *(TMap<FString, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StackEntryKeyToExpandedOverviewMap, __InBuffer);
				}
			}
		}

		public TMap<FString, FText> StackEntryKeyToDisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StackEntryKeyToDisplayName, __ReturnBuffer);

					return *(TMap<FString, FText>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StackEntryKeyToDisplayName, __InBuffer);
				}
			}
		}

		public TArray<FString> DismissedStackIssueIds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DismissedStackIssueIds, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DismissedStackIssueIds, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackEditorData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bHideDisabledModules = 0;

		private static uint __StackEntryKeyToExpandedMap = 0;

		private static uint __StackEntryKeyToInlineDisplayModeMap = 0;

		private static uint __StackEntryKeyToExpandedOverviewMap = 0;

		private static uint __StackEntryKeyToDisplayName = 0;

		private static uint __DismissedStackIssueIds = 0;
	}
}