using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheTrack_TransformAnimation")]
	public partial class UDEPRECATED_GeometryCacheTrack_TransformAnimation : UGeometryCacheTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCache.GeometryCacheTrack_TransformAnimation");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="NewMeshData">
		/// - GeometryCacheMeshData instance later used as the rendered mesh	
		/// </param>
		public virtual void SetMesh(FGeometryCacheMeshData NewMeshData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMeshData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMesh, __InBuffer);
			}
		}

		private static uint __SetMesh = 0;
	}
}