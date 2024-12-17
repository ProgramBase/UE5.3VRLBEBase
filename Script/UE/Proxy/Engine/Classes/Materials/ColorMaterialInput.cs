using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ColorMaterialInput")]
	public partial class FColorMaterialInput : FMaterialInput, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ColorMaterialInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FColorMaterialInput()
		{
		}

		public static bool operator ==(FColorMaterialInput A, FColorMaterialInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FColorMaterialInput A, FColorMaterialInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FColorMaterialInput;

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

		public FColor Constant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Constant, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
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