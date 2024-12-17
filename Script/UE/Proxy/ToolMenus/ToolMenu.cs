using Script.CoreUObject;
using Script.Slate;
using Script.Library;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolMenu")]
	public partial class UToolMenu : UToolMenuBase, IStaticClass
	{
		public FName MenuName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MenuName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MenuName, __InBuffer);
				}
			}
		}

		public FName MenuParent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MenuParent, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MenuParent, __InBuffer);
				}
			}
		}

		public FName StyleName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StyleName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StyleName, __InBuffer);
				}
			}
		}

		public FName TutorialHighlightName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TutorialHighlightName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TutorialHighlightName, __InBuffer);
				}
			}
		}

		public EMultiBoxType MenuType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MenuType, __ReturnBuffer);

					return *(EMultiBoxType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MenuType, __InBuffer);
				}
			}
		}

		public bool bShouldCleanupContextOnDestroy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldCleanupContextOnDestroy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldCleanupContextOnDestroy, __InBuffer);
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

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldCloseWindowAfterMenuSelection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldCloseWindowAfterMenuSelection, __InBuffer);
				}
			}
		}

		public bool bCloseSelfOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCloseSelfOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCloseSelfOnly, __InBuffer);
				}
			}
		}

		public bool bSearchable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSearchable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSearchable, __InBuffer);
				}
			}
		}

		public bool bToolBarIsFocusable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bToolBarIsFocusable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bToolBarIsFocusable, __InBuffer);
				}
			}
		}

		public bool bToolBarForceSmallIcons
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bToolBarForceSmallIcons, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bToolBarForceSmallIcons, __InBuffer);
				}
			}
		}

		public bool bPreventCustomization
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPreventCustomization, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPreventCustomization, __InBuffer);
				}
			}
		}

		public FToolMenuOwner MenuOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MenuOwner, __ReturnBuffer);

					return *(FToolMenuOwner*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MenuOwner, __InBuffer);
				}
			}
		}

		public FToolMenuContext Context
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Context, __ReturnBuffer);

					return *(FToolMenuContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Context, __InBuffer);
				}
			}
		}

		public TArray<FToolMenuSection> Sections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sections, __ReturnBuffer);

					return *(TArray<FToolMenuSection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sections, __InBuffer);
				}
			}
		}

		public UToolMenu SubMenuParent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubMenuParent, __ReturnBuffer);

					return *(UToolMenu*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubMenuParent, __InBuffer);
				}
			}
		}

		public FName SubMenuSourceEntryName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubMenuSourceEntryName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubMenuSourceEntryName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolMenus.ToolMenu");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void InitMenu(FToolMenuOwner Owner, FName Name, FName Parent = null, EMultiBoxType Type = EMultiBoxType.Menu)
		{
			unsafe
			{
				Parent ??= new FName("None");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Owner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Type;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InitMenu, __InBuffer);
			}
		}

		public virtual UToolMenu AddSubMenuScript(FName Owner, FName SectionName, FName Name, FText Label, FText ToolTip = null)
		{
			unsafe
			{
				ToolTip ??= new FText("");

				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = Owner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Label?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ToolTip?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddSubMenuScript, __InBuffer, __ReturnBuffer);

				return *(UToolMenu*)__ReturnBuffer;
			}
		}

		public virtual void AddSectionScript(FName SectionName, FText Label = null, FName InsertName = null, EToolMenuInsertType InsertType = EToolMenuInsertType.Default)
		{
			unsafe
			{
				Label ??= new FText("");

				InsertName ??= new FName("None");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = SectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Label?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InsertName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)InsertType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddSectionScript, __InBuffer);
			}
		}

		public virtual void AddMenuEntryObject(UToolMenuEntryScript InObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddMenuEntryObject, __InBuffer);
			}
		}

		public virtual void AddMenuEntry(FName SectionName, FToolMenuEntry Args)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Args?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddMenuEntry, __InBuffer);
			}
		}

		public virtual void AddDynamicSectionScript(FName SectionName, UToolMenuSectionDynamic Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddDynamicSectionScript, __InBuffer);
			}
		}

		private static uint __MenuName = 0;

		private static uint __MenuParent = 0;

		private static uint __StyleName = 0;

		private static uint __TutorialHighlightName = 0;

		private static uint __MenuType = 0;

		private static uint __bShouldCleanupContextOnDestroy = 0;

		private static uint __bShouldCloseWindowAfterMenuSelection = 0;

		private static uint __bCloseSelfOnly = 0;

		private static uint __bSearchable = 0;

		private static uint __bToolBarIsFocusable = 0;

		private static uint __bToolBarForceSmallIcons = 0;

		private static uint __bPreventCustomization = 0;

		private static uint __MenuOwner = 0;

		private static uint __Context = 0;

		private static uint __Sections = 0;

		private static uint __SubMenuParent = 0;

		private static uint __SubMenuSourceEntryName = 0;

		private static uint __InitMenu = 0;

		private static uint __AddSubMenuScript = 0;

		private static uint __AddSectionScript = 0;

		private static uint __AddMenuEntryObject = 0;

		private static uint __AddMenuEntry = 0;

		private static uint __AddDynamicSectionScript = 0;
	}
}