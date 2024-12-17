using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.CreateLeafConvexHullsDataflowNode")]
	public partial class FCreateLeafConvexHullsDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.CreateLeafConvexHullsDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCreateLeafConvexHullsDataflowNode()
		{
		}

		public static bool operator ==(FCreateLeafConvexHullsDataflowNode A, FCreateLeafConvexHullsDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCreateLeafConvexHullsDataflowNode A, FCreateLeafConvexHullsDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCreateLeafConvexHullsDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FManagedArrayCollection Collection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __ReturnBuffer);

					return *(FManagedArrayCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __InBuffer);
				}
			}
		}

		public FDataflowTransformSelection OptionalSelectionFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OptionalSelectionFilter, __ReturnBuffer);

					return *(FDataflowTransformSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OptionalSelectionFilter, __InBuffer);
				}
			}
		}

		public EGenerateConvexMethod GenerateMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GenerateMethod, __ReturnBuffer);

					return *(EGenerateConvexMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GenerateMethod, __InBuffer);
				}
			}
		}

		public float IntersectIfComputedIsSmallerByFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntersectIfComputedIsSmallerByFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntersectIfComputedIsSmallerByFactor, __InBuffer);
				}
			}
		}

		public float MinExternalVolumeToIntersect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinExternalVolumeToIntersect, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinExternalVolumeToIntersect, __InBuffer);
				}
			}
		}

		public float SimplificationDistanceThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SimplificationDistanceThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SimplificationDistanceThreshold, __InBuffer);
				}
			}
		}

		public FDataflowConvexDecompositionSettings ConvexDecompositionSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConvexDecompositionSettings, __ReturnBuffer);

					return *(FDataflowConvexDecompositionSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConvexDecompositionSettings, __InBuffer);
				}
			}
		}

		private static uint __Collection = 0;

		private static uint __OptionalSelectionFilter = 0;

		private static uint __GenerateMethod = 0;

		private static uint __IntersectIfComputedIsSmallerByFactor = 0;

		private static uint __MinExternalVolumeToIntersect = 0;

		private static uint __SimplificationDistanceThreshold = 0;

		private static uint __ConvexDecompositionSettings = 0;

	}
}