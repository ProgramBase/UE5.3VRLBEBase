using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialFunctionInfo")]
	public partial class FMaterialFunctionInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialFunctionInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialFunctionInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialFunctionInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialFunctionInfo A, FMaterialFunctionInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialFunctionInfo A, FMaterialFunctionInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialFunctionInfo;

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

		public UMaterialFunctionInterface Function
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Function, __ReturnBuffer);

					return *(UMaterialFunctionInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Function, __InBuffer);
				}
			}
		}

		private static uint __StateId = 0;

		private static uint __Function = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}