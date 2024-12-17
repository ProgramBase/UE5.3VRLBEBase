using Script.CoreUObject;
using Script.Library;
using Script.HotPatcherRuntime;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.HotPatcherCookerSettingBase")]
	public partial class FHotPatcherCookerSettingBase : FPatcherEntitySettingBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherCore.HotPatcherCookerSettingBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHotPatcherCookerSettingBase()
		{
		}

		public static bool operator ==(FHotPatcherCookerSettingBase A, FHotPatcherCookerSettingBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHotPatcherCookerSettingBase A, FHotPatcherCookerSettingBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHotPatcherCookerSettingBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}