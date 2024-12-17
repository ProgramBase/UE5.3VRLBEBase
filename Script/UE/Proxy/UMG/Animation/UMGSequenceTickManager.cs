using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UMGSequenceTickManager")]
	public partial class UUMGSequenceTickManager : UObject, IStaticClass
	{
		public TMap<TWeakObjectPtr<UUserWidget>, FSequenceTickManagerWidgetData> WeakUserWidgetData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeakUserWidgetData, __ReturnBuffer);

					return *(TMap<TWeakObjectPtr<UUserWidget>, FSequenceTickManagerWidgetData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeakUserWidgetData, __InBuffer);
				}
			}
		}

		public UMovieSceneEntitySystemLinker Linker
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Linker, __ReturnBuffer);

					return *(UMovieSceneEntitySystemLinker*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Linker, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UMGSequenceTickManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WeakUserWidgetData = 0;

		private static uint __Linker = 0;
	}
}