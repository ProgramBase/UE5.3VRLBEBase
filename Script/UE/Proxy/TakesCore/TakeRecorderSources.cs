using Script.CoreUObject;
using Script.Library;
using Script.LevelSequence;
using Script.MovieScene;

namespace Script.TakesCore
{
	[PathName("/Script/TakesCore.TakeRecorderSources")]
	public partial class UTakeRecorderSources : UObject, IStaticClass
	{
		public TArray<UTakeRecorderSource> Sources
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sources, __ReturnBuffer);

					return *(TArray<UTakeRecorderSource>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sources, __InBuffer);
				}
			}
		}

		public TMap<UTakeRecorderSource, ULevelSequence> SourceSubSequenceMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceSubSequenceMap, __ReturnBuffer);

					return *(TMap<UTakeRecorderSource, ULevelSequence>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceSubSequenceMap, __InBuffer);
				}
			}
		}

		public TArray<UMovieSceneSubSection> ActiveSubSections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveSubSections, __ReturnBuffer);

					return *(TArray<UMovieSceneSubSection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveSubSections, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakesCore.TakeRecorderSources");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StartRecordingSource(TArray<UTakeRecorderSource> InSources, FQualifiedFrameTime CurrentFrameTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InSources?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurrentFrameTime?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartRecordingSource, __InBuffer);
			}
		}

		/// <param name="InSource">
		/// The source to remove
		/// </param>
		public virtual void RemoveSource(UTakeRecorderSource InSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSource?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveSource, __InBuffer);
			}
		}

		public virtual TArray<UTakeRecorderSource> GetSourcesCopy()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSourcesCopy, __ReturnBuffer);

				return *(TArray<UTakeRecorderSource>*)__ReturnBuffer;
			}
		}

		/// <param name="InSourceType">
		/// The class type of the source to add
		/// </param>
		/// <returns>
		/// An instance of the specified source type
		/// </returns>
		public virtual UTakeRecorderSource AddSource(TSubclassOf<UTakeRecorderSource> InSourceType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSourceType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddSource, __InBuffer, __ReturnBuffer);

				return *(UTakeRecorderSource*)__ReturnBuffer;
			}
		}

		private static uint __Sources = 0;

		private static uint __SourceSubSequenceMap = 0;

		private static uint __ActiveSubSections = 0;

		private static uint __StartRecordingSource = 0;

		private static uint __RemoveSource = 0;

		private static uint __GetSourcesCopy = 0;

		private static uint __AddSource = 0;
	}
}