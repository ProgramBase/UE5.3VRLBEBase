using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.BaseMeshProcessingTool")]
	public partial class UBaseMeshProcessingTool : USingleSelectionTool, IStaticClass
	{
		public UMeshOpPreviewWithBackgroundCompute Preview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Preview, __ReturnBuffer);

					return *(UMeshOpPreviewWithBackgroundCompute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Preview, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.BaseMeshProcessingTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Preview = 0;
	}
}