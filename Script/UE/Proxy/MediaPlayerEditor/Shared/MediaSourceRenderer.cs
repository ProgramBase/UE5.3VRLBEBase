using Script.CoreUObject;
using Script.MediaAssets;
using Script.Library;

namespace Script.MediaPlayerEditor
{
	[PathName("/Script/MediaPlayerEditor.MediaSourceRenderer")]
	public partial class UMediaSourceRenderer : UObject, IStaticClass, IMediaSourceRendererInterface
	{
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

		public UMediaSource MediaSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaSource, __ReturnBuffer);

					return *(UMediaSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaSource, __InBuffer);
				}
			}
		}

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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlayerEditor.MediaSourceRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }

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

		public virtual void OnSeekCompleted()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnSeekCompleted);
			}
		}

		private static uint __MediaPlayer = 0;

		private static uint __MediaSource = 0;

		private static uint __MediaTexture = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __OnSeekCompleted = 0;
	}
}