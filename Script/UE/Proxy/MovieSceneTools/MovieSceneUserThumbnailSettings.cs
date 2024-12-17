using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTools
{
	[PathName("/Script/MovieSceneTools.MovieSceneUserThumbnailSettings")]
	public partial class UMovieSceneUserThumbnailSettings : UObject, IStaticClass
	{
		public bool bDrawThumbnails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawThumbnails, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawThumbnails, __InBuffer);
				}
			}
		}

		public bool bDrawSingleThumbnails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawSingleThumbnails, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawSingleThumbnails, __InBuffer);
				}
			}
		}

		public FIntPoint ThumbnailSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailSize, __ReturnBuffer);

					return *(FIntPoint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailSize, __InBuffer);
				}
			}
		}

		public EThumbnailQuality Quality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Quality, __ReturnBuffer);

					return *(EThumbnailQuality*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Quality, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTools.MovieSceneUserThumbnailSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bDrawThumbnails = 0;

		private static uint __bDrawSingleThumbnails = 0;

		private static uint __ThumbnailSize = 0;

		private static uint __Quality = 0;
	}
}