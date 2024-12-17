using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Engine;
using Script.Library;

namespace Script.LevelInstanceEditor
{
	[PathName("/Script/LevelInstanceEditor.LevelInstanceEditorPerProjectUserSettings")]
	public partial class ULevelInstanceEditorPerProjectUserSettings : UDeveloperSettings, IStaticClass
	{
		public bool bAlwaysShowDialog
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowDialog, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowDialog, __InBuffer);
				}
			}
		}

		public ELevelInstancePivotType PivotType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PivotType, __ReturnBuffer);

					return *(ELevelInstancePivotType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PivotType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelInstanceEditor.LevelInstanceEditorPerProjectUserSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bAlwaysShowDialog = 0;

		private static uint __PivotType = 0;
	}
}