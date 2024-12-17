using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaComponent")]
	public partial class UMediaComponent : UActorComponent, IStaticClass
	{
		public UMediaTexture MediaTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaTexture, __ReturnBuffer);

					return *(UMediaTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaTexture, __InBuffer);
				}
			}
		}

		public UMediaPlayer MediaPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayer, __ReturnBuffer);

					return *(UMediaPlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.MediaComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UMediaTexture GetMediaTexture()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMediaTexture, __ReturnBuffer);

				return *(UMediaTexture*)__ReturnBuffer;
			}
		}

		public virtual UMediaPlayer GetMediaPlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMediaPlayer, __ReturnBuffer);

				return *(UMediaPlayer*)__ReturnBuffer;
			}
		}

		private static uint __MediaTexture = 0;

		private static uint __MediaPlayer = 0;

		private static uint __GetMediaTexture = 0;

		private static uint __GetMediaPlayer = 0;
	}
}