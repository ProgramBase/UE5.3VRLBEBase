using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;
using Script.Engine;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.TemplateSequence")]
	public partial class UTemplateSequence : UMovieSceneSequence, IStaticClass
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

		public TSoftClassPtr<AActor> BoundActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoundActorClass, __ReturnBuffer);

					return *(TSoftClassPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoundActorClass, __InBuffer);
				}
			}
		}

		public TMap<FGuid, FName> BoundActorComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoundActorComponents, __ReturnBuffer);

					return *(TMap<FGuid, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoundActorComponents, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.TemplateSequence");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MovieScene = 0;

		private static uint __BoundActorClass = 0;

		private static uint __BoundActorComponents = 0;
	}
}