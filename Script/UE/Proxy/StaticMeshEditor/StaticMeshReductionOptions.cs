using Script.CoreUObject;
using Script.Library;

namespace Script.StaticMeshEditor
{
	[PathName("/Script/StaticMeshEditor.StaticMeshReductionOptions")]
	public partial class FStaticMeshReductionOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StaticMeshEditor.StaticMeshReductionOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStaticMeshReductionOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStaticMeshReductionOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStaticMeshReductionOptions A, FStaticMeshReductionOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStaticMeshReductionOptions A, FStaticMeshReductionOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStaticMeshReductionOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bAutoComputeLODScreenSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAutoComputeLODScreenSize, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAutoComputeLODScreenSize, __InBuffer);
				}
			}
		}

		public TArray<FStaticMeshReductionSettings> ReductionSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReductionSettings, __ReturnBuffer);

					return *(TArray<FStaticMeshReductionSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReductionSettings, __InBuffer);
				}
			}
		}

		private static uint __bAutoComputeLODScreenSize = 0;

		private static uint __ReductionSettings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}