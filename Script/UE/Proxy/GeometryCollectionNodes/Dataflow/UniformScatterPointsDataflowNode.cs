using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.UniformScatterPointsDataflowNode")]
	public partial class FUniformScatterPointsDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.UniformScatterPointsDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUniformScatterPointsDataflowNode()
		{
		}

		public static bool operator ==(FUniformScatterPointsDataflowNode A, FUniformScatterPointsDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUniformScatterPointsDataflowNode A, FUniformScatterPointsDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUniformScatterPointsDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int MinNumberOfPoints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinNumberOfPoints, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinNumberOfPoints, __InBuffer);
				}
			}
		}

		public int MaxNumberOfPoints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxNumberOfPoints, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxNumberOfPoints, __InBuffer);
				}
			}
		}

		public float RandomSeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RandomSeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RandomSeed, __InBuffer);
				}
			}
		}

		public FBox BoundingBox
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoundingBox, __ReturnBuffer);

					return *(FBox*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoundingBox, __InBuffer);
				}
			}
		}

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

		private static uint __MinNumberOfPoints = 0;

		private static uint __MaxNumberOfPoints = 0;

		private static uint __RandomSeed = 0;

		private static uint __BoundingBox = 0;

		private static uint __Points = 0;

	}
}