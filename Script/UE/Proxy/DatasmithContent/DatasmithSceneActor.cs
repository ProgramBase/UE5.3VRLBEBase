using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithSceneActor")]
	public partial class ADatasmithSceneActor : AActor, IStaticClass
	{
		public UDatasmithScene Scene
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Scene, __ReturnBuffer);

					return *(UDatasmithScene*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Scene, __InBuffer);
				}
			}
		}

		public TMap<FName, TSoftObjectPtr<AActor>> RelatedActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RelatedActors, __ReturnBuffer);

					return *(TMap<FName, TSoftObjectPtr<AActor>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RelatedActors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithSceneActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Scene = 0;

		private static uint __RelatedActors = 0;
	}
}