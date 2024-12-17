using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.FoliageStatistics")]
	public partial class UFoliageStatistics : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.FoliageStatistics");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Mesh">
		/// The static mesh we are interested in counting
		/// </param>
		/// <param name="CenterPosition">
		/// The center position of the sphere
		/// </param>
		/// <param name="Radius">
		/// The radius of the sphere.
		/// return number of foliage instances with their mesh set to Mesh that overlap the sphere
		/// </param>
		public static int FoliageOverlappingSphereCount(UObject WorldContextObject, UStaticMesh StaticMesh, FVector CenterPosition, float Radius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = CenterPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FoliageOverlappingSphereCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to get instances of
		/// </param>
		/// <param name="Box">
		/// Box to use for overlap
		/// </param>
		/// <param name="OutTransforms">
		/// Array to populate with transforms
		/// </param>
		public static void FoliageOverlappingBoxTransforms(UObject WorldContextObject, UStaticMesh StaticMesh, FBox Box, ref TArray<FTransform> OutTransforms)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Box?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutTransforms?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __FoliageOverlappingBoxTransforms, __InBuffer, __OutBuffer);

				OutTransforms = *(TArray<FTransform>*)(__OutBuffer);

			}
		}

		/// <param name="StaticMesh">
		/// Mesh to count
		/// </param>
		/// <param name="Box">
		/// Box to overlap
		/// </param>
		public static int FoliageOverlappingBoxCount(UObject WorldContextObject, UStaticMesh StaticMesh, FBox Box)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Box?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FoliageOverlappingBoxCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __FoliageOverlappingSphereCount = 0;

		private static uint __FoliageOverlappingBoxTransforms = 0;

		private static uint __FoliageOverlappingBoxCount = 0;
	}
}