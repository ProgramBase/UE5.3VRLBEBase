using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieScenePossessable")]
	public partial class FMovieScenePossessable : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieScenePossessable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScenePossessable() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieScenePossessable() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieScenePossessable A, FMovieScenePossessable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScenePossessable A, FMovieScenePossessable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScenePossessable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> Tags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tags, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tags, __InBuffer);
				}
			}
		}

		public FMovieSceneDynamicBinding DynamicBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DynamicBinding, __ReturnBuffer);

					return *(FMovieSceneDynamicBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DynamicBinding, __InBuffer);
				}
			}
		}

		public FGuid Guid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Guid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Guid, __InBuffer);
				}
			}
		}

		public FString Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UObject> PossessedObjectClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PossessedObjectClass, __ReturnBuffer);

					return *(TSoftClassPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PossessedObjectClass, __InBuffer);
				}
			}
		}

		public FGuid ParentGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParentGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParentGuid, __InBuffer);
				}
			}
		}

		public FMovieSceneObjectBindingID SpawnableObjectBindingID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnableObjectBindingID, __ReturnBuffer);

					return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnableObjectBindingID, __InBuffer);
				}
			}
		}

		private static uint __Tags = 0;

		private static uint __DynamicBinding = 0;

		private static uint __Guid = 0;

		private static uint __Name = 0;

		private static uint __PossessedObjectClass = 0;

		private static uint __ParentGuid = 0;

		private static uint __SpawnableObjectBindingID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}