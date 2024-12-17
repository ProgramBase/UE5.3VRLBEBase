using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialLayersFunctionsRuntimeData")]
	public partial class FMaterialLayersFunctionsRuntimeData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialLayersFunctionsRuntimeData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialLayersFunctionsRuntimeData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialLayersFunctionsRuntimeData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialLayersFunctionsRuntimeData A, FMaterialLayersFunctionsRuntimeData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialLayersFunctionsRuntimeData A, FMaterialLayersFunctionsRuntimeData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialLayersFunctionsRuntimeData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UMaterialFunctionInterface> Layers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Layers, __ReturnBuffer);

					return *(TArray<UMaterialFunctionInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Layers, __InBuffer);
				}
			}
		}

		public TArray<UMaterialFunctionInterface> Blends
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Blends, __ReturnBuffer);

					return *(TArray<UMaterialFunctionInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Blends, __InBuffer);
				}
			}
		}

		private static uint __Layers = 0;

		private static uint __Blends = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}