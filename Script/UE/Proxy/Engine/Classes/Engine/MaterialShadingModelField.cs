using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialShadingModelField")]
	public partial class FMaterialShadingModelField : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialShadingModelField");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialShadingModelField() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialShadingModelField() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialShadingModelField A, FMaterialShadingModelField B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialShadingModelField A, FMaterialShadingModelField B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialShadingModelField;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ushort ShadingModelField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShadingModelField, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShadingModelField, __InBuffer);
				}
			}
		}

		private static uint __ShadingModelField = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}