using Script.CoreUObject;
using Script.Library;

namespace Script.SceneOutliner
{
	[PathName("/Script/SceneOutliner.SceneOutlinerConfig")]
	public partial class FSceneOutlinerConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SceneOutliner.SceneOutlinerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSceneOutlinerConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSceneOutlinerConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSceneOutlinerConfig A, FSceneOutlinerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSceneOutlinerConfig A, FSceneOutlinerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSceneOutlinerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, bool> ColumnVisibilities
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ColumnVisibilities, __ReturnBuffer);

					return *(TMap<FName, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ColumnVisibilities, __InBuffer);
				}
			}
		}

		public bool bShouldStackHierarchyHeaders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShouldStackHierarchyHeaders, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShouldStackHierarchyHeaders, __InBuffer);
				}
			}
		}

		private static uint __ColumnVisibilities = 0;

		private static uint __bShouldStackHierarchyHeaders = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}