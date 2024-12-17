using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialInstanceCachedData")]
	public partial class FMaterialInstanceCachedData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialInstanceCachedData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialInstanceCachedData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialInstanceCachedData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialInstanceCachedData A, FMaterialInstanceCachedData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialInstanceCachedData A, FMaterialInstanceCachedData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialInstanceCachedData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> ParentLayerIndexRemap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParentLayerIndexRemap, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParentLayerIndexRemap, __InBuffer);
				}
			}
		}

		private static uint __ParentLayerIndexRemap = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}