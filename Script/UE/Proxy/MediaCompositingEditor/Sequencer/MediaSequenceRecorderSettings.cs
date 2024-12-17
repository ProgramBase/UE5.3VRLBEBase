using Script.CoreUObject;
using Script.Library;

namespace Script.MediaCompositingEditor
{
	[PathName("/Script/MediaCompositingEditor.MediaSequenceRecorderSettings")]
	public partial class UMediaSequenceRecorderSettings : UObject, IStaticClass
	{
		public bool bRecordMediaPlayerEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRecordMediaPlayerEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRecordMediaPlayerEnabled, __InBuffer);
				}
			}
		}

		public FString MediaPlayerSubDirectory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayerSubDirectory, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayerSubDirectory, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaCompositingEditor.MediaSequenceRecorderSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bRecordMediaPlayerEnabled = 0;

		private static uint __MediaPlayerSubDirectory = 0;
	}
}