using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ImgMediaEngine
{
	[PathName("/Script/ImgMediaEngine.ImgMediaPlaybackComponent")]
	public partial class UDEPRECATED_ImgMediaPlaybackComponent : UActorComponent, IStaticClass
	{
		public float LODBias
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODBias, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODBias, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ImgMediaEngine.ImgMediaPlaybackComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LODBias = 0;
	}
}