using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialParameterCollectionInfo")]
	public partial class FMaterialParameterCollectionInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialParameterCollectionInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialParameterCollectionInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialParameterCollectionInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialParameterCollectionInfo A, FMaterialParameterCollectionInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialParameterCollectionInfo A, FMaterialParameterCollectionInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialParameterCollectionInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid StateId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateId, __InBuffer);
				}
			}
		}

		public UMaterialParameterCollection ParameterCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterCollection, __ReturnBuffer);

					return *(UMaterialParameterCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterCollection, __InBuffer);
				}
			}
		}

		private static uint __StateId = 0;

		private static uint __ParameterCollection = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}