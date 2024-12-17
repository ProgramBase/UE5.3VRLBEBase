using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.SpaceDeformerOperatorFactory")]
	public partial class USpaceDeformerOperatorFactory : UObject, IStaticClass
	{
		public UMeshSpaceDeformerTool SpaceDeformerTool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpaceDeformerTool, __ReturnBuffer);

					return *(UMeshSpaceDeformerTool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpaceDeformerTool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.SpaceDeformerOperatorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SpaceDeformerTool = 0;
	}
}