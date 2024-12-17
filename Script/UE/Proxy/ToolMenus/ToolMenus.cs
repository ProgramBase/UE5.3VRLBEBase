using Script.CoreUObject;
using Script.Library;
using Script.Slate;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolMenus")]
	public partial class UToolMenus : UObject, IStaticClass
	{
		public TArray<FCustomizedToolMenu> CustomizedMenus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomizedMenus, __ReturnBuffer);

					return *(TArray<FCustomizedToolMenu>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomizedMenus, __InBuffer);
				}
			}
		}

		public TMap<FName, FName> MenuSubstitutionsDuringGenerate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MenuSubstitutionsDuringGenerate, __ReturnBuffer);

					return *(TMap<FName, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MenuSubstitutionsDuringGenerate, __InBuffer);
				}
			}
		}

		public TMap<FName, UToolMenu> Menus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Menus, __ReturnBuffer);

					return *(TMap<FName, UToolMenu>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Menus, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolMenus.ToolMenus");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnregisterOwnerByName(FName InOwnerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InOwnerName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnregisterOwnerByName, __InBuffer);
			}
		}

		public virtual void SetSectionPosition(FName MenuName, FName SectionName, FName OtherSectionName, EToolMenuInsertType PositionType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = MenuName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OtherSectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)PositionType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSectionPosition, __InBuffer);
			}
		}

		public virtual void SetSectionLabel(FName MenuName, FName SectionName, FText Label)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MenuName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Label?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSectionLabel, __InBuffer);
			}
		}

		public virtual void RemoveSection(FName MenuName, FName Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MenuName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Section?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveSection, __InBuffer);
			}
		}

		public virtual void RemoveMenu(FName MenuName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MenuName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveMenu, __InBuffer);
			}
		}

		public virtual void RemoveEntry(FName MenuName, FName Section, FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MenuName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Name?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveEntry, __InBuffer);
			}
		}

		/// <param name="Parent">
		/// Optional name of a menu to layer on top of.
		/// </param>
		/// <param name="Type">
		/// Type of menu that will be generated such as: ToolBar, VerticalToolBar, etc..
		/// </param>
		/// <param name="bWarnIfAlreadyRegistered">
		/// Display warning if already registered
		/// </param>
		/// <returns>
		/// ToolMenu	Menu object
		/// </returns>
		public virtual UToolMenu RegisterMenu(FName Name, FName Parent = null, EMultiBoxType Type = EMultiBoxType.Menu, bool bWarnIfAlreadyRegistered = true)
		{
			unsafe
			{
				Parent ??= new FName("None");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Type;

				*(bool*)(__InBuffer + 17) = bWarnIfAlreadyRegistered;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __RegisterMenu, __InBuffer, __ReturnBuffer);

				return *(UToolMenu*)__ReturnBuffer;
			}
		}

		public virtual bool RefreshMenuWidget(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RefreshMenuWidget, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void RefreshAllWidgets()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RefreshAllWidgets);
			}
		}

		/// <param name="Name">
		/// Name of the menu to find.
		/// </param>
		/// <returns>
		/// bool	True if menu has already been registered.
		/// </returns>
		public virtual bool IsMenuRegistered(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsMenuRegistered, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UToolMenus Get()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Get, __ReturnBuffer);

				return *(UToolMenus*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the menu to find.
		/// </param>
		/// <returns>
		/// ToolMenu	Menu object. Returns null if not found.
		/// </returns>
		public virtual UToolMenu FindMenu(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindMenu, __InBuffer, __ReturnBuffer);

				return *(UToolMenu*)__ReturnBuffer;
			}
		}

		public static UObject FindContext(FToolMenuContext InContext, UClass InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindContext, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the menu to extend
		/// </param>
		/// <returns>
		/// ToolMenu	Menu object
		/// </returns>
		public virtual UToolMenu ExtendMenu(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ExtendMenu, __InBuffer, __ReturnBuffer);

				return *(UToolMenu*)__ReturnBuffer;
			}
		}

		public static bool AddMenuEntryObject(UToolMenuEntryScript MenuEntryObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MenuEntryObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddMenuEntryObject, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __CustomizedMenus = 0;

		private static uint __MenuSubstitutionsDuringGenerate = 0;

		private static uint __Menus = 0;

		private static uint __UnregisterOwnerByName = 0;

		private static uint __SetSectionPosition = 0;

		private static uint __SetSectionLabel = 0;

		private static uint __RemoveSection = 0;

		private static uint __RemoveMenu = 0;

		private static uint __RemoveEntry = 0;

		private static uint __RegisterMenu = 0;

		private static uint __RefreshMenuWidget = 0;

		private static uint __RefreshAllWidgets = 0;

		private static uint __IsMenuRegistered = 0;

		private static uint __Get = 0;

		private static uint __FindMenu = 0;

		private static uint __FindContext = 0;

		private static uint __ExtendMenu = 0;

		private static uint __AddMenuEntryObject = 0;
	}
}