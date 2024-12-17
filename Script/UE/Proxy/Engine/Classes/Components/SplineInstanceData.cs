using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SplineInstanceData")]
	public partial class FSplineInstanceData : FSceneComponentInstanceData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SplineInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSplineInstanceData()
		{
		}

		public static bool operator ==(FSplineInstanceData A, FSplineInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSplineInstanceData A, FSplineInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSplineInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bSplineHasBeenEdited
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSplineHasBeenEdited, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSplineHasBeenEdited, __InBuffer);
				}
			}
		}

		public FSplineCurves SplineCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SplineCurves, __ReturnBuffer);

					return *(FSplineCurves*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SplineCurves, __InBuffer);
				}
			}
		}

		public FSplineCurves SplineCurvesPreUCS
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SplineCurvesPreUCS, __ReturnBuffer);

					return *(FSplineCurves*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SplineCurvesPreUCS, __InBuffer);
				}
			}
		}

		private static uint __bSplineHasBeenEdited = 0;

		private static uint __SplineCurves = 0;

		private static uint __SplineCurvesPreUCS = 0;

	}
}