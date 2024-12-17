using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheTrack_FlipbookAnimation")]
	public partial class UDEPRECATED_GeometryCacheTrack_FlipbookAnimation : UGeometryCacheTrack, IStaticClass
	{
		public uint NumMeshSamples
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumMeshSamples, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumMeshSamples, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCache.GeometryCacheTrack_FlipbookAnimation");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="MeshData">
		/// - Holds the mesh data for the specific sample
		/// </param>
		/// <param name="SampleTime">
		/// - SampleTime for the specific sample being added
		/// </param>
		/// <returns>
		/// void
		/// </returns>
		public virtual void AddMeshSample(FGeometryCacheMeshData MeshData, float SampleTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = MeshData?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = SampleTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddMeshSample, __InBuffer);
			}
		}

		private static uint __NumMeshSamples = 0;

		private static uint __AddMeshSample = 0;
	}
}