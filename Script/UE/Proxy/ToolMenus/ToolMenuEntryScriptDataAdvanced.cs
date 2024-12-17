using Script.CoreUObject;
using Script.Library;
using Script.Slate;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced")]
	public partial class FToolMenuEntryScriptDataAdvanced : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FToolMenuEntryScriptDataAdvanced() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FToolMenuEntryScriptDataAdvanced() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FToolMenuEntryScriptDataAdvanced A, FToolMenuEntryScriptDataAdvanced B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FToolMenuEntryScriptDataAdvanced A, FToolMenuEntryScriptDataAdvanced B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FToolMenuEntryScriptDataAdvanced;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName TutorialHighlight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TutorialHighlight, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TutorialHighlight, __InBuffer);
				}
			}
		}

		public EMultiBlockType EntryType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EntryType, __ReturnBuffer);

					return *(EMultiBlockType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EntryType, __InBuffer);
				}
			}
		}

		public EUserInterfaceActionType UserInterfaceActionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserInterfaceActionType, __ReturnBuffer);

					return *(EUserInterfaceActionType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserInterfaceActionType, __InBuffer);
				}
			}
		}

		public FName StyleNameOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StyleNameOverride, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StyleNameOverride, __InBuffer);
				}
			}
		}

		public bool bIsSubMenu
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsSubMenu, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsSubMenu, __InBuffer);
				}
			}
		}

		public bool bOpenSubMenuOnClick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOpenSubMenuOnClick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOpenSubMenuOnClick, __InBuffer);
				}
			}
		}

		public bool bShouldCloseWindowAfterMenuSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShouldCloseWindowAfterMenuSelection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShouldCloseWindowAfterMenuSelection, __InBuffer);
				}
			}
		}

		public bool bSimpleComboBox
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSimpleComboBox, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSimpleComboBox, __InBuffer);
				}
			}
		}

		private static uint __TutorialHighlight = 0;

		private static uint __EntryType = 0;

		private static uint __UserInterfaceActionType = 0;

		private static uint __StyleNameOverride = 0;

		private static uint __bIsSubMenu = 0;

		private static uint __bOpenSubMenuOnClick = 0;

		private static uint __bShouldCloseWindowAfterMenuSelection = 0;

		private static uint __bSimpleComboBox = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}