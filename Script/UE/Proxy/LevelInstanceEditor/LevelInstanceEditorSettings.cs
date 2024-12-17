using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.UnrealEd;
using Script.Library;

namespace Script.LevelInstanceEditor
{
	[PathName("/Script/LevelInstanceEditor.LevelInstanceEditorSettings")]
	public partial class ULevelInstanceEditorSettings : UDeveloperSettings, IStaticClass
	{
		public TArray<FTemplateMapInfo> TemplateMapInfos
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateMapInfos, __ReturnBuffer);

					return *(TArray<FTemplateMapInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateMapInfos, __InBuffer);
				}
			}
		}

		public FString LevelInstanceClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelInstanceClassName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelInstanceClassName, __InBuffer);
				}
			}
		}

		public bool bEnableStreaming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableStreaming, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableStreaming, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelInstanceEditor.LevelInstanceEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TemplateMapInfos = 0;

		private static uint __LevelInstanceClassName = 0;

		private static uint __bEnableStreaming = 0;
	}
}