using Script.CoreUObject;
using Script.Library;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.SequencerTimeChangeUndoRedoProxy")]
	public partial class USequencerTimeChangeUndoRedoProxy : UObject, IStaticClass
	{
		public FQualifiedFrameTime Time
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Time, __ReturnBuffer);

					return *(FQualifiedFrameTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Time, __InBuffer);
				}
			}
		}

		public bool bTimeWasSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTimeWasSet, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTimeWasSet, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Sequencer.SequencerTimeChangeUndoRedoProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Time = 0;

		private static uint __bTimeWasSet = 0;
	}
}