using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetBoxLengthsDataflowNode")]
	public partial class FGetBoxLengthsDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetBoxLengthsDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetBoxLengthsDataflowNode()
		{
		}

		public static bool operator ==(FGetBoxLengthsDataflowNode A, FGetBoxLengthsDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetBoxLengthsDataflowNode A, FGetBoxLengthsDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetBoxLengthsDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FBox> Boxes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Boxes, __ReturnBuffer);

					return *(TArray<FBox>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Boxes, __InBuffer);
				}
			}
		}

		public TArray<float> Lengths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Lengths, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Lengths, __InBuffer);
				}
			}
		}

		public EBoxLengthMeasurementMethod MeasurementMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeasurementMethod, __ReturnBuffer);

					return *(EBoxLengthMeasurementMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeasurementMethod, __InBuffer);
				}
			}
		}

		private static uint __Boxes = 0;

		private static uint __Lengths = 0;

		private static uint __MeasurementMethod = 0;

	}
}