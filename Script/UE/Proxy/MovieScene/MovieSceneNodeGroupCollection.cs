using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneNodeGroupCollection")]
	public partial class UMovieSceneNodeGroupCollection : UObject, IStaticClass
	{
		public TArray<UMovieSceneNodeGroup> NodeGroups
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NodeGroups, __ReturnBuffer);

					return *(TArray<UMovieSceneNodeGroup>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NodeGroups, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneNodeGroupCollection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NodeGroups = 0;
	}
}