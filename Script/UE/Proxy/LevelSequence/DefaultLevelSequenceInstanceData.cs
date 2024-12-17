using Script.CoreUObject;
using Script.MovieSceneTracks;
using Script.Engine;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.DefaultLevelSequenceInstanceData")]
	public partial class UDefaultLevelSequenceInstanceData : UObject, IStaticClass, IMovieSceneTransformOrigin
	{
		public AActor TransformOriginActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformOriginActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformOriginActor, __InBuffer);
				}
			}
		}

		public FTransform TransformOrigin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformOrigin, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformOrigin, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.DefaultLevelSequenceInstanceData");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FTransform BP_GetTransformOrigin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall1Implementation(GarbageCollectionHandle, __BP_GetTransformOrigin, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

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

		private static uint __TransformOriginActor = 0;

		private static uint __TransformOrigin = 0;

		private static uint __BP_GetTransformOrigin = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}