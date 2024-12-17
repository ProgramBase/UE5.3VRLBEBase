using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.TraceQueryTestResultsInner")]
	public partial class FTraceQueryTestResultsInner : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FunctionalTesting.TraceQueryTestResultsInner");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTraceQueryTestResultsInner() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTraceQueryTestResultsInner() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTraceQueryTestResultsInner A, FTraceQueryTestResultsInner B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTraceQueryTestResultsInner A, FTraceQueryTestResultsInner B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTraceQueryTestResultsInner;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTraceQueryTestResultsInnerMost LineResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LineResults, __ReturnBuffer);

					return *(FTraceQueryTestResultsInnerMost*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LineResults, __InBuffer);
				}
			}
		}

		public FTraceQueryTestResultsInnerMost SphereResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SphereResults, __ReturnBuffer);

					return *(FTraceQueryTestResultsInnerMost*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SphereResults, __InBuffer);
				}
			}
		}

		public FTraceQueryTestResultsInnerMost CapsuleResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CapsuleResults, __ReturnBuffer);

					return *(FTraceQueryTestResultsInnerMost*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CapsuleResults, __InBuffer);
				}
			}
		}

		public FTraceQueryTestResultsInnerMost BoxResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoxResults, __ReturnBuffer);

					return *(FTraceQueryTestResultsInnerMost*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoxResults, __InBuffer);
				}
			}
		}

		private static uint __LineResults = 0;

		private static uint __SphereResults = 0;

		private static uint __CapsuleResults = 0;

		private static uint __BoxResults = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}