using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.ProximityDataflowNode")]
	public partial class FProximityDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.ProximityDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FProximityDataflowNode()
		{
		}

		public static bool operator ==(FProximityDataflowNode A, FProximityDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FProximityDataflowNode A, FProximityDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FProximityDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EProximityMethodEnum ProximityMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProximityMethod, __ReturnBuffer);

					return *(EProximityMethodEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProximityMethod, __InBuffer);
				}
			}
		}

		public float DistanceThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DistanceThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DistanceThreshold, __InBuffer);
				}
			}
		}

		public float ContactThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ContactThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ContactThreshold, __InBuffer);
				}
			}
		}

		public EProximityContactFilteringMethodEnum FilterContactMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterContactMethod, __ReturnBuffer);

					return *(EProximityContactFilteringMethodEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterContactMethod, __InBuffer);
				}
			}
		}

		public bool bUseAsConnectionGraph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseAsConnectionGraph, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseAsConnectionGraph, __InBuffer);
				}
			}
		}

		public EConnectionContactAreaMethodEnum ContactAreaMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ContactAreaMethod, __ReturnBuffer);

					return *(EConnectionContactAreaMethodEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ContactAreaMethod, __InBuffer);
				}
			}
		}

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

		private static uint __ProximityMethod = 0;

		private static uint __DistanceThreshold = 0;

		private static uint __ContactThreshold = 0;

		private static uint __FilterContactMethod = 0;

		private static uint __bUseAsConnectionGraph = 0;

		private static uint __ContactAreaMethod = 0;

		private static uint __Collection = 0;

	}
}