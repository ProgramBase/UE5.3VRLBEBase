using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.LevelSequenceEditorSettings")]
	public partial class ULevelSequenceEditorSettings : UObject, IStaticClass
	{
		public TArray<FLevelSequenceTrackSettings> TrackSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TrackSettings, __ReturnBuffer);

					return *(TArray<FLevelSequenceTrackSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TrackSettings, __InBuffer);
				}
			}
		}

		public bool bAutoBindToPIE
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoBindToPIE, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoBindToPIE, __InBuffer);
				}
			}
		}

		public bool bAutoBindToSimulate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoBindToSimulate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoBindToSimulate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequenceEditor.LevelSequenceEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TrackSettings = 0;

		private static uint __bAutoBindToPIE = 0;

		private static uint __bAutoBindToSimulate = 0;
	}
}