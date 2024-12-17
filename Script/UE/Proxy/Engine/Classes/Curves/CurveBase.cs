using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CurveBase")]
	public partial class UCurveBase : UObject, IStaticClass
	{
		public UAssetImportData AssetImportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportData, __ReturnBuffer);

					return *(UAssetImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CurveBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void GetValueRange(ref float MinValue, ref float MaxValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = MinValue;

				*(float*)(__InBuffer + 4) = MaxValue;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetValueRange, __InBuffer, __OutBuffer);

				MinValue = *(float*)(__OutBuffer);

				MaxValue = *(float*)(__OutBuffer + 4);

			}
		}

		public virtual void GetTimeRange(ref float MinTime, ref float MaxTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = MinTime;

				*(float*)(__InBuffer + 4) = MaxTime;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTimeRange, __InBuffer, __OutBuffer);

				MinTime = *(float*)(__OutBuffer);

				MaxTime = *(float*)(__OutBuffer + 4);

			}
		}

		private static uint __AssetImportData = 0;

		private static uint __GetValueRange = 0;

		private static uint __GetTimeRange = 0;
	}
}