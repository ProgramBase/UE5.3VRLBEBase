using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ScalarMaterialInput")]
	public partial class FScalarMaterialInput : FMaterialInput, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ScalarMaterialInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FScalarMaterialInput()
		{
		}

		public static bool operator ==(FScalarMaterialInput A, FScalarMaterialInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FScalarMaterialInput A, FScalarMaterialInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FScalarMaterialInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool UseConstant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UseConstant, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UseConstant, __InBuffer);
				}
			}
		}

		public float Constant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Constant, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Constant, __InBuffer);
				}
			}
		}

		private static uint __UseConstant = 0;

		private static uint __Constant = 0;

	}
}