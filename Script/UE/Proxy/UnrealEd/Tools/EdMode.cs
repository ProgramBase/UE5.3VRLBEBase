using Script.CoreUObject;
using Script.EditorInteractiveToolsFramework;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EdMode")]
	public partial class UEdMode : UObject, IStaticClass
	{
		public UEdModeInteractiveToolsContext ModeToolsContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModeToolsContext, __ReturnBuffer);

					return *(UEdModeInteractiveToolsContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModeToolsContext, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UObject> SettingsClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SettingsClass, __ReturnBuffer);

					return *(TSoftClassPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SettingsClass, __InBuffer);
				}
			}
		}

		public UObject SettingsObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SettingsObject, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SettingsObject, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EdMode");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ModeToolsContext = 0;

		private static uint __SettingsClass = 0;

		private static uint __SettingsObject = 0;
	}
}