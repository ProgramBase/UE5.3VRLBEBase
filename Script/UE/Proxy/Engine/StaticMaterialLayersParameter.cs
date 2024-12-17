using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticMaterialLayersParameter")]
	public partial class FStaticMaterialLayersParameter : FStaticParameterBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StaticMaterialLayersParameter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStaticMaterialLayersParameter()
		{
		}

		public static bool operator ==(FStaticMaterialLayersParameter A, FStaticMaterialLayersParameter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStaticMaterialLayersParameter A, FStaticMaterialLayersParameter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStaticMaterialLayersParameter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMaterialLayersFunctions Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FMaterialLayersFunctions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}