using Script.CoreUObject;
using Script.SequenceRecorder;
using Script.MediaAssets;
using Script.Library;

namespace Script.MediaCompositingEditor
{
	[PathName("/Script/MediaCompositingEditor.MediaPlayerRecording")]
	public partial class UMediaPlayerRecording : USequenceRecordingBase, IStaticClass
	{
		public FMediaPlayerRecordingSettings RecordingSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RecordingSettings, __ReturnBuffer);

					return *(FMediaPlayerRecordingSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RecordingSettings, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UMediaPlayer> MediaPlayerToRecord
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayerToRecord, __ReturnBuffer);

					return *(TWeakObjectPtr<UMediaPlayer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayerToRecord, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaCompositingEditor.MediaPlayerRecording");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RecordingSettings = 0;

		private static uint __MediaPlayerToRecord = 0;
	}
}