using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.CollectionTransformSelectionSetOperationDataflowNode")]
	public partial class FCollectionTransformSelectionSetOperationDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.CollectionTransformSelectionSetOperationDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionTransformSelectionSetOperationDataflowNode()
		{
		}

		public static bool operator ==(FCollectionTransformSelectionSetOperationDataflowNode A, FCollectionTransformSelectionSetOperationDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionTransformSelectionSetOperationDataflowNode A, FCollectionTransformSelectionSetOperationDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionTransformSelectionSetOperationDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESetOperationEnum Operation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Operation, __ReturnBuffer);

					return *(ESetOperationEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Operation, __InBuffer);
				}
			}
		}

		public FDataflowTransformSelection TransformSelectionA
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelectionA, __ReturnBuffer);

					return *(FDataflowTransformSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelectionA, __InBuffer);
				}
			}
		}

		public FDataflowTransformSelection TransformSelectionB
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelectionB, __ReturnBuffer);

					return *(FDataflowTransformSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelectionB, __InBuffer);
				}
			}
		}

		public FDataflowTransformSelection TransformSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelection, __ReturnBuffer);

					return *(FDataflowTransformSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelection, __InBuffer);
				}
			}
		}

		private static uint __Operation = 0;

		private static uint __TransformSelectionA = 0;

		private static uint __TransformSelectionB = 0;

		private static uint __TransformSelection = 0;

	}
}