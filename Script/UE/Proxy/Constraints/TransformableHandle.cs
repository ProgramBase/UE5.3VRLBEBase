using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.TransformableHandle")]
	public partial class UTransformableHandle : UObject, IStaticClass
	{
		public FMovieSceneObjectBindingID ConstraintBindingID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintBindingID, __ReturnBuffer);

					return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintBindingID, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Constraints.TransformableHandle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ConstraintBindingID = 0;
	}
}