using Script.CoreUObject;
using Script.Library;
using Script.UnrealEd;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.ToolStackContext")]
	public partial class UToolStackContext : UObject, IStaticClass
	{
		public TWeakObjectPtr<UEdMode> EdMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EdMode, __ReturnBuffer);

					return *(TWeakObjectPtr<UEdMode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EdMode, __InBuffer);
				}
			}
		}

		public TMap<FString, FInteractiveToolStack> ToolStacks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToolStacks, __ReturnBuffer);

					return *(TMap<FString, FInteractiveToolStack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToolStacks, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.ToolStackContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EdMode = 0;

		private static uint __ToolStacks = 0;
	}
}