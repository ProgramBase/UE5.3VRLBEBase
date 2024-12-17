using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VectorMaterialInput")]
	public partial class FVectorMaterialInput : FMaterialInput, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.VectorMaterialInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVectorMaterialInput()
		{
		}

		public static bool operator ==(FVectorMaterialInput A, FVectorMaterialInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVectorMaterialInput A, FVectorMaterialInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVectorMaterialInput;

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

		public FVector3f Constant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Constant, __ReturnBuffer);

					return *(FVector3f*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Constant, __InBuffer);
				}
			}
		}

		private static uint __UseConstant = 0;

		private static uint __Constant = 0;

	}
}