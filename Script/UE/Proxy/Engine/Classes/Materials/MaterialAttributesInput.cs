using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialAttributesInput")]
	public partial class FMaterialAttributesInput : FExpressionInput, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialAttributesInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialAttributesInput()
		{
		}

		public static bool operator ==(FMaterialAttributesInput A, FMaterialAttributesInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialAttributesInput A, FMaterialAttributesInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialAttributesInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public long PropertyConnectedMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyConnectedMask, __ReturnBuffer);

					return *(long*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(long*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyConnectedMask, __InBuffer);
				}
			}
		}

		private static uint __PropertyConnectedMask = 0;

	}
}