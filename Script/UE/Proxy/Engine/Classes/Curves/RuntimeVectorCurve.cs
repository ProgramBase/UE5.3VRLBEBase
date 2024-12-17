using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimeVectorCurve")]
	public partial class FRuntimeVectorCurve : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RuntimeVectorCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRuntimeVectorCurve() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRuntimeVectorCurve() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRuntimeVectorCurve A, FRuntimeVectorCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRuntimeVectorCurve A, FRuntimeVectorCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRuntimeVectorCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRichCurve VectorCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VectorCurves, __ReturnBuffer);

					return *(FRichCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VectorCurves, __InBuffer);
				}
			}
		}

		public UCurveVector ExternalCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExternalCurve, __ReturnBuffer);

					return *(UCurveVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExternalCurve, __InBuffer);
				}
			}
		}

		private static uint __VectorCurves = 0;

		private static uint __ExternalCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}