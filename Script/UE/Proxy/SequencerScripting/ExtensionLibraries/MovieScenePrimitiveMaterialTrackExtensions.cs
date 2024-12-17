using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieSceneTracks;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieScenePrimitiveMaterialTrackExtensions")]
	public partial class UMovieScenePrimitiveMaterialTrackExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieScenePrimitiveMaterialTrackExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <param name="MaterialIndex">
		/// The desired material index to animate. Values of < 0 or >= NumMaterials will be silently ignored and evaluation will fail.
		/// </param>
		public static void SetMaterialIndex(UMovieScenePrimitiveMaterialTrack Track, int MaterialIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = MaterialIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetMaterialIndex, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <returns>
		/// The material index.
		/// </returns>
		public static int GetMaterialIndex(UMovieScenePrimitiveMaterialTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaterialIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SetMaterialIndex = 0;

		private static uint __GetMaterialIndex = 0;
	}
}