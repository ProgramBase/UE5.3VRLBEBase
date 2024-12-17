using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.UVProjectionOperatorFactory")]
	public partial class UUVProjectionOperatorFactory : UObject, IStaticClass
	{
		public UUVProjectionTool Tool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tool, __ReturnBuffer);

					return *(UUVProjectionTool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.UVProjectionOperatorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Tool = 0;
	}
}