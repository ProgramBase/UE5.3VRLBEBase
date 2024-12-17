using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.ContentBrowserPluginSettings")]
	public partial class FContentBrowserPluginSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowser.ContentBrowserPluginSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FContentBrowserPluginSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FContentBrowserPluginSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FContentBrowserPluginSettings A, FContentBrowserPluginSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FContentBrowserPluginSettings A, FContentBrowserPluginSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FContentBrowserPluginSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName PluginName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PluginName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PluginName, __InBuffer);
				}
			}
		}

		public float RootFolderSortPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootFolderSortPriority, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootFolderSortPriority, __InBuffer);
				}
			}
		}

		private static uint __PluginName = 0;

		private static uint __RootFolderSortPriority = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}