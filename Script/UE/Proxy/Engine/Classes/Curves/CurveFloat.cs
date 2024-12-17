using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CurveFloat")]
	public partial class UCurveFloat : UCurveBase, IStaticClass
	{
		public FRichCurve FloatCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FloatCurve, __ReturnBuffer);

					return *(FRichCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FloatCurve, __InBuffer);
				}
			}
		}

		public bool bIsEventCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEventCurve, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEventCurve, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CurveFloat");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual float GetFloatValue(float InTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InTime;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetFloatValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __FloatCurve = 0;

		private static uint __bIsEventCurve = 0;

		private static uint __GetFloatValue = 0;
	}
}