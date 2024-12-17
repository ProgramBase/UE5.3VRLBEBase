using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeTranslatorBase")]
	public partial class UInterchangeTranslatorBase : UObject, IStaticClass
	{
		public UInterchangeResultsContainer Results
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Results, __ReturnBuffer);

					return *(UInterchangeResultsContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Results, __InBuffer);
				}
			}
		}

		public UInterchangeSourceData SourceData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceData, __ReturnBuffer);

					return *(UInterchangeSourceData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeTranslatorBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Results = 0;

		private static uint __SourceData = 0;
	}
}