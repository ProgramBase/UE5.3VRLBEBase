using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieSceneTracks;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieScenePropertyTrackExtensions")]
	public partial class UMovieScenePropertyTrackExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieScenePropertyTrackExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <param name="InPropertyName">
		/// The property name
		/// </param>
		/// <param name="InPropertyPath">
		/// The property path
		/// </param>
		public static void SetPropertyNameAndPath(UMovieScenePropertyTrack Track, FName InPropertyName, FString InPropertyPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InPropertyPath?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPropertyNameAndPath, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <param name="PropertyClass">
		/// The property class to set
		/// </param>
		public static void SetObjectPropertyClass(UMovieSceneObjectPropertyTrack Track, UClass PropertyClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetObjectPropertyClass, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <param name="InEnum">
		/// The enum to set
		/// </param>
		public static void SetByteTrackEnum(UMovieSceneByteTrack Track, UEnum InEnum)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InEnum?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetByteTrackEnum, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <returns>
		/// This track's unique name
		/// </returns>
		public static FName GetUniqueTrackName(UMovieScenePropertyTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetUniqueTrackName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <returns>
		/// This track's property path
		/// </returns>
		public static FString GetPropertyPath(UMovieScenePropertyTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPropertyPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <returns>
		/// This track's property name
		/// </returns>
		public static FName GetPropertyName(UMovieScenePropertyTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPropertyName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <returns>
		/// The property class for this object property track
		/// </returns>
		public static UClass GetObjectPropertyClass(UMovieSceneObjectPropertyTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetObjectPropertyClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <returns>
		/// The enum for this byte track
		/// </returns>
		public static UEnum GetByteTrackEnum(UMovieSceneByteTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetByteTrackEnum, __InBuffer, __ReturnBuffer);

				return *(UEnum*)__ReturnBuffer;
			}
		}

		private static uint __SetPropertyNameAndPath = 0;

		private static uint __SetObjectPropertyClass = 0;

		private static uint __SetByteTrackEnum = 0;

		private static uint __GetUniqueTrackName = 0;

		private static uint __GetPropertyPath = 0;

		private static uint __GetPropertyName = 0;

		private static uint __GetObjectPropertyClass = 0;

		private static uint __GetByteTrackEnum = 0;
	}
}