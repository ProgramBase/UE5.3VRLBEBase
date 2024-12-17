using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTools
{
	[PathName("/Script/MovieSceneTools.K2Node_GetSequenceBinding")]
	public partial class UK2Node_GetSequenceBinding : UK2Node, IStaticClass
	{
		public FSoftObjectPath SourceSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceSequence, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceSequence, __InBuffer);
				}
			}
		}

		public FMovieSceneObjectBindingID Binding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Binding, __ReturnBuffer);

					return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Binding, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTools.K2Node_GetSequenceBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SourceSequence = 0;

		private static uint __Binding = 0;
	}
}