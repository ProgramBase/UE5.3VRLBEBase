using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.SequencerExportTask")]
	public partial class USequencerExportTask : UAssetExportTask, IStaticClass
	{
		public UObject SequencerContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SequencerContext, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SequencerContext, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequenceEditor.SequencerExportTask");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SequencerContext = 0;
	}
}