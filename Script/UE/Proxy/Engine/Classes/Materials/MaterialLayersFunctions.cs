using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialLayersFunctions")]
	public partial class FMaterialLayersFunctions : FMaterialLayersFunctionsRuntimeData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialLayersFunctions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialLayersFunctions()
		{
		}

		public static bool operator ==(FMaterialLayersFunctions A, FMaterialLayersFunctions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialLayersFunctions A, FMaterialLayersFunctions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialLayersFunctions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMaterialLayersFunctionsEditorOnlyData EditorOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EditorOnly, __ReturnBuffer);

					return *(FMaterialLayersFunctionsEditorOnlyData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EditorOnly, __InBuffer);
				}
			}
		}

		private static uint __EditorOnly = 0;

	}
}