using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ConvertToPolygonsOperatorFactory")]
	public partial class UConvertToPolygonsOperatorFactory : UObject, IStaticClass
	{
		public UConvertToPolygonsTool ConvertToPolygonsTool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConvertToPolygonsTool, __ReturnBuffer);

					return *(UConvertToPolygonsTool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConvertToPolygonsTool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.ConvertToPolygonsOperatorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ConvertToPolygonsTool = 0;
	}
}