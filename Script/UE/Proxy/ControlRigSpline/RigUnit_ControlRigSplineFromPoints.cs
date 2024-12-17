using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigSpline
{
	[PathName("/Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints")]
	public partial class FRigUnit_ControlRigSplineFromPoints : FRigUnit_ControlRigSplineBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigSpline.RigUnit_ControlRigSplineFromPoints");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ControlRigSplineFromPoints()
		{
		}

		public static bool operator ==(FRigUnit_ControlRigSplineFromPoints A, FRigUnit_ControlRigSplineFromPoints B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ControlRigSplineFromPoints A, FRigUnit_ControlRigSplineFromPoints B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ControlRigSplineFromPoints;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FVector> Points
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Points, __ReturnBuffer);

					return *(TArray<FVector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Points, __InBuffer);
				}
			}
		}

		public ESplineType SplineMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SplineMode, __ReturnBuffer);

					return *(ESplineType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SplineMode, __InBuffer);
				}
			}
		}

		public bool bClosed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bClosed, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bClosed, __InBuffer);
				}
			}
		}

		public int SamplesPerSegment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SamplesPerSegment, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SamplesPerSegment, __InBuffer);
				}
			}
		}

		public float Compression
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Compression, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Compression, __InBuffer);
				}
			}
		}

		public float Stretch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Stretch, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Stretch, __InBuffer);
				}
			}
		}

		public FControlRigSpline Spline
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Spline, __ReturnBuffer);

					return *(FControlRigSpline*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Spline, __InBuffer);
				}
			}
		}

		private static uint __Points = 0;

		private static uint __SplineMode = 0;

		private static uint __bClosed = 0;

		private static uint __SamplesPerSegment = 0;

		private static uint __Compression = 0;

		private static uint __Stretch = 0;

		private static uint __Spline = 0;

	}
}