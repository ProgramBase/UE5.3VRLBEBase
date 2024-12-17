using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEntityComponentField")]
	public partial class FMovieSceneEntityComponentField : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEntityComponentField");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEntityComponentField() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEntityComponentField() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEntityComponentField A, FMovieSceneEntityComponentField B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEntityComponentField A, FMovieSceneEntityComponentField B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEntityComponentField;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneEvaluationFieldEntityTree PersistentEntityTree
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PersistentEntityTree, __ReturnBuffer);

					return *(FMovieSceneEvaluationFieldEntityTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PersistentEntityTree, __InBuffer);
				}
			}
		}

		public FMovieSceneEvaluationFieldEntityTree OneShotEntityTree
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OneShotEntityTree, __ReturnBuffer);

					return *(FMovieSceneEvaluationFieldEntityTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OneShotEntityTree, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneEvaluationFieldEntity> Entities
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Entities, __ReturnBuffer);

					return *(TArray<FMovieSceneEvaluationFieldEntity>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Entities, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneEvaluationFieldEntityMetaData> EntityMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EntityMetaData, __ReturnBuffer);

					return *(TArray<FMovieSceneEvaluationFieldEntityMetaData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EntityMetaData, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneEvaluationFieldSharedEntityMetaData> SharedMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SharedMetaData, __ReturnBuffer);

					return *(TArray<FMovieSceneEvaluationFieldSharedEntityMetaData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SharedMetaData, __InBuffer);
				}
			}
		}

		private static uint __PersistentEntityTree = 0;

		private static uint __OneShotEntityTree = 0;

		private static uint __Entities = 0;

		private static uint __EntityMetaData = 0;

		private static uint __SharedMetaData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}