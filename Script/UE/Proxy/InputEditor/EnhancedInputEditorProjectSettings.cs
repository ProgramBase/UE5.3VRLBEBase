using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.EnhancedInput;
using Script.Library;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.EnhancedInputEditorProjectSettings")]
	public partial class UEnhancedInputEditorProjectSettings : UDeveloperSettings, IStaticClass
	{
		public TSoftClassPtr<UEnhancedPlayerInput> DefaultEditorInputClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorInputClass, __ReturnBuffer);

					return *(TSoftClassPtr<UEnhancedPlayerInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorInputClass, __InBuffer);
				}
			}
		}

		public TArray<FDefaultContextSetting> DefaultMappingContexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMappingContexts, __ReturnBuffer);

					return *(TArray<FDefaultContextSetting>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMappingContexts, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.EnhancedInputEditorProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultEditorInputClass = 0;

		private static uint __DefaultMappingContexts = 0;
	}
}