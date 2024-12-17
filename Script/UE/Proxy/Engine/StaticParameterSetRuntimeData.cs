using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticParameterSetRuntimeData")]
	public partial class FStaticParameterSetRuntimeData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StaticParameterSetRuntimeData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStaticParameterSetRuntimeData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStaticParameterSetRuntimeData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStaticParameterSetRuntimeData A, FStaticParameterSetRuntimeData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStaticParameterSetRuntimeData A, FStaticParameterSetRuntimeData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStaticParameterSetRuntimeData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FStaticSwitchParameter> StaticSwitchParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticSwitchParameters, __ReturnBuffer);

					return *(TArray<FStaticSwitchParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticSwitchParameters, __InBuffer);
				}
			}
		}

		public FMaterialLayersFunctionsRuntimeData MaterialLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaterialLayers, __ReturnBuffer);

					return *(FMaterialLayersFunctionsRuntimeData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaterialLayers, __InBuffer);
				}
			}
		}

		public bool bHasMaterialLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasMaterialLayers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasMaterialLayers, __InBuffer);
				}
			}
		}

		private static uint __StaticSwitchParameters = 0;

		private static uint __MaterialLayers = 0;

		private static uint __bHasMaterialLayers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}