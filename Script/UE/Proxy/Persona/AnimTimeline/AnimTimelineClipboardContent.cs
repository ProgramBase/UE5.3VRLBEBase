using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.AnimTimelineClipboardContent")]
	public partial class UAnimTimelineClipboardContent : UObject, IStaticClass
	{
		public TArray<UAnimCurveBaseCopyObject> Curves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Curves, __ReturnBuffer);

					return *(TArray<UAnimCurveBaseCopyObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Curves, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.AnimTimelineClipboardContent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Curves = 0;
	}
}