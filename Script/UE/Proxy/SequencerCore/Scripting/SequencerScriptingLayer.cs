using Script.CoreUObject;
using Script.Library;

namespace Script.SequencerCore
{
	[PathName("/Script/SequencerCore.SequencerScriptingLayer")]
	public partial class USequencerScriptingLayer : UObject, IStaticClass
	{
		public USequencerOutlinerScriptingObject Outliner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Outliner, __ReturnBuffer);

					return *(USequencerOutlinerScriptingObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Outliner, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerCore.SequencerScriptingLayer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Outliner = 0;
	}
}