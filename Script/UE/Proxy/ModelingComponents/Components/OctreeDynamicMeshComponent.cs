using Script.CoreUObject;
using Script.GeometryFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.OctreeDynamicMeshComponent")]
	public partial class UOctreeDynamicMeshComponent : UBaseDynamicMeshComponent, IStaticClass
	{
		public UDynamicMesh MeshObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshObject, __ReturnBuffer);

					return *(UDynamicMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshObject, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.OctreeDynamicMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetDynamicMesh(UDynamicMesh NewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDynamicMesh, __InBuffer);
			}
		}

		private static uint __MeshObject = 0;

		private static uint __SetDynamicMesh = 0;
	}
}