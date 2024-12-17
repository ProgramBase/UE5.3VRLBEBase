using Script.CoreUObject;
using Script.MovieScene;
using Script.Engine;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequence")]
	public partial class ULevelSequence : UMovieSceneSequence, IStaticClass, IInterface_AssetUserData
	{
		public UMovieScene MovieScene
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScene, __ReturnBuffer);

					return *(UMovieScene*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScene, __InBuffer);
				}
			}
		}

		public FLevelSequenceObjectReferenceMap ObjectReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectReferences, __ReturnBuffer);

					return *(FLevelSequenceObjectReferenceMap*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectReferences, __InBuffer);
				}
			}
		}

		public FLevelSequenceBindingReferences BindingReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BindingReferences, __ReturnBuffer);

					return *(FLevelSequenceBindingReferences*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BindingReferences, __InBuffer);
				}
			}
		}

		public UBlueprint DirectorBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorBlueprint, __ReturnBuffer);

					return *(UBlueprint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorBlueprint, __InBuffer);
				}
			}
		}

		public TSubclassOf<UObject> DirectorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectorClass, __InBuffer);
				}
			}
		}

		public TArray<UObject> MetaDataObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MetaDataObjects, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MetaDataObjects, __InBuffer);
				}
			}
		}

		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __ReturnBuffer);

					return *(TArray<UAssetUserData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.LevelSequence");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		/// <param name="InClass">
		/// - The class type that you wish to remove the metadata for
		/// </param>
		public virtual void RemoveMetaDataByClass(TSubclassOf<UObject> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveMetaDataByClass, __InBuffer);
			}
		}

		/// <param name="InClass">
		/// - Class that you wish to find or create the metadata object for.
		/// </param>
		/// <returns>
		/// An instance of this class as metadata on this Level Sequence.
		/// </returns>
		public virtual UObject FindOrAddMetaDataByClass(TSubclassOf<UObject> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindOrAddMetaDataByClass, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="InClass">
		/// - Class that you wish to find the metadata object for.
		/// </param>
		/// <returns>
		/// An instance of this class if it already exists as metadata on this Level Sequence, otherwise null.
		/// </returns>
		public virtual UObject FindMetaDataByClass(TSubclassOf<UObject> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindMetaDataByClass, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="InMetaData">
		/// - Existing Metadata Object that you wish to copy into this Level Sequence.
		/// </param>
		/// <returns>
		/// The newly copied instance of the Metadata that now exists on this sequence.
		/// </returns>
		public virtual UObject CopyMetaData(UObject InMetaData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMetaData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CopyMetaData, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		private static uint __MovieScene = 0;

		private static uint __ObjectReferences = 0;

		private static uint __BindingReferences = 0;

		private static uint __DirectorBlueprint = 0;

		private static uint __DirectorClass = 0;

		private static uint __MetaDataObjects = 0;

		private static uint __AssetUserData = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __RemoveMetaDataByClass = 0;

		private static uint __FindOrAddMetaDataByClass = 0;

		private static uint __FindMetaDataByClass = 0;

		private static uint __CopyMetaData = 0;
	}
}