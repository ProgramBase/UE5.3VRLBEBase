using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.CustomMeshComponent
{
	[PathName("/Script/CustomMeshComponent.CustomMeshComponent")]
	public partial class UCustomMeshComponent : UMeshComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CustomMeshComponent.CustomMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomMeshTriangles(TArray<FCustomMeshTriangle> Triangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomMeshTriangles, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ClearCustomMeshTriangles()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearCustomMeshTriangles);
			}
		}

		public virtual void AddCustomMeshTriangles(TArray<FCustomMeshTriangle> Triangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddCustomMeshTriangles, __InBuffer);
			}
		}

		private static uint __SetCustomMeshTriangles = 0;

		private static uint __ClearCustomMeshTriangles = 0;

		private static uint __AddCustomMeshTriangles = 0;
	}
}