using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Engine;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.BakeMeshAttributeMapsResultToolProperties")]
	public partial class UBakeMeshAttributeMapsResultToolProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public TMap<EBakeMapType, UTexture2D> Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(TMap<EBakeMapType, UTexture2D>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.BakeMeshAttributeMapsResultToolProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Result = 0;
	}
}