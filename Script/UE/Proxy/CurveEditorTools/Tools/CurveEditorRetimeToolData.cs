using Script.CoreUObject;
using Script.Library;

namespace Script.CurveEditorTools
{
	[PathName("/Script/CurveEditorTools.CurveEditorRetimeToolData")]
	public partial class UCurveEditorRetimeToolData : UObject, IStaticClass
	{
		public TArray<FCurveEditorRetimeAnchor> RetimingAnchors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RetimingAnchors, __ReturnBuffer);

					return *(TArray<FCurveEditorRetimeAnchor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RetimingAnchors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CurveEditorTools.CurveEditorRetimeToolData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RetimingAnchors = 0;
	}
}