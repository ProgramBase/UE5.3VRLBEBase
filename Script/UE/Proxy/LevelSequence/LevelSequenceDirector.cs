using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;
using Script.Engine;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceDirector")]
	public partial class ULevelSequenceDirector : UObject, IStaticClass
	{
		public ULevelSequencePlayer Player
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Player, __ReturnBuffer);

					return *(ULevelSequencePlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Player, __InBuffer);
				}
			}
		}

		public int SubSequenceID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubSequenceID, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubSequenceID, __InBuffer);
				}
			}
		}

		public int MovieScenePlayerIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScenePlayerIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScenePlayerIndex, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.LevelSequenceDirector");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnCreated()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnCreated);
			}
		}

		public virtual UMovieSceneSequence GetSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSequence, __ReturnBuffer);

				return *(UMovieSceneSequence*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The current playback position of the outermost (root) sequence
		/// </returns>
		public virtual FQualifiedFrameTime GetRootSequenceTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRootSequenceTime, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
			}
		}

		public virtual FQualifiedFrameTime GetMasterSequenceTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMasterSequenceTime, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The current playback position of this director's sequence
		/// </returns>
		public virtual FQualifiedFrameTime GetCurrentTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentTime, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
			}
		}

		/// <note>
		/// : ObjectBinding should be constructed from the same sequence as this Sequence Director's owning Sequence (see the GetSequenceBinding node)
		/// </note>
		/// <param name="ObjectBinding">
		/// The ID for the object binding inside this sub-sequence or one of its children to resolve
		/// </param>
		public virtual TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoundObjects, __InBuffer, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// : ObjectBinding should be constructed from the same sequence as this Sequence Director's owning Sequence (see the GetSequenceBinding node)
		/// </note>
		/// <param name="ObjectBinding">
		/// The ID for the object binding inside this sub-sequence or one of its children to resolve
		/// </param>
		public virtual UObject GetBoundObject(FMovieSceneObjectBindingID ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoundObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <note>
		/// : ObjectBinding should be constructed from the same sequence as this Sequence Director's owning Sequence (see the GetSequenceBinding node)
		/// </note>
		/// <param name="ObjectBinding">
		/// The ID for the object binding inside this sub-sequence or one of its children to resolve
		/// </param>
		public virtual TArray<AActor> GetBoundActors(FMovieSceneObjectBindingID ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoundActors, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// : ObjectBinding should be constructed from the same sequence as this Sequence Director's owning Sequence (see the GetSequenceBinding node)
		/// </note>
		/// <param name="ObjectBinding">
		/// The ID for the object binding inside this sub-sequence or one of its children to resolve
		/// </param>
		public virtual AActor GetBoundActor(FMovieSceneObjectBindingID ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoundActor, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		private static uint __Player = 0;

		private static uint __SubSequenceID = 0;

		private static uint __MovieScenePlayerIndex = 0;

		private static uint __OnCreated = 0;

		private static uint __GetSequence = 0;

		private static uint __GetRootSequenceTime = 0;

		private static uint __GetMasterSequenceTime = 0;

		private static uint __GetCurrentTime = 0;

		private static uint __GetBoundObjects = 0;

		private static uint __GetBoundObject = 0;

		private static uint __GetBoundActors = 0;

		private static uint __GetBoundActor = 0;
	}
}