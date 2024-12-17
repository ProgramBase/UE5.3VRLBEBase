using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.InterchangeGLTFPipeline")]
	public partial class UInterchangeGLTFPipeline : UInterchangePipelineBase, IStaticClass
	{
		public bool bUseGLTFMaterialInstanceLibrary
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseGLTFMaterialInstanceLibrary, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseGLTFMaterialInstanceLibrary, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangePipelines.InterchangeGLTFPipeline");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bUseGLTFMaterialInstanceLibrary = 0;
	}
}