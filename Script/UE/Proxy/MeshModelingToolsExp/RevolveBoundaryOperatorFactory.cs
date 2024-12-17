using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.RevolveBoundaryOperatorFactory")]
	public partial class URevolveBoundaryOperatorFactory : UObject, IStaticClass
	{
		public URevolveBoundaryTool RevolveBoundaryTool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RevolveBoundaryTool, __ReturnBuffer);

					return *(URevolveBoundaryTool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RevolveBoundaryTool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.RevolveBoundaryOperatorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RevolveBoundaryTool = 0;
	}
}