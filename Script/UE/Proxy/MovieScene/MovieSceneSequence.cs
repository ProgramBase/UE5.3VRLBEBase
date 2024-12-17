using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequence")]
	public partial class UMovieSceneSequence : UMovieSceneSignedObject, IStaticClass
	{
		public UMovieSceneCompiledData CompiledData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CompiledData, __ReturnBuffer);

					return *(UMovieSceneCompiledData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CompiledData, __InBuffer);
				}
			}
		}

		public EMovieSceneCompletionMode DefaultCompletionMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCompletionMode, __ReturnBuffer);

					return *(EMovieSceneCompletionMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCompletionMode, __InBuffer);
				}
			}
		}

		public bool bParentContextsAreSignificant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bParentContextsAreSignificant, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bParentContextsAreSignificant, __InBuffer);
				}
			}
		}

		public bool bPlayableDirectly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPlayableDirectly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPlayableDirectly, __InBuffer);
				}
			}
		}

		public EMovieSceneSequenceFlags SequenceFlags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SequenceFlags, __ReturnBuffer);

					return *(EMovieSceneSequenceFlags*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SequenceFlags, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneSequence");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FMovieSceneTimecodeSource GetEarliestTimecodeSource()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEarliestTimecodeSource, __ReturnBuffer);

				return *(FMovieSceneTimecodeSource*)__ReturnBuffer;
			}
		}

		public virtual TArray<FMovieSceneObjectBindingID> FindBindingsByTag(FName InBindingName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBindingName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindBindingsByTag, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneObjectBindingID>*)__ReturnBuffer;
			}
		}

		public virtual FMovieSceneObjectBindingID FindBindingByTag(FName InBindingName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBindingName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindBindingByTag, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
			}
		}

		private static uint __CompiledData = 0;

		private static uint __DefaultCompletionMode = 0;

		private static uint __bParentContextsAreSignificant = 0;

		private static uint __bPlayableDirectly = 0;

		private static uint __SequenceFlags = 0;

		private static uint __GetEarliestTimecodeSource = 0;

		private static uint __FindBindingsByTag = 0;

		private static uint __FindBindingByTag = 0;
	}
}