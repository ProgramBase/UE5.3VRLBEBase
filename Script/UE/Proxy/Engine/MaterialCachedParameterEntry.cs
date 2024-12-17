using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialCachedParameterEntry")]
	public partial class FMaterialCachedParameterEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialCachedParameterEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialCachedParameterEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialCachedParameterEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialCachedParameterEntry A, FMaterialCachedParameterEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialCachedParameterEntry A, FMaterialCachedParameterEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialCachedParameterEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<FMaterialParameterInfo> ParameterInfoSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterInfoSet, __ReturnBuffer);

					return *(TSet<FMaterialParameterInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterInfoSet, __InBuffer);
				}
			}
		}

		private static uint __ParameterInfoSet = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}