using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost")]
	public partial class FTraceQueryTestResultsInnerMost : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTraceQueryTestResultsInnerMost() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTraceQueryTestResultsInnerMost() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTraceQueryTestResultsInnerMost A, FTraceQueryTestResultsInnerMost B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTraceQueryTestResultsInnerMost A, FTraceQueryTestResultsInnerMost B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTraceQueryTestResultsInnerMost;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FHitResult SingleHit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SingleHit, __ReturnBuffer);

					return *(FHitResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SingleHit, __InBuffer);
				}
			}
		}

		public FTraceQueryTestNames SingleNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SingleNames, __ReturnBuffer);

					return *(FTraceQueryTestNames*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SingleNames, __InBuffer);
				}
			}
		}

		public bool bSingleResult
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSingleResult, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSingleResult, __InBuffer);
				}
			}
		}

		public TArray<FHitResult> MultiHits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MultiHits, __ReturnBuffer);

					return *(TArray<FHitResult>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MultiHits, __InBuffer);
				}
			}
		}

		public TArray<FTraceQueryTestNames> MultiNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MultiNames, __ReturnBuffer);

					return *(TArray<FTraceQueryTestNames>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MultiNames, __InBuffer);
				}
			}
		}

		public bool bMultiResult
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMultiResult, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMultiResult, __InBuffer);
				}
			}
		}

		private static uint __SingleHit = 0;

		private static uint __SingleNames = 0;

		private static uint __bSingleResult = 0;

		private static uint __MultiHits = 0;

		private static uint __MultiNames = 0;

		private static uint __bMultiResult = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}