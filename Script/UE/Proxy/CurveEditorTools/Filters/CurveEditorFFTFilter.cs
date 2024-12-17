using Script.CoreUObject;
using Script.CurveEditor;
using Script.Library;

namespace Script.CurveEditorTools
{
	[PathName("/Script/CurveEditorTools.CurveEditorFFTFilter")]
	public partial class UCurveEditorFFTFilter : UCurveEditorFilterBase, IStaticClass
	{
		public float CutoffFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CutoffFrequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CutoffFrequency, __InBuffer);
				}
			}
		}

		public ECurveEditorFFTFilterType Type
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Type, __ReturnBuffer);

					return *(ECurveEditorFFTFilterType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Type, __InBuffer);
				}
			}
		}

		public ECurveEditorFFTFilterClass Response
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Response, __ReturnBuffer);

					return *(ECurveEditorFFTFilterClass*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Response, __InBuffer);
				}
			}
		}

		public int Order
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Order, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Order, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CurveEditorTools.CurveEditorFFTFilter");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CutoffFrequency = 0;

		private static uint __Type = 0;

		private static uint __Response = 0;

		private static uint __Order = 0;
	}
}