using Script.CoreUObject;
using Script.Library;
using Script.PhysicsCore;
using Script.Engine;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.PhysicalMaterialInput")]
	public partial class FPhysicalMaterialInput : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.PhysicalMaterialInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPhysicalMaterialInput() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPhysicalMaterialInput() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPhysicalMaterialInput A, FPhysicalMaterialInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPhysicalMaterialInput A, FPhysicalMaterialInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPhysicalMaterialInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UPhysicalMaterial PhysicalMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterial, __ReturnBuffer);

					return *(UPhysicalMaterial*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterial, __InBuffer);
				}
			}
		}

		public FExpressionInput Input
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Input, __ReturnBuffer);

					return *(FExpressionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Input, __InBuffer);
				}
			}
		}

		private static uint __PhysicalMaterial = 0;

		private static uint __Input = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}