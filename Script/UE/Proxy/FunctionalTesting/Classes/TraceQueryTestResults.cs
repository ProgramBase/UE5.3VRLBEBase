using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.TraceQueryTestResults")]
	public partial class UTraceQueryTestResults : UObject, IStaticClass
	{
		public FTraceQueryTestResultsInner ChannelResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChannelResults, __ReturnBuffer);

					return *(FTraceQueryTestResultsInner*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChannelResults, __InBuffer);
				}
			}
		}

		public FTraceQueryTestResultsInner ObjectResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectResults, __ReturnBuffer);

					return *(FTraceQueryTestResultsInner*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectResults, __InBuffer);
				}
			}
		}

		public FTraceQueryTestResultsInner ProfileResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProfileResults, __ReturnBuffer);

					return *(FTraceQueryTestResultsInner*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProfileResults, __InBuffer);
				}
			}
		}

		public FTraceChannelTestBatchOptions BatchOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BatchOptions, __ReturnBuffer);

					return *(FTraceChannelTestBatchOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BatchOptions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.TraceQueryTestResults");
		}

		private static UClass StaticClassSingleton { get; set; }

		public new FString ToString()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ToString, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __ChannelResults = 0;

		private static uint __ObjectResults = 0;

		private static uint __ProfileResults = 0;

		private static uint __BatchOptions = 0;

		private static uint __ToString = 0;
	}
}