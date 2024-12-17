using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.WeldMeshEdgesOperatorFactory")]
	public partial class UWeldMeshEdgesOperatorFactory : UObject, IStaticClass
	{
		public UWeldMeshEdgesTool WeldMeshEdgesTool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeldMeshEdgesTool, __ReturnBuffer);

					return *(UWeldMeshEdgesTool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeldMeshEdgesTool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.WeldMeshEdgesOperatorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WeldMeshEdgesTool = 0;
	}
}